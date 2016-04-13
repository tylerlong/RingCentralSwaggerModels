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
    public class GetCallRecordingResponse :  IEquatable<GetCallRecordingResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCallRecordingResponse" /> class.
        /// </summary>
        public GetCallRecordingResponse()
        {
            
        }

        
        /// <summary>
        /// Internal identifier of the call recording
        /// </summary>
        /// <value>Internal identifier of the call recording</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
  
        
        /// <summary>
        /// Link to the call recording binary content
        /// </summary>
        /// <value>Link to the call recording binary content</value>
        [DataMember(Name="contentUri", EmitDefaultValue=false)]
        public string ContentUri { get; set; }
  
        
        /// <summary>
        /// Call recording file format. Supported format is audio/x-wav
        /// </summary>
        /// <value>Call recording file format. Supported format is audio/x-wav</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }
  
        
        /// <summary>
        /// Recorded call duration
        /// </summary>
        /// <value>Recorded call duration</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCallRecordingResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContentUri: ").Append(ContentUri).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            
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
            return this.Equals(obj as GetCallRecordingResponse);
        }

        /// <summary>
        /// Returns true if GetCallRecordingResponse instances are equal
        /// </summary>
        /// <param name="obj">Instance of GetCallRecordingResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCallRecordingResponse other)
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
                    this.ContentUri == other.ContentUri ||
                    this.ContentUri != null &&
                    this.ContentUri.Equals(other.ContentUri)
                ) && 
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) && 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
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
                
                if (this.ContentUri != null)
                    hash = hash * 57 + this.ContentUri.GetHashCode();
                
                if (this.ContentType != null)
                    hash = hash * 57 + this.ContentType.GetHashCode();
                
                if (this.Duration != null)
                    hash = hash * 57 + this.Duration.GetHashCode();
                
                return hash;
            }
        }

    }
}
