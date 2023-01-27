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
    /// Ptsv1pushfundstransferSenderInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv1pushfundstransferSenderInformation :  IEquatable<Ptsv1pushfundstransferSenderInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv1pushfundstransferSenderInformation" /> class.
        /// </summary>
        /// <param name="Name">Name of sender.  Funds Disbursement  This value is the name of the originator sending the funds disbursement. .</param>
        /// <param name="FirstName">This field contains the first name of the entity funding the transaction. .</param>
        /// <param name="LastName">This field contains the last name of the entity funding the transaction. .</param>
        /// <param name="MiddleName">Supported only for Mastercard  transactions. This field contains the  middle name of the entity funding the transaction .</param>
        /// <param name="PostalCode">Sender’s postal code.  For USA, this must be a valid value of 5 digits or 5 digits hyphen 4 digits, for example &#39;63368&#39;, &#39;63368-5555&#39;. For other regions, this can be alphanumeric, length 1-10.  Required for FDCCompass. .</param>
        /// <param name="Address1">Street address of sender.  Funds Disbursement  This value is the address of the originator sending the funds disbursement.  Visa Platform Connect Required for transactions using business application id of AA, BI, PP, and WT. .</param>
        /// <param name="Address2">Used for additional address information. For example: Attention: Accounts Payable Optional field.  This field is supported for only Mastercard Send. .</param>
        /// <param name="Locality">The sender&#39;s city  Visa Platform Connect Required for transactions using business application id of AA, BI, PP, and WT. .</param>
        /// <param name="AdministrativeArea">Sender’s state. Use the State, Province, and Territory Codes for the United States and Canada.The sender&#39;s province, state or territory. Conditional, required if sender&#39;s country is USA or CAN. Must be uppercase alpha 2 or 3 character country subdivision code.  See https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf .</param>
        /// <param name="Country">Sender&#39;s country code. Use ISO Standard Alpha Country Codes.  https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf  Visa Platform Connect Required for transactions using business application id of AA, BI, PP, and WT.  Required for Mastercard Send .</param>
        /// <param name="VatRegistrationNumber">Customer&#39;s government-assigned tax identification number. .</param>
        /// <param name="DateOfBirth">Sender’s date of birth in YYYYMMDD format. .</param>
        /// <param name="PhoneNumber">Sender’s phone number. .</param>
        /// <param name="PaymentInformation">PaymentInformation.</param>
        /// <param name="ReferenceNumber">Reference number generated by you that uniquely identifies the sender. .</param>
        /// <param name="Account">Account.</param>
        /// <param name="PersonalIdentification">PersonalIdentification.</param>
        public Ptsv1pushfundstransferSenderInformation(string Name = default(string), string FirstName = default(string), string LastName = default(string), string MiddleName = default(string), string PostalCode = default(string), string Address1 = default(string), string Address2 = default(string), string Locality = default(string), string AdministrativeArea = default(string), string Country = default(string), string VatRegistrationNumber = default(string), string DateOfBirth = default(string), string PhoneNumber = default(string), Ptsv1pushfundstransferSenderInformationPaymentInformation PaymentInformation = default(Ptsv1pushfundstransferSenderInformationPaymentInformation), string ReferenceNumber = default(string), Ptsv1pushfundstransferSenderInformationAccount Account = default(Ptsv1pushfundstransferSenderInformationAccount), Ptsv1pushfundstransferSenderInformationPersonalIdentification PersonalIdentification = default(Ptsv1pushfundstransferSenderInformationPersonalIdentification))
        {
            this.Name = Name;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.MiddleName = MiddleName;
            this.PostalCode = PostalCode;
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.Locality = Locality;
            this.AdministrativeArea = AdministrativeArea;
            this.Country = Country;
            this.VatRegistrationNumber = VatRegistrationNumber;
            this.DateOfBirth = DateOfBirth;
            this.PhoneNumber = PhoneNumber;
            this.PaymentInformation = PaymentInformation;
            this.ReferenceNumber = ReferenceNumber;
            this.Account = Account;
            this.PersonalIdentification = PersonalIdentification;
        }
        
        /// <summary>
        /// Name of sender.  Funds Disbursement  This value is the name of the originator sending the funds disbursement. 
        /// </summary>
        /// <value>Name of sender.  Funds Disbursement  This value is the name of the originator sending the funds disbursement. </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// This field contains the first name of the entity funding the transaction. 
        /// </summary>
        /// <value>This field contains the first name of the entity funding the transaction. </value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// This field contains the last name of the entity funding the transaction. 
        /// </summary>
        /// <value>This field contains the last name of the entity funding the transaction. </value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Supported only for Mastercard  transactions. This field contains the  middle name of the entity funding the transaction 
        /// </summary>
        /// <value>Supported only for Mastercard  transactions. This field contains the  middle name of the entity funding the transaction </value>
        [DataMember(Name="middleName", EmitDefaultValue=false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Sender’s postal code.  For USA, this must be a valid value of 5 digits or 5 digits hyphen 4 digits, for example &#39;63368&#39;, &#39;63368-5555&#39;. For other regions, this can be alphanumeric, length 1-10.  Required for FDCCompass. 
        /// </summary>
        /// <value>Sender’s postal code.  For USA, this must be a valid value of 5 digits or 5 digits hyphen 4 digits, for example &#39;63368&#39;, &#39;63368-5555&#39;. For other regions, this can be alphanumeric, length 1-10.  Required for FDCCompass. </value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Street address of sender.  Funds Disbursement  This value is the address of the originator sending the funds disbursement.  Visa Platform Connect Required for transactions using business application id of AA, BI, PP, and WT. 
        /// </summary>
        /// <value>Street address of sender.  Funds Disbursement  This value is the address of the originator sending the funds disbursement.  Visa Platform Connect Required for transactions using business application id of AA, BI, PP, and WT. </value>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Used for additional address information. For example: Attention: Accounts Payable Optional field.  This field is supported for only Mastercard Send. 
        /// </summary>
        /// <value>Used for additional address information. For example: Attention: Accounts Payable Optional field.  This field is supported for only Mastercard Send. </value>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }

        /// <summary>
        /// The sender&#39;s city  Visa Platform Connect Required for transactions using business application id of AA, BI, PP, and WT. 
        /// </summary>
        /// <value>The sender&#39;s city  Visa Platform Connect Required for transactions using business application id of AA, BI, PP, and WT. </value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// Sender’s state. Use the State, Province, and Territory Codes for the United States and Canada.The sender&#39;s province, state or territory. Conditional, required if sender&#39;s country is USA or CAN. Must be uppercase alpha 2 or 3 character country subdivision code.  See https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf 
        /// </summary>
        /// <value>Sender’s state. Use the State, Province, and Territory Codes for the United States and Canada.The sender&#39;s province, state or territory. Conditional, required if sender&#39;s country is USA or CAN. Must be uppercase alpha 2 or 3 character country subdivision code.  See https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf </value>
        [DataMember(Name="administrativeArea", EmitDefaultValue=false)]
        public string AdministrativeArea { get; set; }

        /// <summary>
        /// Sender&#39;s country code. Use ISO Standard Alpha Country Codes.  https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf  Visa Platform Connect Required for transactions using business application id of AA, BI, PP, and WT.  Required for Mastercard Send 
        /// </summary>
        /// <value>Sender&#39;s country code. Use ISO Standard Alpha Country Codes.  https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf  Visa Platform Connect Required for transactions using business application id of AA, BI, PP, and WT.  Required for Mastercard Send </value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Customer&#39;s government-assigned tax identification number. 
        /// </summary>
        /// <value>Customer&#39;s government-assigned tax identification number. </value>
        [DataMember(Name="vatRegistrationNumber", EmitDefaultValue=false)]
        public string VatRegistrationNumber { get; set; }

        /// <summary>
        /// Sender’s date of birth in YYYYMMDD format. 
        /// </summary>
        /// <value>Sender’s date of birth in YYYYMMDD format. </value>
        [DataMember(Name="dateOfBirth", EmitDefaultValue=false)]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Sender’s phone number. 
        /// </summary>
        /// <value>Sender’s phone number. </value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets PaymentInformation
        /// </summary>
        [DataMember(Name="paymentInformation", EmitDefaultValue=false)]
        public Ptsv1pushfundstransferSenderInformationPaymentInformation PaymentInformation { get; set; }

        /// <summary>
        /// Reference number generated by you that uniquely identifies the sender. 
        /// </summary>
        /// <value>Reference number generated by you that uniquely identifies the sender. </value>
        [DataMember(Name="referenceNumber", EmitDefaultValue=false)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public Ptsv1pushfundstransferSenderInformationAccount Account { get; set; }

        /// <summary>
        /// Gets or Sets PersonalIdentification
        /// </summary>
        [DataMember(Name="personalIdentification", EmitDefaultValue=false)]
        public Ptsv1pushfundstransferSenderInformationPersonalIdentification PersonalIdentification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv1pushfundstransferSenderInformation {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  AdministrativeArea: ").Append(AdministrativeArea).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  VatRegistrationNumber: ").Append(VatRegistrationNumber).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PaymentInformation: ").Append(PaymentInformation).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  PersonalIdentification: ").Append(PersonalIdentification).Append("\n");
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
            return this.Equals(obj as Ptsv1pushfundstransferSenderInformation);
        }

        /// <summary>
        /// Returns true if Ptsv1pushfundstransferSenderInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv1pushfundstransferSenderInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv1pushfundstransferSenderInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.MiddleName == other.MiddleName ||
                    this.MiddleName != null &&
                    this.MiddleName.Equals(other.MiddleName)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.Address1 == other.Address1 ||
                    this.Address1 != null &&
                    this.Address1.Equals(other.Address1)
                ) && 
                (
                    this.Address2 == other.Address2 ||
                    this.Address2 != null &&
                    this.Address2.Equals(other.Address2)
                ) && 
                (
                    this.Locality == other.Locality ||
                    this.Locality != null &&
                    this.Locality.Equals(other.Locality)
                ) && 
                (
                    this.AdministrativeArea == other.AdministrativeArea ||
                    this.AdministrativeArea != null &&
                    this.AdministrativeArea.Equals(other.AdministrativeArea)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.VatRegistrationNumber == other.VatRegistrationNumber ||
                    this.VatRegistrationNumber != null &&
                    this.VatRegistrationNumber.Equals(other.VatRegistrationNumber)
                ) && 
                (
                    this.DateOfBirth == other.DateOfBirth ||
                    this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(other.DateOfBirth)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.PaymentInformation == other.PaymentInformation ||
                    this.PaymentInformation != null &&
                    this.PaymentInformation.Equals(other.PaymentInformation)
                ) && 
                (
                    this.ReferenceNumber == other.ReferenceNumber ||
                    this.ReferenceNumber != null &&
                    this.ReferenceNumber.Equals(other.ReferenceNumber)
                ) && 
                (
                    this.Account == other.Account ||
                    this.Account != null &&
                    this.Account.Equals(other.Account)
                ) && 
                (
                    this.PersonalIdentification == other.PersonalIdentification ||
                    this.PersonalIdentification != null &&
                    this.PersonalIdentification.Equals(other.PersonalIdentification)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.MiddleName != null)
                    hash = hash * 59 + this.MiddleName.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.Address1 != null)
                    hash = hash * 59 + this.Address1.GetHashCode();
                if (this.Address2 != null)
                    hash = hash * 59 + this.Address2.GetHashCode();
                if (this.Locality != null)
                    hash = hash * 59 + this.Locality.GetHashCode();
                if (this.AdministrativeArea != null)
                    hash = hash * 59 + this.AdministrativeArea.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.VatRegistrationNumber != null)
                    hash = hash * 59 + this.VatRegistrationNumber.GetHashCode();
                if (this.DateOfBirth != null)
                    hash = hash * 59 + this.DateOfBirth.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.PaymentInformation != null)
                    hash = hash * 59 + this.PaymentInformation.GetHashCode();
                if (this.ReferenceNumber != null)
                    hash = hash * 59 + this.ReferenceNumber.GetHashCode();
                if (this.Account != null)
                    hash = hash * 59 + this.Account.GetHashCode();
                if (this.PersonalIdentification != null)
                    hash = hash * 59 + this.PersonalIdentification.GetHashCode();
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
