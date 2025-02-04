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
    /// Name of the payment processor. Example - \&quot;wellsfargoach\&quot;
    /// </summary>
    [DataContract]
    public partial class PaymentsProductsECheckConfigurationInformationConfigurationsCommonInternalOnlyProcessors :  IEquatable<PaymentsProductsECheckConfigurationInformationConfigurationsCommonInternalOnlyProcessors>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsProductsECheckConfigurationInformationConfigurationsCommonInternalOnlyProcessors" /> class.
        /// </summary>
        /// <param name="EnableCCS">*NEW* Flag to indicate whether the processor is migrated to the Common Connectivity Services Platform. Applicable for VPC and amexdirect processors. .</param>
        /// <param name="TerminalId">*NEW* The &#39;Terminal Id&#39; aka TID, is an identifier used for with your payments processor. Depending on the processor and payment acceptance type this may also be the default Terminal ID used for Card Present and Virtual Terminal transactions. Applicable for VPC processors. .</param>
        /// <param name="Enable15anTransactionReferenceNumber">*NEW* This ensures the transaction reference # contains an identifier that can be viewed in CYBS (default to true).</param>
        /// <param name="PortalSupportedPaytypes">*NEW* This is used by the EBC2 application (default to &quot;CHECK&quot;).</param>
        /// <param name="SetCompletedState">*Moved* When set to Yes we will automatically update transactions to a completed status X-number of days after the transaction comes through; if no failure notification is received. When set to No means we will not update transaction status in this manner. For BAMS/Bank of America merchants, they should be set to No unless we are explicitly asked to set a merchant to YES. (default to false).</param>
        public PaymentsProductsECheckConfigurationInformationConfigurationsCommonInternalOnlyProcessors(bool? EnableCCS = default(bool?), string TerminalId = default(string), bool? Enable15anTransactionReferenceNumber = true, string PortalSupportedPaytypes = "CHECK", bool? SetCompletedState = false)
        {
            this.EnableCCS = EnableCCS;
            this.TerminalId = TerminalId;
            // use default value if no "Enable15anTransactionReferenceNumber" provided
            if (Enable15anTransactionReferenceNumber == null)
            {
                this.Enable15anTransactionReferenceNumber = true;
            }
            else
            {
                this.Enable15anTransactionReferenceNumber = Enable15anTransactionReferenceNumber;
            }
            // use default value if no "PortalSupportedPaytypes" provided
            if (PortalSupportedPaytypes == null)
            {
                this.PortalSupportedPaytypes = "CHECK";
            }
            else
            {
                this.PortalSupportedPaytypes = PortalSupportedPaytypes;
            }
            // use default value if no "SetCompletedState" provided
            if (SetCompletedState == null)
            {
                this.SetCompletedState = false;
            }
            else
            {
                this.SetCompletedState = SetCompletedState;
            }
        }
        
        /// <summary>
        /// *NEW* Flag to indicate whether the processor is migrated to the Common Connectivity Services Platform. Applicable for VPC and amexdirect processors. 
        /// </summary>
        /// <value>*NEW* Flag to indicate whether the processor is migrated to the Common Connectivity Services Platform. Applicable for VPC and amexdirect processors. </value>
        [DataMember(Name="enableCCS", EmitDefaultValue=false)]
        public bool? EnableCCS { get; set; }

        /// <summary>
        /// *NEW* The &#39;Terminal Id&#39; aka TID, is an identifier used for with your payments processor. Depending on the processor and payment acceptance type this may also be the default Terminal ID used for Card Present and Virtual Terminal transactions. Applicable for VPC processors. 
        /// </summary>
        /// <value>*NEW* The &#39;Terminal Id&#39; aka TID, is an identifier used for with your payments processor. Depending on the processor and payment acceptance type this may also be the default Terminal ID used for Card Present and Virtual Terminal transactions. Applicable for VPC processors. </value>
        [DataMember(Name="terminalId", EmitDefaultValue=false)]
        public string TerminalId { get; set; }

        /// <summary>
        /// *NEW* This ensures the transaction reference # contains an identifier that can be viewed in CYBS
        /// </summary>
        /// <value>*NEW* This ensures the transaction reference # contains an identifier that can be viewed in CYBS</value>
        [DataMember(Name="enable15anTransactionReferenceNumber", EmitDefaultValue=false)]
        public bool? Enable15anTransactionReferenceNumber { get; set; }

        /// <summary>
        /// *NEW* This is used by the EBC2 application
        /// </summary>
        /// <value>*NEW* This is used by the EBC2 application</value>
        [DataMember(Name="portalSupportedPaytypes", EmitDefaultValue=false)]
        public string PortalSupportedPaytypes { get; set; }

        /// <summary>
        /// *Moved* When set to Yes we will automatically update transactions to a completed status X-number of days after the transaction comes through; if no failure notification is received. When set to No means we will not update transaction status in this manner. For BAMS/Bank of America merchants, they should be set to No unless we are explicitly asked to set a merchant to YES.
        /// </summary>
        /// <value>*Moved* When set to Yes we will automatically update transactions to a completed status X-number of days after the transaction comes through; if no failure notification is received. When set to No means we will not update transaction status in this manner. For BAMS/Bank of America merchants, they should be set to No unless we are explicitly asked to set a merchant to YES.</value>
        [DataMember(Name="setCompletedState", EmitDefaultValue=false)]
        public bool? SetCompletedState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentsProductsECheckConfigurationInformationConfigurationsCommonInternalOnlyProcessors {\n");
            sb.Append("  EnableCCS: ").Append(EnableCCS).Append("\n");
            sb.Append("  TerminalId: ").Append(TerminalId).Append("\n");
            sb.Append("  Enable15anTransactionReferenceNumber: ").Append(Enable15anTransactionReferenceNumber).Append("\n");
            sb.Append("  PortalSupportedPaytypes: ").Append(PortalSupportedPaytypes).Append("\n");
            sb.Append("  SetCompletedState: ").Append(SetCompletedState).Append("\n");
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
            return this.Equals(obj as PaymentsProductsECheckConfigurationInformationConfigurationsCommonInternalOnlyProcessors);
        }

        /// <summary>
        /// Returns true if PaymentsProductsECheckConfigurationInformationConfigurationsCommonInternalOnlyProcessors instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentsProductsECheckConfigurationInformationConfigurationsCommonInternalOnlyProcessors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentsProductsECheckConfigurationInformationConfigurationsCommonInternalOnlyProcessors other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EnableCCS == other.EnableCCS ||
                    this.EnableCCS != null &&
                    this.EnableCCS.Equals(other.EnableCCS)
                ) && 
                (
                    this.TerminalId == other.TerminalId ||
                    this.TerminalId != null &&
                    this.TerminalId.Equals(other.TerminalId)
                ) && 
                (
                    this.Enable15anTransactionReferenceNumber == other.Enable15anTransactionReferenceNumber ||
                    this.Enable15anTransactionReferenceNumber != null &&
                    this.Enable15anTransactionReferenceNumber.Equals(other.Enable15anTransactionReferenceNumber)
                ) && 
                (
                    this.PortalSupportedPaytypes == other.PortalSupportedPaytypes ||
                    this.PortalSupportedPaytypes != null &&
                    this.PortalSupportedPaytypes.Equals(other.PortalSupportedPaytypes)
                ) && 
                (
                    this.SetCompletedState == other.SetCompletedState ||
                    this.SetCompletedState != null &&
                    this.SetCompletedState.Equals(other.SetCompletedState)
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
                if (this.EnableCCS != null)
                    hash = hash * 59 + this.EnableCCS.GetHashCode();
                if (this.TerminalId != null)
                    hash = hash * 59 + this.TerminalId.GetHashCode();
                if (this.Enable15anTransactionReferenceNumber != null)
                    hash = hash * 59 + this.Enable15anTransactionReferenceNumber.GetHashCode();
                if (this.PortalSupportedPaytypes != null)
                    hash = hash * 59 + this.PortalSupportedPaytypes.GetHashCode();
                if (this.SetCompletedState != null)
                    hash = hash * 59 + this.SetCompletedState.GetHashCode();
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
