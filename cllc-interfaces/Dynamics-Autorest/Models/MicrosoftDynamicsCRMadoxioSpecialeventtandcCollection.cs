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
    /// Collection of adoxio_specialeventtandc
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_specialeventtandcCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioSpecialeventtandcCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioSpecialeventtandcCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioSpecialeventtandcCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioSpecialeventtandcCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioSpecialeventtandcCollection(IList<MicrosoftDynamicsCRMadoxioSpecialeventtandc> value = default(IList<MicrosoftDynamicsCRMadoxioSpecialeventtandc>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMadoxioSpecialeventtandc> Value { get; set; }

    }
}
