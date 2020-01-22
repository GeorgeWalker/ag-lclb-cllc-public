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
    /// Microsoft.Dynamics.CRM.sla
    /// </summary>
    public partial class MicrosoftDynamicsCRMsla
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsla class.
        /// </summary>
        public MicrosoftDynamicsCRMsla()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsla class.
        /// </summary>
        /// <param name="isdefault">Tells whether this SLA is the default
        /// one.</param>
        /// <param name="_modifiedonbehalfbyValue">Shows who created the record
        /// on behalf of another user.</param>
        /// <param name="changedattributelist">Type additional information to
        /// describe the SLA</param>
        /// <param name="_businesshoursidValue">Choose the business hours for
        /// calculating SLA item timelines.</param>
        /// <param name="_owningbusinessunitValue">Unique identifier for the
        /// business unit that owns the record</param>
        /// <param name="overwritetime">For internal use only.</param>
        /// <param name="ismanaged">For internal use only.</param>
        /// <param name="slaid">Unique identifier of the SLA.</param>
        /// <param name="_transactioncurrencyidValue">Unique identifier of the
        /// currency associated with the SLA record.</param>
        /// <param name="modifiedon">Shows the date and time when the record
        /// was last updated. The date and time are displayed in the time zone
        /// selected in Microsoft Dynamics 365 options.</param>
        /// <param name="objecttypecode">Choose the entity type that the SLA is
        /// defined.</param>
        /// <param name="_modifiedbyValue">Shows who last updated the
        /// record.</param>
        /// <param name="slatype">Select the type of service level agreement
        /// (SLA).</param>
        /// <param name="versionnumber">Version number of the SLA.</param>
        /// <param name="_createdonbehalfbyValue">Shows who created the record
        /// on behalf of another user.</param>
        /// <param name="applicablefrompicklist">Select the field that
        /// specifies the date and time from which the SLA items will be
        /// calculated. For example, if you select the Case Created On field,
        /// SLA calculation will begin from the time the case is
        /// created.</param>
        /// <param name="statecode">Shows whether the Service Level Agreement
        /// (SLA) is active or inactive.</param>
        /// <param name="_owninguserValue">Unique identifier for the user that
        /// owns the record.</param>
        /// <param name="applicablefrom">Select the field that specifies the
        /// date and time from which the SLA items will be calculated for the
        /// case record. For example, if you select the Case Created On field,
        /// SLA calculation will begin from the time the case is created.
        /// </param>
        /// <param name="name">Type a descriptive name of the service level
        /// agreement (SLA).</param>
        /// <param name="description">Type additional information to describe
        /// the SLA</param>
        /// <param name="_workflowidValue">Workflow associated with the
        /// SLA.</param>
        /// <param name="_owningteamValue">Unique identifier for the team that
        /// owns the record.</param>
        /// <param name="slaidunique">For internal use only.</param>
        /// <param name="_createdbyValue">Shows who created the record.</param>
        /// <param name="statuscode">Select the status of the service level
        /// agreement (SLA).</param>
        /// <param name="solutionid">Unique identifier of the associated
        /// solution.</param>
        /// <param name="allowpauseresume">Select whether this SLA will allow
        /// pausing and resuming during the time calculation.</param>
        /// <param name="exchangerate">Exchange rate between the currency
        /// associated with the SLA record and the base currency.</param>
        /// <param name="createdon">Shows the date and time when the record was
        /// created. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics 365 options.</param>
        /// <param name="_owneridValue">Enter the user or team who owns the
        /// SLA. This field is updated every time the item is assigned to a
        /// different user.</param>
        /// <param name="primaryentityotc">Shows the primary entity that the
        /// SLA has been created for.</param>
        /// <param name="componentstate">For internal use only.</param>
        public MicrosoftDynamicsCRMsla(bool? isdefault = default(bool?), string _modifiedonbehalfbyValue = default(string), string changedattributelist = default(string), string _businesshoursidValue = default(string), string _owningbusinessunitValue = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), bool? ismanaged = default(bool?), string slaid = default(string), string _transactioncurrencyidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? objecttypecode = default(int?), string _modifiedbyValue = default(string), int? slatype = default(int?), string versionnumber = default(string), string _createdonbehalfbyValue = default(string), int? applicablefrompicklist = default(int?), int? statecode = default(int?), string _owninguserValue = default(string), string applicablefrom = default(string), string name = default(string), string description = default(string), string _workflowidValue = default(string), string _owningteamValue = default(string), string slaidunique = default(string), string _createdbyValue = default(string), int? statuscode = default(int?), string solutionid = default(string), bool? allowpauseresume = default(bool?), decimal? exchangerate = default(decimal?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owneridValue = default(string), int? primaryentityotc = default(int?), int? componentstate = default(int?), MicrosoftDynamicsCRMworkflow workflowid = default(MicrosoftDynamicsCRMworkflow), IList<MicrosoftDynamicsCRMinvoice> manualslaInvoice = default(IList<MicrosoftDynamicsCRMinvoice>), IList<MicrosoftDynamicsCRMaccount> manualslaAccount = default(IList<MicrosoftDynamicsCRMaccount>), IList<MicrosoftDynamicsCRMtask> manualslaTask = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMincident> slaCases = default(IList<MicrosoftDynamicsCRMincident>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcalendar businesshoursid = default(MicrosoftDynamicsCRMcalendar), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMincident> manualslaCases = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMemail> manualslaEmail = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMannotation> slaAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMentitlement> slaEntitlement = default(IList<MicrosoftDynamicsCRMentitlement>), IList<MicrosoftDynamicsCRMsyncerror> sLASyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMphonecall> manualslaPhonecall = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMsalesorder> manualslaSalesorder = default(IList<MicrosoftDynamicsCRMsalesorder>), IList<MicrosoftDynamicsCRMcontact> slaContact = default(IList<MicrosoftDynamicsCRMcontact>), IList<MicrosoftDynamicsCRMopportunity> slaOpportunity = default(IList<MicrosoftDynamicsCRMopportunity>), IList<MicrosoftDynamicsCRMcontact> manualslaContact = default(IList<MicrosoftDynamicsCRMcontact>), IList<MicrosoftDynamicsCRMquote> slaQuote = default(IList<MicrosoftDynamicsCRMquote>), IList<MicrosoftDynamicsCRMquote> manualslaQuote = default(IList<MicrosoftDynamicsCRMquote>), IList<MicrosoftDynamicsCRMactivitypointer> manualslaActivitypointer = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMopportunity> manualslaOpportunity = default(IList<MicrosoftDynamicsCRMopportunity>), IList<MicrosoftDynamicsCRMtask> slaTask = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMfax> manualslaFax = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMentitlementtemplate> slaEntitlementtemplate = default(IList<MicrosoftDynamicsCRMentitlementtemplate>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMletter> slaLetter = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMlead> manualslaLead = default(IList<MicrosoftDynamicsCRMlead>), IList<MicrosoftDynamicsCRMemail> slaEmail = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMsocialactivity> manualslaSocialactivity = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMfax> slaFax = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMaccount> slaAccount = default(IList<MicrosoftDynamicsCRMaccount>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMasyncoperation> slabaseAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), IList<MicrosoftDynamicsCRMappointment> manualslaAppointment = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMphonecall> slaPhonecall = default(IList<MicrosoftDynamicsCRMphonecall>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsocialactivity> slaSocialactivity = default(IList<MicrosoftDynamicsCRMsocialactivity>), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMbulkdeletefailure> slabaseBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMappointment> slaAppointment = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMserviceappointment> manualslaServiceappointment = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMslaitem> slaSlaitemSlaId = default(IList<MicrosoftDynamicsCRMslaitem>), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMlead> slaLead = default(IList<MicrosoftDynamicsCRMlead>), IList<MicrosoftDynamicsCRMactivitypointer> slaActivitypointer = default(IList<MicrosoftDynamicsCRMactivitypointer>), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMletter> manualslaLetter = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMinvoice> slaInvoice = default(IList<MicrosoftDynamicsCRMinvoice>), IList<MicrosoftDynamicsCRMserviceappointment> slaServiceappointment = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMsalesorder> slaSalesorder = default(IList<MicrosoftDynamicsCRMsalesorder>), IList<MicrosoftDynamicsCRMadoxioApplication> manualslaAdoxioApplication = default(IList<MicrosoftDynamicsCRMadoxioApplication>), IList<MicrosoftDynamicsCRMadoxioApplication> slaAdoxioApplication = default(IList<MicrosoftDynamicsCRMadoxioApplication>), IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> absScheduledprocessexecutionSlaSlaid = default(IList<MicrosoftDynamicsCRMabsScheduledprocessexecution>), IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> absScheduledprocessexecutionSlaSlainvokedid = default(IList<MicrosoftDynamicsCRMabsScheduledprocessexecution>))
        {
            Isdefault = isdefault;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Changedattributelist = changedattributelist;
            this._businesshoursidValue = _businesshoursidValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Overwritetime = overwritetime;
            Ismanaged = ismanaged;
            Slaid = slaid;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Modifiedon = modifiedon;
            Objecttypecode = objecttypecode;
            this._modifiedbyValue = _modifiedbyValue;
            Slatype = slatype;
            Versionnumber = versionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Applicablefrompicklist = applicablefrompicklist;
            Statecode = statecode;
            this._owninguserValue = _owninguserValue;
            Applicablefrom = applicablefrom;
            Name = name;
            Description = description;
            this._workflowidValue = _workflowidValue;
            this._owningteamValue = _owningteamValue;
            Slaidunique = slaidunique;
            this._createdbyValue = _createdbyValue;
            Statuscode = statuscode;
            Solutionid = solutionid;
            Allowpauseresume = allowpauseresume;
            Exchangerate = exchangerate;
            Createdon = createdon;
            this._owneridValue = _owneridValue;
            Primaryentityotc = primaryentityotc;
            Componentstate = componentstate;
            Workflowid = workflowid;
            ManualslaInvoice = manualslaInvoice;
            ManualslaAccount = manualslaAccount;
            ManualslaTask = manualslaTask;
            SlaCases = slaCases;
            Createdby = createdby;
            Businesshoursid = businesshoursid;
            Createdonbehalfby = createdonbehalfby;
            ManualslaCases = manualslaCases;
            ManualslaEmail = manualslaEmail;
            SlaAnnotation = slaAnnotation;
            SlaEntitlement = slaEntitlement;
            SLASyncErrors = sLASyncErrors;
            ManualslaPhonecall = manualslaPhonecall;
            ManualslaSalesorder = manualslaSalesorder;
            SlaContact = slaContact;
            SlaOpportunity = slaOpportunity;
            ManualslaContact = manualslaContact;
            SlaQuote = slaQuote;
            ManualslaQuote = manualslaQuote;
            ManualslaActivitypointer = manualslaActivitypointer;
            ManualslaOpportunity = manualslaOpportunity;
            SlaTask = slaTask;
            ManualslaFax = manualslaFax;
            SlaEntitlementtemplate = slaEntitlementtemplate;
            Modifiedby = modifiedby;
            SlaLetter = slaLetter;
            ManualslaLead = manualslaLead;
            SlaEmail = slaEmail;
            ManualslaSocialactivity = manualslaSocialactivity;
            SlaFax = slaFax;
            SlaAccount = slaAccount;
            Transactioncurrencyid = transactioncurrencyid;
            SlabaseAsyncOperations = slabaseAsyncOperations;
            Ownerid = ownerid;
            ManualslaAppointment = manualslaAppointment;
            SlaPhonecall = slaPhonecall;
            Modifiedonbehalfby = modifiedonbehalfby;
            SlaSocialactivity = slaSocialactivity;
            Owningteam = owningteam;
            SlabaseBulkDeleteFailures = slabaseBulkDeleteFailures;
            SlaAppointment = slaAppointment;
            ManualslaServiceappointment = manualslaServiceappointment;
            SlaSlaitemSlaId = slaSlaitemSlaId;
            Owninguser = owninguser;
            SlaLead = slaLead;
            SlaActivitypointer = slaActivitypointer;
            Owningbusinessunit = owningbusinessunit;
            ManualslaLetter = manualslaLetter;
            SlaInvoice = slaInvoice;
            SlaServiceappointment = slaServiceappointment;
            SlaSalesorder = slaSalesorder;
            ManualslaAdoxioApplication = manualslaAdoxioApplication;
            SlaAdoxioApplication = slaAdoxioApplication;
            AbsScheduledprocessexecutionSlaSlaid = absScheduledprocessexecutionSlaSlaid;
            AbsScheduledprocessexecutionSlaSlainvokedid = absScheduledprocessexecutionSlaSlainvokedid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets tells whether this SLA is the default one.
        /// </summary>
        [JsonProperty(PropertyName = "isdefault")]
        public bool? Isdefault { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets type additional information to describe the SLA
        /// </summary>
        [JsonProperty(PropertyName = "changedattributelist")]
        public string Changedattributelist { get; set; }

        /// <summary>
        /// Gets or sets choose the business hours for calculating SLA item
        /// timelines.
        /// </summary>
        [JsonProperty(PropertyName = "_businesshoursid_value")]
        public string _businesshoursidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the business unit that owns the
        /// record
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the SLA.
        /// </summary>
        [JsonProperty(PropertyName = "slaid")]
        public string Slaid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the currency associated with the
        /// SLA record.
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was last
        /// updated. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics 365 options.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets choose the entity type that the SLA is defined.
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public int? Objecttypecode { get; set; }

        /// <summary>
        /// Gets or sets shows who last updated the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets select the type of service level agreement (SLA).
        /// </summary>
        [JsonProperty(PropertyName = "slatype")]
        public int? Slatype { get; set; }

        /// <summary>
        /// Gets or sets version number of the SLA.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets select the field that specifies the date and time from
        /// which the SLA items will be calculated. For example, if you select
        /// the Case Created On field, SLA calculation will begin from the time
        /// the case is created.
        /// </summary>
        [JsonProperty(PropertyName = "applicablefrompicklist")]
        public int? Applicablefrompicklist { get; set; }

        /// <summary>
        /// Gets or sets shows whether the Service Level Agreement (SLA) is
        /// active or inactive.
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the user that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets select the field that specifies the date and time from
        /// which the SLA items will be calculated for the case record. For
        /// example, if you select the Case Created On field, SLA calculation
        /// will begin from the time the case is created.
        /// </summary>
        [JsonProperty(PropertyName = "applicablefrom")]
        public string Applicablefrom { get; set; }

        /// <summary>
        /// Gets or sets type a descriptive name of the service level agreement
        /// (SLA).
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets type additional information to describe the SLA
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets workflow associated with the SLA.
        /// </summary>
        [JsonProperty(PropertyName = "_workflowid_value")]
        public string _workflowidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the team that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "slaidunique")]
        public string Slaidunique { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets select the status of the service level agreement
        /// (SLA).
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the associated solution.
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// Gets or sets select whether this SLA will allow pausing and
        /// resuming during the time calculation.
        /// </summary>
        [JsonProperty(PropertyName = "allowpauseresume")]
        public bool? Allowpauseresume { get; set; }

        /// <summary>
        /// Gets or sets exchange rate between the currency associated with the
        /// SLA record and the base currency.
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was created.
        /// The date and time are displayed in the time zone selected in
        /// Microsoft Dynamics 365 options.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets enter the user or team who owns the SLA. This field is
        /// updated every time the item is assigned to a different user.
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// Gets or sets shows the primary entity that the SLA has been created
        /// for.
        /// </summary>
        [JsonProperty(PropertyName = "primaryentityotc")]
        public int? Primaryentityotc { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflowid")]
        public MicrosoftDynamicsCRMworkflow Workflowid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_invoice")]
        public IList<MicrosoftDynamicsCRMinvoice> ManualslaInvoice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_account")]
        public IList<MicrosoftDynamicsCRMaccount> ManualslaAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_task")]
        public IList<MicrosoftDynamicsCRMtask> ManualslaTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_cases")]
        public IList<MicrosoftDynamicsCRMincident> SlaCases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businesshoursid")]
        public MicrosoftDynamicsCRMcalendar Businesshoursid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_cases")]
        public IList<MicrosoftDynamicsCRMincident> ManualslaCases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_email")]
        public IList<MicrosoftDynamicsCRMemail> ManualslaEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> SlaAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_entitlement")]
        public IList<MicrosoftDynamicsCRMentitlement> SlaEntitlement { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SLA_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SLASyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_phonecall")]
        public IList<MicrosoftDynamicsCRMphonecall> ManualslaPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_salesorder")]
        public IList<MicrosoftDynamicsCRMsalesorder> ManualslaSalesorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_contact")]
        public IList<MicrosoftDynamicsCRMcontact> SlaContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_opportunity")]
        public IList<MicrosoftDynamicsCRMopportunity> SlaOpportunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_contact")]
        public IList<MicrosoftDynamicsCRMcontact> ManualslaContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_quote")]
        public IList<MicrosoftDynamicsCRMquote> SlaQuote { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_quote")]
        public IList<MicrosoftDynamicsCRMquote> ManualslaQuote { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_activitypointer")]
        public IList<MicrosoftDynamicsCRMactivitypointer> ManualslaActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_opportunity")]
        public IList<MicrosoftDynamicsCRMopportunity> ManualslaOpportunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_task")]
        public IList<MicrosoftDynamicsCRMtask> SlaTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_fax")]
        public IList<MicrosoftDynamicsCRMfax> ManualslaFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_entitlementtemplate")]
        public IList<MicrosoftDynamicsCRMentitlementtemplate> SlaEntitlementtemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_letter")]
        public IList<MicrosoftDynamicsCRMletter> SlaLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_lead")]
        public IList<MicrosoftDynamicsCRMlead> ManualslaLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_email")]
        public IList<MicrosoftDynamicsCRMemail> SlaEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_socialactivity")]
        public IList<MicrosoftDynamicsCRMsocialactivity> ManualslaSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_fax")]
        public IList<MicrosoftDynamicsCRMfax> SlaFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_account")]
        public IList<MicrosoftDynamicsCRMaccount> SlaAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slabase_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SlabaseAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_appointment")]
        public IList<MicrosoftDynamicsCRMappointment> ManualslaAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_phonecall")]
        public IList<MicrosoftDynamicsCRMphonecall> SlaPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_socialactivity")]
        public IList<MicrosoftDynamicsCRMsocialactivity> SlaSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slabase_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SlabaseBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_appointment")]
        public IList<MicrosoftDynamicsCRMappointment> SlaAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_serviceappointment")]
        public IList<MicrosoftDynamicsCRMserviceappointment> ManualslaServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_slaitem_slaId")]
        public IList<MicrosoftDynamicsCRMslaitem> SlaSlaitemSlaId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_lead")]
        public IList<MicrosoftDynamicsCRMlead> SlaLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_activitypointer")]
        public IList<MicrosoftDynamicsCRMactivitypointer> SlaActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_letter")]
        public IList<MicrosoftDynamicsCRMletter> ManualslaLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_invoice")]
        public IList<MicrosoftDynamicsCRMinvoice> SlaInvoice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_serviceappointment")]
        public IList<MicrosoftDynamicsCRMserviceappointment> SlaServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_salesorder")]
        public IList<MicrosoftDynamicsCRMsalesorder> SlaSalesorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_adoxio_application")]
        public IList<MicrosoftDynamicsCRMadoxioApplication> ManualslaAdoxioApplication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_adoxio_application")]
        public IList<MicrosoftDynamicsCRMadoxioApplication> SlaAdoxioApplication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocessexecution_sla_slaid")]
        public IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> AbsScheduledprocessexecutionSlaSlaid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocessexecution_sla_slainvokedid")]
        public IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> AbsScheduledprocessexecutionSlaSlainvokedid { get; set; }

    }
}
