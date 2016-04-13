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
    public class ServicePlanInfo :  IEquatable<ServicePlanInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePlanInfo" /> class.
        /// </summary>
        public ServicePlanInfo()
        {
            
        }

        
        /// <summary>
        /// Internal identifier of a service plan
        /// </summary>
        /// <value>Internal identifier of a service plan</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Name of a service plan
        /// </summary>
        /// <value>Name of a service plan</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Edition of a service plan
        /// </summary>
        /// <value>Edition of a service plan</value>
        [DataMember(Name="edition", EmitDefaultValue=false)]
        public string Edition { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServicePlanInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Edition: ").Append(Edition).Append("\n");
            
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
            return this.Equals(obj as ServicePlanInfo);
        }

        /// <summary>
        /// Returns true if ServicePlanInfo instances are equal
        /// </summary>
        /// <param name="obj">Instance of ServicePlanInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServicePlanInfo other)
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
                    this.Edition == other.Edition ||
                    this.Edition != null &&
                    this.Edition.Equals(other.Edition)
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
                
                if (this.Edition != null)
                    hash = hash * 57 + this.Edition.GetHashCode();
                
                return hash;
            }
        }

    }
}
