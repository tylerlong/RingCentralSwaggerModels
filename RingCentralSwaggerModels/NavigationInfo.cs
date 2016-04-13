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
    public class NavigationInfo :  IEquatable<NavigationInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationInfo" /> class.
        /// </summary>
        public NavigationInfo()
        {
            
        }

        
        /// <summary>
        /// Canonical URI for the first page of the list
        /// </summary>
        /// <value>Canonical URI for the first page of the list</value>
        [DataMember(Name="firstPage", EmitDefaultValue=false)]
        public string FirstPage { get; set; }
  
        
        /// <summary>
        /// Canonical URI for the next page of the list
        /// </summary>
        /// <value>Canonical URI for the next page of the list</value>
        [DataMember(Name="nextPage", EmitDefaultValue=false)]
        public string NextPage { get; set; }
  
        
        /// <summary>
        /// Canonical URI for the previous page of the list
        /// </summary>
        /// <value>Canonical URI for the previous page of the list</value>
        [DataMember(Name="previousPage", EmitDefaultValue=false)]
        public string PreviousPage { get; set; }
  
        
        /// <summary>
        /// Canonical URI for the last page of the list
        /// </summary>
        /// <value>Canonical URI for the last page of the list</value>
        [DataMember(Name="lastPage", EmitDefaultValue=false)]
        public string LastPage { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NavigationInfo {\n");
            sb.Append("  FirstPage: ").Append(FirstPage).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  PreviousPage: ").Append(PreviousPage).Append("\n");
            sb.Append("  LastPage: ").Append(LastPage).Append("\n");
            
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
            return this.Equals(obj as NavigationInfo);
        }

        /// <summary>
        /// Returns true if NavigationInfo instances are equal
        /// </summary>
        /// <param name="obj">Instance of NavigationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NavigationInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FirstPage == other.FirstPage ||
                    this.FirstPage != null &&
                    this.FirstPage.Equals(other.FirstPage)
                ) && 
                (
                    this.NextPage == other.NextPage ||
                    this.NextPage != null &&
                    this.NextPage.Equals(other.NextPage)
                ) && 
                (
                    this.PreviousPage == other.PreviousPage ||
                    this.PreviousPage != null &&
                    this.PreviousPage.Equals(other.PreviousPage)
                ) && 
                (
                    this.LastPage == other.LastPage ||
                    this.LastPage != null &&
                    this.LastPage.Equals(other.LastPage)
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
                
                if (this.FirstPage != null)
                    hash = hash * 57 + this.FirstPage.GetHashCode();
                
                if (this.NextPage != null)
                    hash = hash * 57 + this.NextPage.GetHashCode();
                
                if (this.PreviousPage != null)
                    hash = hash * 57 + this.PreviousPage.GetHashCode();
                
                if (this.LastPage != null)
                    hash = hash * 57 + this.LastPage.GetHashCode();
                
                return hash;
            }
        }

    }
}
