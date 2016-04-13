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
    public class CreateSubscriptionRequest :  IEquatable<CreateSubscriptionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequest" /> class.
        /// </summary>
        public CreateSubscriptionRequest()
        {
            
        }

        
        /// <summary>
        /// Mandatory. Collection of URIs to API resources (see Event Types for details). For APNS transport type only message event filter is available
        /// </summary>
        /// <value>Mandatory. Collection of URIs to API resources (see Event Types for details). For APNS transport type only message event filter is available</value>
        [DataMember(Name="eventFilters", EmitDefaultValue=false)]
        public List<string> EventFilters { get; set; }
  
        
        /// <summary>
        /// Notification delivery settings
        /// </summary>
        /// <value>Notification delivery settings</value>
        [DataMember(Name="deliveryMode", EmitDefaultValue=false)]
        public NotificationDeliveryModeRequest DeliveryMode { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubscriptionRequest {\n");
            sb.Append("  EventFilters: ").Append(EventFilters).Append("\n");
            sb.Append("  DeliveryMode: ").Append(DeliveryMode).Append("\n");
            
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
            return this.Equals(obj as CreateSubscriptionRequest);
        }

        /// <summary>
        /// Returns true if CreateSubscriptionRequest instances are equal
        /// </summary>
        /// <param name="obj">Instance of CreateSubscriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSubscriptionRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EventFilters == other.EventFilters ||
                    this.EventFilters != null &&
                    this.EventFilters.SequenceEqual(other.EventFilters)
                ) && 
                (
                    this.DeliveryMode == other.DeliveryMode ||
                    this.DeliveryMode != null &&
                    this.DeliveryMode.Equals(other.DeliveryMode)
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
                
                if (this.EventFilters != null)
                    hash = hash * 57 + this.EventFilters.GetHashCode();
                
                if (this.DeliveryMode != null)
                    hash = hash * 57 + this.DeliveryMode.GetHashCode();
                
                return hash;
            }
        }

    }
}
