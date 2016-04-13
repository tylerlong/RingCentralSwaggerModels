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
    public class ContactAddressInfo :  IEquatable<ContactAddressInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactAddressInfo" /> class.
        /// </summary>
        public ContactAddressInfo()
        {
            
        }

        
        /// <summary>
        /// Country name of extension user company. Not returned for Address Book
        /// </summary>
        /// <value>Country name of extension user company. Not returned for Address Book</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
  
        
        /// <summary>
        /// State/province name of extension user company
        /// </summary>
        /// <value>State/province name of extension user company</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
  
        
        /// <summary>
        /// City name of extension user company
        /// </summary>
        /// <value>City name of extension user company</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
  
        
        /// <summary>
        /// Street address of extension user company
        /// </summary>
        /// <value>Street address of extension user company</value>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }
  
        
        /// <summary>
        /// Zip code of extension user company
        /// </summary>
        /// <value>Zip code of extension user company</value>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public string Zip { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactAddressInfo {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            
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
            return this.Equals(obj as ContactAddressInfo);
        }

        /// <summary>
        /// Returns true if ContactAddressInfo instances are equal
        /// </summary>
        /// <param name="obj">Instance of ContactAddressInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactAddressInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.Street == other.Street ||
                    this.Street != null &&
                    this.Street.Equals(other.Street)
                ) && 
                (
                    this.Zip == other.Zip ||
                    this.Zip != null &&
                    this.Zip.Equals(other.Zip)
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
                
                if (this.Country != null)
                    hash = hash * 57 + this.Country.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 57 + this.State.GetHashCode();
                
                if (this.City != null)
                    hash = hash * 57 + this.City.GetHashCode();
                
                if (this.Street != null)
                    hash = hash * 57 + this.Street.GetHashCode();
                
                if (this.Zip != null)
                    hash = hash * 57 + this.Zip.GetHashCode();
                
                return hash;
            }
        }

    }
}
