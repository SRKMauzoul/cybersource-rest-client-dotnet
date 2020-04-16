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
    /// Ptsv2paymentsPromotionInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsPromotionInformation :  IEquatable<Ptsv2paymentsPromotionInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsPromotionInformation" /> class.
        /// </summary>
        /// <param name="AdditionalCode">Additional rental agency marketed coupons for consumers to discount the rate of the vehicle rental agreement. .</param>
        /// <param name="Code">Code for a promotion or discount. .</param>
        public Ptsv2paymentsPromotionInformation(string AdditionalCode = default(string), string Code = default(string))
        {
            this.AdditionalCode = AdditionalCode;
            this.Code = Code;
        }
        
        /// <summary>
        /// Additional rental agency marketed coupons for consumers to discount the rate of the vehicle rental agreement. 
        /// </summary>
        /// <value>Additional rental agency marketed coupons for consumers to discount the rate of the vehicle rental agreement. </value>
        [DataMember(Name="additionalCode", EmitDefaultValue=false)]
        public string AdditionalCode { get; set; }

        /// <summary>
        /// Code for a promotion or discount. 
        /// </summary>
        /// <value>Code for a promotion or discount. </value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsPromotionInformation {\n");
            sb.Append("  AdditionalCode: ").Append(AdditionalCode).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsPromotionInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsPromotionInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsPromotionInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsPromotionInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AdditionalCode == other.AdditionalCode ||
                    this.AdditionalCode != null &&
                    this.AdditionalCode.Equals(other.AdditionalCode)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
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
                if (this.AdditionalCode != null)
                    hash = hash * 59 + this.AdditionalCode.GetHashCode();
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
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
            // AdditionalCode (string) maxLength
            if(this.AdditionalCode != null && this.AdditionalCode.Length >= 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AdditionalCode, length must be less than or equal to 12.", new [] { "AdditionalCode" });
            }

            // Code (string) maxLength
            if(this.Code != null && this.Code.Length >= 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than or equal to 12.", new [] { "Code" });
            }

            yield break;
        }
    }

}
