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
    public class ExtensionInfo :  IEquatable<ExtensionInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionInfo" /> class.
        /// </summary>
        public ExtensionInfo()
        {
            
        }

        
        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        /// <value>Internal identifier of an extension</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Canonical URI of an extension
        /// </summary>
        /// <value>Canonical URI of an extension</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
  
        
        /// <summary>
        /// Number of department extension
        /// </summary>
        /// <value>Number of department extension</value>
        [DataMember(Name="extensionNumber", EmitDefaultValue=false)]
        public string ExtensionNumber { get; set; }
  
        
        /// <summary>
        /// For Partner Applications Internal identifier of an extension created by partner. The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters using pid = XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all request and response bodies these values are reflected via partnerId attributes of account and extension
        /// </summary>
        /// <value>For Partner Applications Internal identifier of an extension created by partner. The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters using pid = XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all request and response bodies these values are reflected via partnerId attributes of account and extension</value>
        [DataMember(Name="partnerId", EmitDefaultValue=false)]
        public string PartnerId { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  ExtensionNumber: ").Append(ExtensionNumber).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            
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
            return this.Equals(obj as ExtensionInfo);
        }

        /// <summary>
        /// Returns true if ExtensionInfo instances are equal
        /// </summary>
        /// <param name="obj">Instance of ExtensionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtensionInfo other)
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
                    this.ExtensionNumber == other.ExtensionNumber ||
                    this.ExtensionNumber != null &&
                    this.ExtensionNumber.Equals(other.ExtensionNumber)
                ) && 
                (
                    this.PartnerId == other.PartnerId ||
                    this.PartnerId != null &&
                    this.PartnerId.Equals(other.PartnerId)
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
                
                if (this.ExtensionNumber != null)
                    hash = hash * 57 + this.ExtensionNumber.GetHashCode();
                
                if (this.PartnerId != null)
                    hash = hash * 57 + this.PartnerId.GetHashCode();
                
                return hash;
            }
        }

    }
}
