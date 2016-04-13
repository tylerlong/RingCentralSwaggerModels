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
    public class LocationInfo :  IEquatable<LocationInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationInfo" /> class.
        /// </summary>
        public LocationInfo()
        {
            
        }

        
        /// <summary>
        /// Canonical URI of a location
        /// </summary>
        /// <value>Canonical URI of a location</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
  
        
        /// <summary>
        /// Area code of the location
        /// </summary>
        /// <value>Area code of the location</value>
        [DataMember(Name="areaCode", EmitDefaultValue=false)]
        public string AreaCode { get; set; }
  
        
        /// <summary>
        /// Official name of the city, belonging to the certain state
        /// </summary>
        /// <value>Official name of the city, belonging to the certain state</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
  
        
        /// <summary>
        /// Area code of the location (3-digit usually), according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See for details North American Numbering Plan
        /// </summary>
        /// <value>Area code of the location (3-digit usually), according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See for details North American Numbering Plan</value>
        [DataMember(Name="npa", EmitDefaultValue=false)]
        public string Npa { get; set; }
  
        
        /// <summary>
        /// Central office code of the location, according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See for details North American Numbering Plan
        /// </summary>
        /// <value>Central office code of the location, according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See for details North American Numbering Plan</value>
        [DataMember(Name="nxx", EmitDefaultValue=false)]
        public string Nxx { get; set; }
  
        
        /// <summary>
        /// ID and URI of the state this location belongs to, see State Info
        /// </summary>
        /// <value>ID and URI of the state this location belongs to, see State Info</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocationInfo {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  AreaCode: ").Append(AreaCode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Npa: ").Append(Npa).Append("\n");
            sb.Append("  Nxx: ").Append(Nxx).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            
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
            return this.Equals(obj as LocationInfo);
        }

        /// <summary>
        /// Returns true if LocationInfo instances are equal
        /// </summary>
        /// <param name="obj">Instance of LocationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocationInfo other)
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
                    this.AreaCode == other.AreaCode ||
                    this.AreaCode != null &&
                    this.AreaCode.Equals(other.AreaCode)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.Npa == other.Npa ||
                    this.Npa != null &&
                    this.Npa.Equals(other.Npa)
                ) && 
                (
                    this.Nxx == other.Nxx ||
                    this.Nxx != null &&
                    this.Nxx.Equals(other.Nxx)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                
                if (this.AreaCode != null)
                    hash = hash * 57 + this.AreaCode.GetHashCode();
                
                if (this.City != null)
                    hash = hash * 57 + this.City.GetHashCode();
                
                if (this.Npa != null)
                    hash = hash * 57 + this.Npa.GetHashCode();
                
                if (this.Nxx != null)
                    hash = hash * 57 + this.Nxx.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 57 + this.State.GetHashCode();
                
                return hash;
            }
        }

    }
}
