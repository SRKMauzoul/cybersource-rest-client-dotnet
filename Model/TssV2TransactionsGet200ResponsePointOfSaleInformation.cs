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
        /// <param name="EntryMode">Method of entering credit card information into the POS terminal. Possible values:   - &#x60;contact&#x60;: Read from direct contact with chip card.  - &#x60;contactless&#x60;: Read from a contactless interface using chip data.  - &#x60;keyed&#x60;: Manually keyed into POS terminal.  - &#x60;msd&#x60;: Read from a contactless interface using magnetic stripe data (MSD).  - &#x60;swiped&#x60;: Read from credit card magnetic stripe.  The contact, contactless, and msd values are supported only for EMV transactions.  For details, see the &#x60;pos_entry_mode&#x60; field description in [Card-Present Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/) .</param>
        /// <param name="TerminalCapability">POS terminal’s capability. Possible values:   - &#x60;1&#x60;: Terminal has a magnetic stripe reader only.  - &#x60;2&#x60;: Terminal has a magnetic stripe reader and manual entry capability.  - &#x60;3&#x60;: Terminal has manual entry capability only.  - &#x60;4&#x60;: Terminal can read chip cards.  - &#x60;5&#x60;: Terminal can read contactless chip cards.  The values of 4 and 5 are supported only for EMV transactions. * Applicable only for CTV for Payouts.  For processor-specific details, see the &#x60;terminal_capability&#x60; field description in [Card-Present Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/) .</param>
        /// <param name="Emv">Emv.</param>
        public TssV2TransactionsGet200ResponsePointOfSaleInformation(string EntryMode = default(string), int? TerminalCapability = default(int?), Ptsv2paymentsidreversalsPointOfSaleInformationEmv Emv = default(Ptsv2paymentsidreversalsPointOfSaleInformationEmv))
        {
            this.EntryMode = EntryMode;
            this.TerminalCapability = TerminalCapability;
            this.Emv = Emv;
        }
        
        /// <summary>
        /// Method of entering credit card information into the POS terminal. Possible values:   - &#x60;contact&#x60;: Read from direct contact with chip card.  - &#x60;contactless&#x60;: Read from a contactless interface using chip data.  - &#x60;keyed&#x60;: Manually keyed into POS terminal.  - &#x60;msd&#x60;: Read from a contactless interface using magnetic stripe data (MSD).  - &#x60;swiped&#x60;: Read from credit card magnetic stripe.  The contact, contactless, and msd values are supported only for EMV transactions.  For details, see the &#x60;pos_entry_mode&#x60; field description in [Card-Present Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/) 
        /// </summary>
        /// <value>Method of entering credit card information into the POS terminal. Possible values:   - &#x60;contact&#x60;: Read from direct contact with chip card.  - &#x60;contactless&#x60;: Read from a contactless interface using chip data.  - &#x60;keyed&#x60;: Manually keyed into POS terminal.  - &#x60;msd&#x60;: Read from a contactless interface using magnetic stripe data (MSD).  - &#x60;swiped&#x60;: Read from credit card magnetic stripe.  The contact, contactless, and msd values are supported only for EMV transactions.  For details, see the &#x60;pos_entry_mode&#x60; field description in [Card-Present Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/) </value>
        [DataMember(Name="entryMode", EmitDefaultValue=false)]
        public string EntryMode { get; set; }

        /// <summary>
        /// POS terminal’s capability. Possible values:   - &#x60;1&#x60;: Terminal has a magnetic stripe reader only.  - &#x60;2&#x60;: Terminal has a magnetic stripe reader and manual entry capability.  - &#x60;3&#x60;: Terminal has manual entry capability only.  - &#x60;4&#x60;: Terminal can read chip cards.  - &#x60;5&#x60;: Terminal can read contactless chip cards.  The values of 4 and 5 are supported only for EMV transactions. * Applicable only for CTV for Payouts.  For processor-specific details, see the &#x60;terminal_capability&#x60; field description in [Card-Present Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/) 
        /// </summary>
        /// <value>POS terminal’s capability. Possible values:   - &#x60;1&#x60;: Terminal has a magnetic stripe reader only.  - &#x60;2&#x60;: Terminal has a magnetic stripe reader and manual entry capability.  - &#x60;3&#x60;: Terminal has manual entry capability only.  - &#x60;4&#x60;: Terminal can read chip cards.  - &#x60;5&#x60;: Terminal can read contactless chip cards.  The values of 4 and 5 are supported only for EMV transactions. * Applicable only for CTV for Payouts.  For processor-specific details, see the &#x60;terminal_capability&#x60; field description in [Card-Present Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/) </value>
        [DataMember(Name="terminalCapability", EmitDefaultValue=false)]
        public int? TerminalCapability { get; set; }

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
            sb.Append("  EntryMode: ").Append(EntryMode).Append("\n");
            sb.Append("  TerminalCapability: ").Append(TerminalCapability).Append("\n");
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
                if (this.EntryMode != null)
                    hash = hash * 59 + this.EntryMode.GetHashCode();
                if (this.TerminalCapability != null)
                    hash = hash * 59 + this.TerminalCapability.GetHashCode();
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
            // EntryMode (string) maxLength
            if(this.EntryMode != null && this.EntryMode.Length >= 11)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EntryMode, length must be less than or equal to 11.", new [] { "EntryMode" });
            }

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
