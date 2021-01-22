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
    /// Microsoft.Dynamics.CRM.adoxio_contraventionadmin
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioContraventionadmin
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioContraventionadmin class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioContraventionadmin()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioContraventionadmin class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioContraventionadmin(decimal? adoxioSecondcontraventionminvalueBase = default(decimal?), int? adoxioItemnumber = default(int?), string _createdonbehalfbyValue = default(string), string versionnumber = default(string), string _transactioncurrencyidValue = default(string), int? adoxioCategory = default(int?), string adoxioElements = default(string), decimal? adoxioFirstcontraventionmaxvalueBase = default(decimal?), int? adoxioClass = default(int?), string adoxioInterpretation = default(string), int? adoxioFirstcontraventionminperiod = default(int?), bool? adoxioIsact = default(bool?), decimal? adoxioFirstcontraventionmaxvalue = default(decimal?), int? adoxioThirdcontraventionminperiod = default(int?), decimal? adoxioThirdcontraventionminvalue = default(decimal?), string _owneridValue = default(string), string adoxioContraventionadminid = default(string), string _owningteamValue = default(string), decimal? adoxioSecondcontraventionminvalue = default(decimal?), string _owningbusinessunitValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), decimal? exchangerate = default(decimal?), string adoxioName = default(string), string _owninguserValue = default(string), int? adoxioFirstcontraventionmaxperiod = default(int?), int? adoxioLicencetype = default(int?), decimal? adoxioSecondcontraventionmaxvalue = default(decimal?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? adoxioSecondcontraventionmaxperiod = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), decimal? adoxioFirstcontraventionminvalueBase = default(decimal?), int? importsequencenumber = default(int?), bool? adoxioIsreg = default(bool?), int? adoxioSecondcontraventionminperiod = default(int?), string _createdbyValue = default(string), string adoxioReference = default(string), decimal? adoxioSecondcontraventionmaxvalueBase = default(decimal?), int? utcconversiontimezonecode = default(int?), string adoxioLicencetypes = default(string), string _modifiedonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), string adoxioPolicynamereference = default(string), decimal? adoxioThirdcontraventionmaxvalueBase = default(decimal?), int? adoxioThirdcontraventionmaxperiod = default(int?), bool? adoxioIswqr = default(bool?), decimal? adoxioThirdcontraventionmaxvalue = default(decimal?), int? statuscode = default(int?), int? statecode = default(int?), decimal? adoxioThirdcontraventionminvalueBase = default(decimal?), int? adoxioLcrbtype = default(int?), string _modifiedbyValue = default(string), bool? adoxioIstandc = default(bool?), decimal? adoxioFirstcontraventionminvalue = default(decimal?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioContraventionadminSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioContraventionadminDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioContraventionadminDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioContraventionadminAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioContraventionadminMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioContraventionadminProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioContraventionadminBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioContraventionadminPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMadoxioContravention> adoxioContraventionadminContraventions = default(IList<MicrosoftDynamicsCRMadoxioContravention>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMadoxioInvestigationrequest> adoxioContraventionInvestigationrequests = default(IList<MicrosoftDynamicsCRMadoxioInvestigationrequest>))
        {
            AdoxioSecondcontraventionminvalueBase = adoxioSecondcontraventionminvalueBase;
            AdoxioItemnumber = adoxioItemnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Versionnumber = versionnumber;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            AdoxioCategory = adoxioCategory;
            AdoxioElements = adoxioElements;
            AdoxioFirstcontraventionmaxvalueBase = adoxioFirstcontraventionmaxvalueBase;
            AdoxioClass = adoxioClass;
            AdoxioInterpretation = adoxioInterpretation;
            AdoxioFirstcontraventionminperiod = adoxioFirstcontraventionminperiod;
            AdoxioIsact = adoxioIsact;
            AdoxioFirstcontraventionmaxvalue = adoxioFirstcontraventionmaxvalue;
            AdoxioThirdcontraventionminperiod = adoxioThirdcontraventionminperiod;
            AdoxioThirdcontraventionminvalue = adoxioThirdcontraventionminvalue;
            this._owneridValue = _owneridValue;
            AdoxioContraventionadminid = adoxioContraventionadminid;
            this._owningteamValue = _owningteamValue;
            AdoxioSecondcontraventionminvalue = adoxioSecondcontraventionminvalue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Createdon = createdon;
            Exchangerate = exchangerate;
            AdoxioName = adoxioName;
            this._owninguserValue = _owninguserValue;
            AdoxioFirstcontraventionmaxperiod = adoxioFirstcontraventionmaxperiod;
            AdoxioLicencetype = adoxioLicencetype;
            AdoxioSecondcontraventionmaxvalue = adoxioSecondcontraventionmaxvalue;
            Modifiedon = modifiedon;
            AdoxioSecondcontraventionmaxperiod = adoxioSecondcontraventionmaxperiod;
            Overriddencreatedon = overriddencreatedon;
            AdoxioFirstcontraventionminvalueBase = adoxioFirstcontraventionminvalueBase;
            Importsequencenumber = importsequencenumber;
            AdoxioIsreg = adoxioIsreg;
            AdoxioSecondcontraventionminperiod = adoxioSecondcontraventionminperiod;
            this._createdbyValue = _createdbyValue;
            AdoxioReference = adoxioReference;
            AdoxioSecondcontraventionmaxvalueBase = adoxioSecondcontraventionmaxvalueBase;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioLicencetypes = adoxioLicencetypes;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioPolicynamereference = adoxioPolicynamereference;
            AdoxioThirdcontraventionmaxvalueBase = adoxioThirdcontraventionmaxvalueBase;
            AdoxioThirdcontraventionmaxperiod = adoxioThirdcontraventionmaxperiod;
            AdoxioIswqr = adoxioIswqr;
            AdoxioThirdcontraventionmaxvalue = adoxioThirdcontraventionmaxvalue;
            Statuscode = statuscode;
            Statecode = statecode;
            AdoxioThirdcontraventionminvalueBase = adoxioThirdcontraventionminvalueBase;
            AdoxioLcrbtype = adoxioLcrbtype;
            this._modifiedbyValue = _modifiedbyValue;
            AdoxioIstandc = adoxioIstandc;
            AdoxioFirstcontraventionminvalue = adoxioFirstcontraventionminvalue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioContraventionadminSyncErrors = adoxioContraventionadminSyncErrors;
            AdoxioContraventionadminDuplicateMatchingRecord = adoxioContraventionadminDuplicateMatchingRecord;
            AdoxioContraventionadminDuplicateBaseRecord = adoxioContraventionadminDuplicateBaseRecord;
            AdoxioContraventionadminAsyncOperations = adoxioContraventionadminAsyncOperations;
            AdoxioContraventionadminMailboxTrackingFolders = adoxioContraventionadminMailboxTrackingFolders;
            AdoxioContraventionadminProcessSession = adoxioContraventionadminProcessSession;
            AdoxioContraventionadminBulkDeleteFailures = adoxioContraventionadminBulkDeleteFailures;
            AdoxioContraventionadminPrincipalObjectAttributeAccesses = adoxioContraventionadminPrincipalObjectAttributeAccesses;
            AdoxioContraventionadminContraventions = adoxioContraventionadminContraventions;
            Transactioncurrencyid = transactioncurrencyid;
            AdoxioContraventionInvestigationrequests = adoxioContraventionInvestigationrequests;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_secondcontraventionminvalue_base")]
        public decimal? AdoxioSecondcontraventionminvalueBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_itemnumber")]
        public int? AdoxioItemnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_category")]
        public int? AdoxioCategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_elements")]
        public string AdoxioElements { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_firstcontraventionmaxvalue_base")]
        public decimal? AdoxioFirstcontraventionmaxvalueBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_class")]
        public int? AdoxioClass { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_interpretation")]
        public string AdoxioInterpretation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_firstcontraventionminperiod")]
        public int? AdoxioFirstcontraventionminperiod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isact")]
        public bool? AdoxioIsact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_firstcontraventionmaxvalue")]
        public decimal? AdoxioFirstcontraventionmaxvalue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_thirdcontraventionminperiod")]
        public int? AdoxioThirdcontraventionminperiod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_thirdcontraventionminvalue")]
        public decimal? AdoxioThirdcontraventionminvalue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contraventionadminid")]
        public string AdoxioContraventionadminid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_secondcontraventionminvalue")]
        public decimal? AdoxioSecondcontraventionminvalue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_firstcontraventionmaxperiod")]
        public int? AdoxioFirstcontraventionmaxperiod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype")]
        public int? AdoxioLicencetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_secondcontraventionmaxvalue")]
        public decimal? AdoxioSecondcontraventionmaxvalue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_secondcontraventionmaxperiod")]
        public int? AdoxioSecondcontraventionmaxperiod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_firstcontraventionminvalue_base")]
        public decimal? AdoxioFirstcontraventionminvalueBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isreg")]
        public bool? AdoxioIsreg { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_secondcontraventionminperiod")]
        public int? AdoxioSecondcontraventionminperiod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_reference")]
        public string AdoxioReference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_secondcontraventionmaxvalue_base")]
        public decimal? AdoxioSecondcontraventionmaxvalueBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetypes")]
        public string AdoxioLicencetypes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policynamereference")]
        public string AdoxioPolicynamereference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_thirdcontraventionmaxvalue_base")]
        public decimal? AdoxioThirdcontraventionmaxvalueBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_thirdcontraventionmaxperiod")]
        public int? AdoxioThirdcontraventionmaxperiod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_iswqr")]
        public bool? AdoxioIswqr { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_thirdcontraventionmaxvalue")]
        public decimal? AdoxioThirdcontraventionmaxvalue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_thirdcontraventionminvalue_base")]
        public decimal? AdoxioThirdcontraventionminvalueBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_lcrbtype")]
        public int? AdoxioLcrbtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_istandc")]
        public bool? AdoxioIstandc { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_firstcontraventionminvalue")]
        public decimal? AdoxioFirstcontraventionminvalue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_contraventionadmin_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioContraventionadminSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contraventionadmin_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioContraventionadminDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contraventionadmin_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioContraventionadminDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contraventionadmin_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioContraventionadminAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contraventionadmin_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioContraventionadminMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contraventionadmin_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioContraventionadminProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contraventionadmin_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioContraventionadminBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contraventionadmin_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioContraventionadminPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contraventionadmin_contraventions")]
        public IList<MicrosoftDynamicsCRMadoxioContravention> AdoxioContraventionadminContraventions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_investigationrequests")]
        public IList<MicrosoftDynamicsCRMadoxioInvestigationrequest> AdoxioContraventionInvestigationrequests { get; set; }

    }
}
