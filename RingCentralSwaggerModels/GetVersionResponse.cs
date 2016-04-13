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
    public class GetVersionResponse :  IEquatable<GetVersionResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetVersionResponse" /> class.
        /// </summary>
        public GetVersionResponse()
        {
            
        }

        
        /// <summary>
        /// Canonical URI of the version info resource
        /// </summary>
        /// <value>Canonical URI of the version info resource</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
  
        
        /// <summary>
        /// Version of the RingCentral REST API
        /// </summary>
        /// <value>Version of the RingCentral REST API</value>
        [DataMember(Name="versionString", EmitDefaultValue=false)]
        public string VersionString { get; set; }
  
        
        /// <summary>
        /// Release date of this version
        /// </summary>
        /// <value>Release date of this version</value>
        [DataMember(Name="releaseDate", EmitDefaultValue=false)]
        public string ReleaseDate { get; set; }
  
        
        /// <summary>
        /// URI part determining the current version
        /// </summary>
        /// <value>URI part determining the current version</value>
        [DataMember(Name="uriString", EmitDefaultValue=false)]
        public string UriString { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetVersionResponse {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  VersionString: ").Append(VersionString).Append("\n");
            sb.Append("  ReleaseDate: ").Append(ReleaseDate).Append("\n");
            sb.Append("  UriString: ").Append(UriString).Append("\n");
            
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
            return this.Equals(obj as GetVersionResponse);
        }

        /// <summary>
        /// Returns true if GetVersionResponse instances are equal
        /// </summary>
        /// <param name="obj">Instance of GetVersionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetVersionResponse other)
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
                    this.VersionString == other.VersionString ||
                    this.VersionString != null &&
                    this.VersionString.Equals(other.VersionString)
                ) && 
                (
                    this.ReleaseDate == other.ReleaseDate ||
                    this.ReleaseDate != null &&
                    this.ReleaseDate.Equals(other.ReleaseDate)
                ) && 
                (
                    this.UriString == other.UriString ||
                    this.UriString != null &&
                    this.UriString.Equals(other.UriString)
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
                
                if (this.VersionString != null)
                    hash = hash * 57 + this.VersionString.GetHashCode();
                
                if (this.ReleaseDate != null)
                    hash = hash * 57 + this.ReleaseDate.GetHashCode();
                
                if (this.UriString != null)
                    hash = hash * 57 + this.UriString.GetHashCode();
                
                return hash;
            }
        }

    }
}
