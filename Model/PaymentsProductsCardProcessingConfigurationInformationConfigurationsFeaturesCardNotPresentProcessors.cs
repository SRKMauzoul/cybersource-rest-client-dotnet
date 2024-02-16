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
    /// PaymentsProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentProcessors
    /// </summary>
    [DataContract]
    public partial class PaymentsProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentProcessors :  IEquatable<PaymentsProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentProcessors>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentProcessors" /> class.
        /// </summary>
        /// <param name="RelaxAddressVerificationSystem">Enables you to submit the payment transaction without one or more of the fields for the billTo or card_expiration. Applicable for Elavon Americas (elavonamericas), CB2A, Six (six), CMCIC (cmcic), GPX (gpx), GPN (gpn), VPC, Vero (vero), Fiserv (fiserv), American Express Direct (amexdirect), Chase Paymentech Salem (chasepaymentechsalem), RUPAY, FDI Global (fdiglobal) and Barclays HISO (barclayshiso) processors.  Validation details (for selected processors)...  &lt;table&gt; &lt;thead&gt;&lt;tr&gt;&lt;th&gt;Processor&lt;/th&gt;&lt;th&gt;Acceptance Type&lt;/th&gt;&lt;th&gt;Required&lt;/th&gt;&lt;th&gt;Default Value&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt; &lt;tr&gt;&lt;td&gt;Barclays HISO&lt;/td&gt;&lt;td&gt;cp, cnp, hybrid&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cnp&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cp&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;hybrid&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;/tr&gt; &lt;/table&gt; .</param>
        /// <param name="RelaxAddressVerificationSystemAllowZipWithoutCountry">Allows Zip code without country. Applicable for American Express Direct (amexdirect), GPX (gpx), VPC, FDI Global (fdiglobal), Elavon Americas (elavonamericas), Chase Paymentech Salem (chasepaymentechsalem), RUPAY, GPN (gpn) and Barclays HISO (barclayshiso) processors.  Validation details (for selected processors)...  &lt;table&gt; &lt;thead&gt;&lt;tr&gt;&lt;th&gt;Processor&lt;/th&gt;&lt;th&gt;Acceptance Type&lt;/th&gt;&lt;th&gt;Required&lt;/th&gt;&lt;th&gt;Default Value&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt; &lt;tr&gt;&lt;td&gt;Barclays HISO&lt;/td&gt;&lt;td&gt;cp, cnp, both&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cp, hybrid&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cnp&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;/tr&gt; &lt;/table&gt; .</param>
        /// <param name="RelaxAddressVerificationSystemAllowExpiredCard">Allows transactions that use an expired card. Applicable for American Express Direct (amexdirect), GPN (gpn), Barclays HISO (barclayshiso), Elavon Americas (elavonamericas), VPC, FDI Global (fdiglobal), GPX (gpx), RUPAY, Six (six), Chase Paymentech Salem (chasepaymentechsalem) and CB2A processors.  Validation details (for selected processors)...  &lt;table&gt; &lt;thead&gt;&lt;tr&gt;&lt;th&gt;Processor&lt;/th&gt;&lt;th&gt;Acceptance Type&lt;/th&gt;&lt;th&gt;Required&lt;/th&gt;&lt;th&gt;Default Value&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt; &lt;tr&gt;&lt;td&gt;Barclays HISO&lt;/td&gt;&lt;td&gt;cp, cnp, hybrid&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cp, hybrid&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cnp&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;/tr&gt; &lt;/table&gt; .</param>
        /// <param name="EnableEmsTransactionRiskScore">MasterCard Expert Monitoring Solutions (EMS) provides a predictive, behavior-based fraud score in real time during authorizations for card-not-present (CNP) transactions on cards issued in the U.S. Applicable for GPX (gpx) and VPC processors..</param>
        /// <param name="PrestigiousPropertyIndicator">Applicable for VPC processors..</param>
        /// <param name="Payouts">Payouts.</param>
        public PaymentsProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentProcessors(bool? RelaxAddressVerificationSystem = default(bool?), bool? RelaxAddressVerificationSystemAllowZipWithoutCountry = default(bool?), bool? RelaxAddressVerificationSystemAllowExpiredCard = default(bool?), bool? EnableEmsTransactionRiskScore = default(bool?), string PrestigiousPropertyIndicator = default(string), PaymentsProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentPayouts Payouts = default(PaymentsProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentPayouts))
        {
            this.RelaxAddressVerificationSystem = RelaxAddressVerificationSystem;
            this.RelaxAddressVerificationSystemAllowZipWithoutCountry = RelaxAddressVerificationSystemAllowZipWithoutCountry;
            this.RelaxAddressVerificationSystemAllowExpiredCard = RelaxAddressVerificationSystemAllowExpiredCard;
            this.EnableEmsTransactionRiskScore = EnableEmsTransactionRiskScore;
            this.PrestigiousPropertyIndicator = PrestigiousPropertyIndicator;
            this.Payouts = Payouts;
        }
        
        /// <summary>
        /// Enables you to submit the payment transaction without one or more of the fields for the billTo or card_expiration. Applicable for Elavon Americas (elavonamericas), CB2A, Six (six), CMCIC (cmcic), GPX (gpx), GPN (gpn), VPC, Vero (vero), Fiserv (fiserv), American Express Direct (amexdirect), Chase Paymentech Salem (chasepaymentechsalem), RUPAY, FDI Global (fdiglobal) and Barclays HISO (barclayshiso) processors.  Validation details (for selected processors)...  &lt;table&gt; &lt;thead&gt;&lt;tr&gt;&lt;th&gt;Processor&lt;/th&gt;&lt;th&gt;Acceptance Type&lt;/th&gt;&lt;th&gt;Required&lt;/th&gt;&lt;th&gt;Default Value&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt; &lt;tr&gt;&lt;td&gt;Barclays HISO&lt;/td&gt;&lt;td&gt;cp, cnp, hybrid&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cnp&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cp&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;hybrid&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;/tr&gt; &lt;/table&gt; 
        /// </summary>
        /// <value>Enables you to submit the payment transaction without one or more of the fields for the billTo or card_expiration. Applicable for Elavon Americas (elavonamericas), CB2A, Six (six), CMCIC (cmcic), GPX (gpx), GPN (gpn), VPC, Vero (vero), Fiserv (fiserv), American Express Direct (amexdirect), Chase Paymentech Salem (chasepaymentechsalem), RUPAY, FDI Global (fdiglobal) and Barclays HISO (barclayshiso) processors.  Validation details (for selected processors)...  &lt;table&gt; &lt;thead&gt;&lt;tr&gt;&lt;th&gt;Processor&lt;/th&gt;&lt;th&gt;Acceptance Type&lt;/th&gt;&lt;th&gt;Required&lt;/th&gt;&lt;th&gt;Default Value&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt; &lt;tr&gt;&lt;td&gt;Barclays HISO&lt;/td&gt;&lt;td&gt;cp, cnp, hybrid&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cnp&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cp&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;hybrid&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;/tr&gt; &lt;/table&gt; </value>
        [DataMember(Name="relaxAddressVerificationSystem", EmitDefaultValue=false)]
        public bool? RelaxAddressVerificationSystem { get; set; }

        /// <summary>
        /// Allows Zip code without country. Applicable for American Express Direct (amexdirect), GPX (gpx), VPC, FDI Global (fdiglobal), Elavon Americas (elavonamericas), Chase Paymentech Salem (chasepaymentechsalem), RUPAY, GPN (gpn) and Barclays HISO (barclayshiso) processors.  Validation details (for selected processors)...  &lt;table&gt; &lt;thead&gt;&lt;tr&gt;&lt;th&gt;Processor&lt;/th&gt;&lt;th&gt;Acceptance Type&lt;/th&gt;&lt;th&gt;Required&lt;/th&gt;&lt;th&gt;Default Value&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt; &lt;tr&gt;&lt;td&gt;Barclays HISO&lt;/td&gt;&lt;td&gt;cp, cnp, both&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cp, hybrid&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cnp&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;/tr&gt; &lt;/table&gt; 
        /// </summary>
        /// <value>Allows Zip code without country. Applicable for American Express Direct (amexdirect), GPX (gpx), VPC, FDI Global (fdiglobal), Elavon Americas (elavonamericas), Chase Paymentech Salem (chasepaymentechsalem), RUPAY, GPN (gpn) and Barclays HISO (barclayshiso) processors.  Validation details (for selected processors)...  &lt;table&gt; &lt;thead&gt;&lt;tr&gt;&lt;th&gt;Processor&lt;/th&gt;&lt;th&gt;Acceptance Type&lt;/th&gt;&lt;th&gt;Required&lt;/th&gt;&lt;th&gt;Default Value&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt; &lt;tr&gt;&lt;td&gt;Barclays HISO&lt;/td&gt;&lt;td&gt;cp, cnp, both&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cp, hybrid&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cnp&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;/tr&gt; &lt;/table&gt; </value>
        [DataMember(Name="relaxAddressVerificationSystemAllowZipWithoutCountry", EmitDefaultValue=false)]
        public bool? RelaxAddressVerificationSystemAllowZipWithoutCountry { get; set; }

        /// <summary>
        /// Allows transactions that use an expired card. Applicable for American Express Direct (amexdirect), GPN (gpn), Barclays HISO (barclayshiso), Elavon Americas (elavonamericas), VPC, FDI Global (fdiglobal), GPX (gpx), RUPAY, Six (six), Chase Paymentech Salem (chasepaymentechsalem) and CB2A processors.  Validation details (for selected processors)...  &lt;table&gt; &lt;thead&gt;&lt;tr&gt;&lt;th&gt;Processor&lt;/th&gt;&lt;th&gt;Acceptance Type&lt;/th&gt;&lt;th&gt;Required&lt;/th&gt;&lt;th&gt;Default Value&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt; &lt;tr&gt;&lt;td&gt;Barclays HISO&lt;/td&gt;&lt;td&gt;cp, cnp, hybrid&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cp, hybrid&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cnp&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;/tr&gt; &lt;/table&gt; 
        /// </summary>
        /// <value>Allows transactions that use an expired card. Applicable for American Express Direct (amexdirect), GPN (gpn), Barclays HISO (barclayshiso), Elavon Americas (elavonamericas), VPC, FDI Global (fdiglobal), GPX (gpx), RUPAY, Six (six), Chase Paymentech Salem (chasepaymentechsalem) and CB2A processors.  Validation details (for selected processors)...  &lt;table&gt; &lt;thead&gt;&lt;tr&gt;&lt;th&gt;Processor&lt;/th&gt;&lt;th&gt;Acceptance Type&lt;/th&gt;&lt;th&gt;Required&lt;/th&gt;&lt;th&gt;Default Value&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt; &lt;tr&gt;&lt;td&gt;Barclays HISO&lt;/td&gt;&lt;td&gt;cp, cnp, hybrid&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cp, hybrid&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cnp&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;/tr&gt; &lt;/table&gt; </value>
        [DataMember(Name="relaxAddressVerificationSystemAllowExpiredCard", EmitDefaultValue=false)]
        public bool? RelaxAddressVerificationSystemAllowExpiredCard { get; set; }

        /// <summary>
        /// MasterCard Expert Monitoring Solutions (EMS) provides a predictive, behavior-based fraud score in real time during authorizations for card-not-present (CNP) transactions on cards issued in the U.S. Applicable for GPX (gpx) and VPC processors.
        /// </summary>
        /// <value>MasterCard Expert Monitoring Solutions (EMS) provides a predictive, behavior-based fraud score in real time during authorizations for card-not-present (CNP) transactions on cards issued in the U.S. Applicable for GPX (gpx) and VPC processors.</value>
        [DataMember(Name="enableEmsTransactionRiskScore", EmitDefaultValue=false)]
        public bool? EnableEmsTransactionRiskScore { get; set; }

        /// <summary>
        /// Applicable for VPC processors.
        /// </summary>
        /// <value>Applicable for VPC processors.</value>
        [DataMember(Name="prestigiousPropertyIndicator", EmitDefaultValue=false)]
        public string PrestigiousPropertyIndicator { get; set; }

        /// <summary>
        /// Gets or Sets Payouts
        /// </summary>
        [DataMember(Name="payouts", EmitDefaultValue=false)]
        public PaymentsProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentPayouts Payouts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentsProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentProcessors {\n");
            sb.Append("  RelaxAddressVerificationSystem: ").Append(RelaxAddressVerificationSystem).Append("\n");
            sb.Append("  RelaxAddressVerificationSystemAllowZipWithoutCountry: ").Append(RelaxAddressVerificationSystemAllowZipWithoutCountry).Append("\n");
            sb.Append("  RelaxAddressVerificationSystemAllowExpiredCard: ").Append(RelaxAddressVerificationSystemAllowExpiredCard).Append("\n");
            sb.Append("  EnableEmsTransactionRiskScore: ").Append(EnableEmsTransactionRiskScore).Append("\n");
            sb.Append("  PrestigiousPropertyIndicator: ").Append(PrestigiousPropertyIndicator).Append("\n");
            sb.Append("  Payouts: ").Append(Payouts).Append("\n");
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
            return this.Equals(obj as PaymentsProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentProcessors);
        }

        /// <summary>
        /// Returns true if PaymentsProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentProcessors instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentsProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentProcessors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentsProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentProcessors other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RelaxAddressVerificationSystem == other.RelaxAddressVerificationSystem ||
                    this.RelaxAddressVerificationSystem != null &&
                    this.RelaxAddressVerificationSystem.Equals(other.RelaxAddressVerificationSystem)
                ) && 
                (
                    this.RelaxAddressVerificationSystemAllowZipWithoutCountry == other.RelaxAddressVerificationSystemAllowZipWithoutCountry ||
                    this.RelaxAddressVerificationSystemAllowZipWithoutCountry != null &&
                    this.RelaxAddressVerificationSystemAllowZipWithoutCountry.Equals(other.RelaxAddressVerificationSystemAllowZipWithoutCountry)
                ) && 
                (
                    this.RelaxAddressVerificationSystemAllowExpiredCard == other.RelaxAddressVerificationSystemAllowExpiredCard ||
                    this.RelaxAddressVerificationSystemAllowExpiredCard != null &&
                    this.RelaxAddressVerificationSystemAllowExpiredCard.Equals(other.RelaxAddressVerificationSystemAllowExpiredCard)
                ) && 
                (
                    this.EnableEmsTransactionRiskScore == other.EnableEmsTransactionRiskScore ||
                    this.EnableEmsTransactionRiskScore != null &&
                    this.EnableEmsTransactionRiskScore.Equals(other.EnableEmsTransactionRiskScore)
                ) && 
                (
                    this.PrestigiousPropertyIndicator == other.PrestigiousPropertyIndicator ||
                    this.PrestigiousPropertyIndicator != null &&
                    this.PrestigiousPropertyIndicator.Equals(other.PrestigiousPropertyIndicator)
                ) && 
                (
                    this.Payouts == other.Payouts ||
                    this.Payouts != null &&
                    this.Payouts.Equals(other.Payouts)
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
                if (this.RelaxAddressVerificationSystem != null)
                    hash = hash * 59 + this.RelaxAddressVerificationSystem.GetHashCode();
                if (this.RelaxAddressVerificationSystemAllowZipWithoutCountry != null)
                    hash = hash * 59 + this.RelaxAddressVerificationSystemAllowZipWithoutCountry.GetHashCode();
                if (this.RelaxAddressVerificationSystemAllowExpiredCard != null)
                    hash = hash * 59 + this.RelaxAddressVerificationSystemAllowExpiredCard.GetHashCode();
                if (this.EnableEmsTransactionRiskScore != null)
                    hash = hash * 59 + this.EnableEmsTransactionRiskScore.GetHashCode();
                if (this.PrestigiousPropertyIndicator != null)
                    hash = hash * 59 + this.PrestigiousPropertyIndicator.GetHashCode();
                if (this.Payouts != null)
                    hash = hash * 59 + this.Payouts.GetHashCode();
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
