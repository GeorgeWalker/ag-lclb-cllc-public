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
    /// Collection of adoxio_applicenseechangebpfv2
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_applicenseechangebpfv2Collection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioApplicenseechangebpfv2Collection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicenseechangebpfv2Collection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicenseechangebpfv2Collection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicenseechangebpfv2Collection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicenseechangebpfv2Collection(IList<MicrosoftDynamicsCRMadoxioApplicenseechangebpfv2> value = default(IList<MicrosoftDynamicsCRMadoxioApplicenseechangebpfv2>))
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
        public IList<MicrosoftDynamicsCRMadoxioApplicenseechangebpfv2> Value { get; set; }

    }
}