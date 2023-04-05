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
    /// PostCustomerRequest
    /// </summary>
    [DataContract]
    public partial class PostCustomerRequest :  IEquatable<PostCustomerRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomerRequest" /> class.
        /// </summary>
        /// <param name="Links">Links.</param>
        /// <param name="Id">The Id of the Customer Token..</param>
        /// <param name="ObjectInformation">ObjectInformation.</param>
        /// <param name="BuyerInformation">BuyerInformation.</param>
        /// <param name="ClientReferenceInformation">ClientReferenceInformation.</param>
        /// <param name="MerchantDefinedInformation">Object containing the custom data that the merchant defines. .</param>
        /// <param name="DefaultPaymentInstrument">DefaultPaymentInstrument.</param>
        /// <param name="DefaultShippingAddress">DefaultShippingAddress.</param>
        /// <param name="Metadata">Metadata.</param>
        /// <param name="Embedded">Embedded.</param>
        public PostCustomerRequest(Tmsv2customersLinks Links = default(Tmsv2customersLinks), string Id = default(string), Tmsv2customersObjectInformation ObjectInformation = default(Tmsv2customersObjectInformation), Tmsv2customersBuyerInformation BuyerInformation = default(Tmsv2customersBuyerInformation), Tmsv2customersClientReferenceInformation ClientReferenceInformation = default(Tmsv2customersClientReferenceInformation), List<Tmsv2customersMerchantDefinedInformation> MerchantDefinedInformation = default(List<Tmsv2customersMerchantDefinedInformation>), Tmsv2customersDefaultPaymentInstrument DefaultPaymentInstrument = default(Tmsv2customersDefaultPaymentInstrument), Tmsv2customersDefaultShippingAddress DefaultShippingAddress = default(Tmsv2customersDefaultShippingAddress), Tmsv2customersMetadata Metadata = default(Tmsv2customersMetadata), Tmsv2customersEmbedded Embedded = default(Tmsv2customersEmbedded))
        {
            this.Links = Links;
            this.Id = Id;
            this.ObjectInformation = ObjectInformation;
            this.BuyerInformation = BuyerInformation;
            this.ClientReferenceInformation = ClientReferenceInformation;
            this.MerchantDefinedInformation = MerchantDefinedInformation;
            this.DefaultPaymentInstrument = DefaultPaymentInstrument;
            this.DefaultShippingAddress = DefaultShippingAddress;
            this.Metadata = Metadata;
            this.Embedded = Embedded;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public Tmsv2customersLinks Links { get; set; }

        /// <summary>
        /// The Id of the Customer Token.
        /// </summary>
        /// <value>The Id of the Customer Token.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ObjectInformation
        /// </summary>
        [DataMember(Name="objectInformation", EmitDefaultValue=false)]
        public Tmsv2customersObjectInformation ObjectInformation { get; set; }

        /// <summary>
        /// Gets or Sets BuyerInformation
        /// </summary>
        [DataMember(Name="buyerInformation", EmitDefaultValue=false)]
        public Tmsv2customersBuyerInformation BuyerInformation { get; set; }

        /// <summary>
        /// Gets or Sets ClientReferenceInformation
        /// </summary>
        [DataMember(Name="clientReferenceInformation", EmitDefaultValue=false)]
        public Tmsv2customersClientReferenceInformation ClientReferenceInformation { get; set; }

        /// <summary>
        /// Object containing the custom data that the merchant defines. 
        /// </summary>
        /// <value>Object containing the custom data that the merchant defines. </value>
        [DataMember(Name="merchantDefinedInformation", EmitDefaultValue=false)]
        public List<Tmsv2customersMerchantDefinedInformation> MerchantDefinedInformation { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPaymentInstrument
        /// </summary>
        [DataMember(Name="defaultPaymentInstrument", EmitDefaultValue=false)]
        public Tmsv2customersDefaultPaymentInstrument DefaultPaymentInstrument { get; set; }

        /// <summary>
        /// Gets or Sets DefaultShippingAddress
        /// </summary>
        [DataMember(Name="defaultShippingAddress", EmitDefaultValue=false)]
        public Tmsv2customersDefaultShippingAddress DefaultShippingAddress { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Tmsv2customersMetadata Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Embedded
        /// </summary>
        [DataMember(Name="_embedded", EmitDefaultValue=false)]
        public Tmsv2customersEmbedded Embedded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostCustomerRequest {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ObjectInformation: ").Append(ObjectInformation).Append("\n");
            sb.Append("  BuyerInformation: ").Append(BuyerInformation).Append("\n");
            sb.Append("  ClientReferenceInformation: ").Append(ClientReferenceInformation).Append("\n");
            sb.Append("  MerchantDefinedInformation: ").Append(MerchantDefinedInformation).Append("\n");
            sb.Append("  DefaultPaymentInstrument: ").Append(DefaultPaymentInstrument).Append("\n");
            sb.Append("  DefaultShippingAddress: ").Append(DefaultShippingAddress).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Embedded: ").Append(Embedded).Append("\n");
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
            return this.Equals(obj as PostCustomerRequest);
        }

        /// <summary>
        /// Returns true if PostCustomerRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PostCustomerRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostCustomerRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ObjectInformation == other.ObjectInformation ||
                    this.ObjectInformation != null &&
                    this.ObjectInformation.Equals(other.ObjectInformation)
                ) && 
                (
                    this.BuyerInformation == other.BuyerInformation ||
                    this.BuyerInformation != null &&
                    this.BuyerInformation.Equals(other.BuyerInformation)
                ) && 
                (
                    this.ClientReferenceInformation == other.ClientReferenceInformation ||
                    this.ClientReferenceInformation != null &&
                    this.ClientReferenceInformation.Equals(other.ClientReferenceInformation)
                ) && 
                (
                    this.MerchantDefinedInformation == other.MerchantDefinedInformation ||
                    this.MerchantDefinedInformation != null &&
                    this.MerchantDefinedInformation.SequenceEqual(other.MerchantDefinedInformation)
                ) && 
                (
                    this.DefaultPaymentInstrument == other.DefaultPaymentInstrument ||
                    this.DefaultPaymentInstrument != null &&
                    this.DefaultPaymentInstrument.Equals(other.DefaultPaymentInstrument)
                ) && 
                (
                    this.DefaultShippingAddress == other.DefaultShippingAddress ||
                    this.DefaultShippingAddress != null &&
                    this.DefaultShippingAddress.Equals(other.DefaultShippingAddress)
                ) && 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) && 
                (
                    this.Embedded == other.Embedded ||
                    this.Embedded != null &&
                    this.Embedded.Equals(other.Embedded)
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
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.ObjectInformation != null)
                    hash = hash * 59 + this.ObjectInformation.GetHashCode();
                if (this.BuyerInformation != null)
                    hash = hash * 59 + this.BuyerInformation.GetHashCode();
                if (this.ClientReferenceInformation != null)
                    hash = hash * 59 + this.ClientReferenceInformation.GetHashCode();
                if (this.MerchantDefinedInformation != null)
                    hash = hash * 59 + this.MerchantDefinedInformation.GetHashCode();
                if (this.DefaultPaymentInstrument != null)
                    hash = hash * 59 + this.DefaultPaymentInstrument.GetHashCode();
                if (this.DefaultShippingAddress != null)
                    hash = hash * 59 + this.DefaultShippingAddress.GetHashCode();
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                if (this.Embedded != null)
                    hash = hash * 59 + this.Embedded.GetHashCode();
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
