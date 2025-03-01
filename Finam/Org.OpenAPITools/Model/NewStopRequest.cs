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
    /// New Stop Order request.  Запрос на выставление стоп заявки.
    /// </summary>
    [DataContract(Name = "NewStopRequest")]
    public partial class NewStopRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets BuySell
        /// </summary>
        [DataMember(Name = "buySell", EmitDefaultValue = false)]
        public BuySell? BuySell { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewStopRequest" /> class.
        /// </summary>
        /// <param name="clientId">Trade Account ID.  Идентификатор торгового счёта..</param>
        /// <param name="securityBoard">Trading Board.  Режим торгов..</param>
        /// <param name="securityCode">Security Code.  Тикер инструмента..</param>
        /// <param name="buySell">buySell.</param>
        /// <param name="stopLoss">stopLoss.</param>
        /// <param name="takeProfit">takeProfit.</param>
        /// <param name="expirationDate">Time of order canceled on the server in UTC.  Время, когда заявка была отменена на сервере. В UTC..</param>
        /// <param name="linkOrder">Linked order ID.  Биржевой номер связанной (активной) заявки..</param>
        /// <param name="validBefore">validBefore.</param>
        public NewStopRequest(string clientId = default(string), string securityBoard = default(string), string securityCode = default(string), BuySell? buySell = default(BuySell?), StopLoss stopLoss = default(StopLoss), TakeProfit takeProfit = default(TakeProfit), DateOnly? expirationDate = default(DateOnly?), long linkOrder = default(long), OrderValidBefore validBefore = default(OrderValidBefore))
        {
            this.ClientId = clientId;
            this.SecurityBoard = securityBoard;
            this.SecurityCode = securityCode;
            this.BuySell = buySell;
            this.StopLoss = stopLoss;
            this.TakeProfit = takeProfit;
            this.ExpirationDate = expirationDate;
            this.LinkOrder = linkOrder;
            this.ValidBefore = validBefore;
        }

        /// <summary>
        /// Trade Account ID.  Идентификатор торгового счёта.
        /// </summary>
        /// <value>Trade Account ID.  Идентификатор торгового счёта.</value>
        [DataMember(Name = "clientId", EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Trading Board.  Режим торгов.
        /// </summary>
        /// <value>Trading Board.  Режим торгов.</value>
        [DataMember(Name = "securityBoard", EmitDefaultValue = true)]
        public string SecurityBoard { get; set; }

        /// <summary>
        /// Security Code.  Тикер инструмента.
        /// </summary>
        /// <value>Security Code.  Тикер инструмента.</value>
        [DataMember(Name = "securityCode", EmitDefaultValue = true)]
        public string SecurityCode { get; set; }

        /// <summary>
        /// Gets or Sets StopLoss
        /// </summary>
        [DataMember(Name = "stopLoss", EmitDefaultValue = false)]
        public StopLoss StopLoss { get; set; }

        /// <summary>
        /// Gets or Sets TakeProfit
        /// </summary>
        [DataMember(Name = "takeProfit", EmitDefaultValue = false)]
        public TakeProfit TakeProfit { get; set; }

        /// <summary>
        /// Time of order canceled on the server in UTC.  Время, когда заявка была отменена на сервере. В UTC.
        /// </summary>
        /// <value>Time of order canceled on the server in UTC.  Время, когда заявка была отменена на сервере. В UTC.</value>
        [DataMember(Name = "expirationDate", EmitDefaultValue = true)]
        public DateOnly? ExpirationDate { get; set; }

        /// <summary>
        /// Linked order ID.  Биржевой номер связанной (активной) заявки.
        /// </summary>
        /// <value>Linked order ID.  Биржевой номер связанной (активной) заявки.</value>
        [DataMember(Name = "linkOrder", EmitDefaultValue = false)]
        public long LinkOrder { get; set; }

        /// <summary>
        /// Gets or Sets ValidBefore
        /// </summary>
        [DataMember(Name = "validBefore", EmitDefaultValue = false)]
        public OrderValidBefore ValidBefore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NewStopRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  SecurityBoard: ").Append(SecurityBoard).Append("\n");
            sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
            sb.Append("  BuySell: ").Append(BuySell).Append("\n");
            sb.Append("  StopLoss: ").Append(StopLoss).Append("\n");
            sb.Append("  TakeProfit: ").Append(TakeProfit).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  LinkOrder: ").Append(LinkOrder).Append("\n");
            sb.Append("  ValidBefore: ").Append(ValidBefore).Append("\n");
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
