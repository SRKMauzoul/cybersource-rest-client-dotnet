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
    /// TssV2TransactionsGet200ResponsePointOfSaleInformation
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponsePointOfSaleInformation :  IEquatable<TssV2TransactionsGet200ResponsePointOfSaleInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponsePointOfSaleInformation" /> class.
        /// </summary>
        /// <param name="TerminalId">Identifier for the terminal at your retail location. You can define this value yourself, but consult the processor for requirements.  #### CyberSource through VisaNet A list of all possible values is stored in your CyberSource account. If terminal ID validation is enabled for your CyberSource account, the value you send for this field is validated against the list each time you include the field in a request. To enable or disable terminal ID validation, contact CyberSource Customer Support.  When you do not include this field in a request, CyberSource uses the default value that is defined in your CyberSource account.  #### FDC Nashville Global To have your account configured to support this field, contact CyberSource Customer Support. This value must be a value that FDC Nashville Global issued to you.  #### For Payouts This field is applicable for CyberSource through VisaNet.  #### GPX Identifier for the terminal at your retail location. A list of all possible values is stored in your account. If terminal ID validation is enabled for your account, the value you send for this field is validated against the list each time you include the field in a request. To enable or disable terminal ID validation, contact customer support.  When you do not include this field in a request, the default value that is defined in your account is used.  Optional for authorizations.  #### Used by **Authorization** Optional for the following processors. When you do not include this field in a request, the default value that is defined in your account is used.   - American Express Direct   - Credit Mutuel-CIC   - FDC Nashville Global   - SIX - Chase Paymentech Solutions: Optional field. If you include this field in your request, you must also include &#x60;pointOfSaleInformation.catLevel&#x60;. - FDMS Nashville: The default value that is defined in your account is used. - GPX - OmniPay Direct: Optional field.  For the following processors, this field is not used. - GPN - JCN Gateway - RBS WorldPay Atlanta - TSYS Acquiring Solutions - Worldpay VAP  #### Card Present reply Terminal identifier assigned by the acquirer. This value must be printed on the receipt. .</param>
        /// <param name="EntryMode">Method of entering payment card information into the POS terminal. Possible values:   - &#x60;contact&#x60;: Read from direct contact with chip card.  - &#x60;contactless&#x60;: Read from a contactless interface using chip data.  - &#x60;keyed&#x60;: Manually keyed into POS terminal. This value is not supported on OmniPay Direct.  - &#x60;msd&#x60;: Read from a contactless interface using magnetic stripe data (MSD). This value is not supported on OmniPay Direct.  - &#x60;swiped&#x60;: Read from credit card magnetic stripe.  The &#x60;contact&#x60;, &#x60;contactless&#x60;, and &#x60;msd&#x60; values are supported only for EMV transactions.  #### Used by **Authorization** Required field.  #### Card Present Card present information about EMV applies only to credit card processing and PIN debit processing. All other card present information applies only to credit card processing.  #### PIN debit Required for a PIN debit purchase and a PIN debit credit request. .</param>
        /// <param name="TerminalCapability">POS terminal&#39;s capability. Possible values:   - &#x60;1&#x60;: Terminal has a magnetic stripe reader only.  - &#x60;2&#x60;: Terminal has a magnetic stripe reader and manual entry capability.  - &#x60;3&#x60;: Terminal has manual entry capability only.  - &#x60;4&#x60;: Terminal can read chip cards.  - &#x60;5&#x60;: Terminal can read contactless chip cards; cannot use contact to read chip cards.  For an EMV transaction, the value of this field must be &#x60;4&#x60; or &#x60;5&#x60;.  #### PIN debit Required for PIN debit purchase and PIN debit credit request.  #### Used by **Authorization** Required for the following processors: - American Express Direct - Chase Paymentech Solutions - Credit Mutuel-CIC - FDC Nashville Global - FDMS Nashville - OmniPay Direct - SIX - Worldpay VAP  Optional for the following processors: - CyberSource through VisaNet - GPN - GPX - JCN Gateway - RBS WorldPay Atlanta - TSYS Acquiring Solutions .</param>
        /// <param name="CardholderVerificationMethodUsed">Method that was used to verify the cardholder&#39;s identity. Possible values:    - &#x60;0&#x60;: No verification   - &#x60;1&#x60;: Signature   - &#x60;2&#x60;: PIN   - &#x60;3&#x60;: Cardholder device CVM .</param>
        /// <param name="Emv">Emv.</param>
        public TssV2TransactionsGet200ResponsePointOfSaleInformation(string TerminalId = default(string), string EntryMode = default(string), int? TerminalCapability = default(int?), int? CardholderVerificationMethodUsed = default(int?), Ptsv2paymentsidreversalsPointOfSaleInformationEmv Emv = default(Ptsv2paymentsidreversalsPointOfSaleInformationEmv))
        {
            this.TerminalId = TerminalId;
            this.EntryMode = EntryMode;
            this.TerminalCapability = TerminalCapability;
            this.CardholderVerificationMethodUsed = CardholderVerificationMethodUsed;
            this.Emv = Emv;
        }
        
        /// <summary>
        /// Identifier for the terminal at your retail location. You can define this value yourself, but consult the processor for requirements.  #### CyberSource through VisaNet A list of all possible values is stored in your CyberSource account. If terminal ID validation is enabled for your CyberSource account, the value you send for this field is validated against the list each time you include the field in a request. To enable or disable terminal ID validation, contact CyberSource Customer Support.  When you do not include this field in a request, CyberSource uses the default value that is defined in your CyberSource account.  #### FDC Nashville Global To have your account configured to support this field, contact CyberSource Customer Support. This value must be a value that FDC Nashville Global issued to you.  #### For Payouts This field is applicable for CyberSource through VisaNet.  #### GPX Identifier for the terminal at your retail location. A list of all possible values is stored in your account. If terminal ID validation is enabled for your account, the value you send for this field is validated against the list each time you include the field in a request. To enable or disable terminal ID validation, contact customer support.  When you do not include this field in a request, the default value that is defined in your account is used.  Optional for authorizations.  #### Used by **Authorization** Optional for the following processors. When you do not include this field in a request, the default value that is defined in your account is used.   - American Express Direct   - Credit Mutuel-CIC   - FDC Nashville Global   - SIX - Chase Paymentech Solutions: Optional field. If you include this field in your request, you must also include &#x60;pointOfSaleInformation.catLevel&#x60;. - FDMS Nashville: The default value that is defined in your account is used. - GPX - OmniPay Direct: Optional field.  For the following processors, this field is not used. - GPN - JCN Gateway - RBS WorldPay Atlanta - TSYS Acquiring Solutions - Worldpay VAP  #### Card Present reply Terminal identifier assigned by the acquirer. This value must be printed on the receipt. 
        /// </summary>
        /// <value>Identifier for the terminal at your retail location. You can define this value yourself, but consult the processor for requirements.  #### CyberSource through VisaNet A list of all possible values is stored in your CyberSource account. If terminal ID validation is enabled for your CyberSource account, the value you send for this field is validated against the list each time you include the field in a request. To enable or disable terminal ID validation, contact CyberSource Customer Support.  When you do not include this field in a request, CyberSource uses the default value that is defined in your CyberSource account.  #### FDC Nashville Global To have your account configured to support this field, contact CyberSource Customer Support. This value must be a value that FDC Nashville Global issued to you.  #### For Payouts This field is applicable for CyberSource through VisaNet.  #### GPX Identifier for the terminal at your retail location. A list of all possible values is stored in your account. If terminal ID validation is enabled for your account, the value you send for this field is validated against the list each time you include the field in a request. To enable or disable terminal ID validation, contact customer support.  When you do not include this field in a request, the default value that is defined in your account is used.  Optional for authorizations.  #### Used by **Authorization** Optional for the following processors. When you do not include this field in a request, the default value that is defined in your account is used.   - American Express Direct   - Credit Mutuel-CIC   - FDC Nashville Global   - SIX - Chase Paymentech Solutions: Optional field. If you include this field in your request, you must also include &#x60;pointOfSaleInformation.catLevel&#x60;. - FDMS Nashville: The default value that is defined in your account is used. - GPX - OmniPay Direct: Optional field.  For the following processors, this field is not used. - GPN - JCN Gateway - RBS WorldPay Atlanta - TSYS Acquiring Solutions - Worldpay VAP  #### Card Present reply Terminal identifier assigned by the acquirer. This value must be printed on the receipt. </value>
        [DataMember(Name="terminalId", EmitDefaultValue=false)]
        public string TerminalId { get; set; }

        /// <summary>
        /// Method of entering payment card information into the POS terminal. Possible values:   - &#x60;contact&#x60;: Read from direct contact with chip card.  - &#x60;contactless&#x60;: Read from a contactless interface using chip data.  - &#x60;keyed&#x60;: Manually keyed into POS terminal. This value is not supported on OmniPay Direct.  - &#x60;msd&#x60;: Read from a contactless interface using magnetic stripe data (MSD). This value is not supported on OmniPay Direct.  - &#x60;swiped&#x60;: Read from credit card magnetic stripe.  The &#x60;contact&#x60;, &#x60;contactless&#x60;, and &#x60;msd&#x60; values are supported only for EMV transactions.  #### Used by **Authorization** Required field.  #### Card Present Card present information about EMV applies only to credit card processing and PIN debit processing. All other card present information applies only to credit card processing.  #### PIN debit Required for a PIN debit purchase and a PIN debit credit request. 
        /// </summary>
        /// <value>Method of entering payment card information into the POS terminal. Possible values:   - &#x60;contact&#x60;: Read from direct contact with chip card.  - &#x60;contactless&#x60;: Read from a contactless interface using chip data.  - &#x60;keyed&#x60;: Manually keyed into POS terminal. This value is not supported on OmniPay Direct.  - &#x60;msd&#x60;: Read from a contactless interface using magnetic stripe data (MSD). This value is not supported on OmniPay Direct.  - &#x60;swiped&#x60;: Read from credit card magnetic stripe.  The &#x60;contact&#x60;, &#x60;contactless&#x60;, and &#x60;msd&#x60; values are supported only for EMV transactions.  #### Used by **Authorization** Required field.  #### Card Present Card present information about EMV applies only to credit card processing and PIN debit processing. All other card present information applies only to credit card processing.  #### PIN debit Required for a PIN debit purchase and a PIN debit credit request. </value>
        [DataMember(Name="entryMode", EmitDefaultValue=false)]
        public string EntryMode { get; set; }

        /// <summary>
        /// POS terminal&#39;s capability. Possible values:   - &#x60;1&#x60;: Terminal has a magnetic stripe reader only.  - &#x60;2&#x60;: Terminal has a magnetic stripe reader and manual entry capability.  - &#x60;3&#x60;: Terminal has manual entry capability only.  - &#x60;4&#x60;: Terminal can read chip cards.  - &#x60;5&#x60;: Terminal can read contactless chip cards; cannot use contact to read chip cards.  For an EMV transaction, the value of this field must be &#x60;4&#x60; or &#x60;5&#x60;.  #### PIN debit Required for PIN debit purchase and PIN debit credit request.  #### Used by **Authorization** Required for the following processors: - American Express Direct - Chase Paymentech Solutions - Credit Mutuel-CIC - FDC Nashville Global - FDMS Nashville - OmniPay Direct - SIX - Worldpay VAP  Optional for the following processors: - CyberSource through VisaNet - GPN - GPX - JCN Gateway - RBS WorldPay Atlanta - TSYS Acquiring Solutions 
        /// </summary>
        /// <value>POS terminal&#39;s capability. Possible values:   - &#x60;1&#x60;: Terminal has a magnetic stripe reader only.  - &#x60;2&#x60;: Terminal has a magnetic stripe reader and manual entry capability.  - &#x60;3&#x60;: Terminal has manual entry capability only.  - &#x60;4&#x60;: Terminal can read chip cards.  - &#x60;5&#x60;: Terminal can read contactless chip cards; cannot use contact to read chip cards.  For an EMV transaction, the value of this field must be &#x60;4&#x60; or &#x60;5&#x60;.  #### PIN debit Required for PIN debit purchase and PIN debit credit request.  #### Used by **Authorization** Required for the following processors: - American Express Direct - Chase Paymentech Solutions - Credit Mutuel-CIC - FDC Nashville Global - FDMS Nashville - OmniPay Direct - SIX - Worldpay VAP  Optional for the following processors: - CyberSource through VisaNet - GPN - GPX - JCN Gateway - RBS WorldPay Atlanta - TSYS Acquiring Solutions </value>
        [DataMember(Name="terminalCapability", EmitDefaultValue=false)]
        public int? TerminalCapability { get; set; }

        /// <summary>
        /// Method that was used to verify the cardholder&#39;s identity. Possible values:    - &#x60;0&#x60;: No verification   - &#x60;1&#x60;: Signature   - &#x60;2&#x60;: PIN   - &#x60;3&#x60;: Cardholder device CVM 
        /// </summary>
        /// <value>Method that was used to verify the cardholder&#39;s identity. Possible values:    - &#x60;0&#x60;: No verification   - &#x60;1&#x60;: Signature   - &#x60;2&#x60;: PIN   - &#x60;3&#x60;: Cardholder device CVM </value>
        [DataMember(Name="cardholderVerificationMethodUsed", EmitDefaultValue=false)]
        public int? CardholderVerificationMethodUsed { get; set; }

        /// <summary>
        /// Gets or Sets Emv
        /// </summary>
        [DataMember(Name="emv", EmitDefaultValue=false)]
        public Ptsv2paymentsidreversalsPointOfSaleInformationEmv Emv { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponsePointOfSaleInformation {\n");
            sb.Append("  TerminalId: ").Append(TerminalId).Append("\n");
            sb.Append("  EntryMode: ").Append(EntryMode).Append("\n");
            sb.Append("  TerminalCapability: ").Append(TerminalCapability).Append("\n");
            sb.Append("  CardholderVerificationMethodUsed: ").Append(CardholderVerificationMethodUsed).Append("\n");
            sb.Append("  Emv: ").Append(Emv).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponsePointOfSaleInformation);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponsePointOfSaleInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponsePointOfSaleInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponsePointOfSaleInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TerminalId == other.TerminalId ||
                    this.TerminalId != null &&
                    this.TerminalId.Equals(other.TerminalId)
                ) && 
                (
                    this.EntryMode == other.EntryMode ||
                    this.EntryMode != null &&
                    this.EntryMode.Equals(other.EntryMode)
                ) && 
                (
                    this.TerminalCapability == other.TerminalCapability ||
                    this.TerminalCapability != null &&
                    this.TerminalCapability.Equals(other.TerminalCapability)
                ) && 
                (
                    this.CardholderVerificationMethodUsed == other.CardholderVerificationMethodUsed ||
                    this.CardholderVerificationMethodUsed != null &&
                    this.CardholderVerificationMethodUsed.Equals(other.CardholderVerificationMethodUsed)
                ) && 
                (
                    this.Emv == other.Emv ||
                    this.Emv != null &&
                    this.Emv.Equals(other.Emv)
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
                if (this.TerminalId != null)
                    hash = hash * 59 + this.TerminalId.GetHashCode();
                if (this.EntryMode != null)
                    hash = hash * 59 + this.EntryMode.GetHashCode();
                if (this.TerminalCapability != null)
                    hash = hash * 59 + this.TerminalCapability.GetHashCode();
                if (this.CardholderVerificationMethodUsed != null)
                    hash = hash * 59 + this.CardholderVerificationMethodUsed.GetHashCode();
                if (this.Emv != null)
                    hash = hash * 59 + this.Emv.GetHashCode();
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
            // TerminalCapability (int?) maximum
            if(this.TerminalCapability >= (int?)5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TerminalCapability, must be a value less than or equal to 5.", new [] { "TerminalCapability" });
            }

            // TerminalCapability (int?) minimum
            if(this.TerminalCapability <= (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TerminalCapability, must be a value greater than or equal to 1.", new [] { "TerminalCapability" });
            }

            yield break;
        }
    }

}
