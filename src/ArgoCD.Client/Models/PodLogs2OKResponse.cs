// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ArgoCD.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Stream result of applicationLogEntry
    /// </summary>
    public partial class PodLogs2OKResponse
    {
        /// <summary>
        /// Initializes a new instance of the PodLogs2OKResponse class.
        /// </summary>
        public PodLogs2OKResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PodLogs2OKResponse class.
        /// </summary>
        public PodLogs2OKResponse(RuntimeStreamError error = default(RuntimeStreamError), ApplicationLogEntry result = default(ApplicationLogEntry))
        {
            Error = error;
            Result = result;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public RuntimeStreamError Error { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public ApplicationLogEntry Result { get; set; }

    }
}
