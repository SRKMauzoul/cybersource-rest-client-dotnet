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
    /// Ptsv2paymentsOrderInformationAmountDetailsTaxDetails
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsOrderInformationAmountDetailsTaxDetails :  IEquatable<Ptsv2paymentsOrderInformationAmountDetailsTaxDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsOrderInformationAmountDetailsTaxDetails" /> class.
        /// </summary>
        /// <param name="Type">Indicates the type of tax data for the _taxDetails_ object.  Possible values:  - &#x60;alternate&#x60; - &#x60;local&#x60; - &#x60;national&#x60; - &#x60;vat&#x60; - &#x60;other&#x60;  For processor-specific details, see the &#x60;alternate_tax_amount&#x60;, &#x60;local_tax&#x60;, &#x60;national_tax&#x60; or &#x60;vat_tax_amount&#x60; field descriptions in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/) .</param>
        /// <param name="Amount">Indicates the amount of tax based on the &#x60;type&#x60; field as described in the table below:  | type      | type description | |- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -| | &#x60;alternate&#x60; | Total amount of alternate tax for the order. | | &#x60;local&#x60;     | Sales tax for the order. | | &#x60;national&#x60;  | National tax for the order. | | &#x60;vat&#x60;       | Total amount of Value Added Tax (VAT) included in the order. | | &#x60;other&#x60;     | Other tax. |  For processor-specific details, see the &#x60;alternate_tax_amount&#x60;, &#x60;local_tax&#x60;, &#x60;national_tax&#x60;, &#x60;vat_tax_amount&#x60; or &#x60;other_tax#_amount&#x60; field descriptions in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/) .</param>
        /// <param name="Rate">Rate of VAT or other tax for the order.  Example 0.040 (&#x3D;4%)  Valid range: 0.01 to 0.99 (1% to 99%, with only whole percentage values accepted; values with additional decimal places will be truncated)  For processor-specific details, see the &#x60;alternate_tax_amount&#x60;, &#x60;vat_rate&#x60;, &#x60;vat_tax_rate&#x60;, &#x60;local_tax&#x60;, &#x60;national_tax&#x60;, &#x60;vat_tax_amount&#x60; or &#x60;other_tax#_rate&#x60; field descriptions in the [Level II and Level III Processing Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/) .</param>
        /// <param name="Code">Type of tax being applied to the item.  For possible values, see the processor-specific field descriptions in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/):  #### FDC Nashville Global - &#x60;alternate_tax_type_applied&#x60; - &#x60;alternate_tax_type_identifier&#x60;  #### Worldpay VAP - &#x60;alternate_tax_type_identifier&#x60;  #### RBS WorldPay Atlanta - &#x60;tax_type_applied&#x60;  #### TSYS Acquiring Solutions - &#x60;tax_type_applied&#x60; - &#x60;local_tax_indicator&#x60;  #### Chase Paymentech Solutions - &#x60;tax_type_applied&#x60;  #### Elavon Americas - &#x60;local_tax_indicator&#x60;  #### FDC Compass - &#x60;tax_type_applied&#x60;  #### OmniPay Direct - &#x60;local_tax_indicator&#x60; .</param>
        /// <param name="TaxId">Your tax ID number to use for the alternate tax amount. Required if you set alternate tax amount to any value, including zero. You may send this field without sending alternate tax amount.  For processor-specific details, see &#x60;alternate_tax_id&#x60; field description in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/) .</param>
        /// <param name="Applied">Flag that indicates whether the alternate tax amount (&#x60;orderInformation.amountDetails.taxDetails[].amount&#x60;) is included in the request.  Possible values: - &#x60;false&#x60;: alternate tax amount is not included in the request. - &#x60;true&#x60;: alternate tax amount is included in the request.  For processor-specific details, see &#x60;alternate_tax_amount_indicator&#x60; field description in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/) .</param>
        /// <param name="ExemptionCode">Status code for exemption from sales and use tax. This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor.  For possible values and important information for using this field, see _Appendix B, \&quot;Exemption Status Values_ and _Offer-Level Tax Fields_ in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/) .</param>
        public Ptsv2paymentsOrderInformationAmountDetailsTaxDetails(string Type = default(string), string Amount = default(string), string Rate = default(string), string Code = default(string), string TaxId = default(string), bool? Applied = default(bool?), string ExemptionCode = default(string))
        {
            this.Type = Type;
            this.Amount = Amount;
            this.Rate = Rate;
            this.Code = Code;
            this.TaxId = TaxId;
            this.Applied = Applied;
            this.ExemptionCode = ExemptionCode;
        }
        
        /// <summary>
        /// Indicates the type of tax data for the _taxDetails_ object.  Possible values:  - &#x60;alternate&#x60; - &#x60;local&#x60; - &#x60;national&#x60; - &#x60;vat&#x60; - &#x60;other&#x60;  For processor-specific details, see the &#x60;alternate_tax_amount&#x60;, &#x60;local_tax&#x60;, &#x60;national_tax&#x60; or &#x60;vat_tax_amount&#x60; field descriptions in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/) 
        /// </summary>
        /// <value>Indicates the type of tax data for the _taxDetails_ object.  Possible values:  - &#x60;alternate&#x60; - &#x60;local&#x60; - &#x60;national&#x60; - &#x60;vat&#x60; - &#x60;other&#x60;  For processor-specific details, see the &#x60;alternate_tax_amount&#x60;, &#x60;local_tax&#x60;, &#x60;national_tax&#x60; or &#x60;vat_tax_amount&#x60; field descriptions in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/) </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Indicates the amount of tax based on the &#x60;type&#x60; field as described in the table below:  | type      | type description | |- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -| | &#x60;alternate&#x60; | Total amount of alternate tax for the order. | | &#x60;local&#x60;     | Sales tax for the order. | | &#x60;national&#x60;  | National tax for the order. | | &#x60;vat&#x60;       | Total amount of Value Added Tax (VAT) included in the order. | | &#x60;other&#x60;     | Other tax. |  For processor-specific details, see the &#x60;alternate_tax_amount&#x60;, &#x60;local_tax&#x60;, &#x60;national_tax&#x60;, &#x60;vat_tax_amount&#x60; or &#x60;other_tax#_amount&#x60; field descriptions in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/) 
        /// </summary>
        /// <value>Indicates the amount of tax based on the &#x60;type&#x60; field as described in the table below:  | type      | type description | |- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -| | &#x60;alternate&#x60; | Total amount of alternate tax for the order. | | &#x60;local&#x60;     | Sales tax for the order. | | &#x60;national&#x60;  | National tax for the order. | | &#x60;vat&#x60;       | Total amount of Value Added Tax (VAT) included in the order. | | &#x60;other&#x60;     | Other tax. |  For processor-specific details, see the &#x60;alternate_tax_amount&#x60;, &#x60;local_tax&#x60;, &#x60;national_tax&#x60;, &#x60;vat_tax_amount&#x60; or &#x60;other_tax#_amount&#x60; field descriptions in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/) </value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Rate of VAT or other tax for the order.  Example 0.040 (&#x3D;4%)  Valid range: 0.01 to 0.99 (1% to 99%, with only whole percentage values accepted; values with additional decimal places will be truncated)  For processor-specific details, see the &#x60;alternate_tax_amount&#x60;, &#x60;vat_rate&#x60;, &#x60;vat_tax_rate&#x60;, &#x60;local_tax&#x60;, &#x60;national_tax&#x60;, &#x60;vat_tax_amount&#x60; or &#x60;other_tax#_rate&#x60; field descriptions in the [Level II and Level III Processing Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/) 
        /// </summary>
        /// <value>Rate of VAT or other tax for the order.  Example 0.040 (&#x3D;4%)  Valid range: 0.01 to 0.99 (1% to 99%, with only whole percentage values accepted; values with additional decimal places will be truncated)  For processor-specific details, see the &#x60;alternate_tax_amount&#x60;, &#x60;vat_rate&#x60;, &#x60;vat_tax_rate&#x60;, &#x60;local_tax&#x60;, &#x60;national_tax&#x60;, &#x60;vat_tax_amount&#x60; or &#x60;other_tax#_rate&#x60; field descriptions in the [Level II and Level III Processing Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/) </value>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public string Rate { get; set; }

        /// <summary>
        /// Type of tax being applied to the item.  For possible values, see the processor-specific field descriptions in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/):  #### FDC Nashville Global - &#x60;alternate_tax_type_applied&#x60; - &#x60;alternate_tax_type_identifier&#x60;  #### Worldpay VAP - &#x60;alternate_tax_type_identifier&#x60;  #### RBS WorldPay Atlanta - &#x60;tax_type_applied&#x60;  #### TSYS Acquiring Solutions - &#x60;tax_type_applied&#x60; - &#x60;local_tax_indicator&#x60;  #### Chase Paymentech Solutions - &#x60;tax_type_applied&#x60;  #### Elavon Americas - &#x60;local_tax_indicator&#x60;  #### FDC Compass - &#x60;tax_type_applied&#x60;  #### OmniPay Direct - &#x60;local_tax_indicator&#x60; 
        /// </summary>
        /// <value>Type of tax being applied to the item.  For possible values, see the processor-specific field descriptions in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/):  #### FDC Nashville Global - &#x60;alternate_tax_type_applied&#x60; - &#x60;alternate_tax_type_identifier&#x60;  #### Worldpay VAP - &#x60;alternate_tax_type_identifier&#x60;  #### RBS WorldPay Atlanta - &#x60;tax_type_applied&#x60;  #### TSYS Acquiring Solutions - &#x60;tax_type_applied&#x60; - &#x60;local_tax_indicator&#x60;  #### Chase Paymentech Solutions - &#x60;tax_type_applied&#x60;  #### Elavon Americas - &#x60;local_tax_indicator&#x60;  #### FDC Compass - &#x60;tax_type_applied&#x60;  #### OmniPay Direct - &#x60;local_tax_indicator&#x60; </value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Your tax ID number to use for the alternate tax amount. Required if you set alternate tax amount to any value, including zero. You may send this field without sending alternate tax amount.  For processor-specific details, see &#x60;alternate_tax_id&#x60; field description in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/) 
        /// </summary>
        /// <value>Your tax ID number to use for the alternate tax amount. Required if you set alternate tax amount to any value, including zero. You may send this field without sending alternate tax amount.  For processor-specific details, see &#x60;alternate_tax_id&#x60; field description in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/) </value>
        [DataMember(Name="taxId", EmitDefaultValue=false)]
        public string TaxId { get; set; }

        /// <summary>
        /// Flag that indicates whether the alternate tax amount (&#x60;orderInformation.amountDetails.taxDetails[].amount&#x60;) is included in the request.  Possible values: - &#x60;false&#x60;: alternate tax amount is not included in the request. - &#x60;true&#x60;: alternate tax amount is included in the request.  For processor-specific details, see &#x60;alternate_tax_amount_indicator&#x60; field description in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/) 
        /// </summary>
        /// <value>Flag that indicates whether the alternate tax amount (&#x60;orderInformation.amountDetails.taxDetails[].amount&#x60;) is included in the request.  Possible values: - &#x60;false&#x60;: alternate tax amount is not included in the request. - &#x60;true&#x60;: alternate tax amount is included in the request.  For processor-specific details, see &#x60;alternate_tax_amount_indicator&#x60; field description in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/) </value>
        [DataMember(Name="applied", EmitDefaultValue=false)]
        public bool? Applied { get; set; }

        /// <summary>
        /// Status code for exemption from sales and use tax. This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor.  For possible values and important information for using this field, see _Appendix B, \&quot;Exemption Status Values_ and _Offer-Level Tax Fields_ in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/) 
        /// </summary>
        /// <value>Status code for exemption from sales and use tax. This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor.  For possible values and important information for using this field, see _Appendix B, \&quot;Exemption Status Values_ and _Offer-Level Tax Fields_ in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/) </value>
        [DataMember(Name="exemptionCode", EmitDefaultValue=false)]
        public string ExemptionCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsOrderInformationAmountDetailsTaxDetails {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
            sb.Append("  Applied: ").Append(Applied).Append("\n");
            sb.Append("  ExemptionCode: ").Append(ExemptionCode).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsOrderInformationAmountDetailsTaxDetails);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsOrderInformationAmountDetailsTaxDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsOrderInformationAmountDetailsTaxDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsOrderInformationAmountDetailsTaxDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Rate == other.Rate ||
                    this.Rate != null &&
                    this.Rate.Equals(other.Rate)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.TaxId == other.TaxId ||
                    this.TaxId != null &&
                    this.TaxId.Equals(other.TaxId)
                ) && 
                (
                    this.Applied == other.Applied ||
                    this.Applied != null &&
                    this.Applied.Equals(other.Applied)
                ) && 
                (
                    this.ExemptionCode == other.ExemptionCode ||
                    this.ExemptionCode != null &&
                    this.ExemptionCode.Equals(other.ExemptionCode)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Rate != null)
                    hash = hash * 59 + this.Rate.GetHashCode();
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.TaxId != null)
                    hash = hash * 59 + this.TaxId.GetHashCode();
                if (this.Applied != null)
                    hash = hash * 59 + this.Applied.GetHashCode();
                if (this.ExemptionCode != null)
                    hash = hash * 59 + this.ExemptionCode.GetHashCode();
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
            // Amount (string) maxLength
            if(this.Amount != null && this.Amount.Length >= 13)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, length must be less than or equal to 13.", new [] { "Amount" });
            }

            // Rate (string) maxLength
            if(this.Rate != null && this.Rate.Length >= 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Rate, length must be less than or equal to 6.", new [] { "Rate" });
            }

            // Code (string) maxLength
            if(this.Code != null && this.Code.Length >= 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than or equal to 4.", new [] { "Code" });
            }

            // TaxId (string) maxLength
            if(this.TaxId != null && this.TaxId.Length >= 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaxId, length must be less than or equal to 15.", new [] { "TaxId" });
            }

            // ExemptionCode (string) maxLength
            if(this.ExemptionCode != null && this.ExemptionCode.Length >= 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExemptionCode, length must be less than or equal to 1.", new [] { "ExemptionCode" });
            }

            yield break;
        }
    }

}
