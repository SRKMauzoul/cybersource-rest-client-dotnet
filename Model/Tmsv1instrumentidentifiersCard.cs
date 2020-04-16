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
    /// Tmsv1instrumentidentifiersCard
    /// </summary>
    [DataContract]
    public partial class Tmsv1instrumentidentifiersCard :  IEquatable<Tmsv1instrumentidentifiersCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tmsv1instrumentidentifiersCard" /> class.
        /// </summary>
        /// <param name="Number">Credit card number (PAN)..</param>
        /// <param name="ExpirationMonth">Card expiration month.  Format: &#x60;MM&#x60;. Possible values: &#x60;01&#x60; through &#x60;12&#x60;. .</param>
        /// <param name="ExpirationYear">Card expiration year. Format: &#x60;YYYY&#x60;. Possible values: &#x60;1900&#x60; through &#x60;2099&#x60;. .</param>
        /// <param name="SecurityCode">Card security code..</param>
        public Tmsv1instrumentidentifiersCard(string Number = default(string), string ExpirationMonth = default(string), string ExpirationYear = default(string), string SecurityCode = default(string))
        {
            this.Number = Number;
            this.ExpirationMonth = ExpirationMonth;
            this.ExpirationYear = ExpirationYear;
            this.SecurityCode = SecurityCode;
        }
        
        /// <summary>
        /// Credit card number (PAN).
        /// </summary>
        /// <value>Credit card number (PAN).</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Card expiration month.  Format: &#x60;MM&#x60;. Possible values: &#x60;01&#x60; through &#x60;12&#x60;. 
        /// </summary>
        /// <value>Card expiration month.  Format: &#x60;MM&#x60;. Possible values: &#x60;01&#x60; through &#x60;12&#x60;. </value>
        [DataMember(Name="expirationMonth", EmitDefaultValue=false)]
        public string ExpirationMonth { get; set; }

        /// <summary>
        /// Card expiration year. Format: &#x60;YYYY&#x60;. Possible values: &#x60;1900&#x60; through &#x60;2099&#x60;. 
        /// </summary>
        /// <value>Card expiration year. Format: &#x60;YYYY&#x60;. Possible values: &#x60;1900&#x60; through &#x60;2099&#x60;. </value>
        [DataMember(Name="expirationYear", EmitDefaultValue=false)]
        public string ExpirationYear { get; set; }

        /// <summary>
        /// Card security code.
        /// </summary>
        /// <value>Card security code.</value>
        [DataMember(Name="securityCode", EmitDefaultValue=false)]
        public string SecurityCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tmsv1instrumentidentifiersCard {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  ExpirationMonth: ").Append(ExpirationMonth).Append("\n");
            sb.Append("  ExpirationYear: ").Append(ExpirationYear).Append("\n");
            sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
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
            return this.Equals(obj as Tmsv1instrumentidentifiersCard);
        }

        /// <summary>
        /// Returns true if Tmsv1instrumentidentifiersCard instances are equal
        /// </summary>
        /// <param name="other">Instance of Tmsv1instrumentidentifiersCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tmsv1instrumentidentifiersCard other)
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
                    this.ExpirationMonth == other.ExpirationMonth ||
                    this.ExpirationMonth != null &&
                    this.ExpirationMonth.Equals(other.ExpirationMonth)
                ) && 
                (
                    this.ExpirationYear == other.ExpirationYear ||
                    this.ExpirationYear != null &&
                    this.ExpirationYear.Equals(other.ExpirationYear)
                ) && 
                (
                    this.SecurityCode == other.SecurityCode ||
                    this.SecurityCode != null &&
                    this.SecurityCode.Equals(other.SecurityCode)
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
                if (this.ExpirationMonth != null)
                    hash = hash * 59 + this.ExpirationMonth.GetHashCode();
                if (this.ExpirationYear != null)
                    hash = hash * 59 + this.ExpirationYear.GetHashCode();
                if (this.SecurityCode != null)
                    hash = hash * 59 + this.SecurityCode.GetHashCode();
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
            if(this.Number != null && this.Number.Length <= 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, length must be greater than or equal to 12.", new [] { "Number" });
            }

            // ExpirationMonth (string) maxLength
            if(this.ExpirationMonth != null && this.ExpirationMonth.Length >= 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationMonth, length must be less than or equal to 2.", new [] { "ExpirationMonth" });
            }

            // ExpirationMonth (string) minLength
            if(this.ExpirationMonth != null && this.ExpirationMonth.Length <= 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationMonth, length must be greater than or equal to 2.", new [] { "ExpirationMonth" });
            }

            // ExpirationYear (string) maxLength
            if(this.ExpirationYear != null && this.ExpirationYear.Length >= 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationYear, length must be less than or equal to 4.", new [] { "ExpirationYear" });
            }

            // ExpirationYear (string) minLength
            if(this.ExpirationYear != null && this.ExpirationYear.Length <= 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationYear, length must be greater than or equal to 4.", new [] { "ExpirationYear" });
            }

            // SecurityCode (string) maxLength
            if(this.SecurityCode != null && this.SecurityCode.Length >= 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecurityCode, length must be less than or equal to 4.", new [] { "SecurityCode" });
            }

            // SecurityCode (string) minLength
            if(this.SecurityCode != null && this.SecurityCode.Length <= 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecurityCode, length must be greater than or equal to 3.", new [] { "SecurityCode" });
            }

            yield break;
        }
    }

}
