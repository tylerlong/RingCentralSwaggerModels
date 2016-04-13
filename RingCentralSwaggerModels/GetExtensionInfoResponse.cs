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
    public class GetExtensionInfoResponse :  IEquatable<GetExtensionInfoResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtensionInfoResponse" /> class.
        /// </summary>
        public GetExtensionInfoResponse()
        {
            
        }

        
        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        /// <value>Internal identifier of an extension</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Canonical URI of an extension
        /// </summary>
        /// <value>Canonical URI of an extension</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
  
        
        /// <summary>
        /// Contact detailed information
        /// </summary>
        /// <value>Contact detailed information</value>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public ContactInfo Contact { get; set; }
  
        
        /// <summary>
        /// Information on department extension(s), to which the requested extension belongs. Returned only for user extensions, members of department, requested by single extensionId
        /// </summary>
        /// <value>Information on department extension(s), to which the requested extension belongs. Returned only for user extensions, members of department, requested by single extensionId</value>
        [DataMember(Name="departments", EmitDefaultValue=false)]
        public DepartmentInfo Departments { get; set; }
  
        
        /// <summary>
        /// Number of department extension
        /// </summary>
        /// <value>Number of department extension</value>
        [DataMember(Name="extensionNumber", EmitDefaultValue=false)]
        public string ExtensionNumber { get; set; }
  
        
        /// <summary>
        /// Extension user name
        /// </summary>
        /// <value>Extension user name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// For Partner Applications Internal identifier of an extension created by partner. The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters using pid = XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all request and response bodies these values are reflected via partnerId attributes of account and extension
        /// </summary>
        /// <value>For Partner Applications Internal identifier of an extension created by partner. The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters using pid = XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all request and response bodies these values are reflected via partnerId attributes of account and extension</value>
        [DataMember(Name="partnerId", EmitDefaultValue=false)]
        public string PartnerId { get; set; }
  
        
        /// <summary>
        /// Extension permissions, corresponding to the Service Web permissions 'Admin' and 'InternationalCalling'
        /// </summary>
        /// <value>Extension permissions, corresponding to the Service Web permissions 'Admin' and 'InternationalCalling'</value>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public ExtensionPermissions Permissions { get; set; }
  
        
        /// <summary>
        /// Information on profile image
        /// </summary>
        /// <value>Information on profile image</value>
        [DataMember(Name="profileImage", EmitDefaultValue=false)]
        public ProfileImageInfo ProfileImage { get; set; }
  
        
        /// <summary>
        /// List of non-RC internal identifiers assigned to an extension
        /// </summary>
        /// <value>List of non-RC internal identifiers assigned to an extension</value>
        [DataMember(Name="references", EmitDefaultValue=false)]
        public List<ReferenceInfo> References { get; set; }
  
        
        /// <summary>
        /// Extension region data (timezone, home country, language)
        /// </summary>
        /// <value>Extension region data (timezone, home country, language)</value>
        [DataMember(Name="regionalSettings", EmitDefaultValue=false)]
        public RegionalSettings RegionalSettings { get; set; }
  
        
        /// <summary>
        /// Extension service features returned in response only when the logged-in user requests his/her own extension info, see also Extension Service Features
        /// </summary>
        /// <value>Extension service features returned in response only when the logged-in user requests his/her own extension info, see also Extension Service Features</value>
        [DataMember(Name="serviceFeatures", EmitDefaultValue=false)]
        public List<ExtensionServiceFeatureInfo> ServiceFeatures { get; set; }
  
        
        /// <summary>
        /// Specifies extension configuration wizard state (web service setup). The default value is 'NotStarted'
        /// </summary>
        /// <value>Specifies extension configuration wizard state (web service setup). The default value is 'NotStarted'</value>
        [DataMember(Name="setupWizardState", EmitDefaultValue=false)]
        public string SetupWizardState { get; set; }
  
        
        /// <summary>
        /// Extension current state. If the status is 'Unassigned'. Returned for all extensions
        /// </summary>
        /// <value>Extension current state. If the status is 'Unassigned'. Returned for all extensions</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
  
        
        /// <summary>
        /// Status information (reason, comment). Returned for 'Disabled' status only
        /// </summary>
        /// <value>Status information (reason, comment). Returned for 'Disabled' status only</value>
        [DataMember(Name="statusInfo", EmitDefaultValue=false)]
        public ExtensionStatusInfo StatusInfo { get; set; }
  
        
        /// <summary>
        /// Extension type
        /// </summary>
        /// <value>Extension type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetExtensionInfoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Departments: ").Append(Departments).Append("\n");
            sb.Append("  ExtensionNumber: ").Append(ExtensionNumber).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  ProfileImage: ").Append(ProfileImage).Append("\n");
            sb.Append("  References: ").Append(References).Append("\n");
            sb.Append("  RegionalSettings: ").Append(RegionalSettings).Append("\n");
            sb.Append("  ServiceFeatures: ").Append(ServiceFeatures).Append("\n");
            sb.Append("  SetupWizardState: ").Append(SetupWizardState).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusInfo: ").Append(StatusInfo).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            
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
            return this.Equals(obj as GetExtensionInfoResponse);
        }

        /// <summary>
        /// Returns true if GetExtensionInfoResponse instances are equal
        /// </summary>
        /// <param name="obj">Instance of GetExtensionInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetExtensionInfoResponse other)
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
                    this.Contact == other.Contact ||
                    this.Contact != null &&
                    this.Contact.Equals(other.Contact)
                ) && 
                (
                    this.Departments == other.Departments ||
                    this.Departments != null &&
                    this.Departments.Equals(other.Departments)
                ) && 
                (
                    this.ExtensionNumber == other.ExtensionNumber ||
                    this.ExtensionNumber != null &&
                    this.ExtensionNumber.Equals(other.ExtensionNumber)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PartnerId == other.PartnerId ||
                    this.PartnerId != null &&
                    this.PartnerId.Equals(other.PartnerId)
                ) && 
                (
                    this.Permissions == other.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.Equals(other.Permissions)
                ) && 
                (
                    this.ProfileImage == other.ProfileImage ||
                    this.ProfileImage != null &&
                    this.ProfileImage.Equals(other.ProfileImage)
                ) && 
                (
                    this.References == other.References ||
                    this.References != null &&
                    this.References.SequenceEqual(other.References)
                ) && 
                (
                    this.RegionalSettings == other.RegionalSettings ||
                    this.RegionalSettings != null &&
                    this.RegionalSettings.Equals(other.RegionalSettings)
                ) && 
                (
                    this.ServiceFeatures == other.ServiceFeatures ||
                    this.ServiceFeatures != null &&
                    this.ServiceFeatures.SequenceEqual(other.ServiceFeatures)
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
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                
                if (this.Contact != null)
                    hash = hash * 57 + this.Contact.GetHashCode();
                
                if (this.Departments != null)
                    hash = hash * 57 + this.Departments.GetHashCode();
                
                if (this.ExtensionNumber != null)
                    hash = hash * 57 + this.ExtensionNumber.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.PartnerId != null)
                    hash = hash * 57 + this.PartnerId.GetHashCode();
                
                if (this.Permissions != null)
                    hash = hash * 57 + this.Permissions.GetHashCode();
                
                if (this.ProfileImage != null)
                    hash = hash * 57 + this.ProfileImage.GetHashCode();
                
                if (this.References != null)
                    hash = hash * 57 + this.References.GetHashCode();
                
                if (this.RegionalSettings != null)
                    hash = hash * 57 + this.RegionalSettings.GetHashCode();
                
                if (this.ServiceFeatures != null)
                    hash = hash * 57 + this.ServiceFeatures.GetHashCode();
                
                if (this.SetupWizardState != null)
                    hash = hash * 57 + this.SetupWizardState.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 57 + this.Status.GetHashCode();
                
                if (this.StatusInfo != null)
                    hash = hash * 57 + this.StatusInfo.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 57 + this.Type.GetHashCode();
                
                return hash;
            }
        }

    }
}
