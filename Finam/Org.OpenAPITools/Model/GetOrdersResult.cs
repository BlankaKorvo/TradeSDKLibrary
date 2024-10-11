/*
 * Trade API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: current
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// GetOrdersRequest result.  Результат GetOrdersRequest.
    /// </summary>
    [DataContract(Name = "GetOrdersResult")]
    public partial class GetOrdersResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrdersResult" /> class.
        /// </summary>
        /// <param name="clientId">Trade Account ID.  Идентификатор торгового счёта..</param>
        public GetOrdersResult(string clientId = default(string))
        {
            this.ClientId = clientId;
        }

        /// <summary>
        /// Trade Account ID.  Идентификатор торгового счёта.
        /// </summary>
        /// <value>Trade Account ID.  Идентификатор торгового счёта.</value>
        [DataMember(Name = "clientId", EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Orders list.  Список заявок.
        /// </summary>
        /// <value>Orders list.  Список заявок.</value>
        [DataMember(Name = "orders", EmitDefaultValue = true)]
        public List<Order> Orders { get; private set; }

        /// <summary>
        /// Returns false as Orders should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOrders()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetOrdersResult {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Orders: ").Append(Orders).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
