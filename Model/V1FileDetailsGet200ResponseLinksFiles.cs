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
    /// V1FileDetailsGet200ResponseLinksFiles
    /// </summary>
    [DataContract]
    public partial class V1FileDetailsGet200ResponseLinksFiles :  IEquatable<V1FileDetailsGet200ResponseLinksFiles>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1FileDetailsGet200ResponseLinksFiles" /> class.
        /// </summary>
        /// <param name="FileId">Unique identifier for each file.</param>
        /// <param name="Href">Href.</param>
        /// <param name="Method">Method.</param>
        public V1FileDetailsGet200ResponseLinksFiles(string FileId = default(string), string Href = default(string), string Method = default(string))
        {
            this.FileId = FileId;
            this.Href = Href;
            this.Method = Method;
        }
        
        /// <summary>
        /// Unique identifier for each file
        /// </summary>
        /// <value>Unique identifier for each file</value>
        [DataMember(Name="fileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1FileDetailsGet200ResponseLinksFiles {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
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
            return this.Equals(obj as V1FileDetailsGet200ResponseLinksFiles);
        }

        /// <summary>
        /// Returns true if V1FileDetailsGet200ResponseLinksFiles instances are equal
        /// </summary>
        /// <param name="other">Instance of V1FileDetailsGet200ResponseLinksFiles to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1FileDetailsGet200ResponseLinksFiles other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FileId == other.FileId ||
                    this.FileId != null &&
                    this.FileId.Equals(other.FileId)
                ) && 
                (
                    this.Href == other.Href ||
                    this.Href != null &&
                    this.Href.Equals(other.Href)
                ) && 
                (
                    this.Method == other.Method ||
                    this.Method != null &&
                    this.Method.Equals(other.Method)
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
                if (this.FileId != null)
                    hash = hash * 59 + this.FileId.GetHashCode();
                if (this.Href != null)
                    hash = hash * 59 + this.Href.GetHashCode();
                if (this.Method != null)
                    hash = hash * 59 + this.Method.GetHashCode();
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
