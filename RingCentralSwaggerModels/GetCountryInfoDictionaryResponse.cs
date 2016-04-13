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
    public class GetCountryInfoDictionaryResponse :  IEquatable<GetCountryInfoDictionaryResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCountryInfoDictionaryResponse" /> class.
        /// </summary>
        public GetCountryInfoDictionaryResponse()
        {
            
        }

        
        /// <summary>
        /// Internal identifier of a country
        /// </summary>
        /// <value>Internal identifier of a country</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Canonical URI of a country
        /// </summary>
        /// <value>Canonical URI of a country</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
  
        
        /// <summary>
        /// Country calling code defined by ITU-T recommendations E.123 and E.164, see Calling Codes
        /// </summary>
        /// <value>Country calling code defined by ITU-T recommendations E.123 and E.164, see Calling Codes</value>
        [DataMember(Name="callingCode", EmitDefaultValue=false)]
        public string CallingCode { get; set; }
  
        
        /// <summary>
        /// Emergency calling feature availability/emergency address requirement indicator
        /// </summary>
        /// <value>Emergency calling feature availability/emergency address requirement indicator</value>
        [DataMember(Name="emergencyCalling", EmitDefaultValue=false)]
        public bool? EmergencyCalling { get; set; }
  
        
        /// <summary>
        /// Country code according to the ISO standard, see ISO 3166
        /// </summary>
        /// <value>Country code according to the ISO standard, see ISO 3166</value>
        [DataMember(Name="isoCode", EmitDefaultValue=false)]
        public string IsoCode { get; set; }
  
        
        /// <summary>
        /// Official name of a country
        /// </summary>
        /// <value>Official name of a country</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Determines whether phone numbers are available for a country
        /// </summary>
        /// <value>Determines whether phone numbers are available for a country</value>
        [DataMember(Name="numberSelling", EmitDefaultValue=false)]
        public bool? NumberSelling { get; set; }
  
        
        /// <summary>
        /// Specifies whether login with the phone numbers of this country is enabled or not
        /// </summary>
        /// <value>Specifies whether login with the phone numbers of this country is enabled or not</value>
        [DataMember(Name="loginAllowed", EmitDefaultValue=false)]
        public bool? LoginAllowed { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCountryInfoDictionaryResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  CallingCode: ").Append(CallingCode).Append("\n");
            sb.Append("  EmergencyCalling: ").Append(EmergencyCalling).Append("\n");
            sb.Append("  IsoCode: ").Append(IsoCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NumberSelling: ").Append(NumberSelling).Append("\n");
            sb.Append("  LoginAllowed: ").Append(LoginAllowed).Append("\n");
            
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
            return this.Equals(obj as GetCountryInfoDictionaryResponse);
        }

        /// <summary>
        /// Returns true if GetCountryInfoDictionaryResponse instances are equal
        /// </summary>
        /// <param name="obj">Instance of GetCountryInfoDictionaryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCountryInfoDictionaryResponse other)
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
                    this.CallingCode == other.CallingCode ||
                    this.CallingCode != null &&
                    this.CallingCode.Equals(other.CallingCode)
                ) && 
                (
                    this.EmergencyCalling == other.EmergencyCalling ||
                    this.EmergencyCalling != null &&
                    this.EmergencyCalling.Equals(other.EmergencyCalling)
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
                ) && 
                (
                    this.NumberSelling == other.NumberSelling ||
                    this.NumberSelling != null &&
                    this.NumberSelling.Equals(other.NumberSelling)
                ) && 
                (
                    this.LoginAllowed == other.LoginAllowed ||
                    this.LoginAllowed != null &&
                    this.LoginAllowed.Equals(other.LoginAllowed)
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
                
                if (this.CallingCode != null)
                    hash = hash * 57 + this.CallingCode.GetHashCode();
                
                if (this.EmergencyCalling != null)
                    hash = hash * 57 + this.EmergencyCalling.GetHashCode();
                
                if (this.IsoCode != null)
                    hash = hash * 57 + this.IsoCode.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.NumberSelling != null)
                    hash = hash * 57 + this.NumberSelling.GetHashCode();
                
                if (this.LoginAllowed != null)
                    hash = hash * 57 + this.LoginAllowed.GetHashCode();
                
                return hash;
            }
        }

    }
}
