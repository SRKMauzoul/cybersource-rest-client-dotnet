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
    /// PtsV2PaymentsPost201Response
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201Response :  IEquatable<PtsV2PaymentsPost201Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201Response" /> class.
        /// </summary>
        /// <param name="Links">Links.</param>
        /// <param name="Id">An unique identification number assigned by CyberSource to identify the submitted request. It is also appended to the endpoint of the resource.  On incremental authorizations, this value with be the same as the identification number returned in the original authorization response. .</param>
        /// <param name="SubmitTimeUtc">Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; Example &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC. .</param>
        /// <param name="Status">The status of the submitted transaction.  Possible values:  - AUTHORIZED  - PARTIAL_AUTHORIZED  - AUTHORIZED_PENDING_REVIEW  - DECLINED  - INVALID_REQUEST .</param>
        /// <param name="ReconciliationId">The reconciliation id for the submitted transaction. This value is not returned for all processors. .</param>
        /// <param name="ErrorInformation">ErrorInformation.</param>
        /// <param name="ClientReferenceInformation">ClientReferenceInformation.</param>
        /// <param name="ProcessingInformation">ProcessingInformation.</param>
        /// <param name="ProcessorInformation">ProcessorInformation.</param>
        /// <param name="IssuerInformation">IssuerInformation.</param>
        /// <param name="PaymentInformation">PaymentInformation.</param>
        /// <param name="OrderInformation">OrderInformation.</param>
        /// <param name="PointOfSaleInformation">PointOfSaleInformation.</param>
        /// <param name="InstallmentInformation">InstallmentInformation.</param>
        /// <param name="RiskInformation">RiskInformation.</param>
        /// <param name="ConsumerAuthenticationInformation">ConsumerAuthenticationInformation.</param>
        public PtsV2PaymentsPost201Response(PtsV2PaymentsPost201ResponseLinks Links = default(PtsV2PaymentsPost201ResponseLinks), string Id = default(string), string SubmitTimeUtc = default(string), string Status = default(string), string ReconciliationId = default(string), PtsV2PaymentsPost201ResponseErrorInformation ErrorInformation = default(PtsV2PaymentsPost201ResponseErrorInformation), PtsV2PaymentsPost201ResponseClientReferenceInformation ClientReferenceInformation = default(PtsV2PaymentsPost201ResponseClientReferenceInformation), PtsV2PaymentsPost201ResponseProcessingInformation ProcessingInformation = default(PtsV2PaymentsPost201ResponseProcessingInformation), PtsV2PaymentsPost201ResponseProcessorInformation ProcessorInformation = default(PtsV2PaymentsPost201ResponseProcessorInformation), PtsV2PaymentsPost201ResponseIssuerInformation IssuerInformation = default(PtsV2PaymentsPost201ResponseIssuerInformation), PtsV2PaymentsPost201ResponsePaymentInformation PaymentInformation = default(PtsV2PaymentsPost201ResponsePaymentInformation), PtsV2PaymentsPost201ResponseOrderInformation OrderInformation = default(PtsV2PaymentsPost201ResponseOrderInformation), PtsV2PaymentsPost201ResponsePointOfSaleInformation PointOfSaleInformation = default(PtsV2PaymentsPost201ResponsePointOfSaleInformation), PtsV2PaymentsPost201ResponseInstallmentInformation InstallmentInformation = default(PtsV2PaymentsPost201ResponseInstallmentInformation), PtsV2PaymentsPost201ResponseRiskInformation RiskInformation = default(PtsV2PaymentsPost201ResponseRiskInformation), PtsV2PaymentsPost201ResponseConsumerAuthenticationInformation ConsumerAuthenticationInformation = default(PtsV2PaymentsPost201ResponseConsumerAuthenticationInformation))
        {
            this.Links = Links;
            this.Id = Id;
            this.SubmitTimeUtc = SubmitTimeUtc;
            this.Status = Status;
            this.ReconciliationId = ReconciliationId;
            this.ErrorInformation = ErrorInformation;
            this.ClientReferenceInformation = ClientReferenceInformation;
            this.ProcessingInformation = ProcessingInformation;
            this.ProcessorInformation = ProcessorInformation;
            this.IssuerInformation = IssuerInformation;
            this.PaymentInformation = PaymentInformation;
            this.OrderInformation = OrderInformation;
            this.PointOfSaleInformation = PointOfSaleInformation;
            this.InstallmentInformation = InstallmentInformation;
            this.RiskInformation = RiskInformation;
            this.ConsumerAuthenticationInformation = ConsumerAuthenticationInformation;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseLinks Links { get; set; }

        /// <summary>
        /// An unique identification number assigned by CyberSource to identify the submitted request. It is also appended to the endpoint of the resource.  On incremental authorizations, this value with be the same as the identification number returned in the original authorization response. 
        /// </summary>
        /// <value>An unique identification number assigned by CyberSource to identify the submitted request. It is also appended to the endpoint of the resource.  On incremental authorizations, this value with be the same as the identification number returned in the original authorization response. </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; Example &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC. 
        /// </summary>
        /// <value>Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; Example &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC. </value>
        [DataMember(Name="submitTimeUtc", EmitDefaultValue=false)]
        public string SubmitTimeUtc { get; set; }

        /// <summary>
        /// The status of the submitted transaction.  Possible values:  - AUTHORIZED  - PARTIAL_AUTHORIZED  - AUTHORIZED_PENDING_REVIEW  - DECLINED  - INVALID_REQUEST 
        /// </summary>
        /// <value>The status of the submitted transaction.  Possible values:  - AUTHORIZED  - PARTIAL_AUTHORIZED  - AUTHORIZED_PENDING_REVIEW  - DECLINED  - INVALID_REQUEST </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// The reconciliation id for the submitted transaction. This value is not returned for all processors. 
        /// </summary>
        /// <value>The reconciliation id for the submitted transaction. This value is not returned for all processors. </value>
        [DataMember(Name="reconciliationId", EmitDefaultValue=false)]
        public string ReconciliationId { get; set; }

        /// <summary>
        /// Gets or Sets ErrorInformation
        /// </summary>
        [DataMember(Name="errorInformation", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseErrorInformation ErrorInformation { get; set; }

        /// <summary>
        /// Gets or Sets ClientReferenceInformation
        /// </summary>
        [DataMember(Name="clientReferenceInformation", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseClientReferenceInformation ClientReferenceInformation { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingInformation
        /// </summary>
        [DataMember(Name="processingInformation", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseProcessingInformation ProcessingInformation { get; set; }

        /// <summary>
        /// Gets or Sets ProcessorInformation
        /// </summary>
        [DataMember(Name="processorInformation", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseProcessorInformation ProcessorInformation { get; set; }

        /// <summary>
        /// Gets or Sets IssuerInformation
        /// </summary>
        [DataMember(Name="issuerInformation", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseIssuerInformation IssuerInformation { get; set; }

        /// <summary>
        /// Gets or Sets PaymentInformation
        /// </summary>
        [DataMember(Name="paymentInformation", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponsePaymentInformation PaymentInformation { get; set; }

        /// <summary>
        /// Gets or Sets OrderInformation
        /// </summary>
        [DataMember(Name="orderInformation", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseOrderInformation OrderInformation { get; set; }

        /// <summary>
        /// Gets or Sets PointOfSaleInformation
        /// </summary>
        [DataMember(Name="pointOfSaleInformation", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponsePointOfSaleInformation PointOfSaleInformation { get; set; }

        /// <summary>
        /// Gets or Sets InstallmentInformation
        /// </summary>
        [DataMember(Name="installmentInformation", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseInstallmentInformation InstallmentInformation { get; set; }

        /// <summary>
        /// Gets or Sets RiskInformation
        /// </summary>
        [DataMember(Name="riskInformation", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseRiskInformation RiskInformation { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerAuthenticationInformation
        /// </summary>
        [DataMember(Name="consumerAuthenticationInformation", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseConsumerAuthenticationInformation ConsumerAuthenticationInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201Response {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SubmitTimeUtc: ").Append(SubmitTimeUtc).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ReconciliationId: ").Append(ReconciliationId).Append("\n");
            sb.Append("  ErrorInformation: ").Append(ErrorInformation).Append("\n");
            sb.Append("  ClientReferenceInformation: ").Append(ClientReferenceInformation).Append("\n");
            sb.Append("  ProcessingInformation: ").Append(ProcessingInformation).Append("\n");
            sb.Append("  ProcessorInformation: ").Append(ProcessorInformation).Append("\n");
            sb.Append("  IssuerInformation: ").Append(IssuerInformation).Append("\n");
            sb.Append("  PaymentInformation: ").Append(PaymentInformation).Append("\n");
            sb.Append("  OrderInformation: ").Append(OrderInformation).Append("\n");
            sb.Append("  PointOfSaleInformation: ").Append(PointOfSaleInformation).Append("\n");
            sb.Append("  InstallmentInformation: ").Append(InstallmentInformation).Append("\n");
            sb.Append("  RiskInformation: ").Append(RiskInformation).Append("\n");
            sb.Append("  ConsumerAuthenticationInformation: ").Append(ConsumerAuthenticationInformation).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsPost201Response);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201Response instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201Response other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.SubmitTimeUtc == other.SubmitTimeUtc ||
                    this.SubmitTimeUtc != null &&
                    this.SubmitTimeUtc.Equals(other.SubmitTimeUtc)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.ReconciliationId == other.ReconciliationId ||
                    this.ReconciliationId != null &&
                    this.ReconciliationId.Equals(other.ReconciliationId)
                ) && 
                (
                    this.ErrorInformation == other.ErrorInformation ||
                    this.ErrorInformation != null &&
                    this.ErrorInformation.Equals(other.ErrorInformation)
                ) && 
                (
                    this.ClientReferenceInformation == other.ClientReferenceInformation ||
                    this.ClientReferenceInformation != null &&
                    this.ClientReferenceInformation.Equals(other.ClientReferenceInformation)
                ) && 
                (
                    this.ProcessingInformation == other.ProcessingInformation ||
                    this.ProcessingInformation != null &&
                    this.ProcessingInformation.Equals(other.ProcessingInformation)
                ) && 
                (
                    this.ProcessorInformation == other.ProcessorInformation ||
                    this.ProcessorInformation != null &&
                    this.ProcessorInformation.Equals(other.ProcessorInformation)
                ) && 
                (
                    this.IssuerInformation == other.IssuerInformation ||
                    this.IssuerInformation != null &&
                    this.IssuerInformation.Equals(other.IssuerInformation)
                ) && 
                (
                    this.PaymentInformation == other.PaymentInformation ||
                    this.PaymentInformation != null &&
                    this.PaymentInformation.Equals(other.PaymentInformation)
                ) && 
                (
                    this.OrderInformation == other.OrderInformation ||
                    this.OrderInformation != null &&
                    this.OrderInformation.Equals(other.OrderInformation)
                ) && 
                (
                    this.PointOfSaleInformation == other.PointOfSaleInformation ||
                    this.PointOfSaleInformation != null &&
                    this.PointOfSaleInformation.Equals(other.PointOfSaleInformation)
                ) && 
                (
                    this.InstallmentInformation == other.InstallmentInformation ||
                    this.InstallmentInformation != null &&
                    this.InstallmentInformation.Equals(other.InstallmentInformation)
                ) && 
                (
                    this.RiskInformation == other.RiskInformation ||
                    this.RiskInformation != null &&
                    this.RiskInformation.Equals(other.RiskInformation)
                ) && 
                (
                    this.ConsumerAuthenticationInformation == other.ConsumerAuthenticationInformation ||
                    this.ConsumerAuthenticationInformation != null &&
                    this.ConsumerAuthenticationInformation.Equals(other.ConsumerAuthenticationInformation)
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
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.SubmitTimeUtc != null)
                    hash = hash * 59 + this.SubmitTimeUtc.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.ReconciliationId != null)
                    hash = hash * 59 + this.ReconciliationId.GetHashCode();
                if (this.ErrorInformation != null)
                    hash = hash * 59 + this.ErrorInformation.GetHashCode();
                if (this.ClientReferenceInformation != null)
                    hash = hash * 59 + this.ClientReferenceInformation.GetHashCode();
                if (this.ProcessingInformation != null)
                    hash = hash * 59 + this.ProcessingInformation.GetHashCode();
                if (this.ProcessorInformation != null)
                    hash = hash * 59 + this.ProcessorInformation.GetHashCode();
                if (this.IssuerInformation != null)
                    hash = hash * 59 + this.IssuerInformation.GetHashCode();
                if (this.PaymentInformation != null)
                    hash = hash * 59 + this.PaymentInformation.GetHashCode();
                if (this.OrderInformation != null)
                    hash = hash * 59 + this.OrderInformation.GetHashCode();
                if (this.PointOfSaleInformation != null)
                    hash = hash * 59 + this.PointOfSaleInformation.GetHashCode();
                if (this.InstallmentInformation != null)
                    hash = hash * 59 + this.InstallmentInformation.GetHashCode();
                if (this.RiskInformation != null)
                    hash = hash * 59 + this.RiskInformation.GetHashCode();
                if (this.ConsumerAuthenticationInformation != null)
                    hash = hash * 59 + this.ConsumerAuthenticationInformation.GetHashCode();
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
            // Id (string) maxLength
            if(this.Id != null && this.Id.Length >= 26)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be less than or equal to 26.", new [] { "Id" });
            }

            // ReconciliationId (string) maxLength
            if(this.ReconciliationId != null && this.ReconciliationId.Length >= 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReconciliationId, length must be less than or equal to 60.", new [] { "ReconciliationId" });
            }

            yield break;
        }
    }

}
