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
    public class AccountInformation : IEquatable<AccountInformation>
    {
        
        /// <summary>
        /// Identifies the plan that was used create this account.
        /// </summary>
        /// <value>Identifies the plan that was used create this account.</value>
        [DataMember(Name="currentPlanId", EmitDefaultValue=false)]
        public string CurrentPlanId { get; set; }
  
        
        /// <summary>
        /// The name of the Billing Plan.
        /// </summary>
        /// <value>The name of the Billing Plan.</value>
        [DataMember(Name="planName", EmitDefaultValue=false)]
        public string PlanName { get; set; }
  
        
        /// <summary>
        /// Identifies the type of plan. Examples include Business, Corporate, Enterprise, Free.
        /// </summary>
        /// <value>Identifies the type of plan. Examples include Business, Corporate, Enterprise, Free.</value>
        [DataMember(Name="planClassification", EmitDefaultValue=false)]
        public string PlanClassification { get; set; }
  
        
        /// <summary>
        /// The date that the Account started using the current plan.
        /// </summary>
        /// <value>The date that the Account started using the current plan.</value>
        [DataMember(Name="planStartDate", EmitDefaultValue=false)]
        public string PlanStartDate { get; set; }
  
        
        /// <summary>
        /// The date that the current plan will end.
        /// </summary>
        /// <value>The date that the current plan will end.</value>
        [DataMember(Name="planEndDate", EmitDefaultValue=false)]
        public string PlanEndDate { get; set; }
  
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="billingPeriodStartDate", EmitDefaultValue=false)]
        public string BillingPeriodStartDate { get; set; }
  
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="billingPeriodEndDate", EmitDefaultValue=false)]
        public string BillingPeriodEndDate { get; set; }
  
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="billingPeriodEnvelopesSent", EmitDefaultValue=false)]
        public string BillingPeriodEnvelopesSent { get; set; }
  
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="billingPeriodEnvelopesAllowed", EmitDefaultValue=false)]
        public string BillingPeriodEnvelopesAllowed { get; set; }
  
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="billingPeriodDaysRemaining", EmitDefaultValue=false)]
        public string BillingPeriodDaysRemaining { get; set; }
  
        
        /// <summary>
        /// When set to **true**, specifies that you can upgrade the account through the API.
        /// </summary>
        /// <value>When set to **true**, specifies that you can upgrade the account through the API.</value>
        [DataMember(Name="canUpgrade", EmitDefaultValue=false)]
        public string CanUpgrade { get; set; }
  
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="canCancelRenewal", EmitDefaultValue=false)]
        public string CanCancelRenewal { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="envelopeSendingBlocked", EmitDefaultValue=false)]
        public string EnvelopeSendingBlocked { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="envelopeUnitPrice", EmitDefaultValue=false)]
        public string EnvelopeUnitPrice { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="suspensionStatus", EmitDefaultValue=false)]
        public string SuspensionStatus { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="suspensionDate", EmitDefaultValue=false)]
        public string SuspensionDate { get; set; }
  
        
        /// <summary>
        /// The name of the current account.
        /// </summary>
        /// <value>The name of the current account.</value>
        [DataMember(Name="accountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="connectPermission", EmitDefaultValue=false)]
        public string ConnectPermission { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="docuSignLandingUrl", EmitDefaultValue=false)]
        public string DocuSignLandingUrl { get; set; }
  
        
        /// <summary>
        /// The code that identifies the billing plan groups and plans for the new account.
        /// </summary>
        /// <value>The code that identifies the billing plan groups and plans for the new account.</value>
        [DataMember(Name="distributorCode", EmitDefaultValue=false)]
        public string DistributorCode { get; set; }
  
        
        /// <summary>
        /// The GUID associated with the account ID.
        /// </summary>
        /// <value>The GUID associated with the account ID.</value>
        [DataMember(Name="accountIdGuid", EmitDefaultValue=false)]
        public string AccountIdGuid { get; set; }
  
        
        /// <summary>
        /// Specifies the ISO currency code for the account.
        /// </summary>
        /// <value>Specifies the ISO currency code for the account.</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
  
        
        /// <summary>
        /// A complex element that contains up to four Question/Answer pairs for forgotten password information for a user.
        /// </summary>
        /// <value>A complex element that contains up to four Question/Answer pairs for forgotten password information for a user.</value>
        [DataMember(Name="forgottenPasswordQuestionsCount", EmitDefaultValue=false)]
        public string ForgottenPasswordQuestionsCount { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
        public string PaymentMethod { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="seatsAllowed", EmitDefaultValue=false)]
        public string SeatsAllowed { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="seatsInUse", EmitDefaultValue=false)]
        public string SeatsInUse { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public string CreatedDate { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="isDowngrade", EmitDefaultValue=false)]
        public string IsDowngrade { get; set; }
  
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="billingProfile", EmitDefaultValue=false)]
        public string BillingProfile { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="status21CFRPart11", EmitDefaultValue=false)]
        public string Status21CFRPart11 { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountInformation {\n");
            sb.Append("  CurrentPlanId: ").Append(CurrentPlanId).Append("\n");
            sb.Append("  PlanName: ").Append(PlanName).Append("\n");
            sb.Append("  PlanClassification: ").Append(PlanClassification).Append("\n");
            sb.Append("  PlanStartDate: ").Append(PlanStartDate).Append("\n");
            sb.Append("  PlanEndDate: ").Append(PlanEndDate).Append("\n");
            sb.Append("  BillingPeriodStartDate: ").Append(BillingPeriodStartDate).Append("\n");
            sb.Append("  BillingPeriodEndDate: ").Append(BillingPeriodEndDate).Append("\n");
            sb.Append("  BillingPeriodEnvelopesSent: ").Append(BillingPeriodEnvelopesSent).Append("\n");
            sb.Append("  BillingPeriodEnvelopesAllowed: ").Append(BillingPeriodEnvelopesAllowed).Append("\n");
            sb.Append("  BillingPeriodDaysRemaining: ").Append(BillingPeriodDaysRemaining).Append("\n");
            sb.Append("  CanUpgrade: ").Append(CanUpgrade).Append("\n");
            sb.Append("  CanCancelRenewal: ").Append(CanCancelRenewal).Append("\n");
            sb.Append("  EnvelopeSendingBlocked: ").Append(EnvelopeSendingBlocked).Append("\n");
            sb.Append("  EnvelopeUnitPrice: ").Append(EnvelopeUnitPrice).Append("\n");
            sb.Append("  SuspensionStatus: ").Append(SuspensionStatus).Append("\n");
            sb.Append("  SuspensionDate: ").Append(SuspensionDate).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  ConnectPermission: ").Append(ConnectPermission).Append("\n");
            sb.Append("  DocuSignLandingUrl: ").Append(DocuSignLandingUrl).Append("\n");
            sb.Append("  DistributorCode: ").Append(DistributorCode).Append("\n");
            sb.Append("  AccountIdGuid: ").Append(AccountIdGuid).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  ForgottenPasswordQuestionsCount: ").Append(ForgottenPasswordQuestionsCount).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  SeatsAllowed: ").Append(SeatsAllowed).Append("\n");
            sb.Append("  SeatsInUse: ").Append(SeatsInUse).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  IsDowngrade: ").Append(IsDowngrade).Append("\n");
            sb.Append("  BillingProfile: ").Append(BillingProfile).Append("\n");
            sb.Append("  Status21CFRPart11: ").Append(Status21CFRPart11).Append("\n");
            
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
            return this.Equals(obj as AccountInformation);
        }

        /// <summary>
        /// Returns true if AccountInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CurrentPlanId == other.CurrentPlanId ||
                    this.CurrentPlanId != null &&
                    this.CurrentPlanId.Equals(other.CurrentPlanId)
                ) && 
                (
                    this.PlanName == other.PlanName ||
                    this.PlanName != null &&
                    this.PlanName.Equals(other.PlanName)
                ) && 
                (
                    this.PlanClassification == other.PlanClassification ||
                    this.PlanClassification != null &&
                    this.PlanClassification.Equals(other.PlanClassification)
                ) && 
                (
                    this.PlanStartDate == other.PlanStartDate ||
                    this.PlanStartDate != null &&
                    this.PlanStartDate.Equals(other.PlanStartDate)
                ) && 
                (
                    this.PlanEndDate == other.PlanEndDate ||
                    this.PlanEndDate != null &&
                    this.PlanEndDate.Equals(other.PlanEndDate)
                ) && 
                (
                    this.BillingPeriodStartDate == other.BillingPeriodStartDate ||
                    this.BillingPeriodStartDate != null &&
                    this.BillingPeriodStartDate.Equals(other.BillingPeriodStartDate)
                ) && 
                (
                    this.BillingPeriodEndDate == other.BillingPeriodEndDate ||
                    this.BillingPeriodEndDate != null &&
                    this.BillingPeriodEndDate.Equals(other.BillingPeriodEndDate)
                ) && 
                (
                    this.BillingPeriodEnvelopesSent == other.BillingPeriodEnvelopesSent ||
                    this.BillingPeriodEnvelopesSent != null &&
                    this.BillingPeriodEnvelopesSent.Equals(other.BillingPeriodEnvelopesSent)
                ) && 
                (
                    this.BillingPeriodEnvelopesAllowed == other.BillingPeriodEnvelopesAllowed ||
                    this.BillingPeriodEnvelopesAllowed != null &&
                    this.BillingPeriodEnvelopesAllowed.Equals(other.BillingPeriodEnvelopesAllowed)
                ) && 
                (
                    this.BillingPeriodDaysRemaining == other.BillingPeriodDaysRemaining ||
                    this.BillingPeriodDaysRemaining != null &&
                    this.BillingPeriodDaysRemaining.Equals(other.BillingPeriodDaysRemaining)
                ) && 
                (
                    this.CanUpgrade == other.CanUpgrade ||
                    this.CanUpgrade != null &&
                    this.CanUpgrade.Equals(other.CanUpgrade)
                ) && 
                (
                    this.CanCancelRenewal == other.CanCancelRenewal ||
                    this.CanCancelRenewal != null &&
                    this.CanCancelRenewal.Equals(other.CanCancelRenewal)
                ) && 
                (
                    this.EnvelopeSendingBlocked == other.EnvelopeSendingBlocked ||
                    this.EnvelopeSendingBlocked != null &&
                    this.EnvelopeSendingBlocked.Equals(other.EnvelopeSendingBlocked)
                ) && 
                (
                    this.EnvelopeUnitPrice == other.EnvelopeUnitPrice ||
                    this.EnvelopeUnitPrice != null &&
                    this.EnvelopeUnitPrice.Equals(other.EnvelopeUnitPrice)
                ) && 
                (
                    this.SuspensionStatus == other.SuspensionStatus ||
                    this.SuspensionStatus != null &&
                    this.SuspensionStatus.Equals(other.SuspensionStatus)
                ) && 
                (
                    this.SuspensionDate == other.SuspensionDate ||
                    this.SuspensionDate != null &&
                    this.SuspensionDate.Equals(other.SuspensionDate)
                ) && 
                (
                    this.AccountName == other.AccountName ||
                    this.AccountName != null &&
                    this.AccountName.Equals(other.AccountName)
                ) && 
                (
                    this.ConnectPermission == other.ConnectPermission ||
                    this.ConnectPermission != null &&
                    this.ConnectPermission.Equals(other.ConnectPermission)
                ) && 
                (
                    this.DocuSignLandingUrl == other.DocuSignLandingUrl ||
                    this.DocuSignLandingUrl != null &&
                    this.DocuSignLandingUrl.Equals(other.DocuSignLandingUrl)
                ) && 
                (
                    this.DistributorCode == other.DistributorCode ||
                    this.DistributorCode != null &&
                    this.DistributorCode.Equals(other.DistributorCode)
                ) && 
                (
                    this.AccountIdGuid == other.AccountIdGuid ||
                    this.AccountIdGuid != null &&
                    this.AccountIdGuid.Equals(other.AccountIdGuid)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.ForgottenPasswordQuestionsCount == other.ForgottenPasswordQuestionsCount ||
                    this.ForgottenPasswordQuestionsCount != null &&
                    this.ForgottenPasswordQuestionsCount.Equals(other.ForgottenPasswordQuestionsCount)
                ) && 
                (
                    this.PaymentMethod == other.PaymentMethod ||
                    this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(other.PaymentMethod)
                ) && 
                (
                    this.SeatsAllowed == other.SeatsAllowed ||
                    this.SeatsAllowed != null &&
                    this.SeatsAllowed.Equals(other.SeatsAllowed)
                ) && 
                (
                    this.SeatsInUse == other.SeatsInUse ||
                    this.SeatsInUse != null &&
                    this.SeatsInUse.Equals(other.SeatsInUse)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.IsDowngrade == other.IsDowngrade ||
                    this.IsDowngrade != null &&
                    this.IsDowngrade.Equals(other.IsDowngrade)
                ) && 
                (
                    this.BillingProfile == other.BillingProfile ||
                    this.BillingProfile != null &&
                    this.BillingProfile.Equals(other.BillingProfile)
                ) && 
                (
                    this.Status21CFRPart11 == other.Status21CFRPart11 ||
                    this.Status21CFRPart11 != null &&
                    this.Status21CFRPart11.Equals(other.Status21CFRPart11)
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
                
                if (this.CurrentPlanId != null)
                    hash = hash * 57 + this.CurrentPlanId.GetHashCode();
                
                if (this.PlanName != null)
                    hash = hash * 57 + this.PlanName.GetHashCode();
                
                if (this.PlanClassification != null)
                    hash = hash * 57 + this.PlanClassification.GetHashCode();
                
                if (this.PlanStartDate != null)
                    hash = hash * 57 + this.PlanStartDate.GetHashCode();
                
                if (this.PlanEndDate != null)
                    hash = hash * 57 + this.PlanEndDate.GetHashCode();
                
                if (this.BillingPeriodStartDate != null)
                    hash = hash * 57 + this.BillingPeriodStartDate.GetHashCode();
                
                if (this.BillingPeriodEndDate != null)
                    hash = hash * 57 + this.BillingPeriodEndDate.GetHashCode();
                
                if (this.BillingPeriodEnvelopesSent != null)
                    hash = hash * 57 + this.BillingPeriodEnvelopesSent.GetHashCode();
                
                if (this.BillingPeriodEnvelopesAllowed != null)
                    hash = hash * 57 + this.BillingPeriodEnvelopesAllowed.GetHashCode();
                
                if (this.BillingPeriodDaysRemaining != null)
                    hash = hash * 57 + this.BillingPeriodDaysRemaining.GetHashCode();
                
                if (this.CanUpgrade != null)
                    hash = hash * 57 + this.CanUpgrade.GetHashCode();
                
                if (this.CanCancelRenewal != null)
                    hash = hash * 57 + this.CanCancelRenewal.GetHashCode();
                
                if (this.EnvelopeSendingBlocked != null)
                    hash = hash * 57 + this.EnvelopeSendingBlocked.GetHashCode();
                
                if (this.EnvelopeUnitPrice != null)
                    hash = hash * 57 + this.EnvelopeUnitPrice.GetHashCode();
                
                if (this.SuspensionStatus != null)
                    hash = hash * 57 + this.SuspensionStatus.GetHashCode();
                
                if (this.SuspensionDate != null)
                    hash = hash * 57 + this.SuspensionDate.GetHashCode();
                
                if (this.AccountName != null)
                    hash = hash * 57 + this.AccountName.GetHashCode();
                
                if (this.ConnectPermission != null)
                    hash = hash * 57 + this.ConnectPermission.GetHashCode();
                
                if (this.DocuSignLandingUrl != null)
                    hash = hash * 57 + this.DocuSignLandingUrl.GetHashCode();
                
                if (this.DistributorCode != null)
                    hash = hash * 57 + this.DistributorCode.GetHashCode();
                
                if (this.AccountIdGuid != null)
                    hash = hash * 57 + this.AccountIdGuid.GetHashCode();
                
                if (this.CurrencyCode != null)
                    hash = hash * 57 + this.CurrencyCode.GetHashCode();
                
                if (this.ForgottenPasswordQuestionsCount != null)
                    hash = hash * 57 + this.ForgottenPasswordQuestionsCount.GetHashCode();
                
                if (this.PaymentMethod != null)
                    hash = hash * 57 + this.PaymentMethod.GetHashCode();
                
                if (this.SeatsAllowed != null)
                    hash = hash * 57 + this.SeatsAllowed.GetHashCode();
                
                if (this.SeatsInUse != null)
                    hash = hash * 57 + this.SeatsInUse.GetHashCode();
                
                if (this.CreatedDate != null)
                    hash = hash * 57 + this.CreatedDate.GetHashCode();
                
                if (this.IsDowngrade != null)
                    hash = hash * 57 + this.IsDowngrade.GetHashCode();
                
                if (this.BillingProfile != null)
                    hash = hash * 57 + this.BillingProfile.GetHashCode();
                
                if (this.Status21CFRPart11 != null)
                    hash = hash * 57 + this.Status21CFRPart11.GetHashCode();
                
                return hash;
            }
        }

    }
}
