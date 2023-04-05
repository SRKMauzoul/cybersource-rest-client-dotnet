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
    /// Rbsv1plansidProcessingInformationSubscriptionBillingOptions
    /// </summary>
    [DataContract]
    public partial class Rbsv1plansidProcessingInformationSubscriptionBillingOptions :  IEquatable<Rbsv1plansidProcessingInformationSubscriptionBillingOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rbsv1plansidProcessingInformationSubscriptionBillingOptions" /> class.
        /// </summary>
        /// <param name="ApplyTo">Valid Values: - &#x60;ALL&#x60; - Change applied to all Subscriptions (Existing + New) - &#x60;NEW&#x60; - Change applied to New Subsciptions only .</param>
        public Rbsv1plansidProcessingInformationSubscriptionBillingOptions(string ApplyTo = default(string))
        {
            this.ApplyTo = ApplyTo;
        }
        
        /// <summary>
        /// Valid Values: - &#x60;ALL&#x60; - Change applied to all Subscriptions (Existing + New) - &#x60;NEW&#x60; - Change applied to New Subsciptions only 
        /// </summary>
        /// <value>Valid Values: - &#x60;ALL&#x60; - Change applied to all Subscriptions (Existing + New) - &#x60;NEW&#x60; - Change applied to New Subsciptions only </value>
        [DataMember(Name="applyTo", EmitDefaultValue=false)]
        public string ApplyTo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rbsv1plansidProcessingInformationSubscriptionBillingOptions {\n");
            sb.Append("  ApplyTo: ").Append(ApplyTo).Append("\n");
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
            return this.Equals(obj as Rbsv1plansidProcessingInformationSubscriptionBillingOptions);
        }

        /// <summary>
        /// Returns true if Rbsv1plansidProcessingInformationSubscriptionBillingOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of Rbsv1plansidProcessingInformationSubscriptionBillingOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rbsv1plansidProcessingInformationSubscriptionBillingOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApplyTo == other.ApplyTo ||
                    this.ApplyTo != null &&
                    this.ApplyTo.Equals(other.ApplyTo)
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
                if (this.ApplyTo != null)
                    hash = hash * 59 + this.ApplyTo.GetHashCode();
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
