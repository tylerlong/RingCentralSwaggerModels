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
    public class RegionalSettings :  IEquatable<RegionalSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionalSettings" /> class.
        /// </summary>
        public RegionalSettings()
        {
            
        }

        
        /// <summary>
        /// Extension country information
        /// </summary>
        /// <value>Extension country information</value>
        [DataMember(Name="homeCountry", EmitDefaultValue=false)]
        public CountryInfo HomeCountry { get; set; }
  
        
        /// <summary>
        /// Extension timezone information
        /// </summary>
        /// <value>Extension timezone information</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public TimezoneInfo Timezone { get; set; }
  
        
        /// <summary>
        /// User interface language data
        /// </summary>
        /// <value>User interface language data</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public LanguageInfo Language { get; set; }
  
        
        /// <summary>
        /// Information on language used for telephony greetings
        /// </summary>
        /// <value>Information on language used for telephony greetings</value>
        [DataMember(Name="greetingLanguage", EmitDefaultValue=false)]
        public GreetingLanguageInfo GreetingLanguage { get; set; }
  
        
        /// <summary>
        /// Formatting language preferences for numbers, dates and currencies
        /// </summary>
        /// <value>Formatting language preferences for numbers, dates and currencies</value>
        [DataMember(Name="formattingLocale", EmitDefaultValue=false)]
        public FormattingLocaleInfo FormattingLocale { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegionalSettings {\n");
            sb.Append("  HomeCountry: ").Append(HomeCountry).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  GreetingLanguage: ").Append(GreetingLanguage).Append("\n");
            sb.Append("  FormattingLocale: ").Append(FormattingLocale).Append("\n");
            
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
            return this.Equals(obj as RegionalSettings);
        }

        /// <summary>
        /// Returns true if RegionalSettings instances are equal
        /// </summary>
        /// <param name="obj">Instance of RegionalSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegionalSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.HomeCountry == other.HomeCountry ||
                    this.HomeCountry != null &&
                    this.HomeCountry.Equals(other.HomeCountry)
                ) && 
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.GreetingLanguage == other.GreetingLanguage ||
                    this.GreetingLanguage != null &&
                    this.GreetingLanguage.Equals(other.GreetingLanguage)
                ) && 
                (
                    this.FormattingLocale == other.FormattingLocale ||
                    this.FormattingLocale != null &&
                    this.FormattingLocale.Equals(other.FormattingLocale)
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
                
                if (this.HomeCountry != null)
                    hash = hash * 57 + this.HomeCountry.GetHashCode();
                
                if (this.Timezone != null)
                    hash = hash * 57 + this.Timezone.GetHashCode();
                
                if (this.Language != null)
                    hash = hash * 57 + this.Language.GetHashCode();
                
                if (this.GreetingLanguage != null)
                    hash = hash * 57 + this.GreetingLanguage.GetHashCode();
                
                if (this.FormattingLocale != null)
                    hash = hash * 57 + this.FormattingLocale.GetHashCode();
                
                return hash;
            }
        }

    }
}
