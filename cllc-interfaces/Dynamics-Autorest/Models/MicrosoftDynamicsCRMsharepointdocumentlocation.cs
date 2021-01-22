// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.sharepointdocumentlocation
    /// </summary>
    public partial class MicrosoftDynamicsCRMsharepointdocumentlocation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsharepointdocumentlocation class.
        /// </summary>
        public MicrosoftDynamicsCRMsharepointdocumentlocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsharepointdocumentlocation class.
        /// </summary>
        public MicrosoftDynamicsCRMsharepointdocumentlocation(string description = default(string), string _owneridValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? statuscode = default(int?), string _owningbusinessunitValue = default(string), string userid = default(string), string _transactioncurrencyidValue = default(string), int? locationtype = default(int?), string _owninguserValue = default(string), string absoluteurl = default(string), int? importsequencenumber = default(int?), string _createdbyValue = default(string), string name = default(string), string _modifiedonbehalfbyValue = default(string), string _regardingobjectidValue = default(string), string _parentsiteorlocationValue = default(string), string versionnumber = default(string), int? timezoneruleversionnumber = default(int?), int? utcconversiontimezonecode = default(int?), int? statecode = default(int?), string _owningteamValue = default(string), decimal? exchangerate = default(decimal?), string sitecollectionid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string relativeurl = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string sharepointdocumentlocationid = default(string), string _createdonbehalfbyValue = default(string), int? servicetype = default(int?), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticle = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMadoxioApplication regardingobjectidAdoxioApplication = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioComplaint regardingobjectidAdoxioComplaint = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMadoxioInvestigation regardingobjectidAdoxioInvestigation = default(MicrosoftDynamicsCRMadoxioInvestigation), MicrosoftDynamicsCRMadoxioLegalentity regardingobjectidAdoxioLegalentity = default(MicrosoftDynamicsCRMadoxioLegalentity), MicrosoftDynamicsCRMadoxioPersonalhistorysummary regardingobjectidAdoxioPersonalhistorysummary = default(MicrosoftDynamicsCRMadoxioPersonalhistorysummary), MicrosoftDynamicsCRMadoxioSpdexports regardingobjectidAdoxioSpdexports = default(MicrosoftDynamicsCRMadoxioSpdexports), MicrosoftDynamicsCRMadoxioWorker regardingobjectidAdoxioWorker = default(MicrosoftDynamicsCRMadoxioWorker), MicrosoftDynamicsCRMincident regardingobjectidIncident = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMadoxioDocument regardingobjectidAdoxioDocument = default(MicrosoftDynamicsCRMadoxioDocument), MicrosoftDynamicsCRMcontact regardingobjectidContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMadoxioComplianceinvestigation regardingobjectidAdoxioComplianceinvestigation = default(MicrosoftDynamicsCRMadoxioComplianceinvestigation), MicrosoftDynamicsCRMadoxioLicences regardingobjectidAdoxioLicences = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMadoxioEvent regardingobjectidAdoxioEvent = default(MicrosoftDynamicsCRMadoxioEvent), MicrosoftDynamicsCRMadoxioContravention regardingobjectidAdoxioContravention = default(MicrosoftDynamicsCRMadoxioContravention), MicrosoftDynamicsCRMadoxioFederalreportexport regardingobjectidAdoxioFederalreportexport = default(MicrosoftDynamicsCRMadoxioFederalreportexport), MicrosoftDynamicsCRMadoxioLdborder regardingobjectidAdoxioLdborder = default(MicrosoftDynamicsCRMadoxioLdborder), MicrosoftDynamicsCRMadoxioEndorsement regardingobjectidAdoxioEndorsement = default(MicrosoftDynamicsCRMadoxioEndorsement), MicrosoftDynamicsCRMadoxioEnforcementaction regardingobjectidAdoxioEnforcementaction = default(MicrosoftDynamicsCRMadoxioEnforcementaction), MicrosoftDynamicsCRMadoxioEstablishmentincident regardingobjectidAdoxioEstablishmentincident = default(MicrosoftDynamicsCRMadoxioEstablishmentincident), MicrosoftDynamicsCRMadoxioInvestigationrequest regardingobjectidAdoxioInvestigationrequest = default(MicrosoftDynamicsCRMadoxioInvestigationrequest), MicrosoftDynamicsCRMaccount regardingobjectidAccount = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> sharepointdocumentlocationPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMquote regardingobjectidQuote = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMproduct regardingobjectidProduct = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMsharepointdocumentlocation parentsiteorlocationSharepointdocumentlocation = default(MicrosoftDynamicsCRMsharepointdocumentlocation), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> sharepointdocumentlocationParentSharepointdocumentlocation = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMlead regardingobjectidLead = default(MicrosoftDynamicsCRMlead), IList<MicrosoftDynamicsCRMduplicaterecord> sharePointDocumentLocationDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsalesliterature regardingobjectidSalesliterature = default(MicrosoftDynamicsCRMsalesliterature), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunity = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMsharepointsite parentsiteorlocationSharepointsite = default(MicrosoftDynamicsCRMsharepointsite), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMkbarticle regardingobjectidKbarticle = default(MicrosoftDynamicsCRMkbarticle), IList<MicrosoftDynamicsCRMduplicaterecord> sharePointDocumentLocationDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMprocesssession> sharePointDocumentLocationProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMsyncerror> sharePointDocumentLocationSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> sharePointDocumentLocationAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>))
        {
            Description = description;
            this._owneridValue = _owneridValue;
            Createdon = createdon;
            Statuscode = statuscode;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Userid = userid;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Locationtype = locationtype;
            this._owninguserValue = _owninguserValue;
            Absoluteurl = absoluteurl;
            Importsequencenumber = importsequencenumber;
            this._createdbyValue = _createdbyValue;
            Name = name;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._regardingobjectidValue = _regardingobjectidValue;
            this._parentsiteorlocationValue = _parentsiteorlocationValue;
            Versionnumber = versionnumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Statecode = statecode;
            this._owningteamValue = _owningteamValue;
            Exchangerate = exchangerate;
            Sitecollectionid = sitecollectionid;
            Overriddencreatedon = overriddencreatedon;
            Relativeurl = relativeurl;
            Modifiedon = modifiedon;
            this._modifiedbyValue = _modifiedbyValue;
            Sharepointdocumentlocationid = sharepointdocumentlocationid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Servicetype = servicetype;
            RegardingobjectidKnowledgearticle = regardingobjectidKnowledgearticle;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            RegardingobjectidAdoxioApplication = regardingobjectidAdoxioApplication;
            RegardingobjectidAdoxioComplaint = regardingobjectidAdoxioComplaint;
            RegardingobjectidAdoxioInvestigation = regardingobjectidAdoxioInvestigation;
            RegardingobjectidAdoxioLegalentity = regardingobjectidAdoxioLegalentity;
            RegardingobjectidAdoxioPersonalhistorysummary = regardingobjectidAdoxioPersonalhistorysummary;
            RegardingobjectidAdoxioSpdexports = regardingobjectidAdoxioSpdexports;
            RegardingobjectidAdoxioWorker = regardingobjectidAdoxioWorker;
            RegardingobjectidIncident = regardingobjectidIncident;
            RegardingobjectidAdoxioDocument = regardingobjectidAdoxioDocument;
            RegardingobjectidContact = regardingobjectidContact;
            RegardingobjectidAdoxioComplianceinvestigation = regardingobjectidAdoxioComplianceinvestigation;
            RegardingobjectidAdoxioLicences = regardingobjectidAdoxioLicences;
            RegardingobjectidAdoxioEvent = regardingobjectidAdoxioEvent;
            RegardingobjectidAdoxioContravention = regardingobjectidAdoxioContravention;
            RegardingobjectidAdoxioFederalreportexport = regardingobjectidAdoxioFederalreportexport;
            RegardingobjectidAdoxioLdborder = regardingobjectidAdoxioLdborder;
            RegardingobjectidAdoxioEndorsement = regardingobjectidAdoxioEndorsement;
            RegardingobjectidAdoxioEnforcementaction = regardingobjectidAdoxioEnforcementaction;
            RegardingobjectidAdoxioEstablishmentincident = regardingobjectidAdoxioEstablishmentincident;
            RegardingobjectidAdoxioInvestigationrequest = regardingobjectidAdoxioInvestigationrequest;
            RegardingobjectidAccount = regardingobjectidAccount;
            SharepointdocumentlocationPrincipalobjectattributeaccess = sharepointdocumentlocationPrincipalobjectattributeaccess;
            RegardingobjectidQuote = regardingobjectidQuote;
            RegardingobjectidProduct = regardingobjectidProduct;
            ParentsiteorlocationSharepointdocumentlocation = parentsiteorlocationSharepointdocumentlocation;
            SharepointdocumentlocationParentSharepointdocumentlocation = sharepointdocumentlocationParentSharepointdocumentlocation;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            RegardingobjectidLead = regardingobjectidLead;
            SharePointDocumentLocationDuplicateBaseRecord = sharePointDocumentLocationDuplicateBaseRecord;
            Createdby = createdby;
            RegardingobjectidSalesliterature = regardingobjectidSalesliterature;
            RegardingobjectidOpportunity = regardingobjectidOpportunity;
            ParentsiteorlocationSharepointsite = parentsiteorlocationSharepointsite;
            Modifiedonbehalfby = modifiedonbehalfby;
            RegardingobjectidKbarticle = regardingobjectidKbarticle;
            SharePointDocumentLocationDuplicateMatchingRecord = sharePointDocumentLocationDuplicateMatchingRecord;
            SharePointDocumentLocationProcessSessions = sharePointDocumentLocationProcessSessions;
            Transactioncurrencyid = transactioncurrencyid;
            SharePointDocumentLocationSyncErrors = sharePointDocumentLocationSyncErrors;
            SharePointDocumentLocationAsyncOperations = sharePointDocumentLocationAsyncOperations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userid")]
        public string Userid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "locationtype")]
        public int? Locationtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "absoluteurl")]
        public string Absoluteurl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentsiteorlocation_value")]
        public string _parentsiteorlocationValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sitecollectionid")]
        public string Sitecollectionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "relativeurl")]
        public string Relativeurl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sharepointdocumentlocationid")]
        public string Sharepointdocumentlocationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "servicetype")]
        public int? Servicetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_application")]
        public MicrosoftDynamicsCRMadoxioApplication RegardingobjectidAdoxioApplication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_complaint")]
        public MicrosoftDynamicsCRMadoxioComplaint RegardingobjectidAdoxioComplaint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_investigation")]
        public MicrosoftDynamicsCRMadoxioInvestigation RegardingobjectidAdoxioInvestigation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_legalentity")]
        public MicrosoftDynamicsCRMadoxioLegalentity RegardingobjectidAdoxioLegalentity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_personalhistorysummary")]
        public MicrosoftDynamicsCRMadoxioPersonalhistorysummary RegardingobjectidAdoxioPersonalhistorysummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_spdexports")]
        public MicrosoftDynamicsCRMadoxioSpdexports RegardingobjectidAdoxioSpdexports { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_worker")]
        public MicrosoftDynamicsCRMadoxioWorker RegardingobjectidAdoxioWorker { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncident { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_document")]
        public MicrosoftDynamicsCRMadoxioDocument RegardingobjectidAdoxioDocument { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_complianceinvestigation")]
        public MicrosoftDynamicsCRMadoxioComplianceinvestigation RegardingobjectidAdoxioComplianceinvestigation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_licences")]
        public MicrosoftDynamicsCRMadoxioLicences RegardingobjectidAdoxioLicences { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_event")]
        public MicrosoftDynamicsCRMadoxioEvent RegardingobjectidAdoxioEvent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_contravention")]
        public MicrosoftDynamicsCRMadoxioContravention RegardingobjectidAdoxioContravention { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_federalreportexport")]
        public MicrosoftDynamicsCRMadoxioFederalreportexport RegardingobjectidAdoxioFederalreportexport { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_ldborder")]
        public MicrosoftDynamicsCRMadoxioLdborder RegardingobjectidAdoxioLdborder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_endorsement")]
        public MicrosoftDynamicsCRMadoxioEndorsement RegardingobjectidAdoxioEndorsement { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_enforcementaction")]
        public MicrosoftDynamicsCRMadoxioEnforcementaction RegardingobjectidAdoxioEnforcementaction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_establishmentincident")]
        public MicrosoftDynamicsCRMadoxioEstablishmentincident RegardingobjectidAdoxioEstablishmentincident { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_investigationrequest")]
        public MicrosoftDynamicsCRMadoxioInvestigationrequest RegardingobjectidAdoxioInvestigationrequest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sharepointdocumentlocation_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SharepointdocumentlocationPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quote")]
        public MicrosoftDynamicsCRMquote RegardingobjectidQuote { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_product")]
        public MicrosoftDynamicsCRMproduct RegardingobjectidProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentsiteorlocation_sharepointdocumentlocation")]
        public MicrosoftDynamicsCRMsharepointdocumentlocation ParentsiteorlocationSharepointdocumentlocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sharepointdocumentlocation_parent_sharepointdocumentlocation")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> SharepointdocumentlocationParentSharepointdocumentlocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SharePointDocumentLocation_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SharePointDocumentLocationDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_salesliterature")]
        public MicrosoftDynamicsCRMsalesliterature RegardingobjectidSalesliterature { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentsiteorlocation_sharepointsite")]
        public MicrosoftDynamicsCRMsharepointsite ParentsiteorlocationSharepointsite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_kbarticle")]
        public MicrosoftDynamicsCRMkbarticle RegardingobjectidKbarticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SharePointDocumentLocation_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SharePointDocumentLocationDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SharePointDocumentLocation_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> SharePointDocumentLocationProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SharePointDocumentLocation_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SharePointDocumentLocationSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SharePointDocumentLocation_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SharePointDocumentLocationAsyncOperations { get; set; }

    }
}
