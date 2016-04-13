using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class GetAccountInfoResponse :  IEquatable<GetAccountInfoResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountInfoResponse" /> class.
        /// </summary>
        public GetAccountInfoResponse()
        {
            
        }

        
        /// <summary>
        /// Internal identifier of an account
        /// </summary>
        /// <value>Internal identifier of an account</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Canonical URI of an account
        /// </summary>
        /// <value>Canonical URI of an account</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
  
        
        /// <summary>
        /// Main phone number of the current account
        /// </summary>
        /// <value>Main phone number of the current account</value>
        [DataMember(Name="mainNumber", EmitDefaultValue=false)]
        public string MainNumber { get; set; }
  
        
        /// <summary>
        /// Operator's extension information. This extension will receive all calls and messages intended for the operator
        /// </summary>
        /// <value>Operator's extension information. This extension will receive all calls and messages intended for the operator</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public GetExtensionInfoResponse Operator { get; set; }
  
        
        /// <summary>
        /// Additional account identifier, developed and applied by the client
        /// </summary>
        /// <value>Additional account identifier, developed and applied by the client</value>
        [DataMember(Name="partnerId", EmitDefaultValue=false)]
        public string PartnerId { get; set; }
  
        
        /// <summary>
        /// Account service information, including brand, service plan and billing plan
        /// </summary>
        /// <value>Account service information, including brand, service plan and billing plan</value>
        [DataMember(Name="serviceInfo", EmitDefaultValue=false)]
        public ServiceInfo ServiceInfo { get; set; }
  
        
        /// <summary>
        /// Specifies account configuration wizard state (web service setup). The default value is 'NotStarted'
        /// </summary>
        /// <value>Specifies account configuration wizard state (web service setup). The default value is 'NotStarted'</value>
        [DataMember(Name="setupWizardState", EmitDefaultValue=false)]
        public string SetupWizardState { get; set; }
  
        
        /// <summary>
        /// Status of the current account
        /// </summary>
        /// <value>Status of the current account</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
  
        
        /// <summary>
        /// Status information (reason, comment, lifetime). Returned for 'Disabled' status only
        /// </summary>
        /// <value>Status information (reason, comment, lifetime). Returned for 'Disabled' status only</value>
        [DataMember(Name="statusInfo", EmitDefaultValue=false)]
        public AccountStatusInfo StatusInfo { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAccountInfoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  MainNumber: ").Append(MainNumber).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  ServiceInfo: ").Append(ServiceInfo).Append("\n");
            sb.Append("  SetupWizardState: ").Append(SetupWizardState).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusInfo: ").Append(StatusInfo).Append("\n");
            
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
            return this.Equals(obj as GetAccountInfoResponse);
        }

        /// <summary>
        /// Returns true if GetAccountInfoResponse instances are equal
        /// </summary>
        /// <param name="obj">Instance of GetAccountInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAccountInfoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.MainNumber == other.MainNumber ||
                    this.MainNumber != null &&
                    this.MainNumber.Equals(other.MainNumber)
                ) && 
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
                ) && 
                (
                    this.PartnerId == other.PartnerId ||
                    this.PartnerId != null &&
                    this.PartnerId.Equals(other.PartnerId)
                ) && 
                (
                    this.ServiceInfo == other.ServiceInfo ||
                    this.ServiceInfo != null &&
                    this.ServiceInfo.Equals(other.ServiceInfo)
                ) && 
                (
                    this.SetupWizardState == other.SetupWizardState ||
                    this.SetupWizardState != null &&
                    this.SetupWizardState.Equals(other.SetupWizardState)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StatusInfo == other.StatusInfo ||
                    this.StatusInfo != null &&
                    this.StatusInfo.Equals(other.StatusInfo)
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
                
                if (this.Id != null)
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.Uri != null)
                    hash = hash * 57 + this.Uri.GetHashCode();
                
                if (this.MainNumber != null)
                    hash = hash * 57 + this.MainNumber.GetHashCode();
                
                if (this.Operator != null)
                    hash = hash * 57 + this.Operator.GetHashCode();
                
                if (this.PartnerId != null)
                    hash = hash * 57 + this.PartnerId.GetHashCode();
                
                if (this.ServiceInfo != null)
                    hash = hash * 57 + this.ServiceInfo.GetHashCode();
                
                if (this.SetupWizardState != null)
                    hash = hash * 57 + this.SetupWizardState.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 57 + this.Status.GetHashCode();
                
                if (this.StatusInfo != null)
                    hash = hash * 57 + this.StatusInfo.GetHashCode();
                
                return hash;
            }
        }

    }
}
