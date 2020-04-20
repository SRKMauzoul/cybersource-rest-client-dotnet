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
    /// TssV2TransactionsGet200ResponseOrderInformationInvoiceDetails
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponseOrderInformationInvoiceDetails :  IEquatable<TssV2TransactionsGet200ResponseOrderInformationInvoiceDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponseOrderInformationInvoiceDetails" /> class.
        /// </summary>
        /// <param name="SalesSlipNumber">Transaction identifier that CyberSource generates. You have the option of printing the sales slip number on the receipt. This field is supported only on Cybersource through Visanet and JCN gateway. .</param>
        public TssV2TransactionsGet200ResponseOrderInformationInvoiceDetails(int? SalesSlipNumber = default(int?))
        {
            this.SalesSlipNumber = SalesSlipNumber;
        }
        
        /// <summary>
        /// Transaction identifier that CyberSource generates. You have the option of printing the sales slip number on the receipt. This field is supported only on Cybersource through Visanet and JCN gateway. 
        /// </summary>
        /// <value>Transaction identifier that CyberSource generates. You have the option of printing the sales slip number on the receipt. This field is supported only on Cybersource through Visanet and JCN gateway. </value>
        [DataMember(Name="salesSlipNumber", EmitDefaultValue=false)]
        public int? SalesSlipNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponseOrderInformationInvoiceDetails {\n");
            sb.Append("  SalesSlipNumber: ").Append(SalesSlipNumber).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponseOrderInformationInvoiceDetails);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponseOrderInformationInvoiceDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponseOrderInformationInvoiceDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponseOrderInformationInvoiceDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SalesSlipNumber == other.SalesSlipNumber ||
                    this.SalesSlipNumber != null &&
                    this.SalesSlipNumber.Equals(other.SalesSlipNumber)
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
                if (this.SalesSlipNumber != null)
                    hash = hash * 59 + this.SalesSlipNumber.GetHashCode();
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
            // SalesSlipNumber (int?) maximum
            if(this.SalesSlipNumber >= (int?)99999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SalesSlipNumber, must be a value less than or equal to 99999.", new [] { "SalesSlipNumber" });
            }

            yield break;
        }
    }

}
