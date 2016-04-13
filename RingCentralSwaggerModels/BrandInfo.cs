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
    public class BrandInfo :  IEquatable<BrandInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandInfo" /> class.
        /// </summary>
        public BrandInfo()
        {
            
        }

        
        /// <summary>
        /// Internal identifier of a brand
        /// </summary>
        /// <value>Internal identifier of a brand</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Brand name, for example  RingCentral UK ,  ClearFax
        /// </summary>
        /// <value>Brand name, for example  RingCentral UK ,  ClearFax</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Home country information
        /// </summary>
        /// <value>Home country information</value>
        [DataMember(Name="homeCountry", EmitDefaultValue=false)]
        public CountryInfo HomeCountry { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HomeCountry: ").Append(HomeCountry).Append("\n");
            
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
            return this.Equals(obj as BrandInfo);
        }

        /// <summary>
        /// Returns true if BrandInfo instances are equal
        /// </summary>
        /// <param name="obj">Instance of BrandInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandInfo other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.HomeCountry == other.HomeCountry ||
                    this.HomeCountry != null &&
                    this.HomeCountry.Equals(other.HomeCountry)
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
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.HomeCountry != null)
                    hash = hash * 57 + this.HomeCountry.GetHashCode();
                
                return hash;
            }
        }

    }
}
