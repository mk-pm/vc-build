// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ArgoCD.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ApplicationSourcePlugin holds options specific to config management
    /// plugins
    /// </summary>
    public partial class V1alpha1ApplicationSourcePlugin
    {
        /// <summary>
        /// Initializes a new instance of the V1alpha1ApplicationSourcePlugin
        /// class.
        /// </summary>
        public V1alpha1ApplicationSourcePlugin()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1alpha1ApplicationSourcePlugin
        /// class.
        /// </summary>
        public V1alpha1ApplicationSourcePlugin(IList<Applicationv1alpha1EnvEntry> env = default(IList<Applicationv1alpha1EnvEntry>), string name = default(string))
        {
            Env = env;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "env")]
        public IList<Applicationv1alpha1EnvEntry> Env { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
