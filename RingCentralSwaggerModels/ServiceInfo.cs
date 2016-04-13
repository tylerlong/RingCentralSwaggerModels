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
    public class ServiceInfo :  IEquatable<ServiceInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceInfo" /> class.
        /// </summary>
        public ServiceInfo()
        {
            
        }

        
        /// <summary>
        /// Canonical URI of a service info resource
        /// </summary>
        /// <value>Canonical URI of a service info resource</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
  
        
        /// <summary>
        /// Information on account billing plan
        /// </summary>
        /// <value>Information on account billing plan</value>
        [DataMember(Name="billingPlan", EmitDefaultValue=false)]
        public BillingPlanInfo BillingPlan { get; set; }
  
        
        /// <summary>
        /// Information on account brand
        /// </summary>
        /// <value>Information on account brand</value>
        [DataMember(Name="brand", EmitDefaultValue=false)]
        public BrandInfo Brand { get; set; }
  
        
        /// <summary>
        /// Information on account service plan
        /// </summary>
        /// <value>Information on account service plan</value>
        [DataMember(Name="servicePlan", EmitDefaultValue=false)]
        public ServicePlanInfo ServicePlan { get; set; }
  
        
        /// <summary>
        /// Information on account target service plan
        /// </summary>
        /// <value>Information on account target service plan</value>
        [DataMember(Name="targetServicePlan", EmitDefaultValue=false)]
        public TargetServicePlanInfo TargetServicePlan { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceInfo {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  BillingPlan: ").Append(BillingPlan).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  ServicePlan: ").Append(ServicePlan).Append("\n");
            sb.Append("  TargetServicePlan: ").Append(TargetServicePlan).Append("\n");
            
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
            return this.Equals(obj as ServiceInfo);
        }

        /// <summary>
        /// Returns true if ServiceInfo instances are equal
        /// </summary>
        /// <param name="obj">Instance of ServiceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceInfo other)
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
                    this.BillingPlan == other.BillingPlan ||
                    this.BillingPlan != null &&
                    this.BillingPlan.Equals(other.BillingPlan)
                ) && 
                (
                    this.Brand == other.Brand ||
                    this.Brand != null &&
                    this.Brand.Equals(other.Brand)
                ) && 
                (
                    this.ServicePlan == other.ServicePlan ||
                    this.ServicePlan != null &&
                    this.ServicePlan.Equals(other.ServicePlan)
                ) && 
                (
                    this.TargetServicePlan == other.TargetServicePlan ||
                    this.TargetServicePlan != null &&
                    this.TargetServicePlan.Equals(other.TargetServicePlan)
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
                
                if (this.BillingPlan != null)
                    hash = hash * 57 + this.BillingPlan.GetHashCode();
                
                if (this.Brand != null)
                    hash = hash * 57 + this.Brand.GetHashCode();
                
                if (this.ServicePlan != null)
                    hash = hash * 57 + this.ServicePlan.GetHashCode();
                
                if (this.TargetServicePlan != null)
                    hash = hash * 57 + this.TargetServicePlan.GetHashCode();
                
                return hash;
            }
        }

    }
}
