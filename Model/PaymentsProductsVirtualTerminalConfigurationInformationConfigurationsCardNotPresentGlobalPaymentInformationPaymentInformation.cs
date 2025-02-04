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
    /// PaymentsProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentGlobalPaymentInformationPaymentInformation
    /// </summary>
    [DataContract]
    public partial class PaymentsProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentGlobalPaymentInformationPaymentInformation :  IEquatable<PaymentsProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentGlobalPaymentInformationPaymentInformation>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DisplayCardVerificationValue
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DisplayCardVerificationValueEnum
        {
            
            /// <summary>
            /// Enum VISA for "VISA"
            /// </summary>
            [EnumMember(Value = "VISA")]
            VISA,
            
            /// <summary>
            /// Enum MASTERCARD for "MASTER_CARD"
            /// </summary>
            [EnumMember(Value = "MASTER_CARD")]
            MASTERCARD,
            
            /// <summary>
            /// Enum AMEX for "AMEX"
            /// </summary>
            [EnumMember(Value = "AMEX")]
            AMEX,
            
            /// <summary>
            /// Enum DISCOVER for "DISCOVER"
            /// </summary>
            [EnumMember(Value = "DISCOVER")]
            DISCOVER,
            
            /// <summary>
            /// Enum DINERSCLUB for "DINERS_CLUB"
            /// </summary>
            [EnumMember(Value = "DINERS_CLUB")]
            DINERSCLUB,
            
            /// <summary>
            /// Enum CARTEBLANCHE for "CARTE_BLANCHE"
            /// </summary>
            [EnumMember(Value = "CARTE_BLANCHE")]
            CARTEBLANCHE,
            
            /// <summary>
            /// Enum JCB for "JCB"
            /// </summary>
            [EnumMember(Value = "JCB")]
            JCB,
            
            /// <summary>
            /// Enum ENROUTE for "ENROUTE"
            /// </summary>
            [EnumMember(Value = "ENROUTE")]
            ENROUTE,
            
            /// <summary>
            /// Enum JAL for "JAL"
            /// </summary>
            [EnumMember(Value = "JAL")]
            JAL,
            
            /// <summary>
            /// Enum SWITCHSOLO for "SWITCH_SOLO"
            /// </summary>
            [EnumMember(Value = "SWITCH_SOLO")]
            SWITCHSOLO,
            
            /// <summary>
            /// Enum DELTA for "DELTA"
            /// </summary>
            [EnumMember(Value = "DELTA")]
            DELTA,
            
            /// <summary>
            /// Enum VISAELECTRON for "VISA_ELECTRON"
            /// </summary>
            [EnumMember(Value = "VISA_ELECTRON")]
            VISAELECTRON,
            
            /// <summary>
            /// Enum DANKORT for "DANKORT"
            /// </summary>
            [EnumMember(Value = "DANKORT")]
            DANKORT,
            
            /// <summary>
            /// Enum LASER for "LASER"
            /// </summary>
            [EnumMember(Value = "LASER")]
            LASER,
            
            /// <summary>
            /// Enum CARTESBANCAIRES for "CARTE_SBANCAIRES"
            /// </summary>
            [EnumMember(Value = "CARTE_SBANCAIRES")]
            CARTESBANCAIRES,
            
            /// <summary>
            /// Enum CARTASI for "CARTASI"
            /// </summary>
            [EnumMember(Value = "CARTASI")]
            CARTASI,
            
            /// <summary>
            /// Enum MAESTROINTERNATIONAL for "MAESTRO_INTERNATIONAL"
            /// </summary>
            [EnumMember(Value = "MAESTRO_INTERNATIONAL")]
            MAESTROINTERNATIONAL,
            
            /// <summary>
            /// Enum GEMONEYUKCARD for "GE_MONEY_UK_CARD"
            /// </summary>
            [EnumMember(Value = "GE_MONEY_UK_CARD")]
            GEMONEYUKCARD,
            
            /// <summary>
            /// Enum HIPERCARD for "HIPER_CARD"
            /// </summary>
            [EnumMember(Value = "HIPER_CARD")]
            HIPERCARD,
            
            /// <summary>
            /// Enum ELO for "ELO"
            /// </summary>
            [EnumMember(Value = "ELO")]
            ELO
        }


        /// <summary>
        /// Gets or Sets RequireCardVerificationValue
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RequireCardVerificationValueEnum
        {
            
            /// <summary>
            /// Enum VISA for "VISA"
            /// </summary>
            [EnumMember(Value = "VISA")]
            VISA,
            
            /// <summary>
            /// Enum MASTERCARD for "MASTER_CARD"
            /// </summary>
            [EnumMember(Value = "MASTER_CARD")]
            MASTERCARD,
            
            /// <summary>
            /// Enum AMEX for "AMEX"
            /// </summary>
            [EnumMember(Value = "AMEX")]
            AMEX,
            
            /// <summary>
            /// Enum DISCOVER for "DISCOVER"
            /// </summary>
            [EnumMember(Value = "DISCOVER")]
            DISCOVER,
            
            /// <summary>
            /// Enum DINERSCLUB for "DINERS_CLUB"
            /// </summary>
            [EnumMember(Value = "DINERS_CLUB")]
            DINERSCLUB,
            
            /// <summary>
            /// Enum CARTEBLANCHE for "CARTE_BLANCHE"
            /// </summary>
            [EnumMember(Value = "CARTE_BLANCHE")]
            CARTEBLANCHE,
            
            /// <summary>
            /// Enum JCB for "JCB"
            /// </summary>
            [EnumMember(Value = "JCB")]
            JCB,
            
            /// <summary>
            /// Enum ENROUTE for "ENROUTE"
            /// </summary>
            [EnumMember(Value = "ENROUTE")]
            ENROUTE,
            
            /// <summary>
            /// Enum JAL for "JAL"
            /// </summary>
            [EnumMember(Value = "JAL")]
            JAL,
            
            /// <summary>
            /// Enum SWITCHSOLO for "SWITCH_SOLO"
            /// </summary>
            [EnumMember(Value = "SWITCH_SOLO")]
            SWITCHSOLO,
            
            /// <summary>
            /// Enum DELTA for "DELTA"
            /// </summary>
            [EnumMember(Value = "DELTA")]
            DELTA,
            
            /// <summary>
            /// Enum VISAELECTRON for "VISA_ELECTRON"
            /// </summary>
            [EnumMember(Value = "VISA_ELECTRON")]
            VISAELECTRON,
            
            /// <summary>
            /// Enum DANKORT for "DANKORT"
            /// </summary>
            [EnumMember(Value = "DANKORT")]
            DANKORT,
            
            /// <summary>
            /// Enum LASER for "LASER"
            /// </summary>
            [EnumMember(Value = "LASER")]
            LASER,
            
            /// <summary>
            /// Enum CARTESBANCAIRES for "CARTE_SBANCAIRES"
            /// </summary>
            [EnumMember(Value = "CARTE_SBANCAIRES")]
            CARTESBANCAIRES,
            
            /// <summary>
            /// Enum CARTASI for "CARTASI"
            /// </summary>
            [EnumMember(Value = "CARTASI")]
            CARTASI,
            
            /// <summary>
            /// Enum MAESTROINTERNATIONAL for "MAESTRO_INTERNATIONAL"
            /// </summary>
            [EnumMember(Value = "MAESTRO_INTERNATIONAL")]
            MAESTROINTERNATIONAL,
            
            /// <summary>
            /// Enum GEMONEYUKCARD for "GE_MONEY_UK_CARD"
            /// </summary>
            [EnumMember(Value = "GE_MONEY_UK_CARD")]
            GEMONEYUKCARD,
            
            /// <summary>
            /// Enum HIPERCARD for "HIPER_CARD"
            /// </summary>
            [EnumMember(Value = "HIPER_CARD")]
            HIPERCARD,
            
            /// <summary>
            /// Enum ELO for "ELO"
            /// </summary>
            [EnumMember(Value = "ELO")]
            ELO
        }


        /// <summary>
        /// Gets or Sets AcceptedCardTypes
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AcceptedCardTypesEnum
        {
            
            /// <summary>
            /// Enum VISA for "VISA"
            /// </summary>
            [EnumMember(Value = "VISA")]
            VISA,
            
            /// <summary>
            /// Enum MASTERCARD for "MASTER_CARD"
            /// </summary>
            [EnumMember(Value = "MASTER_CARD")]
            MASTERCARD,
            
            /// <summary>
            /// Enum AMEX for "AMEX"
            /// </summary>
            [EnumMember(Value = "AMEX")]
            AMEX,
            
            /// <summary>
            /// Enum DISCOVER for "DISCOVER"
            /// </summary>
            [EnumMember(Value = "DISCOVER")]
            DISCOVER,
            
            /// <summary>
            /// Enum DINERSCLUB for "DINERS_CLUB"
            /// </summary>
            [EnumMember(Value = "DINERS_CLUB")]
            DINERSCLUB,
            
            /// <summary>
            /// Enum CARTEBLANCHE for "CARTE_BLANCHE"
            /// </summary>
            [EnumMember(Value = "CARTE_BLANCHE")]
            CARTEBLANCHE,
            
            /// <summary>
            /// Enum JCB for "JCB"
            /// </summary>
            [EnumMember(Value = "JCB")]
            JCB,
            
            /// <summary>
            /// Enum ENROUTE for "ENROUTE"
            /// </summary>
            [EnumMember(Value = "ENROUTE")]
            ENROUTE,
            
            /// <summary>
            /// Enum JAL for "JAL"
            /// </summary>
            [EnumMember(Value = "JAL")]
            JAL,
            
            /// <summary>
            /// Enum SWITCHSOLO for "SWITCH_SOLO"
            /// </summary>
            [EnumMember(Value = "SWITCH_SOLO")]
            SWITCHSOLO,
            
            /// <summary>
            /// Enum DELTA for "DELTA"
            /// </summary>
            [EnumMember(Value = "DELTA")]
            DELTA,
            
            /// <summary>
            /// Enum VISAELECTRON for "VISA_ELECTRON"
            /// </summary>
            [EnumMember(Value = "VISA_ELECTRON")]
            VISAELECTRON,
            
            /// <summary>
            /// Enum DANKORT for "DANKORT"
            /// </summary>
            [EnumMember(Value = "DANKORT")]
            DANKORT,
            
            /// <summary>
            /// Enum LASER for "LASER"
            /// </summary>
            [EnumMember(Value = "LASER")]
            LASER,
            
            /// <summary>
            /// Enum CARTESBANCAIRES for "CARTE_SBANCAIRES"
            /// </summary>
            [EnumMember(Value = "CARTE_SBANCAIRES")]
            CARTESBANCAIRES,
            
            /// <summary>
            /// Enum CARTASI for "CARTASI"
            /// </summary>
            [EnumMember(Value = "CARTASI")]
            CARTASI,
            
            /// <summary>
            /// Enum MAESTROINTERNATIONAL for "MAESTRO_INTERNATIONAL"
            /// </summary>
            [EnumMember(Value = "MAESTRO_INTERNATIONAL")]
            MAESTROINTERNATIONAL,
            
            /// <summary>
            /// Enum GEMONEYUKCARD for "GE_MONEY_UK_CARD"
            /// </summary>
            [EnumMember(Value = "GE_MONEY_UK_CARD")]
            GEMONEYUKCARD,
            
            /// <summary>
            /// Enum HIPERCARD for "HIPER_CARD"
            /// </summary>
            [EnumMember(Value = "HIPER_CARD")]
            HIPERCARD,
            
            /// <summary>
            /// Enum ELO for "ELO"
            /// </summary>
            [EnumMember(Value = "ELO")]
            ELO
        }

        /// <summary>
        /// Gets or Sets DisplayCardVerificationValue
        /// </summary>
        [DataMember(Name="displayCardVerificationValue", EmitDefaultValue=false)]
        public List<DisplayCardVerificationValueEnum> DisplayCardVerificationValue { get; set; }
        /// <summary>
        /// Gets or Sets RequireCardVerificationValue
        /// </summary>
        [DataMember(Name="requireCardVerificationValue", EmitDefaultValue=false)]
        public List<RequireCardVerificationValueEnum> RequireCardVerificationValue { get; set; }
        /// <summary>
        /// Gets or Sets AcceptedCardTypes
        /// </summary>
        [DataMember(Name="acceptedCardTypes", EmitDefaultValue=false)]
        public List<AcceptedCardTypesEnum> AcceptedCardTypes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentGlobalPaymentInformationPaymentInformation" /> class.
        /// </summary>
        /// <param name="DisplayCardVerificationValue">DisplayCardVerificationValue.</param>
        /// <param name="RequireCardVerificationValue">RequireCardVerificationValue.</param>
        /// <param name="AcceptedCardTypes">AcceptedCardTypes.</param>
        /// <param name="DisplayCreditCards">DisplayCreditCards.</param>
        /// <param name="DisplayEchecks">DisplayEchecks.</param>
        /// <param name="DisplayDebtIndicator">DisplayDebtIndicator.</param>
        /// <param name="DisplayBillPayment">DisplayBillPayment.</param>
        /// <param name="EnableEchecks">EnableEchecks.</param>
        /// <param name="DisplayIgnoreECheckAvsCheckbox">DisplayIgnoreECheckAvsCheckbox.</param>
        /// <param name="FirstNameRequired">FirstNameRequired.</param>
        /// <param name="LastNameRequired">LastNameRequired.</param>
        /// <param name="DisplayFirstName">DisplayFirstName.</param>
        /// <param name="DisplayLastName">DisplayLastName.</param>
        public PaymentsProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentGlobalPaymentInformationPaymentInformation(List<DisplayCardVerificationValueEnum> DisplayCardVerificationValue = default(List<DisplayCardVerificationValueEnum>), List<RequireCardVerificationValueEnum> RequireCardVerificationValue = default(List<RequireCardVerificationValueEnum>), List<AcceptedCardTypesEnum> AcceptedCardTypes = default(List<AcceptedCardTypesEnum>), bool? DisplayCreditCards = default(bool?), bool? DisplayEchecks = default(bool?), bool? DisplayDebtIndicator = default(bool?), bool? DisplayBillPayment = default(bool?), bool? EnableEchecks = default(bool?), bool? DisplayIgnoreECheckAvsCheckbox = default(bool?), bool? FirstNameRequired = default(bool?), bool? LastNameRequired = default(bool?), bool? DisplayFirstName = default(bool?), bool? DisplayLastName = default(bool?))
        {
            this.DisplayCardVerificationValue = DisplayCardVerificationValue;
            this.RequireCardVerificationValue = RequireCardVerificationValue;
            this.AcceptedCardTypes = AcceptedCardTypes;
            this.DisplayCreditCards = DisplayCreditCards;
            this.DisplayEchecks = DisplayEchecks;
            this.DisplayDebtIndicator = DisplayDebtIndicator;
            this.DisplayBillPayment = DisplayBillPayment;
            this.EnableEchecks = EnableEchecks;
            this.DisplayIgnoreECheckAvsCheckbox = DisplayIgnoreECheckAvsCheckbox;
            this.FirstNameRequired = FirstNameRequired;
            this.LastNameRequired = LastNameRequired;
            this.DisplayFirstName = DisplayFirstName;
            this.DisplayLastName = DisplayLastName;
        }
        



        /// <summary>
        /// Gets or Sets DisplayCreditCards
        /// </summary>
        [DataMember(Name="displayCreditCards", EmitDefaultValue=false)]
        public bool? DisplayCreditCards { get; set; }

        /// <summary>
        /// Gets or Sets DisplayEchecks
        /// </summary>
        [DataMember(Name="displayEchecks", EmitDefaultValue=false)]
        public bool? DisplayEchecks { get; set; }

        /// <summary>
        /// Gets or Sets DisplayDebtIndicator
        /// </summary>
        [DataMember(Name="displayDebtIndicator", EmitDefaultValue=false)]
        public bool? DisplayDebtIndicator { get; set; }

        /// <summary>
        /// Gets or Sets DisplayBillPayment
        /// </summary>
        [DataMember(Name="displayBillPayment", EmitDefaultValue=false)]
        public bool? DisplayBillPayment { get; set; }

        /// <summary>
        /// Gets or Sets EnableEchecks
        /// </summary>
        [DataMember(Name="enableEchecks", EmitDefaultValue=false)]
        public bool? EnableEchecks { get; set; }

        /// <summary>
        /// Gets or Sets DisplayIgnoreECheckAvsCheckbox
        /// </summary>
        [DataMember(Name="displayIgnoreECheckAvsCheckbox", EmitDefaultValue=false)]
        public bool? DisplayIgnoreECheckAvsCheckbox { get; set; }

        /// <summary>
        /// Gets or Sets FirstNameRequired
        /// </summary>
        [DataMember(Name="firstNameRequired", EmitDefaultValue=false)]
        public bool? FirstNameRequired { get; set; }

        /// <summary>
        /// Gets or Sets LastNameRequired
        /// </summary>
        [DataMember(Name="lastNameRequired", EmitDefaultValue=false)]
        public bool? LastNameRequired { get; set; }

        /// <summary>
        /// Gets or Sets DisplayFirstName
        /// </summary>
        [DataMember(Name="displayFirstName", EmitDefaultValue=false)]
        public bool? DisplayFirstName { get; set; }

        /// <summary>
        /// Gets or Sets DisplayLastName
        /// </summary>
        [DataMember(Name="displayLastName", EmitDefaultValue=false)]
        public bool? DisplayLastName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentsProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentGlobalPaymentInformationPaymentInformation {\n");
            sb.Append("  DisplayCardVerificationValue: ").Append(DisplayCardVerificationValue).Append("\n");
            sb.Append("  RequireCardVerificationValue: ").Append(RequireCardVerificationValue).Append("\n");
            sb.Append("  AcceptedCardTypes: ").Append(AcceptedCardTypes).Append("\n");
            sb.Append("  DisplayCreditCards: ").Append(DisplayCreditCards).Append("\n");
            sb.Append("  DisplayEchecks: ").Append(DisplayEchecks).Append("\n");
            sb.Append("  DisplayDebtIndicator: ").Append(DisplayDebtIndicator).Append("\n");
            sb.Append("  DisplayBillPayment: ").Append(DisplayBillPayment).Append("\n");
            sb.Append("  EnableEchecks: ").Append(EnableEchecks).Append("\n");
            sb.Append("  DisplayIgnoreECheckAvsCheckbox: ").Append(DisplayIgnoreECheckAvsCheckbox).Append("\n");
            sb.Append("  FirstNameRequired: ").Append(FirstNameRequired).Append("\n");
            sb.Append("  LastNameRequired: ").Append(LastNameRequired).Append("\n");
            sb.Append("  DisplayFirstName: ").Append(DisplayFirstName).Append("\n");
            sb.Append("  DisplayLastName: ").Append(DisplayLastName).Append("\n");
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
            return this.Equals(obj as PaymentsProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentGlobalPaymentInformationPaymentInformation);
        }

        /// <summary>
        /// Returns true if PaymentsProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentGlobalPaymentInformationPaymentInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentsProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentGlobalPaymentInformationPaymentInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentsProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentGlobalPaymentInformationPaymentInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DisplayCardVerificationValue == other.DisplayCardVerificationValue ||
                    this.DisplayCardVerificationValue != null &&
                    this.DisplayCardVerificationValue.SequenceEqual(other.DisplayCardVerificationValue)
                ) && 
                (
                    this.RequireCardVerificationValue == other.RequireCardVerificationValue ||
                    this.RequireCardVerificationValue != null &&
                    this.RequireCardVerificationValue.SequenceEqual(other.RequireCardVerificationValue)
                ) && 
                (
                    this.AcceptedCardTypes == other.AcceptedCardTypes ||
                    this.AcceptedCardTypes != null &&
                    this.AcceptedCardTypes.SequenceEqual(other.AcceptedCardTypes)
                ) && 
                (
                    this.DisplayCreditCards == other.DisplayCreditCards ||
                    this.DisplayCreditCards != null &&
                    this.DisplayCreditCards.Equals(other.DisplayCreditCards)
                ) && 
                (
                    this.DisplayEchecks == other.DisplayEchecks ||
                    this.DisplayEchecks != null &&
                    this.DisplayEchecks.Equals(other.DisplayEchecks)
                ) && 
                (
                    this.DisplayDebtIndicator == other.DisplayDebtIndicator ||
                    this.DisplayDebtIndicator != null &&
                    this.DisplayDebtIndicator.Equals(other.DisplayDebtIndicator)
                ) && 
                (
                    this.DisplayBillPayment == other.DisplayBillPayment ||
                    this.DisplayBillPayment != null &&
                    this.DisplayBillPayment.Equals(other.DisplayBillPayment)
                ) && 
                (
                    this.EnableEchecks == other.EnableEchecks ||
                    this.EnableEchecks != null &&
                    this.EnableEchecks.Equals(other.EnableEchecks)
                ) && 
                (
                    this.DisplayIgnoreECheckAvsCheckbox == other.DisplayIgnoreECheckAvsCheckbox ||
                    this.DisplayIgnoreECheckAvsCheckbox != null &&
                    this.DisplayIgnoreECheckAvsCheckbox.Equals(other.DisplayIgnoreECheckAvsCheckbox)
                ) && 
                (
                    this.FirstNameRequired == other.FirstNameRequired ||
                    this.FirstNameRequired != null &&
                    this.FirstNameRequired.Equals(other.FirstNameRequired)
                ) && 
                (
                    this.LastNameRequired == other.LastNameRequired ||
                    this.LastNameRequired != null &&
                    this.LastNameRequired.Equals(other.LastNameRequired)
                ) && 
                (
                    this.DisplayFirstName == other.DisplayFirstName ||
                    this.DisplayFirstName != null &&
                    this.DisplayFirstName.Equals(other.DisplayFirstName)
                ) && 
                (
                    this.DisplayLastName == other.DisplayLastName ||
                    this.DisplayLastName != null &&
                    this.DisplayLastName.Equals(other.DisplayLastName)
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
                if (this.DisplayCardVerificationValue != null)
                    hash = hash * 59 + this.DisplayCardVerificationValue.GetHashCode();
                if (this.RequireCardVerificationValue != null)
                    hash = hash * 59 + this.RequireCardVerificationValue.GetHashCode();
                if (this.AcceptedCardTypes != null)
                    hash = hash * 59 + this.AcceptedCardTypes.GetHashCode();
                if (this.DisplayCreditCards != null)
                    hash = hash * 59 + this.DisplayCreditCards.GetHashCode();
                if (this.DisplayEchecks != null)
                    hash = hash * 59 + this.DisplayEchecks.GetHashCode();
                if (this.DisplayDebtIndicator != null)
                    hash = hash * 59 + this.DisplayDebtIndicator.GetHashCode();
                if (this.DisplayBillPayment != null)
                    hash = hash * 59 + this.DisplayBillPayment.GetHashCode();
                if (this.EnableEchecks != null)
                    hash = hash * 59 + this.EnableEchecks.GetHashCode();
                if (this.DisplayIgnoreECheckAvsCheckbox != null)
                    hash = hash * 59 + this.DisplayIgnoreECheckAvsCheckbox.GetHashCode();
                if (this.FirstNameRequired != null)
                    hash = hash * 59 + this.FirstNameRequired.GetHashCode();
                if (this.LastNameRequired != null)
                    hash = hash * 59 + this.LastNameRequired.GetHashCode();
                if (this.DisplayFirstName != null)
                    hash = hash * 59 + this.DisplayFirstName.GetHashCode();
                if (this.DisplayLastName != null)
                    hash = hash * 59 + this.DisplayLastName.GetHashCode();
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
