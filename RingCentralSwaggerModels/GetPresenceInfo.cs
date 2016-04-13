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
    public class GetPresenceInfo :  IEquatable<GetPresenceInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPresenceInfo" /> class.
        /// </summary>
        public GetPresenceInfo()
        {
            
        }

        
        /// <summary>
        /// Canonical URI of a presence info resource
        /// </summary>
        /// <value>Canonical URI of a presence info resource</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
  
        
        /// <summary>
        /// If 'True' enables other extensions to see the extension presence status
        /// </summary>
        /// <value>If 'True' enables other extensions to see the extension presence status</value>
        [DataMember(Name="allowSeeMyPresence", EmitDefaultValue=false)]
        public bool? AllowSeeMyPresence { get; set; }
  
        
        /// <summary>
        /// Extended DnD (Do not Disturb) status. Cannot be set for Department/Announcement/Voicemail (Take Messages Only)/Fax User/Shared Lines Group/Paging Only Group/IVR Menu/Application Extension/Park Location extensions. The 'DoNotAcceptDepartmentCalls' and 'TakeDepartmentCallsOnly' values are applicable only for extensions - members of a Department; if these values are set for department outsiders, the 400 Bad Request error code is returned. The 'TakeDepartmentCallsOnly' status can be set through the old RingCentral user interface and is available for some migrated accounts only.
        /// </summary>
        /// <value>Extended DnD (Do not Disturb) status. Cannot be set for Department/Announcement/Voicemail (Take Messages Only)/Fax User/Shared Lines Group/Paging Only Group/IVR Menu/Application Extension/Park Location extensions. The 'DoNotAcceptDepartmentCalls' and 'TakeDepartmentCallsOnly' values are applicable only for extensions - members of a Department; if these values are set for department outsiders, the 400 Bad Request error code is returned. The 'TakeDepartmentCallsOnly' status can be set through the old RingCentral user interface and is available for some migrated accounts only.</value>
        [DataMember(Name="dndStatus", EmitDefaultValue=false)]
        public string DndStatus { get; set; }
  
        
        /// <summary>
        /// Information on extension, for which this presence data is returned
        /// </summary>
        /// <value>Information on extension, for which this presence data is returned</value>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public GetPresenceExtensionInfo Extension { get; set; }
  
        
        /// <summary>
        /// Custom status message (as previously published by user)
        /// </summary>
        /// <value>Custom status message (as previously published by user)</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
  
        
        /// <summary>
        /// If 'True' enables the extension user to pick up a monitored line on hold
        /// </summary>
        /// <value>If 'True' enables the extension user to pick up a monitored line on hold</value>
        [DataMember(Name="pickUpCallsOnHold", EmitDefaultValue=false)]
        public bool? PickUpCallsOnHold { get; set; }
  
        
        /// <summary>
        /// Aggregated presence status, calculated from a number of sources
        /// </summary>
        /// <value>Aggregated presence status, calculated from a number of sources</value>
        [DataMember(Name="presenceStatus", EmitDefaultValue=false)]
        public string PresenceStatus { get; set; }
  
        
        /// <summary>
        /// If 'True' enables to ring extension phone, if any user monitored by this extension is ringing
        /// </summary>
        /// <value>If 'True' enables to ring extension phone, if any user monitored by this extension is ringing</value>
        [DataMember(Name="ringOnMonitoredCall", EmitDefaultValue=false)]
        public bool? RingOnMonitoredCall { get; set; }
  
        
        /// <summary>
        /// Telephony presence status
        /// </summary>
        /// <value>Telephony presence status</value>
        [DataMember(Name="telephonyStatus", EmitDefaultValue=false)]
        public string TelephonyStatus { get; set; }
  
        
        /// <summary>
        /// User-defined presence status (as previously published by the user)
        /// </summary>
        /// <value>User-defined presence status (as previously published by the user)</value>
        [DataMember(Name="userStatus", EmitDefaultValue=false)]
        public string UserStatus { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetPresenceInfo {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  AllowSeeMyPresence: ").Append(AllowSeeMyPresence).Append("\n");
            sb.Append("  DndStatus: ").Append(DndStatus).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  PickUpCallsOnHold: ").Append(PickUpCallsOnHold).Append("\n");
            sb.Append("  PresenceStatus: ").Append(PresenceStatus).Append("\n");
            sb.Append("  RingOnMonitoredCall: ").Append(RingOnMonitoredCall).Append("\n");
            sb.Append("  TelephonyStatus: ").Append(TelephonyStatus).Append("\n");
            sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");
            
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
            return this.Equals(obj as GetPresenceInfo);
        }

        /// <summary>
        /// Returns true if GetPresenceInfo instances are equal
        /// </summary>
        /// <param name="obj">Instance of GetPresenceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPresenceInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.AllowSeeMyPresence == other.AllowSeeMyPresence ||
                    this.AllowSeeMyPresence != null &&
                    this.AllowSeeMyPresence.Equals(other.AllowSeeMyPresence)
                ) && 
                (
                    this.DndStatus == other.DndStatus ||
                    this.DndStatus != null &&
                    this.DndStatus.Equals(other.DndStatus)
                ) && 
                (
                    this.Extension == other.Extension ||
                    this.Extension != null &&
                    this.Extension.Equals(other.Extension)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.PickUpCallsOnHold == other.PickUpCallsOnHold ||
                    this.PickUpCallsOnHold != null &&
                    this.PickUpCallsOnHold.Equals(other.PickUpCallsOnHold)
                ) && 
                (
                    this.PresenceStatus == other.PresenceStatus ||
                    this.PresenceStatus != null &&
                    this.PresenceStatus.Equals(other.PresenceStatus)
                ) && 
                (
                    this.RingOnMonitoredCall == other.RingOnMonitoredCall ||
                    this.RingOnMonitoredCall != null &&
                    this.RingOnMonitoredCall.Equals(other.RingOnMonitoredCall)
                ) && 
                (
                    this.TelephonyStatus == other.TelephonyStatus ||
                    this.TelephonyStatus != null &&
                    this.TelephonyStatus.Equals(other.TelephonyStatus)
                ) && 
                (
                    this.UserStatus == other.UserStatus ||
                    this.UserStatus != null &&
                    this.UserStatus.Equals(other.UserStatus)
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
                
                if (this.Uri != null)
                    hash = hash * 57 + this.Uri.GetHashCode();
                
                if (this.AllowSeeMyPresence != null)
                    hash = hash * 57 + this.AllowSeeMyPresence.GetHashCode();
                
                if (this.DndStatus != null)
                    hash = hash * 57 + this.DndStatus.GetHashCode();
                
                if (this.Extension != null)
                    hash = hash * 57 + this.Extension.GetHashCode();
                
                if (this.Message != null)
                    hash = hash * 57 + this.Message.GetHashCode();
                
                if (this.PickUpCallsOnHold != null)
                    hash = hash * 57 + this.PickUpCallsOnHold.GetHashCode();
                
                if (this.PresenceStatus != null)
                    hash = hash * 57 + this.PresenceStatus.GetHashCode();
                
                if (this.RingOnMonitoredCall != null)
                    hash = hash * 57 + this.RingOnMonitoredCall.GetHashCode();
                
                if (this.TelephonyStatus != null)
                    hash = hash * 57 + this.TelephonyStatus.GetHashCode();
                
                if (this.UserStatus != null)
                    hash = hash * 57 + this.UserStatus.GetHashCode();
                
                return hash;
            }
        }

    }
}
