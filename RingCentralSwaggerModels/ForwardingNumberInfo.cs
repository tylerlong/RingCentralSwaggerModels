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
    public class ForwardingNumberInfo :  IEquatable<ForwardingNumberInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForwardingNumberInfo" /> class.
        /// </summary>
        public ForwardingNumberInfo()
        {
            
        }

        
        /// <summary>
        /// Internal identifier of a forwarding/call flip phone number
        /// </summary>
        /// <value>Internal identifier of a forwarding/call flip phone number</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Canonical URI of a forwarding/call flip phone number
        /// </summary>
        /// <value>Canonical URI of a forwarding/call flip phone number</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
  
        
        /// <summary>
        /// Forwarding/Call flip phone number
        /// </summary>
        /// <value>Forwarding/Call flip phone number</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
  
        
        /// <summary>
        /// Forwarding/Call flip number title
        /// </summary>
        /// <value>Forwarding/Call flip number title</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }
  
        
        /// <summary>
        /// Type of option this phone number is used for. Multiple values are accepted
        /// </summary>
        /// <value>Type of option this phone number is used for. Multiple values are accepted</value>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public string Features { get; set; }
  
        
        /// <summary>
        /// Number assigned to the call flip phone number, corresponds to the shortcut dial number
        /// </summary>
        /// <value>Number assigned to the call flip phone number, corresponds to the shortcut dial number</value>
        [DataMember(Name="flipNumber", EmitDefaultValue=false)]
        public int? FlipNumber { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForwardingNumberInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  FlipNumber: ").Append(FlipNumber).Append("\n");
            
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
            return this.Equals(obj as ForwardingNumberInfo);
        }

        /// <summary>
        /// Returns true if ForwardingNumberInfo instances are equal
        /// </summary>
        /// <param name="obj">Instance of ForwardingNumberInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForwardingNumberInfo other)
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
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) && 
                (
                    this.Features == other.Features ||
                    this.Features != null &&
                    this.Features.Equals(other.Features)
                ) && 
                (
                    this.FlipNumber == other.FlipNumber ||
                    this.FlipNumber != null &&
                    this.FlipNumber.Equals(other.FlipNumber)
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
                
                if (this.PhoneNumber != null)
                    hash = hash * 57 + this.PhoneNumber.GetHashCode();
                
                if (this.Label != null)
                    hash = hash * 57 + this.Label.GetHashCode();
                
                if (this.Features != null)
                    hash = hash * 57 + this.Features.GetHashCode();
                
                if (this.FlipNumber != null)
                    hash = hash * 57 + this.FlipNumber.GetHashCode();
                
                return hash;
            }
        }

    }
}
