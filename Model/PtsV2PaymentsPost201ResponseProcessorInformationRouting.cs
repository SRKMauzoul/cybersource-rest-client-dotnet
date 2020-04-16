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
    /// PtsV2PaymentsPost201ResponseProcessorInformationRouting
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponseProcessorInformationRouting :  IEquatable<PtsV2PaymentsPost201ResponseProcessorInformationRouting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponseProcessorInformationRouting" /> class.
        /// </summary>
        /// <param name="Network">Indicates whether the transaction was routed on a credit network, a debit network, or the STAR signature debit network.  Possible values: - &#x60;C&#x60;: Credit network - &#x60;D&#x60;: Debit network (without signature) - &#x60;S&#x60;: STAR signature debit network  This field is supported only on FDC Nashville Global.  For details, see the &#x60;routing_network_type&#x60; field description in [Card-Present Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/) .</param>
        /// <param name="NetworkName">Name of the network on which the transaction was routed.  This field is supported only on FDC Nashville Global.  For details, see the &#x60;routing_network_label&#x60; field description in [Card-Present Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/) .</param>
        /// <param name="CustomerSignatureRequired">Indicates whether you need to obtain the cardholder&#39;s signature.  Possible values: - &#x60;Y&#x60;: You need to obtain the cardholder&#39;s signature. - &#x60;N&#x60;: You do not need to obtain the cardholder&#39;s signature.  This field is supported only on FDC Nashville Global.  For details, see the &#x60;routing_signature_cvm_required&#x60; field description in [Card-Present Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/) .</param>
        public PtsV2PaymentsPost201ResponseProcessorInformationRouting(string Network = default(string), string NetworkName = default(string), string CustomerSignatureRequired = default(string))
        {
            this.Network = Network;
            this.NetworkName = NetworkName;
            this.CustomerSignatureRequired = CustomerSignatureRequired;
        }
        
        /// <summary>
        /// Indicates whether the transaction was routed on a credit network, a debit network, or the STAR signature debit network.  Possible values: - &#x60;C&#x60;: Credit network - &#x60;D&#x60;: Debit network (without signature) - &#x60;S&#x60;: STAR signature debit network  This field is supported only on FDC Nashville Global.  For details, see the &#x60;routing_network_type&#x60; field description in [Card-Present Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/) 
        /// </summary>
        /// <value>Indicates whether the transaction was routed on a credit network, a debit network, or the STAR signature debit network.  Possible values: - &#x60;C&#x60;: Credit network - &#x60;D&#x60;: Debit network (without signature) - &#x60;S&#x60;: STAR signature debit network  This field is supported only on FDC Nashville Global.  For details, see the &#x60;routing_network_type&#x60; field description in [Card-Present Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/) </value>
        [DataMember(Name="network", EmitDefaultValue=false)]
        public string Network { get; set; }

        /// <summary>
        /// Name of the network on which the transaction was routed.  This field is supported only on FDC Nashville Global.  For details, see the &#x60;routing_network_label&#x60; field description in [Card-Present Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/) 
        /// </summary>
        /// <value>Name of the network on which the transaction was routed.  This field is supported only on FDC Nashville Global.  For details, see the &#x60;routing_network_label&#x60; field description in [Card-Present Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/) </value>
        [DataMember(Name="networkName", EmitDefaultValue=false)]
        public string NetworkName { get; set; }

        /// <summary>
        /// Indicates whether you need to obtain the cardholder&#39;s signature.  Possible values: - &#x60;Y&#x60;: You need to obtain the cardholder&#39;s signature. - &#x60;N&#x60;: You do not need to obtain the cardholder&#39;s signature.  This field is supported only on FDC Nashville Global.  For details, see the &#x60;routing_signature_cvm_required&#x60; field description in [Card-Present Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/) 
        /// </summary>
        /// <value>Indicates whether you need to obtain the cardholder&#39;s signature.  Possible values: - &#x60;Y&#x60;: You need to obtain the cardholder&#39;s signature. - &#x60;N&#x60;: You do not need to obtain the cardholder&#39;s signature.  This field is supported only on FDC Nashville Global.  For details, see the &#x60;routing_signature_cvm_required&#x60; field description in [Card-Present Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/) </value>
        [DataMember(Name="customerSignatureRequired", EmitDefaultValue=false)]
        public string CustomerSignatureRequired { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponseProcessorInformationRouting {\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  NetworkName: ").Append(NetworkName).Append("\n");
            sb.Append("  CustomerSignatureRequired: ").Append(CustomerSignatureRequired).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsPost201ResponseProcessorInformationRouting);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponseProcessorInformationRouting instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponseProcessorInformationRouting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponseProcessorInformationRouting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Network == other.Network ||
                    this.Network != null &&
                    this.Network.Equals(other.Network)
                ) && 
                (
                    this.NetworkName == other.NetworkName ||
                    this.NetworkName != null &&
                    this.NetworkName.Equals(other.NetworkName)
                ) && 
                (
                    this.CustomerSignatureRequired == other.CustomerSignatureRequired ||
                    this.CustomerSignatureRequired != null &&
                    this.CustomerSignatureRequired.Equals(other.CustomerSignatureRequired)
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
                if (this.Network != null)
                    hash = hash * 59 + this.Network.GetHashCode();
                if (this.NetworkName != null)
                    hash = hash * 59 + this.NetworkName.GetHashCode();
                if (this.CustomerSignatureRequired != null)
                    hash = hash * 59 + this.CustomerSignatureRequired.GetHashCode();
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
            // Network (string) maxLength
            if(this.Network != null && this.Network.Length >= 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Network, length must be less than or equal to 1.", new [] { "Network" });
            }

            // NetworkName (string) maxLength
            if(this.NetworkName != null && this.NetworkName.Length >= 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NetworkName, length must be less than or equal to 10.", new [] { "NetworkName" });
            }

            // CustomerSignatureRequired (string) maxLength
            if(this.CustomerSignatureRequired != null && this.CustomerSignatureRequired.Length >= 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerSignatureRequired, length must be less than or equal to 1.", new [] { "CustomerSignatureRequired" });
            }

            yield break;
        }
    }

}
