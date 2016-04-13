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
    public class MessageStoreCallerInfoRequest :  IEquatable<MessageStoreCallerInfoRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStoreCallerInfoRequest" /> class.
        /// </summary>
        public MessageStoreCallerInfoRequest()
        {
            
        }

        
        /// <summary>
        /// Extension short number (usually 3 or 4 digits). This property is filled when parties communicate by means of short internal numbers, for example when calling to other extension or sending/receiving Company Pager message
        /// </summary>
        /// <value>Extension short number (usually 3 or 4 digits). This property is filled when parties communicate by means of short internal numbers, for example when calling to other extension or sending/receiving Company Pager message</value>
        [DataMember(Name="extensionNumber", EmitDefaultValue=false)]
        public string ExtensionNumber { get; set; }
  
        
        /// <summary>
        /// Contains party location (city, state) if one can be determined from phoneNumber. This property is filled only when phoneNumber is not empty and server can calculate location information from it (for example, this information is unavailable for US toll-free numbers)
        /// </summary>
        /// <value>Contains party location (city, state) if one can be determined from phoneNumber. This property is filled only when phoneNumber is not empty and server can calculate location information from it (for example, this information is unavailable for US toll-free numbers)</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }
  
        
        /// <summary>
        /// Symbolic name associated with a party. If the phone does not belong to the known extension,only the location is returned, the name is not determined then
        /// </summary>
        /// <value>Symbolic name associated with a party. If the phone does not belong to the known extension,only the location is returned, the name is not determined then</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Phone number of a party. Usually it is a plain number including country and area code like 18661234567. But sometimes it could be returned from database with some formatting applied, for example (866)123-4567. This property is filled in all cases where parties communicate by means of global phone numbers, for example when calling to direct numbers or sending/receiving SMS
        /// </summary>
        /// <value>Phone number of a party. Usually it is a plain number including country and area code like 18661234567. But sometimes it could be returned from database with some formatting applied, for example (866)123-4567. This property is filled in all cases where parties communicate by means of global phone numbers, for example when calling to direct numbers or sending/receiving SMS</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageStoreCallerInfoRequest {\n");
            sb.Append("  ExtensionNumber: ").Append(ExtensionNumber).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            
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
            return this.Equals(obj as MessageStoreCallerInfoRequest);
        }

        /// <summary>
        /// Returns true if MessageStoreCallerInfoRequest instances are equal
        /// </summary>
        /// <param name="obj">Instance of MessageStoreCallerInfoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageStoreCallerInfoRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ExtensionNumber == other.ExtensionNumber ||
                    this.ExtensionNumber != null &&
                    this.ExtensionNumber.Equals(other.ExtensionNumber)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
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
                
                if (this.ExtensionNumber != null)
                    hash = hash * 57 + this.ExtensionNumber.GetHashCode();
                
                if (this.Location != null)
                    hash = hash * 57 + this.Location.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 57 + this.PhoneNumber.GetHashCode();
                
                return hash;
            }
        }

    }
}
