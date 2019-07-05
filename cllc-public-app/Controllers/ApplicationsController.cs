﻿using Gov.Lclb.Cllb.Interfaces;
using Gov.Lclb.Cllb.Interfaces.Models;
using Gov.Lclb.Cllb.Public.Authentication;
using Gov.Lclb.Cllb.Public.Models;
using Gov.Lclb.Cllb.Public.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Gov.Lclb.Cllb.Interfaces.SharePointFileManager;

namespace Gov.Lclb.Cllb.Public.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Policy = "Business-User")]
    public class ApplicationsController : Controller
    {
        private readonly IConfiguration Configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly SharePointFileManager _sharePointFileManager;
        private readonly ILogger _logger;
        private readonly IDynamicsClient _dynamicsClient;

        public ApplicationsController(SharePointFileManager sharePointFileManager, IConfiguration configuration, IHttpContextAccessor httpContextAccessor, ILoggerFactory loggerFactory, IDynamicsClient dynamicsClient)
        {
            Configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _sharePointFileManager = sharePointFileManager;
            _dynamicsClient = dynamicsClient;
            _logger = loggerFactory.CreateLogger(typeof(ApplicationsController));
        }



        /// <summary>
        /// Get a license application by applicant id
        /// </summary>
        /// <param name="applicantId"></param>
        /// <returns></returns>
        private List<ViewModels.ApplicationSummary> GetApplicationSummariesByApplicant(string applicantId)
        {
            List<ViewModels.ApplicationSummary> result = new List<ViewModels.ApplicationSummary>();

            IEnumerable<MicrosoftDynamicsCRMadoxioApplication> dynamicsApplicationList = _dynamicsClient.GetApplicationListByApplicant(applicantId);
            if (dynamicsApplicationList != null)
            {
                foreach (MicrosoftDynamicsCRMadoxioApplication dynamicsApplication in dynamicsApplicationList)
                {
                    // hide terminated applications from view.
                    if (dynamicsApplication.Statuscode == null || (dynamicsApplication.Statuscode != (int)AdoxioApplicationStatusCodes.Terminated
                        && dynamicsApplication.Statuscode != (int)AdoxioApplicationStatusCodes.Denied
                        && dynamicsApplication.Statuscode != (int)AdoxioApplicationStatusCodes.Cancelled
                        && dynamicsApplication.Statuscode != (int)AdoxioApplicationStatusCodes.TerminatedAndRefunded))
                    {
                        result.Add(dynamicsApplication.ToSummaryViewModel());
                    }
                }

            }
            return result;
        }

        /// <summary>
        /// Get a license application by applicant id
        /// </summary>
        /// <param name="applicantId"></param>
        /// <returns></returns>
        private async Task<List<ViewModels.Application>> GetApplicationsByApplicant(string applicantId)
        {
            List<ViewModels.Application> result = new List<ViewModels.Application>();

            IEnumerable<MicrosoftDynamicsCRMadoxioApplication> dynamicsApplicationList = _dynamicsClient.GetApplicationListByApplicant(applicantId);
            if (dynamicsApplicationList != null)
            {
                foreach (MicrosoftDynamicsCRMadoxioApplication dynamicsApplication in dynamicsApplicationList)
                {
                    // hide terminated applications from view.
                    if (dynamicsApplication.Statuscode == null || (dynamicsApplication.Statuscode != (int)AdoxioApplicationStatusCodes.Terminated
                        && dynamicsApplication.Statuscode != (int)AdoxioApplicationStatusCodes.Denied
                        && dynamicsApplication.Statuscode != (int)AdoxioApplicationStatusCodes.Cancelled
                        && dynamicsApplication.Statuscode != (int)AdoxioApplicationStatusCodes.TerminatedAndRefunded))
                    {
                        result.Add(await dynamicsApplication.ToViewModel(_dynamicsClient));
                    }
                }

                // second pass to determine if transfer or location change is in progress.

                foreach (var item in result)
                {
                    if (item.LicenseType == "Cannabis Retail Store" && item.ApplicationStatus == AdoxioApplicationStatusCodes.Approved
                        && item.AssignedLicence != null && item.AssignedLicence.expiryDate > DateTime.Now
                        )
                    {
                        // determine if there is a transfer in progress.
                        item.IsLocationChangeInProgress = FindRelatedApplication(result, item, "CRS Location Change");
                        // item.isTransferInProgress = FindRelatedApplication(result, item, "CRS Transfer of Ownership");
                    }
                }

            }
            return result;
        }

        bool FindRelatedApplication(List<ViewModels.Application> applicationList, ViewModels.Application application, string licenseType)
        {
            bool result = false;
            foreach (var item in applicationList)
            {
                if (item.LicenseType == licenseType && item.AssignedLicence != null && item.AssignedLicence.id == application.AssignedLicence.id)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }


        /// <summary>
        /// Gets the number of applications that are submitted
        /// </summary>
        /// <param name="applicantId"></param>
        /// <returns></returns>
        private int GetSubmittedCountByApplicant(string applicantId)
        {

            var result = 0;
            if (!string.IsNullOrEmpty(applicantId))
            {
                var filter = $"_adoxio_applicant_value eq {applicantId} and adoxio_paymentrecieved eq true and statuscode ne {(int)AdoxioApplicationStatusCodes.Terminated}";
                filter += $" and statuscode ne {(int)AdoxioApplicationStatusCodes.Denied}";
                filter += $" and statuscode ne {(int)AdoxioApplicationStatusCodes.Cancelled}";
                filter += $" and statuscode ne {(int)AdoxioApplicationStatusCodes.TerminatedAndRefunded}";

                var adoxioLicencetype = _dynamicsClient.GetAdoxioLicencetypeByName("Cannabis Retail Store");
                if (adoxioLicencetype != null)
                {
                    filter += $" and _adoxio_licencetype_value eq {adoxioLicencetype.AdoxioLicencetypeid} ";
                }

                try
                {
                    result = _dynamicsClient.Applications.Get(filter: filter).Value.Count;
                }
                catch (OdataerrorException)
                {
                    result = 0;
                }
            }
            return result;
        }

        /// <summary>
        /// GET all applications in Dynamics. Optional parameter for applicant ID. Or all applications if the applicantId is null
        /// </summary>
        /// <param name="applicantId"></param>
        /// <returns></returns>
        [HttpGet()]
        public async Task<JsonResult> GetDynamicsApplications(string applicantId)
        {
            List<ViewModels.Application> adoxioApplications = await GetApplicationsByApplicant(applicantId);
            return Json(adoxioApplications);
        }

        /// GET all applications in Dynamics for the current user
        [HttpGet("current")]
        public JsonResult GetCurrentUserApplications()
        {
            // get the current user.
            string temp = _httpContextAccessor.HttpContext.Session.GetString("UserSettings");
            UserSettings userSettings = JsonConvert.DeserializeObject<UserSettings>(temp);

            // GET all applications in Dynamics by applicant using the account Id assigned to the user logged in
            List<ViewModels.ApplicationSummary> adoxioApplications = GetApplicationSummariesByApplicant(userSettings.AccountId);
            return Json(adoxioApplications);
        }

        /// GET submitted applications in Dynamics for the current user
        [HttpGet("current/submitted-count")]
        public JsonResult GetCountForCurrentUserSubmittedApplications()
        {
            // get the current user.
            string temp = _httpContextAccessor.HttpContext.Session.GetString("UserSettings");
            UserSettings userSettings = JsonConvert.DeserializeObject<UserSettings>(temp);

            // GET all applications in Dynamics by applicant using the account Id assigned to the user logged in
            var count = GetSubmittedCountByApplicant(userSettings.AccountId);
            return Json(count);
        }

        /// <summary>
        /// GET an Application by ID
        /// </summary>
        /// <param name="id">GUID of the Application to get</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDynamicsApplication(string id)
        {
            // get the current user.
            string temp = _httpContextAccessor.HttpContext.Session.GetString("UserSettings");
            UserSettings userSettings = JsonConvert.DeserializeObject<UserSettings>(temp);

            _logger.LogError("Application id = " + id);
            _logger.LogError("User id = " + userSettings.AccountId);

            ViewModels.Application result = null;
            var dynamicsApplication = await _dynamicsClient.GetApplicationByIdWithChildren(Guid.Parse(id));
            if (dynamicsApplication == null)
            {
                return NotFound();
            }
            else
            {
                if (!CurrentUserHasAccessToApplicationOwnedBy(dynamicsApplication._adoxioApplicantValue))
                {
                    return new NotFoundResult();
                }
                result = await dynamicsApplication.ToViewModel(_dynamicsClient);
            }




            if (dynamicsApplication.AdoxioApplicationSharePointDocumentLocations.Count == 0)
            {
                await initializeSharepoint(dynamicsApplication);
            }

            return Json(result);
        }

        private string GetApplicationFolderName(MicrosoftDynamicsCRMadoxioApplication application)
        {
            string applicationIdCleaned = application.AdoxioApplicationid.ToString().ToUpper().Replace("-", "");
            string folderName = $"{application.AdoxioJobnumber}_{applicationIdCleaned}";
            return folderName;
        }

        /// <summary>
        /// Get a document location by reference
        /// </summary>
        /// <param name="relativeUrl"></param>
        /// <returns></returns>
        private string GetDocumentLocationReferenceByRelativeURL(string relativeUrl)
        {
            string result = null;
            string sanitized = relativeUrl.Replace("'", "''");
            // first see if one exists.
            var locations = _dynamicsClient.Sharepointdocumentlocations.Get(filter: "relativeurl eq '" + sanitized + "'");

            var location = locations.Value.FirstOrDefault();

            if (location == null)
            {
                var parentSite = _dynamicsClient.Sharepointsites.Get().Value.FirstOrDefault();
                var parentSiteRef = _dynamicsClient.GetEntityURI("sharepointsites", parentSite.Sharepointsiteid);
                MicrosoftDynamicsCRMsharepointdocumentlocation newRecord = new MicrosoftDynamicsCRMsharepointdocumentlocation()
                {
                    Relativeurl = relativeUrl,
                    Name = "Application",
                    ParentSiteODataBind = parentSiteRef
                };
                // create a new document location.
                try
                {
                    location = _dynamicsClient.Sharepointdocumentlocations.Create(newRecord);
                }
                catch (OdataerrorException odee)
                {
                    _logger.LogError("Error creating document location");
                    _logger.LogError("Request:");
                    _logger.LogError(odee.Request.Content);
                    _logger.LogError("Response:");
                    _logger.LogError(odee.Response.Content);
                }
            }

            if (location != null)
            {
                result = location.Sharepointdocumentlocationid;
            }

            return result;
        }


        /// <summary>
        /// Create an Application in Dynamics (POST)
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost()]
        public async Task<IActionResult> CreateApplication([FromBody] ViewModels.Application item)
        {

            // for association with current user
            string userJson = _httpContextAccessor.HttpContext.Session.GetString("UserSettings");
            UserSettings userSettings = JsonConvert.DeserializeObject<UserSettings>(userJson);
            int count = GetSubmittedCountByApplicant(userSettings.AccountId);
            if (count >= 8)
            {
                return BadRequest("8 applications have already been submitted. Can not create more");
            }
            MicrosoftDynamicsCRMadoxioApplication adoxioApplication = new MicrosoftDynamicsCRMadoxioApplication();
            // copy received values to Dynamics Application
            adoxioApplication.CopyValues(item);
            adoxioApplication.AdoxioApplicanttype = (int?)item.ApplicantType;
            try
            {
                // set license type relationship 
                var adoxioLicencetype = _dynamicsClient.GetAdoxioLicencetypeByName(item.LicenseType);
                adoxioApplication.AdoxioLicenceTypeODataBind = _dynamicsClient.GetEntityURI("adoxio_licencetypes", adoxioLicencetype.AdoxioLicencetypeid);

                // set account relationship
                adoxioApplication.AdoxioApplicantODataBind = _dynamicsClient.GetEntityURI("accounts", userSettings.AccountId);

                // set applicaiton type relationship 
                var applicationType = _dynamicsClient.GetApplicationTypeByName(item.ApplicationType.Name);
                adoxioApplication.AdoxioApplicationTypeIdODataBind = _dynamicsClient.GetEntityURI("adoxio_applicationtypes", applicationType.AdoxioApplicationtypeid);

                if (item.ApplicationType.Name == "Marketer")
                {
                    // create tiedhouse relationship
                    adoxioApplication.AdoxioApplicationAdoxioTiedhouseconnectionApplication = new List<MicrosoftDynamicsCRMadoxioTiedhouseconnection>{
                            new MicrosoftDynamicsCRMadoxioTiedhouseconnection()
                        };
                }

                // create application
                adoxioApplication = _dynamicsClient.Applications.Create(adoxioApplication);
            }
            catch (OdataerrorException odee)
            {
                string applicationId = _dynamicsClient.GetCreatedRecord(odee, null);
                if (!string.IsNullOrEmpty(applicationId) && Guid.TryParse(applicationId, out Guid applicationGuid))
                {
                    adoxioApplication = await _dynamicsClient.GetApplicationById(applicationGuid);
                }
                else
                {

                    _logger.LogError("Error creating application");
                    _logger.LogError("Request:");
                    _logger.LogError(odee.Request.Content);
                    _logger.LogError("Response:");
                    _logger.LogError(odee.Response.Content);
                    // fail if we can't create.
                    throw (odee);
                }

            }

            // in case the job number is not there, try getting the record from the server.
            if (adoxioApplication.AdoxioJobnumber == null)
            {
                _logger.LogError("AdoxioJobnumber is null, fetching record again.");
                Guid id = Guid.Parse(adoxioApplication.AdoxioApplicationid);
                adoxioApplication = await _dynamicsClient.GetApplicationById(id);
            }

            if (adoxioApplication.AdoxioJobnumber == null)
            {
                _logger.LogError("Unable to get the Job Number for the Application.");
                throw new Exception("Error creating Licence Application.");
            }

            await initializeSharepoint(adoxioApplication);

            return Json(await adoxioApplication.ToViewModel(_dynamicsClient));

        }

        private async Task initializeSharepoint(MicrosoftDynamicsCRMadoxioApplication adoxioApplication)
        {
            // create a SharePointDocumentLocation link
            string folderName = GetApplicationFolderName(adoxioApplication);
            string name = adoxioApplication.AdoxioJobnumber + " Files";

            // Create the folder
            bool folderExists = await _sharePointFileManager.FolderExists(ApplicationDocumentUrlTitle, folderName);
            if (!folderExists)
            {
                try
                {
                    await _sharePointFileManager.CreateFolder(ApplicationDocumentUrlTitle, folderName);
                }
                catch (SharePointRestException spre)
                {
                    _logger.LogError("Error creating Sharepoint Folder");
                    _logger.LogError($"List is: {ApplicationDocumentUrlTitle}");
                    _logger.LogError($"FolderName is: {folderName}");
                    _logger.LogError($"Request is: {spre.Request.Content}");
                    _logger.LogError($"Response is: {spre.Response.Content}");
                    _logger.LogError($"Error is: {spre.Message} {spre.StackTrace}");
                    throw spre;
                }
                catch (Exception e)
                {
                    _logger.LogError("Error creating Sharepoint Folder");
                    _logger.LogError($"List is: {ApplicationDocumentUrlTitle}");
                    _logger.LogError($"FolderName is: {folderName}");
                    _logger.LogError($"Error is: {e.Message} {e.StackTrace}");
                    throw e;
                }

            }

            // Create the SharePointDocumentLocation entity
            MicrosoftDynamicsCRMsharepointdocumentlocation mdcsdl = new MicrosoftDynamicsCRMsharepointdocumentlocation()
            {
                Relativeurl = folderName,
                Description = "Application Files",
                Name = name
            };


            try
            {
                mdcsdl = _dynamicsClient.Sharepointdocumentlocations.Create(mdcsdl);
            }
            catch (OdataerrorException odee)
            {
                string mdcsdlId = _dynamicsClient.GetCreatedRecord(odee, null);
                if (!string.IsNullOrEmpty(mdcsdlId))
                {
                    mdcsdl.Sharepointdocumentlocationid = mdcsdlId;
                }
                else
                {
                    _logger.LogError("Error creating SharepointDocumentLocation");
                    _logger.LogError("Request:");
                    _logger.LogError(odee.Request.Content);
                    _logger.LogError("Response:");
                    _logger.LogError(odee.Response.Content);
                    mdcsdl = null;
                }

            }
            if (mdcsdl != null)
            {
                // add a regardingobjectid.
                string applicationReference = _dynamicsClient.GetEntityURI("adoxio_applications", adoxioApplication.AdoxioApplicationid);
                var patchSharePointDocumentLocation = new MicrosoftDynamicsCRMsharepointdocumentlocation();
                patchSharePointDocumentLocation.RegardingobjectidAdoxioApplicationODataBind = applicationReference;
                // set the parent document library.
                string parentDocumentLibraryReference = GetDocumentLocationReferenceByRelativeURL("adoxio_application");
                patchSharePointDocumentLocation.ParentsiteorlocationSharepointdocumentlocationODataBind = _dynamicsClient.GetEntityURI("sharepointdocumentlocations", parentDocumentLibraryReference);

                try
                {
                    _dynamicsClient.Sharepointdocumentlocations.Update(mdcsdl.Sharepointdocumentlocationid, patchSharePointDocumentLocation);
                }
                catch (OdataerrorException odee)
                {
                    _logger.LogError("Error adding reference SharepointDocumentLocation to application");
                    _logger.LogError("Request:");
                    _logger.LogError(odee.Request.Content);
                    _logger.LogError("Response:");
                    _logger.LogError(odee.Response.Content);
                }

                string sharePointLocationData = _dynamicsClient.GetEntityURI("sharepointdocumentlocations", mdcsdl.Sharepointdocumentlocationid);
                // update the sharePointLocationData.
                Odataid oDataId = new Odataid()
                {
                    OdataidProperty = sharePointLocationData
                };
                try
                {
                    _dynamicsClient.Applications.AddReference(adoxioApplication.AdoxioApplicationid, "adoxio_application_SharePointDocumentLocations", oDataId);
                }
                catch (OdataerrorException odee)
                {
                    _logger.LogError("Error adding reference to SharepointDocumentLocation");
                    _logger.LogError("Request:");
                    _logger.LogError(odee.Request.Content);
                    _logger.LogError("Response:");
                    _logger.LogError(odee.Response.Content);
                }
            }
        }

        /// <summary>
        /// Update a Dynamics Application (PUT)
        /// </summary>
        /// <param name="item"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateApplication([FromBody] ViewModels.Application item, string id)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            // for association with current user
            string userJson = _httpContextAccessor.HttpContext.Session.GetString("UserSettings");
            UserSettings userSettings = JsonConvert.DeserializeObject<UserSettings>(userJson);


            //Prepare application for update
            Guid adoxio_applicationId = new Guid(id);
            MicrosoftDynamicsCRMadoxioApplication adoxioApplication = await _dynamicsClient.GetApplicationById(adoxio_applicationId);

            if (!CurrentUserHasAccessToApplicationOwnedBy(adoxioApplication._adoxioApplicantValue))
            {
                return new NotFoundResult();
            }

            adoxioApplication = new MicrosoftDynamicsCRMadoxioApplication();

            adoxioApplication.CopyValues(item);

            try
            {
                // Indigenous nation association
                if (!string.IsNullOrEmpty(item.IndigenousNationId))
                {
                    adoxioApplication.AdoxioLocalgovindigenousnationidODataBind = _dynamicsClient.GetEntityURI("adoxio_localgovindigenousnations", item.IndigenousNationId);
                } else
                {
                    //remove reference
                    await _dynamicsClient.Applications.DeleteReferenceAsync(item.Id, "adoxio_localgovindigenousnationid");
                }

                _dynamicsClient.Applications.Update(id, adoxioApplication);
            }
            catch (OdataerrorException odee)
            {
                _logger.LogError("Error updating application");
                _logger.LogError("Request:");
                _logger.LogError(odee.Request.Content);
                _logger.LogError("Response:");
                _logger.LogError(odee.Response.Content);
                // fail if we can't create.
                throw (odee);
            }

            adoxioApplication = await _dynamicsClient.GetApplicationById(adoxio_applicationId);

            return Json(await adoxioApplication.ToViewModel(_dynamicsClient));
        }

        /// <summary>
        /// Delete an Application.  Using a HTTP Post to avoid Siteminder issues with DELETE
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("{id}/cancel")]
        public async Task<IActionResult> CancelApplication(string id)
        {
            // get the application.
            Guid adoxio_applicationid = new Guid(id);

            MicrosoftDynamicsCRMadoxioApplication adoxioApplication = await _dynamicsClient.GetApplicationById(adoxio_applicationid);
            if (adoxioApplication == null)
            {
                return new NotFoundResult();
            }

            if (!CurrentUserHasAccessToApplicationOwnedBy(adoxioApplication._adoxioApplicantValue))
            {
                return new NotFoundResult();
            }

            // set the status to Terminated.
            MicrosoftDynamicsCRMadoxioApplication patchRecord = new MicrosoftDynamicsCRMadoxioApplication()
            {
                //StatusCodeODataBind = ((int)AdoxioApplicationStatusCodes.Terminated).ToString()
                Statuscode = (int)AdoxioApplicationStatusCodes.Terminated
            };

            try
            {
                _dynamicsClient.Applications.Update(id, patchRecord);
            }
            catch (OdataerrorException odee)
            {
                _logger.LogError("Error cancelling application");
                _logger.LogError("Request:");
                _logger.LogError(odee.Request.Content);
                _logger.LogError("Response:");
                _logger.LogError(odee.Response.Content);
                // fail if we can't create.
                throw (odee);
            }


            return NoContent(); // 204
        }

        /// <summary>
        /// Delete an Application.  Using a HTTP Post to avoid Siteminder issues with DELETE
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("{id}/delete")]
        public async Task<IActionResult> DeleteApplication(string id)
        {
            // get the application.
            Guid adoxio_applicationid = new Guid(id);

            MicrosoftDynamicsCRMadoxioApplication adoxioApplication = await _dynamicsClient.GetApplicationById(adoxio_applicationid);
            if (adoxioApplication == null)
            {
                return new NotFoundResult();
            }

            if (!CurrentUserHasAccessToApplicationOwnedBy(adoxioApplication._adoxioApplicantValue))
            {
                return new NotFoundResult();
            }


            await _dynamicsClient.Applications.DeleteAsync(adoxio_applicationid.ToString());

            return NoContent(); // 204
        }

        /// <summary>
        /// Verify whether currently logged in user has access to this account id
        /// </summary>
        /// <returns>boolean</returns>
        private bool CurrentUserHasAccessToApplicationOwnedBy(string accountId)
        {
            // get the current user.
            string temp = _httpContextAccessor.HttpContext.Session.GetString("UserSettings");
            UserSettings userSettings = JsonConvert.DeserializeObject<UserSettings>(temp);

            // For now, check if the account id matches the user's account.
            // TODO there may be some account relationships in the future
            if (userSettings.AccountId != null && userSettings.AccountId.Length > 0)
            {
                return userSettings.AccountId == accountId;
            }

            // if current user doesn't have an account they are probably not logged in
            return false;
        }
    }
}