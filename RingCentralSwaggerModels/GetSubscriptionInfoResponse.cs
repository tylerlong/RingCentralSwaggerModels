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
    public class GetSubscriptionInfoResponse :  IEquatable<GetSubscriptionInfoResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionInfoResponse" /> class.
        /// </summary>
        public GetSubscriptionInfoResponse()
        {
            
        }

        
        /// <summary>
        /// Internal identifier of a subscription
        /// </summary>
        /// <value>Internal identifier of a subscription</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Canonical URI of a subscription
        /// </summary>
        /// <value>Canonical URI of a subscription</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
  
        
        /// <summary>
        /// Collection of URIs to API resources (message-store/presence/detailed presence)
        /// </summary>
        /// <value>Collection of URIs to API resources (message-store/presence/detailed presence)</value>
        [DataMember(Name="eventFilters", EmitDefaultValue=false)]
        public List<string> EventFilters { get; set; }
  
        
        /// <summary>
        /// Subscription expiration datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        /// <value>Subscription expiration datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z</value>
        [DataMember(Name="expirationTime", EmitDefaultValue=false)]
        public DateTime? ExpirationTime { get; set; }
  
        
        /// <summary>
        /// Subscription lifetime in seconds. The default value is 900
        /// </summary>
        /// <value>Subscription lifetime in seconds. The default value is 900</value>
        [DataMember(Name="expiresIn", EmitDefaultValue=false)]
        public int? ExpiresIn { get; set; }
  
        
        /// <summary>
        /// Subscription status
        /// </summary>
        /// <value>Subscription status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
  
        
        /// <summary>
        /// Subscription creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        /// <value>Subscription creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z</value>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public DateTime? CreationTime { get; set; }
  
        
        /// <summary>
        /// Delivery mode data
        /// </summary>
        /// <value>Delivery mode data</value>
        [DataMember(Name="deliveryMode", EmitDefaultValue=false)]
        public NotificationDeliveryMode DeliveryMode { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetSubscriptionInfoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  EventFilters: ").Append(EventFilters).Append("\n");
            sb.Append("  ExpirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
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
            return this.Equals(obj as GetSubscriptionInfoResponse);
        }

        /// <summary>
        /// Returns true if GetSubscriptionInfoResponse instances are equal
        /// </summary>
        /// <param name="obj">Instance of GetSubscriptionInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSubscriptionInfoResponse other)
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
                    this.EventFilters == other.EventFilters ||
                    this.EventFilters != null &&
                    this.EventFilters.SequenceEqual(other.EventFilters)
                ) && 
                (
                    this.ExpirationTime == other.ExpirationTime ||
                    this.ExpirationTime != null &&
                    this.ExpirationTime.Equals(other.ExpirationTime)
                ) && 
                (
                    this.ExpiresIn == other.ExpiresIn ||
                    this.ExpiresIn != null &&
                    this.ExpiresIn.Equals(other.ExpiresIn)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.CreationTime == other.CreationTime ||
                    this.CreationTime != null &&
                    this.CreationTime.Equals(other.CreationTime)
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
                
                if (this.Id != null)
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.Uri != null)
                    hash = hash * 57 + this.Uri.GetHashCode();
                
                if (this.EventFilters != null)
                    hash = hash * 57 + this.EventFilters.GetHashCode();
                
                if (this.ExpirationTime != null)
                    hash = hash * 57 + this.ExpirationTime.GetHashCode();
                
                if (this.ExpiresIn != null)
                    hash = hash * 57 + this.ExpiresIn.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 57 + this.Status.GetHashCode();
                
                if (this.CreationTime != null)
                    hash = hash * 57 + this.CreationTime.GetHashCode();
                
                if (this.DeliveryMode != null)
                    hash = hash * 57 + this.DeliveryMode.GetHashCode();
                
                return hash;
            }
        }

    }
}
