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
    public class LanguageInfo :  IEquatable<LanguageInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageInfo" /> class.
        /// </summary>
        public LanguageInfo()
        {
            
        }

        
        /// <summary>
        /// Internal identifier of a language
        /// </summary>
        /// <value>Internal identifier of a language</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Canonical URI of a language
        /// </summary>
        /// <value>Canonical URI of a language</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
  
        
        /// <summary>
        /// Indicates whether a language is available as greeting language
        /// </summary>
        /// <value>Indicates whether a language is available as greeting language</value>
        [DataMember(Name="greeting", EmitDefaultValue=false)]
        public bool? Greeting { get; set; }
  
        
        /// <summary>
        /// Indicates whether a language is available as formatting locale
        /// </summary>
        /// <value>Indicates whether a language is available as formatting locale</value>
        [DataMember(Name="formattingLocale", EmitDefaultValue=false)]
        public bool? FormattingLocale { get; set; }
  
        
        /// <summary>
        /// Localization code of a language
        /// </summary>
        /// <value>Localization code of a language</value>
        [DataMember(Name="localeCode", EmitDefaultValue=false)]
        public string LocaleCode { get; set; }
  
        
        /// <summary>
        /// Official name of a language
        /// </summary>
        /// <value>Official name of a language</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Indicates whether a language is available as UI language
        /// </summary>
        /// <value>Indicates whether a language is available as UI language</value>
        [DataMember(Name="ui", EmitDefaultValue=false)]
        public bool? Ui { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LanguageInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Greeting: ").Append(Greeting).Append("\n");
            sb.Append("  FormattingLocale: ").Append(FormattingLocale).Append("\n");
            sb.Append("  LocaleCode: ").Append(LocaleCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Ui: ").Append(Ui).Append("\n");
            
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
            return this.Equals(obj as LanguageInfo);
        }

        /// <summary>
        /// Returns true if LanguageInfo instances are equal
        /// </summary>
        /// <param name="obj">Instance of LanguageInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LanguageInfo other)
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
                    this.Greeting == other.Greeting ||
                    this.Greeting != null &&
                    this.Greeting.Equals(other.Greeting)
                ) && 
                (
                    this.FormattingLocale == other.FormattingLocale ||
                    this.FormattingLocale != null &&
                    this.FormattingLocale.Equals(other.FormattingLocale)
                ) && 
                (
                    this.LocaleCode == other.LocaleCode ||
                    this.LocaleCode != null &&
                    this.LocaleCode.Equals(other.LocaleCode)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Ui == other.Ui ||
                    this.Ui != null &&
                    this.Ui.Equals(other.Ui)
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
                
                if (this.Greeting != null)
                    hash = hash * 57 + this.Greeting.GetHashCode();
                
                if (this.FormattingLocale != null)
                    hash = hash * 57 + this.FormattingLocale.GetHashCode();
                
                if (this.LocaleCode != null)
                    hash = hash * 57 + this.LocaleCode.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Ui != null)
                    hash = hash * 57 + this.Ui.GetHashCode();
                
                return hash;
            }
        }

    }
}
