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
    public class NotificationDeliveryMode :  IEquatable<NotificationDeliveryMode>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationDeliveryMode" /> class.
        /// </summary>
        public NotificationDeliveryMode()
        {
            
        }

        
        /// <summary>
        /// Notifications transportation provider name. 'APNS' (Apple Push Notifications Service)
        /// </summary>
        /// <value>Notifications transportation provider name. 'APNS' (Apple Push Notifications Service)</value>
        [DataMember(Name="transportType", EmitDefaultValue=false)]
        public string TransportType { get; set; }
  
        
        /// <summary>
        /// Optional parameter. Specifies if the message will be encrypted or not. For APNS transport type the value is always  false
        /// </summary>
        /// <value>Optional parameter. Specifies if the message will be encrypted or not. For APNS transport type the value is always  false</value>
        [DataMember(Name="encryption", EmitDefaultValue=false)]
        public bool? Encryption { get; set; }
  
        
        /// <summary>
        /// PubNub channel name. For APNS transport type - internal identifier of a device  device_token
        /// </summary>
        /// <value>PubNub channel name. For APNS transport type - internal identifier of a device  device_token</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
  
        
        /// <summary>
        /// PubNub subscriber credentials required to subscribe to the channel
        /// </summary>
        /// <value>PubNub subscriber credentials required to subscribe to the channel</value>
        [DataMember(Name="subscriberKey", EmitDefaultValue=false)]
        public string SubscriberKey { get; set; }
  
        
        /// <summary>
        /// PubNub subscriber credentials required to subscribe to the channel. Optional (for PubNub transport type only)
        /// </summary>
        /// <value>PubNub subscriber credentials required to subscribe to the channel. Optional (for PubNub transport type only)</value>
        [DataMember(Name="secretKey", EmitDefaultValue=false)]
        public string SecretKey { get; set; }
  
        
        /// <summary>
        /// Encryption algorithm 'AES' (for PubNub transport type only)
        /// </summary>
        /// <value>Encryption algorithm 'AES' (for PubNub transport type only)</value>
        [DataMember(Name="encryptionAlgorithm", EmitDefaultValue=false)]
        public string EncryptionAlgorithm { get; set; }
  
        
        /// <summary>
        /// Key for notification message decryption (for PubNub transport type only)
        /// </summary>
        /// <value>Key for notification message decryption (for PubNub transport type only)</value>
        [DataMember(Name="encryptionKey", EmitDefaultValue=false)]
        public string EncryptionKey { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationDeliveryMode {\n");
            sb.Append("  TransportType: ").Append(TransportType).Append("\n");
            sb.Append("  Encryption: ").Append(Encryption).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  SubscriberKey: ").Append(SubscriberKey).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
            sb.Append("  EncryptionAlgorithm: ").Append(EncryptionAlgorithm).Append("\n");
            sb.Append("  EncryptionKey: ").Append(EncryptionKey).Append("\n");
            
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
            return this.Equals(obj as NotificationDeliveryMode);
        }

        /// <summary>
        /// Returns true if NotificationDeliveryMode instances are equal
        /// </summary>
        /// <param name="obj">Instance of NotificationDeliveryMode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationDeliveryMode other)
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
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.SubscriberKey == other.SubscriberKey ||
                    this.SubscriberKey != null &&
                    this.SubscriberKey.Equals(other.SubscriberKey)
                ) && 
                (
                    this.SecretKey == other.SecretKey ||
                    this.SecretKey != null &&
                    this.SecretKey.Equals(other.SecretKey)
                ) && 
                (
                    this.EncryptionAlgorithm == other.EncryptionAlgorithm ||
                    this.EncryptionAlgorithm != null &&
                    this.EncryptionAlgorithm.Equals(other.EncryptionAlgorithm)
                ) && 
                (
                    this.EncryptionKey == other.EncryptionKey ||
                    this.EncryptionKey != null &&
                    this.EncryptionKey.Equals(other.EncryptionKey)
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
                
                if (this.Address != null)
                    hash = hash * 57 + this.Address.GetHashCode();
                
                if (this.SubscriberKey != null)
                    hash = hash * 57 + this.SubscriberKey.GetHashCode();
                
                if (this.SecretKey != null)
                    hash = hash * 57 + this.SecretKey.GetHashCode();
                
                if (this.EncryptionAlgorithm != null)
                    hash = hash * 57 + this.EncryptionAlgorithm.GetHashCode();
                
                if (this.EncryptionKey != null)
                    hash = hash * 57 + this.EncryptionKey.GetHashCode();
                
                return hash;
            }
        }

    }
}
