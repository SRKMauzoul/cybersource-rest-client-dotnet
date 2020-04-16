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
    /// Ptsv2paymentsidrefundsMerchantInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsidrefundsMerchantInformation :  IEquatable<Ptsv2paymentsidrefundsMerchantInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsidrefundsMerchantInformation" /> class.
        /// </summary>
        /// <param name="MerchantDescriptor">MerchantDescriptor.</param>
        /// <param name="CategoryCode">The value for this field is a four-digit number that the payment card industry uses to classify merchants into market segments. A payment card company assigned one or more of these values to your business when you started accepting the payment card company’s cards. When you do not include this field in your request, CyberSource uses the value in your CyberSource account.  For processor-specific information, see the &#x60;merchant_category_code&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  #### CyberSource through VisaNet The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP01 TCR4 - Position: 150-153 - Field: Merchant Category Code .</param>
        /// <param name="VatRegistrationNumber">Your government-assigned tax identification number.  For CtV processors, the maximum length is 20.  For other processor-specific information, see the &#x60;merchant_vat_registration_number&#x60; field description in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="CardAcceptorReferenceNumber">Reference number that facilitates card acceptor/corporation communication and record keeping.  For processor-specific information, see the &#x60;card_acceptor_ref_number&#x60; field description in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="TaxId">Your Cadastro Nacional da Pessoa Jurídica (CNPJ) number.  This field is supported only for BNDES transactions on CyberSource through VisaNet.  The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP07 TCR6 - Position: 40-59 - Field: BNDES Reference Field 1  For details, see &#x60;bill_merchant_tax_id&#x60; field description in the [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/) .</param>
        public Ptsv2paymentsidrefundsMerchantInformation(Ptsv2paymentsMerchantInformationMerchantDescriptor MerchantDescriptor = default(Ptsv2paymentsMerchantInformationMerchantDescriptor), int? CategoryCode = default(int?), string VatRegistrationNumber = default(string), string CardAcceptorReferenceNumber = default(string), string TaxId = default(string))
        {
            this.MerchantDescriptor = MerchantDescriptor;
            this.CategoryCode = CategoryCode;
            this.VatRegistrationNumber = VatRegistrationNumber;
            this.CardAcceptorReferenceNumber = CardAcceptorReferenceNumber;
            this.TaxId = TaxId;
        }
        
        /// <summary>
        /// Gets or Sets MerchantDescriptor
        /// </summary>
        [DataMember(Name="merchantDescriptor", EmitDefaultValue=false)]
        public Ptsv2paymentsMerchantInformationMerchantDescriptor MerchantDescriptor { get; set; }

        /// <summary>
        /// The value for this field is a four-digit number that the payment card industry uses to classify merchants into market segments. A payment card company assigned one or more of these values to your business when you started accepting the payment card company’s cards. When you do not include this field in your request, CyberSource uses the value in your CyberSource account.  For processor-specific information, see the &#x60;merchant_category_code&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  #### CyberSource through VisaNet The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP01 TCR4 - Position: 150-153 - Field: Merchant Category Code 
        /// </summary>
        /// <value>The value for this field is a four-digit number that the payment card industry uses to classify merchants into market segments. A payment card company assigned one or more of these values to your business when you started accepting the payment card company’s cards. When you do not include this field in your request, CyberSource uses the value in your CyberSource account.  For processor-specific information, see the &#x60;merchant_category_code&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  #### CyberSource through VisaNet The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP01 TCR4 - Position: 150-153 - Field: Merchant Category Code </value>
        [DataMember(Name="categoryCode", EmitDefaultValue=false)]
        public int? CategoryCode { get; set; }

        /// <summary>
        /// Your government-assigned tax identification number.  For CtV processors, the maximum length is 20.  For other processor-specific information, see the &#x60;merchant_vat_registration_number&#x60; field description in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>Your government-assigned tax identification number.  For CtV processors, the maximum length is 20.  For other processor-specific information, see the &#x60;merchant_vat_registration_number&#x60; field description in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="vatRegistrationNumber", EmitDefaultValue=false)]
        public string VatRegistrationNumber { get; set; }

        /// <summary>
        /// Reference number that facilitates card acceptor/corporation communication and record keeping.  For processor-specific information, see the &#x60;card_acceptor_ref_number&#x60; field description in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>Reference number that facilitates card acceptor/corporation communication and record keeping.  For processor-specific information, see the &#x60;card_acceptor_ref_number&#x60; field description in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="cardAcceptorReferenceNumber", EmitDefaultValue=false)]
        public string CardAcceptorReferenceNumber { get; set; }

        /// <summary>
        /// Your Cadastro Nacional da Pessoa Jurídica (CNPJ) number.  This field is supported only for BNDES transactions on CyberSource through VisaNet.  The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP07 TCR6 - Position: 40-59 - Field: BNDES Reference Field 1  For details, see &#x60;bill_merchant_tax_id&#x60; field description in the [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/) 
        /// </summary>
        /// <value>Your Cadastro Nacional da Pessoa Jurídica (CNPJ) number.  This field is supported only for BNDES transactions on CyberSource through VisaNet.  The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP07 TCR6 - Position: 40-59 - Field: BNDES Reference Field 1  For details, see &#x60;bill_merchant_tax_id&#x60; field description in the [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/) </value>
        [DataMember(Name="taxId", EmitDefaultValue=false)]
        public string TaxId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsidrefundsMerchantInformation {\n");
            sb.Append("  MerchantDescriptor: ").Append(MerchantDescriptor).Append("\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  VatRegistrationNumber: ").Append(VatRegistrationNumber).Append("\n");
            sb.Append("  CardAcceptorReferenceNumber: ").Append(CardAcceptorReferenceNumber).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsidrefundsMerchantInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsidrefundsMerchantInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsidrefundsMerchantInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsidrefundsMerchantInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MerchantDescriptor == other.MerchantDescriptor ||
                    this.MerchantDescriptor != null &&
                    this.MerchantDescriptor.Equals(other.MerchantDescriptor)
                ) && 
                (
                    this.CategoryCode == other.CategoryCode ||
                    this.CategoryCode != null &&
                    this.CategoryCode.Equals(other.CategoryCode)
                ) && 
                (
                    this.VatRegistrationNumber == other.VatRegistrationNumber ||
                    this.VatRegistrationNumber != null &&
                    this.VatRegistrationNumber.Equals(other.VatRegistrationNumber)
                ) && 
                (
                    this.CardAcceptorReferenceNumber == other.CardAcceptorReferenceNumber ||
                    this.CardAcceptorReferenceNumber != null &&
                    this.CardAcceptorReferenceNumber.Equals(other.CardAcceptorReferenceNumber)
                ) && 
                (
                    this.TaxId == other.TaxId ||
                    this.TaxId != null &&
                    this.TaxId.Equals(other.TaxId)
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
                if (this.MerchantDescriptor != null)
                    hash = hash * 59 + this.MerchantDescriptor.GetHashCode();
                if (this.CategoryCode != null)
                    hash = hash * 59 + this.CategoryCode.GetHashCode();
                if (this.VatRegistrationNumber != null)
                    hash = hash * 59 + this.VatRegistrationNumber.GetHashCode();
                if (this.CardAcceptorReferenceNumber != null)
                    hash = hash * 59 + this.CardAcceptorReferenceNumber.GetHashCode();
                if (this.TaxId != null)
                    hash = hash * 59 + this.TaxId.GetHashCode();
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
            // CategoryCode (int?) maximum
            if(this.CategoryCode >= (int?)9999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CategoryCode, must be a value less than or equal to 9999.", new [] { "CategoryCode" });
            }

            // VatRegistrationNumber (string) maxLength
            if(this.VatRegistrationNumber != null && this.VatRegistrationNumber.Length >= 21)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VatRegistrationNumber, length must be less than or equal to 21.", new [] { "VatRegistrationNumber" });
            }

            // CardAcceptorReferenceNumber (string) maxLength
            if(this.CardAcceptorReferenceNumber != null && this.CardAcceptorReferenceNumber.Length >= 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CardAcceptorReferenceNumber, length must be less than or equal to 25.", new [] { "CardAcceptorReferenceNumber" });
            }

            // TaxId (string) maxLength
            if(this.TaxId != null && this.TaxId.Length >= 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaxId, length must be less than or equal to 15.", new [] { "TaxId" });
            }

            yield break;
        }
    }

}
