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
    public class BillingPlanInfo :  IEquatable<BillingPlanInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPlanInfo" /> class.
        /// </summary>
        public BillingPlanInfo()
        {
            
        }

        
        /// <summary>
        /// Internal identifier of a billing plan
        /// </summary>
        /// <value>Internal identifier of a billing plan</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Billing plan name
        /// </summary>
        /// <value>Billing plan name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Duration period
        /// </summary>
        /// <value>Duration period</value>
        [DataMember(Name="durationUnit", EmitDefaultValue=false)]
        public string DurationUnit { get; set; }
  
        
        /// <summary>
        /// Number of duration units
        /// </summary>
        /// <value>Number of duration units</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public string Duration { get; set; }
  
        
        /// <summary>
        /// Billing plan type
        /// </summary>
        /// <value>Billing plan type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingPlanInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DurationUnit: ").Append(DurationUnit).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            
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
            return this.Equals(obj as BillingPlanInfo);
        }

        /// <summary>
        /// Returns true if BillingPlanInfo instances are equal
        /// </summary>
        /// <param name="obj">Instance of BillingPlanInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingPlanInfo other)
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
                    this.DurationUnit == other.DurationUnit ||
                    this.DurationUnit != null &&
                    this.DurationUnit.Equals(other.DurationUnit)
                ) && 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                
                if (this.DurationUnit != null)
                    hash = hash * 57 + this.DurationUnit.GetHashCode();
                
                if (this.Duration != null)
                    hash = hash * 57 + this.Duration.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 57 + this.Type.GetHashCode();
                
                return hash;
            }
        }

    }
}
