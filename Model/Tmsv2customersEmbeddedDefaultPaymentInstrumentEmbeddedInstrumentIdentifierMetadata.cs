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
    /// Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifierMetadata
    /// </summary>
    [DataContract]
    public partial class Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifierMetadata :  IEquatable<Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifierMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifierMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifierMetadata()
        {
        }
        
        /// <summary>
        /// The creator of the Instrument Identifier.
        /// </summary>
        /// <value>The creator of the Instrument Identifier.</value>
        [DataMember(Name="creator", EmitDefaultValue=false)]
        public string Creator { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifierMetadata {\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
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
            return this.Equals(obj as Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifierMetadata);
        }

        /// <summary>
        /// Returns true if Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifierMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifierMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifierMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Creator == other.Creator ||
                    this.Creator != null &&
                    this.Creator.Equals(other.Creator)
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
                if (this.Creator != null)
                    hash = hash * 59 + this.Creator.GetHashCode();
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
