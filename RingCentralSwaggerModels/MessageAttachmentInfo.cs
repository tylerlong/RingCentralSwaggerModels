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
    public class MessageAttachmentInfo :  IEquatable<MessageAttachmentInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageAttachmentInfo" /> class.
        /// </summary>
        public MessageAttachmentInfo()
        {
            
        }

        
        /// <summary>
        /// Internal identifier of a message attachment
        /// </summary>
        /// <value>Internal identifier of a message attachment</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Canonical URI of a message attachment
        /// </summary>
        /// <value>Canonical URI of a message attachment</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
  
        
        /// <summary>
        /// Type of message attachment
        /// </summary>
        /// <value>Type of message attachment</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// MIME type for a given attachment, for instance 'audio/wav'
        /// </summary>
        /// <value>MIME type for a given attachment, for instance 'audio/wav'</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }
  
        
        /// <summary>
        /// Voicemail only Duration of the voicemail in seconds
        /// </summary>
        /// <value>Voicemail only Duration of the voicemail in seconds</value>
        [DataMember(Name="vmDuration", EmitDefaultValue=false)]
        public int? VmDuration { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageAttachmentInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  VmDuration: ").Append(VmDuration).Append("\n");
            
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
            return this.Equals(obj as MessageAttachmentInfo);
        }

        /// <summary>
        /// Returns true if MessageAttachmentInfo instances are equal
        /// </summary>
        /// <param name="obj">Instance of MessageAttachmentInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageAttachmentInfo other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) && 
                (
                    this.VmDuration == other.VmDuration ||
                    this.VmDuration != null &&
                    this.VmDuration.Equals(other.VmDuration)
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
                
                if (this.Type != null)
                    hash = hash * 57 + this.Type.GetHashCode();
                
                if (this.ContentType != null)
                    hash = hash * 57 + this.ContentType.GetHashCode();
                
                if (this.VmDuration != null)
                    hash = hash * 57 + this.VmDuration.GetHashCode();
                
                return hash;
            }
        }

    }
}
