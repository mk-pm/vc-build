// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ArgoCD.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ApplicationLogEntry
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationLogEntry class.
        /// </summary>
        public ApplicationLogEntry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationLogEntry class.
        /// </summary>
        public ApplicationLogEntry(string content = default(string), bool? last = default(bool?), string podName = default(string), V1Time timeStamp = default(V1Time), string timeStampStr = default(string))
        {
            Content = content;
            Last = last;
            PodName = podName;
            TimeStamp = timeStamp;
            TimeStampStr = timeStampStr;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "last")]
        public bool? Last { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "podName")]
        public string PodName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timeStamp")]
        public V1Time TimeStamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timeStampStr")]
        public string TimeStampStr { get; set; }

    }
}
