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
    public class NotificationDeliveryModeRequest :  IEquatable<NotificationDeliveryModeRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationDeliveryModeRequest" /> class.
        /// </summary>
        public NotificationDeliveryModeRequest()
        {
            
        }

        
        /// <summary>
        /// Notifications transportation provider name. 'APNS' (Apple Push Notifications Service)
        /// </summary>
        /// <value>Notifications transportation provider name. 'APNS' (Apple Push Notifications Service)</value>
        [DataMember(Name="transportType", EmitDefaultValue=false)]
        public string TransportType { get; set; }
  
        
        /// <summary>
        /// Optional parameter. Specifies if the message will be encrypted or not. If request contains any presence event filter the value by default is 'True' (even if specified as 'false'). If request contains only message event filters the value by default is 'False'
        /// </summary>
        /// <value>Optional parameter. Specifies if the message will be encrypted or not. If request contains any presence event filter the value by default is 'True' (even if specified as 'false'). If request contains only message event filters the value by default is 'False'</value>
        [DataMember(Name="encryption", EmitDefaultValue=false)]
        public bool? Encryption { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationDeliveryModeRequest {\n");
            sb.Append("  TransportType: ").Append(TransportType).Append("\n");
            sb.Append("  Encryption: ").Append(Encryption).Append("\n");
            
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
            return this.Equals(obj as NotificationDeliveryModeRequest);
        }

        /// <summary>
        /// Returns true if NotificationDeliveryModeRequest instances are equal
        /// </summary>
        /// <param name="obj">Instance of NotificationDeliveryModeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationDeliveryModeRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TransportType == other.TransportType ||
                    this.TransportType != null &&
                    this.TransportType.Equals(other.TransportType)
                ) && 
                (
                    this.Encryption == other.Encryption ||
                    this.Encryption != null &&
                    this.Encryption.Equals(other.Encryption)
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
                
                if (this.TransportType != null)
                    hash = hash * 57 + this.TransportType.GetHashCode();
                
                if (this.Encryption != null)
                    hash = hash * 57 + this.Encryption.GetHashCode();
                
                return hash;
            }
        }

    }
}
