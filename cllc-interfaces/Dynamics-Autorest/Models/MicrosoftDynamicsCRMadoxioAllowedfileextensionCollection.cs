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
    /// Collection of adoxio_allowedfileextension
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_allowedfileextensionCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioAllowedfileextensionCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioAllowedfileextensionCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioAllowedfileextensionCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioAllowedfileextensionCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioAllowedfileextensionCollection(IList<MicrosoftDynamicsCRMadoxioAllowedfileextension> value = default(IList<MicrosoftDynamicsCRMadoxioAllowedfileextension>))
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
        public IList<MicrosoftDynamicsCRMadoxioAllowedfileextension> Value { get; set; }

    }
}
