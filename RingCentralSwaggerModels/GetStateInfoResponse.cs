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
    public class GetStateInfoResponse :  IEquatable<GetStateInfoResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStateInfoResponse" /> class.
        /// </summary>
        public GetStateInfoResponse()
        {
            
        }

        
        /// <summary>
        /// Internal identifier of a state
        /// </summary>
        /// <value>Internal identifier of a state</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Canonical URI of a state
        /// </summary>
        /// <value>Canonical URI of a state</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
  
        
        /// <summary>
        /// Information on a country the state belongs to
        /// </summary>
        /// <value>Information on a country the state belongs to</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public GetCountryInfoState Country { get; set; }
  
        
        /// <summary>
        /// Short code for a state (2-letter usually)
        /// </summary>
        /// <value>Short code for a state (2-letter usually)</value>
        [DataMember(Name="isoCode", EmitDefaultValue=false)]
        public string IsoCode { get; set; }
  
        
        /// <summary>
        /// Official name of a state
        /// </summary>
        /// <value>Official name of a state</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetStateInfoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  IsoCode: ").Append(IsoCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            
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
            return this.Equals(obj as GetStateInfoResponse);
        }

        /// <summary>
        /// Returns true if GetStateInfoResponse instances are equal
        /// </summary>
        /// <param name="obj">Instance of GetStateInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetStateInfoResponse other)
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
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.IsoCode == other.IsoCode ||
                    this.IsoCode != null &&
                    this.IsoCode.Equals(other.IsoCode)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                
                if (this.Country != null)
                    hash = hash * 57 + this.Country.GetHashCode();
                
                if (this.IsoCode != null)
                    hash = hash * 57 + this.IsoCode.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                return hash;
            }
        }

    }
}
