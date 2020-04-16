/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// InstrumentIdentifierBankAccount
    /// </summary>
    [DataContract]
    public partial class InstrumentIdentifierBankAccount :  IEquatable<InstrumentIdentifierBankAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentIdentifierBankAccount" /> class.
        /// </summary>
        /// <param name="Number">Checking account number..</param>
        /// <param name="RoutingNumber">Routing number..</param>
        public InstrumentIdentifierBankAccount(string Number = default(string), string RoutingNumber = default(string))
        {
            this.Number = Number;
            this.RoutingNumber = RoutingNumber;
        }
        
        /// <summary>
        /// Checking account number.
        /// </summary>
        /// <value>Checking account number.</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Routing number.
        /// </summary>
        /// <value>Routing number.</value>
        [DataMember(Name="routingNumber", EmitDefaultValue=false)]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstrumentIdentifierBankAccount {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  RoutingNumber: ").Append(RoutingNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as InstrumentIdentifierBankAccount);
        }

        /// <summary>
        /// Returns true if InstrumentIdentifierBankAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of InstrumentIdentifierBankAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstrumentIdentifierBankAccount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.RoutingNumber == other.RoutingNumber ||
                    this.RoutingNumber != null &&
                    this.RoutingNumber.Equals(other.RoutingNumber)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                if (this.RoutingNumber != null)
                    hash = hash * 59 + this.RoutingNumber.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Number (string) maxLength
            if(this.Number != null && this.Number.Length >= 19)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, length must be less than or equal to 19.", new [] { "Number" });
            }

            // Number (string) minLength
            if(this.Number != null && this.Number.Length <= 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, length must be greater than or equal to 1.", new [] { "Number" });
            }

            // RoutingNumber (string) maxLength
            if(this.RoutingNumber != null && this.RoutingNumber.Length >= 9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RoutingNumber, length must be less than or equal to 9.", new [] { "RoutingNumber" });
            }

            // RoutingNumber (string) minLength
            if(this.RoutingNumber != null && this.RoutingNumber.Length <= 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RoutingNumber, length must be greater than or equal to 1.", new [] { "RoutingNumber" });
            }

            yield break;
        }
    }

}
