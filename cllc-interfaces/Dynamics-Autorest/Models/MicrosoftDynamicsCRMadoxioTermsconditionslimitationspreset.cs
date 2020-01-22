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
    /// Microsoft.Dynamics.CRM.adoxio_termsconditionslimitationspreset
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset class.
        /// </summary>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="adoxioTermsconditionslimitationspresetid">Unique
        /// identifier for entity instances</param>
        /// <param name="_owningbusinessunitValue">Unique identifier for the
        /// business unit that owns the record</param>
        /// <param name="versionnumber">Version Number</param>
        /// <param name="_owninguserValue">Unique identifier for the user that
        /// owns the record.</param>
        /// <param name="adoxioDisplayorder">Order to be displayed or
        /// inserted</param>
        /// <param name="_owneridValue">Owner Id</param>
        /// <param name="adoxioName">The name of the custom entity.</param>
        /// <param name="_owningteamValue">Unique identifier for the team that
        /// owns the record.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="adoxioIsdefault">Is to be added to Application By
        /// Default</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        /// <param name="statecode">Status of the Terms Conditions Limitations
        /// Preset</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="statuscode">Reason for the status of the Terms
        /// Conditions Limitations Preset</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        public MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset(string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string adoxioTermsconditionslimitationspresetid = default(string), string _owningbusinessunitValue = default(string), string versionnumber = default(string), string _owninguserValue = default(string), int? adoxioDisplayorder = default(int?), string adoxioContents = default(string), string _owneridValue = default(string), string _adoxioLicencetypeValue = default(string), string adoxioName = default(string), string _owningteamValue = default(string), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), bool? adoxioIsdefault = default(bool?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), int? statecode = default(int?), int? utcconversiontimezonecode = default(int?), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? statuscode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioTermsconditionslimitationspresetSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioTermsconditionslimitationspresetDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioTermsconditionslimitationspresetDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioTermsconditionslimitationspresetAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioTermsconditionslimitationspresetBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMadoxioLicencetype adoxioLicenceType = default(MicrosoftDynamicsCRMadoxioLicencetype), IList<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation> adoxioAdoxioTermsconditionspresetAdoxioApplicationtermsconditionsTermsConditionsPreset = default(IList<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation>))
        {
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioTermsconditionslimitationspresetid = adoxioTermsconditionslimitationspresetid;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Versionnumber = versionnumber;
            this._owninguserValue = _owninguserValue;
            AdoxioDisplayorder = adoxioDisplayorder;
            AdoxioContents = adoxioContents;
            this._owneridValue = _owneridValue;
            this._adoxioLicencetypeValue = _adoxioLicencetypeValue;
            AdoxioName = adoxioName;
            this._owningteamValue = _owningteamValue;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioIsdefault = adoxioIsdefault;
            Createdon = createdon;
            Importsequencenumber = importsequencenumber;
            Statecode = statecode;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Modifiedon = modifiedon;
            Statuscode = statuscode;
            Overriddencreatedon = overriddencreatedon;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioTermsconditionslimitationspresetSyncErrors = adoxioTermsconditionslimitationspresetSyncErrors;
            AdoxioTermsconditionslimitationspresetDuplicateMatchingRecord = adoxioTermsconditionslimitationspresetDuplicateMatchingRecord;
            AdoxioTermsconditionslimitationspresetDuplicateBaseRecord = adoxioTermsconditionslimitationspresetDuplicateBaseRecord;
            AdoxioTermsconditionslimitationspresetAsyncOperations = adoxioTermsconditionslimitationspresetAsyncOperations;
            AdoxioTermsconditionslimitationspresetBulkDeleteFailures = adoxioTermsconditionslimitationspresetBulkDeleteFailures;
            AdoxioLicenceType = adoxioLicenceType;
            AdoxioAdoxioTermsconditionspresetAdoxioApplicationtermsconditionsTermsConditionsPreset = adoxioAdoxioTermsconditionspresetAdoxioApplicationtermsconditionsTermsConditionsPreset;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_termsconditionslimitationspresetid")]
        public string AdoxioTermsconditionslimitationspresetid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the business unit that owns the
        /// record
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets version Number
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the user that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets order to be displayed or inserted
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_displayorder")]
        public int? AdoxioDisplayorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contents")]
        public string AdoxioContents { get; set; }

        /// <summary>
        /// Gets or sets owner Id
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licencetype_value")]
        public string _adoxioLicencetypeValue { get; set; }

        /// <summary>
        /// Gets or sets the name of the custom entity.
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the team that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets is to be added to Application By Default
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isdefault")]
        public bool? AdoxioIsdefault { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets status of the Terms Conditions Limitations Preset
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the Terms Conditions
        /// Limitations Preset
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_termsconditionslimitationspreset_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioTermsconditionslimitationspresetSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_termsconditionslimitationspreset_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioTermsconditionslimitationspresetDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_termsconditionslimitationspreset_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioTermsconditionslimitationspresetDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_termsconditionslimitationspreset_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioTermsconditionslimitationspresetAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_termsconditionslimitationspreset_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioTermsconditionslimitationspresetBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenceType")]
        public MicrosoftDynamicsCRMadoxioLicencetype AdoxioLicenceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_termsconditionspreset_adoxio_applicationtermsconditions_TermsConditionsPreset")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation> AdoxioAdoxioTermsconditionspresetAdoxioApplicationtermsconditionsTermsConditionsPreset { get; set; }

    }
}
