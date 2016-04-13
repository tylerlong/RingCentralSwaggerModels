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
    public class ContactInfo :  IEquatable<ContactInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactInfo" /> class.
        /// </summary>
        public ContactInfo()
        {
            
        }

        
        /// <summary>
        /// For User extension type only. Extension user first name
        /// </summary>
        /// <value>For User extension type only. Extension user first name</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
  
        
        /// <summary>
        /// For User extension type only. Extension user last name
        /// </summary>
        /// <value>For User extension type only. Extension user last name</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
  
        
        /// <summary>
        /// Extension user company name
        /// </summary>
        /// <value>Extension user company name</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }
  
        
        /// <summary>
        /// Email of extension user
        /// </summary>
        /// <value>Email of extension user</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
  
        
        /// <summary>
        /// Extension user contact phone number
        /// </summary>
        /// <value>Extension user contact phone number</value>
        [DataMember(Name="businessPhone", EmitDefaultValue=false)]
        public string BusinessPhone { get; set; }
  
        
        /// <summary>
        /// Business address of extension user company
        /// </summary>
        /// <value>Business address of extension user company</value>
        [DataMember(Name="businessAddress", EmitDefaultValue=false)]
        public ContactAddressInfo BusinessAddress { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactInfo {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  BusinessPhone: ").Append(BusinessPhone).Append("\n");
            sb.Append("  BusinessAddress: ").Append(BusinessAddress).Append("\n");
            
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
            return this.Equals(obj as ContactInfo);
        }

        /// <summary>
        /// Returns true if ContactInfo instances are equal
        /// </summary>
        /// <param name="obj">Instance of ContactInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.BusinessPhone == other.BusinessPhone ||
                    this.BusinessPhone != null &&
                    this.BusinessPhone.Equals(other.BusinessPhone)
                ) && 
                (
                    this.BusinessAddress == other.BusinessAddress ||
                    this.BusinessAddress != null &&
                    this.BusinessAddress.Equals(other.BusinessAddress)
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
                
                if (this.FirstName != null)
                    hash = hash * 57 + this.FirstName.GetHashCode();
                
                if (this.LastName != null)
                    hash = hash * 57 + this.LastName.GetHashCode();
                
                if (this.Company != null)
                    hash = hash * 57 + this.Company.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 57 + this.Email.GetHashCode();
                
                if (this.BusinessPhone != null)
                    hash = hash * 57 + this.BusinessPhone.GetHashCode();
                
                if (this.BusinessAddress != null)
                    hash = hash * 57 + this.BusinessAddress.GetHashCode();
                
                return hash;
            }
        }

    }
}
