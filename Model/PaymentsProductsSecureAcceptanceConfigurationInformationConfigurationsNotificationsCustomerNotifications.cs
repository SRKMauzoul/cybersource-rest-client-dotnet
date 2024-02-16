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
    /// Features relating to notifications being sent directly to the payer using the Hosted Checkout.
    /// </summary>
    [DataContract]
    public partial class PaymentsProductsSecureAcceptanceConfigurationInformationConfigurationsNotificationsCustomerNotifications :  IEquatable<PaymentsProductsSecureAcceptanceConfigurationInformationConfigurationsNotificationsCustomerNotifications>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsProductsSecureAcceptanceConfigurationInformationConfigurationsNotificationsCustomerNotifications" /> class.
        /// </summary>
        /// <param name="CustomReceiptPageEnabled">Toggles the custom receipt page, where merchants can receive the results of the transaction and display appropriate messaging. Usually set by web developers integrating to Secure Acceptance..</param>
        /// <param name="ReceiptEmailAddress">Email address where a copy of the payer&#39;s receipt email is sent, when notificationReceiptEmailEnabled is true..</param>
        /// <param name="CustomerReceiptEmailEnabled">Toggles an email receipt sent to the payer&#39;s email address on payment success..</param>
        /// <param name="CustomCancelPage">URL to which transaction results are POSTed when the payer clicks &#39;Cancel&#39; on the Hosted Checkout. Triggered when customCancelPageEnabled is true. Usually set by web developers integrating to Secure Acceptance..</param>
        /// <param name="CustomReceiptPage">URL to which transaction results are POSTed when the payer requests a payment on the Hosted Checkout. Triggered when customCancelPageEnabled is true. Usually set by web developers integrating to Secure Acceptance..</param>
        /// <param name="CustomCancelPageEnabled">Toggles the custom cancel page, where merchants can receive notice that the payer has canceled, and display appropriate messaging and direction. Usually set by web developers integrating to Secure Acceptance..</param>
        /// <param name="NotificationReceiptEmailEnabled">Toggles whether merchant receives a copy of the payer&#39;s receipt email..</param>
        public PaymentsProductsSecureAcceptanceConfigurationInformationConfigurationsNotificationsCustomerNotifications(bool? CustomReceiptPageEnabled = default(bool?), string ReceiptEmailAddress = default(string), bool? CustomerReceiptEmailEnabled = default(bool?), string CustomCancelPage = default(string), string CustomReceiptPage = default(string), bool? CustomCancelPageEnabled = default(bool?), bool? NotificationReceiptEmailEnabled = default(bool?))
        {
            this.CustomReceiptPageEnabled = CustomReceiptPageEnabled;
            this.ReceiptEmailAddress = ReceiptEmailAddress;
            this.CustomerReceiptEmailEnabled = CustomerReceiptEmailEnabled;
            this.CustomCancelPage = CustomCancelPage;
            this.CustomReceiptPage = CustomReceiptPage;
            this.CustomCancelPageEnabled = CustomCancelPageEnabled;
            this.NotificationReceiptEmailEnabled = NotificationReceiptEmailEnabled;
        }
        
        /// <summary>
        /// Toggles the custom receipt page, where merchants can receive the results of the transaction and display appropriate messaging. Usually set by web developers integrating to Secure Acceptance.
        /// </summary>
        /// <value>Toggles the custom receipt page, where merchants can receive the results of the transaction and display appropriate messaging. Usually set by web developers integrating to Secure Acceptance.</value>
        [DataMember(Name="customReceiptPageEnabled", EmitDefaultValue=false)]
        public bool? CustomReceiptPageEnabled { get; set; }

        /// <summary>
        /// Email address where a copy of the payer&#39;s receipt email is sent, when notificationReceiptEmailEnabled is true.
        /// </summary>
        /// <value>Email address where a copy of the payer&#39;s receipt email is sent, when notificationReceiptEmailEnabled is true.</value>
        [DataMember(Name="receiptEmailAddress", EmitDefaultValue=false)]
        public string ReceiptEmailAddress { get; set; }

        /// <summary>
        /// Toggles an email receipt sent to the payer&#39;s email address on payment success.
        /// </summary>
        /// <value>Toggles an email receipt sent to the payer&#39;s email address on payment success.</value>
        [DataMember(Name="customerReceiptEmailEnabled", EmitDefaultValue=false)]
        public bool? CustomerReceiptEmailEnabled { get; set; }

        /// <summary>
        /// URL to which transaction results are POSTed when the payer clicks &#39;Cancel&#39; on the Hosted Checkout. Triggered when customCancelPageEnabled is true. Usually set by web developers integrating to Secure Acceptance.
        /// </summary>
        /// <value>URL to which transaction results are POSTed when the payer clicks &#39;Cancel&#39; on the Hosted Checkout. Triggered when customCancelPageEnabled is true. Usually set by web developers integrating to Secure Acceptance.</value>
        [DataMember(Name="customCancelPage", EmitDefaultValue=false)]
        public string CustomCancelPage { get; set; }

        /// <summary>
        /// URL to which transaction results are POSTed when the payer requests a payment on the Hosted Checkout. Triggered when customCancelPageEnabled is true. Usually set by web developers integrating to Secure Acceptance.
        /// </summary>
        /// <value>URL to which transaction results are POSTed when the payer requests a payment on the Hosted Checkout. Triggered when customCancelPageEnabled is true. Usually set by web developers integrating to Secure Acceptance.</value>
        [DataMember(Name="customReceiptPage", EmitDefaultValue=false)]
        public string CustomReceiptPage { get; set; }

        /// <summary>
        /// Toggles the custom cancel page, where merchants can receive notice that the payer has canceled, and display appropriate messaging and direction. Usually set by web developers integrating to Secure Acceptance.
        /// </summary>
        /// <value>Toggles the custom cancel page, where merchants can receive notice that the payer has canceled, and display appropriate messaging and direction. Usually set by web developers integrating to Secure Acceptance.</value>
        [DataMember(Name="customCancelPageEnabled", EmitDefaultValue=false)]
        public bool? CustomCancelPageEnabled { get; set; }

        /// <summary>
        /// Toggles whether merchant receives a copy of the payer&#39;s receipt email.
        /// </summary>
        /// <value>Toggles whether merchant receives a copy of the payer&#39;s receipt email.</value>
        [DataMember(Name="notificationReceiptEmailEnabled", EmitDefaultValue=false)]
        public bool? NotificationReceiptEmailEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentsProductsSecureAcceptanceConfigurationInformationConfigurationsNotificationsCustomerNotifications {\n");
            sb.Append("  CustomReceiptPageEnabled: ").Append(CustomReceiptPageEnabled).Append("\n");
            sb.Append("  ReceiptEmailAddress: ").Append(ReceiptEmailAddress).Append("\n");
            sb.Append("  CustomerReceiptEmailEnabled: ").Append(CustomerReceiptEmailEnabled).Append("\n");
            sb.Append("  CustomCancelPage: ").Append(CustomCancelPage).Append("\n");
            sb.Append("  CustomReceiptPage: ").Append(CustomReceiptPage).Append("\n");
            sb.Append("  CustomCancelPageEnabled: ").Append(CustomCancelPageEnabled).Append("\n");
            sb.Append("  NotificationReceiptEmailEnabled: ").Append(NotificationReceiptEmailEnabled).Append("\n");
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
            return this.Equals(obj as PaymentsProductsSecureAcceptanceConfigurationInformationConfigurationsNotificationsCustomerNotifications);
        }

        /// <summary>
        /// Returns true if PaymentsProductsSecureAcceptanceConfigurationInformationConfigurationsNotificationsCustomerNotifications instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentsProductsSecureAcceptanceConfigurationInformationConfigurationsNotificationsCustomerNotifications to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentsProductsSecureAcceptanceConfigurationInformationConfigurationsNotificationsCustomerNotifications other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CustomReceiptPageEnabled == other.CustomReceiptPageEnabled ||
                    this.CustomReceiptPageEnabled != null &&
                    this.CustomReceiptPageEnabled.Equals(other.CustomReceiptPageEnabled)
                ) && 
                (
                    this.ReceiptEmailAddress == other.ReceiptEmailAddress ||
                    this.ReceiptEmailAddress != null &&
                    this.ReceiptEmailAddress.Equals(other.ReceiptEmailAddress)
                ) && 
                (
                    this.CustomerReceiptEmailEnabled == other.CustomerReceiptEmailEnabled ||
                    this.CustomerReceiptEmailEnabled != null &&
                    this.CustomerReceiptEmailEnabled.Equals(other.CustomerReceiptEmailEnabled)
                ) && 
                (
                    this.CustomCancelPage == other.CustomCancelPage ||
                    this.CustomCancelPage != null &&
                    this.CustomCancelPage.Equals(other.CustomCancelPage)
                ) && 
                (
                    this.CustomReceiptPage == other.CustomReceiptPage ||
                    this.CustomReceiptPage != null &&
                    this.CustomReceiptPage.Equals(other.CustomReceiptPage)
                ) && 
                (
                    this.CustomCancelPageEnabled == other.CustomCancelPageEnabled ||
                    this.CustomCancelPageEnabled != null &&
                    this.CustomCancelPageEnabled.Equals(other.CustomCancelPageEnabled)
                ) && 
                (
                    this.NotificationReceiptEmailEnabled == other.NotificationReceiptEmailEnabled ||
                    this.NotificationReceiptEmailEnabled != null &&
                    this.NotificationReceiptEmailEnabled.Equals(other.NotificationReceiptEmailEnabled)
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
                if (this.CustomReceiptPageEnabled != null)
                    hash = hash * 59 + this.CustomReceiptPageEnabled.GetHashCode();
                if (this.ReceiptEmailAddress != null)
                    hash = hash * 59 + this.ReceiptEmailAddress.GetHashCode();
                if (this.CustomerReceiptEmailEnabled != null)
                    hash = hash * 59 + this.CustomerReceiptEmailEnabled.GetHashCode();
                if (this.CustomCancelPage != null)
                    hash = hash * 59 + this.CustomCancelPage.GetHashCode();
                if (this.CustomReceiptPage != null)
                    hash = hash * 59 + this.CustomReceiptPage.GetHashCode();
                if (this.CustomCancelPageEnabled != null)
                    hash = hash * 59 + this.CustomCancelPageEnabled.GetHashCode();
                if (this.NotificationReceiptEmailEnabled != null)
                    hash = hash * 59 + this.NotificationReceiptEmailEnabled.GetHashCode();
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
