using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DocuSign.eSign.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Tabs : IEquatable<Tabs>
    {
        
        /// <summary>
        /// A complex type the contains information about the tag that specifies where the recipient places their signature in the document. The \"optional\" parameter sets if the signature is required or optional.
        /// </summary>
        /// <value>A complex type the contains information about the tag that specifies where the recipient places their signature in the document. The \"optional\" parameter sets if the signature is required or optional.</value>
        [DataMember(Name="signHereTabs", EmitDefaultValue=false)]
        public List<SignHere> SignHereTabs { get; set; }
  
        
        /// <summary>
        /// Specifies a tag to have a recipient place their initials in the document. The \"optional\" parameter sets if the initials are required or optional.
        /// </summary>
        /// <value>Specifies a tag to have a recipient place their initials in the document. The \"optional\" parameter sets if the initials are required or optional.</value>
        [DataMember(Name="initialHereTabs", EmitDefaultValue=false)]
        public List<InitialHere> InitialHereTabs { get; set; }
  
        
        /// <summary>
        /// Specifies a tag on the document when you want the recipient to add supporting documents to an envelope.
        /// </summary>
        /// <value>Specifies a tag on the document when you want the recipient to add supporting documents to an envelope.</value>
        [DataMember(Name="signerAttachmentTabs", EmitDefaultValue=false)]
        public List<SignerAttachment> SignerAttachmentTabs { get; set; }
  
        
        /// <summary>
        /// Specifies a tag on the document where you want the recipient to approve documents in an envelope without placing a signature or initials on the document. If the recipient clicks the Approve tag during the signing process, the recipient is considered to have signed the document. No information is shown on the document for the approval, but it is recorded as a signature in the envelope history.
        /// </summary>
        /// <value>Specifies a tag on the document where you want the recipient to approve documents in an envelope without placing a signature or initials on the document. If the recipient clicks the Approve tag during the signing process, the recipient is considered to have signed the document. No information is shown on the document for the approval, but it is recorded as a signature in the envelope history.</value>
        [DataMember(Name="approveTabs", EmitDefaultValue=false)]
        public List<Approve> ApproveTabs { get; set; }
  
        
        /// <summary>
        /// Specifies a tag on the document where you want to give the recipient the option of declining an envelope. If the recipient clicks the Decline tag during the signing process, the envelope is voided.
        /// </summary>
        /// <value>Specifies a tag on the document where you want to give the recipient the option of declining an envelope. If the recipient clicks the Decline tag during the signing process, the envelope is voided.</value>
        [DataMember(Name="declineTabs", EmitDefaultValue=false)]
        public List<Decline> DeclineTabs { get; set; }
  
        
        /// <summary>
        /// Specifies a tag on the document where you want the recipient's name to appear.
        /// </summary>
        /// <value>Specifies a tag on the document where you want the recipient's name to appear.</value>
        [DataMember(Name="fullNameTabs", EmitDefaultValue=false)]
        public List<FullName> FullNameTabs { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="dateSignedTabs", EmitDefaultValue=false)]
        public List<DateSigned> DateSignedTabs { get; set; }
  
        
        /// <summary>
        /// Specifies a tag on the document where you want the envelope ID for to appear. Recipients cannot enter or change the information in this tab, it is for informational purposes only.
        /// </summary>
        /// <value>Specifies a tag on the document where you want the envelope ID for to appear. Recipients cannot enter or change the information in this tab, it is for informational purposes only.</value>
        [DataMember(Name="envelopeIdTabs", EmitDefaultValue=false)]
        public List<EnvelopeId> EnvelopeIdTabs { get; set; }
  
        
        /// <summary>
        /// Specifies a tag on the document where you want the recipient's company name to appear.\n\nWhen getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.
        /// </summary>
        /// <value>Specifies a tag on the document where you want the recipient's company name to appear.\n\nWhen getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.</value>
        [DataMember(Name="companyTabs", EmitDefaultValue=false)]
        public List<Company> CompanyTabs { get; set; }
  
        
        /// <summary>
        /// Specifies a tag on the document where you want the recipient's title to appear.\n\nWhen getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.
        /// </summary>
        /// <value>Specifies a tag on the document where you want the recipient's title to appear.\n\nWhen getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.</value>
        [DataMember(Name="titleTabs", EmitDefaultValue=false)]
        public List<Title> TitleTabs { get; set; }
  
        
        /// <summary>
        /// Specifies a that that is an adaptable field that allows the recipient to enter different text information.\n\nWhen getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.
        /// </summary>
        /// <value>Specifies a that that is an adaptable field that allows the recipient to enter different text information.\n\nWhen getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.</value>
        [DataMember(Name="textTabs", EmitDefaultValue=false)]
        public List<Text> TextTabs { get; set; }
  
        
        /// <summary>
        /// Specifies a tag on the document where you want the recipient to enter a number. It uses the same parameters as a Text tab, with the validation message and pattern set for number information.\n\nWhen getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.
        /// </summary>
        /// <value>Specifies a tag on the document where you want the recipient to enter a number. It uses the same parameters as a Text tab, with the validation message and pattern set for number information.\n\nWhen getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.</value>
        [DataMember(Name="numberTabs", EmitDefaultValue=false)]
        public List<double?> NumberTabs { get; set; }
  
        
        /// <summary>
        /// Specifies a tag on the document where you want the recipient to enter a Social Security Number (SSN). A SSN can be typed with or without dashes. It uses the same parameters as a Text tab, with the validation message and pattern set for SSN information.\n\nWhen getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.
        /// </summary>
        /// <value>Specifies a tag on the document where you want the recipient to enter a Social Security Number (SSN). A SSN can be typed with or without dashes. It uses the same parameters as a Text tab, with the validation message and pattern set for SSN information.\n\nWhen getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.</value>
        [DataMember(Name="ssnTabs", EmitDefaultValue=false)]
        public List<Ssn> SsnTabs { get; set; }
  
        
        /// <summary>
        /// Specifies a tab on the document where you want the recipient to enter a date. Date tabs are single-line fields that allow date information to be entered in any format. The tooltip for this tab recommends entering the date as MM/DD/YYYY, but this is not enforced. The format entered by the signer is retained. \n\nIf you need a particular date format enforced, DocuSign recommends using a Text tab with a Validation Pattern and Validation Message to enforce the format.
        /// </summary>
        /// <value>Specifies a tab on the document where you want the recipient to enter a date. Date tabs are single-line fields that allow date information to be entered in any format. The tooltip for this tab recommends entering the date as MM/DD/YYYY, but this is not enforced. The format entered by the signer is retained. \n\nIf you need a particular date format enforced, DocuSign recommends using a Text tab with a Validation Pattern and Validation Message to enforce the format.</value>
        [DataMember(Name="dateTabs", EmitDefaultValue=false)]
        public List<Date> DateTabs { get; set; }
  
        
        /// <summary>
        /// Specifies a tag on the document where you want the recipient to enter a ZIP code. The ZIP code can be a five numbers or the ZIP+4 format with nine numbers. The zip code can be typed with or without dashes. It uses the same parameters as a Text tab, with the validation message and pattern set for ZIP code information.\n\nWhen getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.
        /// </summary>
        /// <value>Specifies a tag on the document where you want the recipient to enter a ZIP code. The ZIP code can be a five numbers or the ZIP+4 format with nine numbers. The zip code can be typed with or without dashes. It uses the same parameters as a Text tab, with the validation message and pattern set for ZIP code information.\n\nWhen getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.</value>
        [DataMember(Name="zipTabs", EmitDefaultValue=false)]
        public List<Zip> ZipTabs { get; set; }
  
        
        /// <summary>
        /// Specifies a tag on the document where you want the recipient to enter an email. Email tags are single-line fields that accept any characters. The system checks that a valid email format (i.e. xxx@yyy.zzz) is entered in the tag. It uses the same parameters as a Text tab, with the validation message and pattern set for email information.\n\nWhen getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.
        /// </summary>
        /// <value>Specifies a tag on the document where you want the recipient to enter an email. Email tags are single-line fields that accept any characters. The system checks that a valid email format (i.e. xxx@yyy.zzz) is entered in the tag. It uses the same parameters as a Text tab, with the validation message and pattern set for email information.\n\nWhen getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.</value>
        [DataMember(Name="emailTabs", EmitDefaultValue=false)]
        public List<Email> EmailTabs { get; set; }
  
        
        /// <summary>
        /// Specifies a tag on the document where you want to place additional information, in the form of a note, on a document for a recipient.
        /// </summary>
        /// <value>Specifies a tag on the document where you want to place additional information, in the form of a note, on a document for a recipient.</value>
        [DataMember(Name="noteTabs", EmitDefaultValue=false)]
        public List<Note> NoteTabs { get; set; }
  
        
        /// <summary>
        /// Specifies a tag on the document in a location where the recipient can select an option.
        /// </summary>
        /// <value>Specifies a tag on the document in a location where the recipient can select an option.</value>
        [DataMember(Name="checkboxTabs", EmitDefaultValue=false)]
        public List<Checkbox> CheckboxTabs { get; set; }
  
        
        /// <summary>
        /// Specifies a tag on the document in a location where the recipient can select one option from a group of options using a radio button. The radio buttons do not have to be on the same page in a document.
        /// </summary>
        /// <value>Specifies a tag on the document in a location where the recipient can select one option from a group of options using a radio button. The radio buttons do not have to be on the same page in a document.</value>
        [DataMember(Name="radioGroupTabs", EmitDefaultValue=false)]
        public List<RadioGroup> RadioGroupTabs { get; set; }
  
        
        /// <summary>
        /// Specify this tag to give your recipient a list of options, presented as a drop-down list, from which they can select.
        /// </summary>
        /// <value>Specify this tag to give your recipient a list of options, presented as a drop-down list, from which they can select.</value>
        [DataMember(Name="listTabs", EmitDefaultValue=false)]
        public List<List> ListTabs { get; set; }
  
        
        /// <summary>
        /// Specifies tag on a document where you want the recipient's first name to appear. This tag takes the recipient's name, as entered in the recipient information, splits it into sections based on spaces and uses the first section as the first name.
        /// </summary>
        /// <value>Specifies tag on a document where you want the recipient's first name to appear. This tag takes the recipient's name, as entered in the recipient information, splits it into sections based on spaces and uses the first section as the first name.</value>
        [DataMember(Name="firstNameTabs", EmitDefaultValue=false)]
        public List<FirstName> FirstNameTabs { get; set; }
  
        
        /// <summary>
        /// Specifies a tag on a document where you want the recipient’s last name to appear. This tag takes the recipient’s name, as entered in the recipient information, splits it into sections based on spaces and uses the last section as the last name.
        /// </summary>
        /// <value>Specifies a tag on a document where you want the recipient’s last name to appear. This tag takes the recipient’s name, as entered in the recipient information, splits it into sections based on spaces and uses the last section as the last name.</value>
        [DataMember(Name="lastNameTabs", EmitDefaultValue=false)]
        public List<LastName> LastNameTabs { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="emailAddressTabs", EmitDefaultValue=false)]
        public List<EmailAddress> EmailAddressTabs { get; set; }
  
        
        /// <summary>
        /// Specifies a tag that is used to add a calculated field to a document. Envelope recipients cannot directly enter information into the tag; the formula tab calculates and displays a new value when changes are made to the reference tag values. The reference tag information and calculation operations are entered in the \"formula\" element. See the [ML:Using the Calculated Fields Feature] quick start guide or [ML:DocuSign Service User Guide] for more information about formulas.
        /// </summary>
        /// <value>Specifies a tag that is used to add a calculated field to a document. Envelope recipients cannot directly enter information into the tag; the formula tab calculates and displays a new value when changes are made to the reference tag values. The reference tag information and calculation operations are entered in the \"formula\" element. See the [ML:Using the Calculated Fields Feature] quick start guide or [ML:DocuSign Service User Guide] for more information about formulas.</value>
        [DataMember(Name="formulaTabs", EmitDefaultValue=false)]
        public List<FormulaTab> FormulaTabs { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tabs {\n");
            sb.Append("  SignHereTabs: ").Append(SignHereTabs).Append("\n");
            sb.Append("  InitialHereTabs: ").Append(InitialHereTabs).Append("\n");
            sb.Append("  SignerAttachmentTabs: ").Append(SignerAttachmentTabs).Append("\n");
            sb.Append("  ApproveTabs: ").Append(ApproveTabs).Append("\n");
            sb.Append("  DeclineTabs: ").Append(DeclineTabs).Append("\n");
            sb.Append("  FullNameTabs: ").Append(FullNameTabs).Append("\n");
            sb.Append("  DateSignedTabs: ").Append(DateSignedTabs).Append("\n");
            sb.Append("  EnvelopeIdTabs: ").Append(EnvelopeIdTabs).Append("\n");
            sb.Append("  CompanyTabs: ").Append(CompanyTabs).Append("\n");
            sb.Append("  TitleTabs: ").Append(TitleTabs).Append("\n");
            sb.Append("  TextTabs: ").Append(TextTabs).Append("\n");
            sb.Append("  NumberTabs: ").Append(NumberTabs).Append("\n");
            sb.Append("  SsnTabs: ").Append(SsnTabs).Append("\n");
            sb.Append("  DateTabs: ").Append(DateTabs).Append("\n");
            sb.Append("  ZipTabs: ").Append(ZipTabs).Append("\n");
            sb.Append("  EmailTabs: ").Append(EmailTabs).Append("\n");
            sb.Append("  NoteTabs: ").Append(NoteTabs).Append("\n");
            sb.Append("  CheckboxTabs: ").Append(CheckboxTabs).Append("\n");
            sb.Append("  RadioGroupTabs: ").Append(RadioGroupTabs).Append("\n");
            sb.Append("  ListTabs: ").Append(ListTabs).Append("\n");
            sb.Append("  FirstNameTabs: ").Append(FirstNameTabs).Append("\n");
            sb.Append("  LastNameTabs: ").Append(LastNameTabs).Append("\n");
            sb.Append("  EmailAddressTabs: ").Append(EmailAddressTabs).Append("\n");
            sb.Append("  FormulaTabs: ").Append(FormulaTabs).Append("\n");
            
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
            return this.Equals(obj as Tabs);
        }

        /// <summary>
        /// Returns true if Tabs instances are equal
        /// </summary>
        /// <param name="other">Instance of Tabs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tabs other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SignHereTabs == other.SignHereTabs ||
                    this.SignHereTabs != null &&
                    this.SignHereTabs.SequenceEqual(other.SignHereTabs)
                ) && 
                (
                    this.InitialHereTabs == other.InitialHereTabs ||
                    this.InitialHereTabs != null &&
                    this.InitialHereTabs.SequenceEqual(other.InitialHereTabs)
                ) && 
                (
                    this.SignerAttachmentTabs == other.SignerAttachmentTabs ||
                    this.SignerAttachmentTabs != null &&
                    this.SignerAttachmentTabs.SequenceEqual(other.SignerAttachmentTabs)
                ) && 
                (
                    this.ApproveTabs == other.ApproveTabs ||
                    this.ApproveTabs != null &&
                    this.ApproveTabs.SequenceEqual(other.ApproveTabs)
                ) && 
                (
                    this.DeclineTabs == other.DeclineTabs ||
                    this.DeclineTabs != null &&
                    this.DeclineTabs.SequenceEqual(other.DeclineTabs)
                ) && 
                (
                    this.FullNameTabs == other.FullNameTabs ||
                    this.FullNameTabs != null &&
                    this.FullNameTabs.SequenceEqual(other.FullNameTabs)
                ) && 
                (
                    this.DateSignedTabs == other.DateSignedTabs ||
                    this.DateSignedTabs != null &&
                    this.DateSignedTabs.SequenceEqual(other.DateSignedTabs)
                ) && 
                (
                    this.EnvelopeIdTabs == other.EnvelopeIdTabs ||
                    this.EnvelopeIdTabs != null &&
                    this.EnvelopeIdTabs.SequenceEqual(other.EnvelopeIdTabs)
                ) && 
                (
                    this.CompanyTabs == other.CompanyTabs ||
                    this.CompanyTabs != null &&
                    this.CompanyTabs.SequenceEqual(other.CompanyTabs)
                ) && 
                (
                    this.TitleTabs == other.TitleTabs ||
                    this.TitleTabs != null &&
                    this.TitleTabs.SequenceEqual(other.TitleTabs)
                ) && 
                (
                    this.TextTabs == other.TextTabs ||
                    this.TextTabs != null &&
                    this.TextTabs.SequenceEqual(other.TextTabs)
                ) && 
                (
                    this.NumberTabs == other.NumberTabs ||
                    this.NumberTabs != null &&
                    this.NumberTabs.SequenceEqual(other.NumberTabs)
                ) && 
                (
                    this.SsnTabs == other.SsnTabs ||
                    this.SsnTabs != null &&
                    this.SsnTabs.SequenceEqual(other.SsnTabs)
                ) && 
                (
                    this.DateTabs == other.DateTabs ||
                    this.DateTabs != null &&
                    this.DateTabs.SequenceEqual(other.DateTabs)
                ) && 
                (
                    this.ZipTabs == other.ZipTabs ||
                    this.ZipTabs != null &&
                    this.ZipTabs.SequenceEqual(other.ZipTabs)
                ) && 
                (
                    this.EmailTabs == other.EmailTabs ||
                    this.EmailTabs != null &&
                    this.EmailTabs.SequenceEqual(other.EmailTabs)
                ) && 
                (
                    this.NoteTabs == other.NoteTabs ||
                    this.NoteTabs != null &&
                    this.NoteTabs.SequenceEqual(other.NoteTabs)
                ) && 
                (
                    this.CheckboxTabs == other.CheckboxTabs ||
                    this.CheckboxTabs != null &&
                    this.CheckboxTabs.SequenceEqual(other.CheckboxTabs)
                ) && 
                (
                    this.RadioGroupTabs == other.RadioGroupTabs ||
                    this.RadioGroupTabs != null &&
                    this.RadioGroupTabs.SequenceEqual(other.RadioGroupTabs)
                ) && 
                (
                    this.ListTabs == other.ListTabs ||
                    this.ListTabs != null &&
                    this.ListTabs.SequenceEqual(other.ListTabs)
                ) && 
                (
                    this.FirstNameTabs == other.FirstNameTabs ||
                    this.FirstNameTabs != null &&
                    this.FirstNameTabs.SequenceEqual(other.FirstNameTabs)
                ) && 
                (
                    this.LastNameTabs == other.LastNameTabs ||
                    this.LastNameTabs != null &&
                    this.LastNameTabs.SequenceEqual(other.LastNameTabs)
                ) && 
                (
                    this.EmailAddressTabs == other.EmailAddressTabs ||
                    this.EmailAddressTabs != null &&
                    this.EmailAddressTabs.SequenceEqual(other.EmailAddressTabs)
                ) && 
                (
                    this.FormulaTabs == other.FormulaTabs ||
                    this.FormulaTabs != null &&
                    this.FormulaTabs.SequenceEqual(other.FormulaTabs)
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
                
                if (this.SignHereTabs != null)
                    hash = hash * 57 + this.SignHereTabs.GetHashCode();
                
                if (this.InitialHereTabs != null)
                    hash = hash * 57 + this.InitialHereTabs.GetHashCode();
                
                if (this.SignerAttachmentTabs != null)
                    hash = hash * 57 + this.SignerAttachmentTabs.GetHashCode();
                
                if (this.ApproveTabs != null)
                    hash = hash * 57 + this.ApproveTabs.GetHashCode();
                
                if (this.DeclineTabs != null)
                    hash = hash * 57 + this.DeclineTabs.GetHashCode();
                
                if (this.FullNameTabs != null)
                    hash = hash * 57 + this.FullNameTabs.GetHashCode();
                
                if (this.DateSignedTabs != null)
                    hash = hash * 57 + this.DateSignedTabs.GetHashCode();
                
                if (this.EnvelopeIdTabs != null)
                    hash = hash * 57 + this.EnvelopeIdTabs.GetHashCode();
                
                if (this.CompanyTabs != null)
                    hash = hash * 57 + this.CompanyTabs.GetHashCode();
                
                if (this.TitleTabs != null)
                    hash = hash * 57 + this.TitleTabs.GetHashCode();
                
                if (this.TextTabs != null)
                    hash = hash * 57 + this.TextTabs.GetHashCode();
                
                if (this.NumberTabs != null)
                    hash = hash * 57 + this.NumberTabs.GetHashCode();
                
                if (this.SsnTabs != null)
                    hash = hash * 57 + this.SsnTabs.GetHashCode();
                
                if (this.DateTabs != null)
                    hash = hash * 57 + this.DateTabs.GetHashCode();
                
                if (this.ZipTabs != null)
                    hash = hash * 57 + this.ZipTabs.GetHashCode();
                
                if (this.EmailTabs != null)
                    hash = hash * 57 + this.EmailTabs.GetHashCode();
                
                if (this.NoteTabs != null)
                    hash = hash * 57 + this.NoteTabs.GetHashCode();
                
                if (this.CheckboxTabs != null)
                    hash = hash * 57 + this.CheckboxTabs.GetHashCode();
                
                if (this.RadioGroupTabs != null)
                    hash = hash * 57 + this.RadioGroupTabs.GetHashCode();
                
                if (this.ListTabs != null)
                    hash = hash * 57 + this.ListTabs.GetHashCode();
                
                if (this.FirstNameTabs != null)
                    hash = hash * 57 + this.FirstNameTabs.GetHashCode();
                
                if (this.LastNameTabs != null)
                    hash = hash * 57 + this.LastNameTabs.GetHashCode();
                
                if (this.EmailAddressTabs != null)
                    hash = hash * 57 + this.EmailAddressTabs.GetHashCode();
                
                if (this.FormulaTabs != null)
                    hash = hash * 57 + this.FormulaTabs.GetHashCode();
                
                return hash;
            }
        }

    }
}
