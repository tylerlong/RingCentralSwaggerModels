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
    public class GetExtensionListResponse :  IEquatable<GetExtensionListResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtensionListResponse" /> class.
        /// </summary>
        public GetExtensionListResponse()
        {
            
        }

        
        /// <summary>
        /// List of extensions with extension information
        /// </summary>
        /// <value>List of extensions with extension information</value>
        [DataMember(Name="records", EmitDefaultValue=false)]
        public List<GetExtensionInfoResponse> Records { get; set; }
  
        
        /// <summary>
        /// Information on navigation
        /// </summary>
        /// <value>Information on navigation</value>
        [DataMember(Name="navigation", EmitDefaultValue=false)]
        public NavigationInfo Navigation { get; set; }
  
        
        /// <summary>
        /// Information on paging
        /// </summary>
        /// <value>Information on paging</value>
        [DataMember(Name="paging", EmitDefaultValue=false)]
        public PagingInfo Paging { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetExtensionListResponse {\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
            sb.Append("  Navigation: ").Append(Navigation).Append("\n");
            sb.Append("  Paging: ").Append(Paging).Append("\n");
            
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
            return this.Equals(obj as GetExtensionListResponse);
        }

        /// <summary>
        /// Returns true if GetExtensionListResponse instances are equal
        /// </summary>
        /// <param name="obj">Instance of GetExtensionListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetExtensionListResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Records == other.Records ||
                    this.Records != null &&
                    this.Records.SequenceEqual(other.Records)
                ) && 
                (
                    this.Navigation == other.Navigation ||
                    this.Navigation != null &&
                    this.Navigation.Equals(other.Navigation)
                ) && 
                (
                    this.Paging == other.Paging ||
                    this.Paging != null &&
                    this.Paging.Equals(other.Paging)
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
                
                if (this.Records != null)
                    hash = hash * 57 + this.Records.GetHashCode();
                
                if (this.Navigation != null)
                    hash = hash * 57 + this.Navigation.GetHashCode();
                
                if (this.Paging != null)
                    hash = hash * 57 + this.Paging.GetHashCode();
                
                return hash;
            }
        }

    }
}
