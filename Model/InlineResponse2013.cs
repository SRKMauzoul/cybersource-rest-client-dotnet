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
    /// InlineResponse2013
    /// </summary>
    [DataContract]
    public partial class InlineResponse2013 :  IEquatable<InlineResponse2013>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2013" /> class.
        /// </summary>
        /// <param name="WebhookId">Webhook Id. This is generated by the server..</param>
        /// <param name="OrganizationId">Organization ID.</param>
        /// <param name="ProductId">The product you are receiving a webhook for..</param>
        /// <param name="EventTypes">Array of the different events for a given product id..</param>
        /// <param name="WebhookUrl">The client&#39;s endpoint (URL) to receive webhooks..</param>
        /// <param name="HealthCheckUrl">The client&#39;s health check endpoint (URL). This should be as close as possible to the actual webhookUrl..</param>
        /// <param name="NotificationScope">NotificationScope.</param>
        /// <param name="Status">Webhook status. (default to &quot;INACTIVE&quot;).</param>
        /// <param name="Name">Client friendly webhook name..</param>
        /// <param name="Description">Client friendly webhook description..</param>
        /// <param name="RetryPolicy">RetryPolicy.</param>
        /// <param name="SecurityPolicy">SecurityPolicy.</param>
        /// <param name="CreatedOn">Date on which webhook was created/registered..</param>
        /// <param name="UpdatedOn">Date on which webhook was most recently updated..</param>
        /// <param name="AdditionalAttributes">Additional, free form configuration data..</param>
        public InlineResponse2013(string WebhookId = default(string), string OrganizationId = default(string), string ProductId = default(string), List<string> EventTypes = default(List<string>), string WebhookUrl = default(string), string HealthCheckUrl = default(string), Notificationsubscriptionsv1webhooksNotificationScope NotificationScope = default(Notificationsubscriptionsv1webhooksNotificationScope), string Status = "INACTIVE", string Name = default(string), string Description = default(string), Notificationsubscriptionsv1webhooksRetryPolicy RetryPolicy = default(Notificationsubscriptionsv1webhooksRetryPolicy), Notificationsubscriptionsv1webhooksSecurityPolicy SecurityPolicy = default(Notificationsubscriptionsv1webhooksSecurityPolicy), string CreatedOn = default(string), string UpdatedOn = default(string), List<Dictionary<string, string>> AdditionalAttributes = default(List<Dictionary<string, string>>))
        {
            this.WebhookId = WebhookId;
            this.OrganizationId = OrganizationId;
            this.ProductId = ProductId;
            this.EventTypes = EventTypes;
            this.WebhookUrl = WebhookUrl;
            this.HealthCheckUrl = HealthCheckUrl;
            this.NotificationScope = NotificationScope;
            // use default value if no "Status" provided
            if (Status == null)
            {
                this.Status = "INACTIVE";
            }
            else
            {
                this.Status = Status;
            }
            this.Name = Name;
            this.Description = Description;
            this.RetryPolicy = RetryPolicy;
            this.SecurityPolicy = SecurityPolicy;
            this.CreatedOn = CreatedOn;
            this.UpdatedOn = UpdatedOn;
            this.AdditionalAttributes = AdditionalAttributes;
        }
        
        /// <summary>
        /// Webhook Id. This is generated by the server.
        /// </summary>
        /// <value>Webhook Id. This is generated by the server.</value>
        [DataMember(Name="webhookId", EmitDefaultValue=false)]
        public string WebhookId { get; set; }

        /// <summary>
        /// Organization ID
        /// </summary>
        /// <value>Organization ID</value>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// The product you are receiving a webhook for.
        /// </summary>
        /// <value>The product you are receiving a webhook for.</value>
        [DataMember(Name="productId", EmitDefaultValue=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// Array of the different events for a given product id.
        /// </summary>
        /// <value>Array of the different events for a given product id.</value>
        [DataMember(Name="eventTypes", EmitDefaultValue=false)]
        public List<string> EventTypes { get; set; }

        /// <summary>
        /// The client&#39;s endpoint (URL) to receive webhooks.
        /// </summary>
        /// <value>The client&#39;s endpoint (URL) to receive webhooks.</value>
        [DataMember(Name="webhookUrl", EmitDefaultValue=false)]
        public string WebhookUrl { get; set; }

        /// <summary>
        /// The client&#39;s health check endpoint (URL). This should be as close as possible to the actual webhookUrl.
        /// </summary>
        /// <value>The client&#39;s health check endpoint (URL). This should be as close as possible to the actual webhookUrl.</value>
        [DataMember(Name="healthCheckUrl", EmitDefaultValue=false)]
        public string HealthCheckUrl { get; set; }

        /// <summary>
        /// Gets or Sets NotificationScope
        /// </summary>
        [DataMember(Name="notificationScope", EmitDefaultValue=false)]
        public Notificationsubscriptionsv1webhooksNotificationScope NotificationScope { get; set; }

        /// <summary>
        /// Webhook status.
        /// </summary>
        /// <value>Webhook status.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Client friendly webhook name.
        /// </summary>
        /// <value>Client friendly webhook name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Client friendly webhook description.
        /// </summary>
        /// <value>Client friendly webhook description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets RetryPolicy
        /// </summary>
        [DataMember(Name="retryPolicy", EmitDefaultValue=false)]
        public Notificationsubscriptionsv1webhooksRetryPolicy RetryPolicy { get; set; }

        /// <summary>
        /// Gets or Sets SecurityPolicy
        /// </summary>
        [DataMember(Name="securityPolicy", EmitDefaultValue=false)]
        public Notificationsubscriptionsv1webhooksSecurityPolicy SecurityPolicy { get; set; }

        /// <summary>
        /// Date on which webhook was created/registered.
        /// </summary>
        /// <value>Date on which webhook was created/registered.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public string CreatedOn { get; set; }

        /// <summary>
        /// Date on which webhook was most recently updated.
        /// </summary>
        /// <value>Date on which webhook was most recently updated.</value>
        [DataMember(Name="updatedOn", EmitDefaultValue=false)]
        public string UpdatedOn { get; set; }

        /// <summary>
        /// Additional, free form configuration data.
        /// </summary>
        /// <value>Additional, free form configuration data.</value>
        [DataMember(Name="additionalAttributes", EmitDefaultValue=false)]
        public List<Dictionary<string, string>> AdditionalAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2013 {\n");
            sb.Append("  WebhookId: ").Append(WebhookId).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  EventTypes: ").Append(EventTypes).Append("\n");
            sb.Append("  WebhookUrl: ").Append(WebhookUrl).Append("\n");
            sb.Append("  HealthCheckUrl: ").Append(HealthCheckUrl).Append("\n");
            sb.Append("  NotificationScope: ").Append(NotificationScope).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RetryPolicy: ").Append(RetryPolicy).Append("\n");
            sb.Append("  SecurityPolicy: ").Append(SecurityPolicy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  AdditionalAttributes: ").Append(AdditionalAttributes).Append("\n");
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
            return this.Equals(obj as InlineResponse2013);
        }

        /// <summary>
        /// Returns true if InlineResponse2013 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2013 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2013 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.WebhookId == other.WebhookId ||
                    this.WebhookId != null &&
                    this.WebhookId.Equals(other.WebhookId)
                ) && 
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) && 
                (
                    this.ProductId == other.ProductId ||
                    this.ProductId != null &&
                    this.ProductId.Equals(other.ProductId)
                ) && 
                (
                    this.EventTypes == other.EventTypes ||
                    this.EventTypes != null &&
                    this.EventTypes.SequenceEqual(other.EventTypes)
                ) && 
                (
                    this.WebhookUrl == other.WebhookUrl ||
                    this.WebhookUrl != null &&
                    this.WebhookUrl.Equals(other.WebhookUrl)
                ) && 
                (
                    this.HealthCheckUrl == other.HealthCheckUrl ||
                    this.HealthCheckUrl != null &&
                    this.HealthCheckUrl.Equals(other.HealthCheckUrl)
                ) && 
                (
                    this.NotificationScope == other.NotificationScope ||
                    this.NotificationScope != null &&
                    this.NotificationScope.Equals(other.NotificationScope)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.RetryPolicy == other.RetryPolicy ||
                    this.RetryPolicy != null &&
                    this.RetryPolicy.Equals(other.RetryPolicy)
                ) && 
                (
                    this.SecurityPolicy == other.SecurityPolicy ||
                    this.SecurityPolicy != null &&
                    this.SecurityPolicy.Equals(other.SecurityPolicy)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.UpdatedOn == other.UpdatedOn ||
                    this.UpdatedOn != null &&
                    this.UpdatedOn.Equals(other.UpdatedOn)
                ) && 
                (
                    this.AdditionalAttributes == other.AdditionalAttributes ||
                    this.AdditionalAttributes != null &&
                    this.AdditionalAttributes.SequenceEqual(other.AdditionalAttributes)
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
                if (this.WebhookId != null)
                    hash = hash * 59 + this.WebhookId.GetHashCode();
                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();
                if (this.ProductId != null)
                    hash = hash * 59 + this.ProductId.GetHashCode();
                if (this.EventTypes != null)
                    hash = hash * 59 + this.EventTypes.GetHashCode();
                if (this.WebhookUrl != null)
                    hash = hash * 59 + this.WebhookUrl.GetHashCode();
                if (this.HealthCheckUrl != null)
                    hash = hash * 59 + this.HealthCheckUrl.GetHashCode();
                if (this.NotificationScope != null)
                    hash = hash * 59 + this.NotificationScope.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.RetryPolicy != null)
                    hash = hash * 59 + this.RetryPolicy.GetHashCode();
                if (this.SecurityPolicy != null)
                    hash = hash * 59 + this.SecurityPolicy.GetHashCode();
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                if (this.UpdatedOn != null)
                    hash = hash * 59 + this.UpdatedOn.GetHashCode();
                if (this.AdditionalAttributes != null)
                    hash = hash * 59 + this.AdditionalAttributes.GetHashCode();
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
