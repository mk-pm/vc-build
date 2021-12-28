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

    public partial class RuntimeStreamError
    {
        /// <summary>
        /// Initializes a new instance of the RuntimeStreamError class.
        /// </summary>
        public RuntimeStreamError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RuntimeStreamError class.
        /// </summary>
        public RuntimeStreamError(IList<ProtobufAny> details = default(IList<ProtobufAny>), int? grpcCode = default(int?), int? httpCode = default(int?), string httpStatus = default(string), string message = default(string))
        {
            Details = details;
            GrpcCode = grpcCode;
            HttpCode = httpCode;
            HttpStatus = httpStatus;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<ProtobufAny> Details { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "grpc_code")]
        public int? GrpcCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "http_code")]
        public int? HttpCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "http_status")]
        public string HttpStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
