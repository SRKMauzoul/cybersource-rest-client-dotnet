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
    /// PaymentsProductsECheckConfigurationInformationConfigurationsFeaturesAccountValidationServiceInternalOnly
    /// </summary>
    [DataContract]
    public partial class PaymentsProductsECheckConfigurationInformationConfigurationsFeaturesAccountValidationServiceInternalOnly :  IEquatable<PaymentsProductsECheckConfigurationInformationConfigurationsFeaturesAccountValidationServiceInternalOnly>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsProductsECheckConfigurationInformationConfigurationsFeaturesAccountValidationServiceInternalOnly" /> class.
        /// </summary>
        /// <param name="Processors">*NEW* Payment Processing connection used to support eCheck, aka ACH, payment methods. Example * \&quot;bofaach\&quot; * \&quot;wellsfargoach\&quot; .</param>
        public PaymentsProductsECheckConfigurationInformationConfigurationsFeaturesAccountValidationServiceInternalOnly(Dictionary<string, Object> Processors = default(Dictionary<string, Object>))
        {
            this.Processors = Processors;
        }
        
        /// <summary>
        /// *NEW* Payment Processing connection used to support eCheck, aka ACH, payment methods. Example * \&quot;bofaach\&quot; * \&quot;wellsfargoach\&quot; 
        /// </summary>
        /// <value>*NEW* Payment Processing connection used to support eCheck, aka ACH, payment methods. Example * \&quot;bofaach\&quot; * \&quot;wellsfargoach\&quot; </value>
        [DataMember(Name="processors", EmitDefaultValue=false)]
        public Dictionary<string, Object> Processors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentsProductsECheckConfigurationInformationConfigurationsFeaturesAccountValidationServiceInternalOnly {\n");
            sb.Append("  Processors: ").Append(Processors).Append("\n");
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
            return this.Equals(obj as PaymentsProductsECheckConfigurationInformationConfigurationsFeaturesAccountValidationServiceInternalOnly);
        }

        /// <summary>
        /// Returns true if PaymentsProductsECheckConfigurationInformationConfigurationsFeaturesAccountValidationServiceInternalOnly instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentsProductsECheckConfigurationInformationConfigurationsFeaturesAccountValidationServiceInternalOnly to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentsProductsECheckConfigurationInformationConfigurationsFeaturesAccountValidationServiceInternalOnly other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Processors == other.Processors ||
                    this.Processors != null &&
                    this.Processors.SequenceEqual(other.Processors)
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
                if (this.Processors != null)
                    hash = hash * 59 + this.Processors.GetHashCode();
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
            yield break;
        }
    }

}
