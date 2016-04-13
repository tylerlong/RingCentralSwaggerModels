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
    public class RingOutStatusInfo :  IEquatable<RingOutStatusInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RingOutStatusInfo" /> class.
        /// </summary>
        public RingOutStatusInfo()
        {
            
        }

        
        /// <summary>
        /// Status of a call
        /// </summary>
        /// <value>Status of a call</value>
        [DataMember(Name="callStatus", EmitDefaultValue=false)]
        public string CallStatus { get; set; }
  
        
        /// <summary>
        /// Status of a calling party
        /// </summary>
        /// <value>Status of a calling party</value>
        [DataMember(Name="callerStatus", EmitDefaultValue=false)]
        public string CallerStatus { get; set; }
  
        
        /// <summary>
        /// Status of a called party
        /// </summary>
        /// <value>Status of a called party</value>
        [DataMember(Name="calleeStatus", EmitDefaultValue=false)]
        public string CalleeStatus { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RingOutStatusInfo {\n");
            sb.Append("  CallStatus: ").Append(CallStatus).Append("\n");
            sb.Append("  CallerStatus: ").Append(CallerStatus).Append("\n");
            sb.Append("  CalleeStatus: ").Append(CalleeStatus).Append("\n");
            
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
            return this.Equals(obj as RingOutStatusInfo);
        }

        /// <summary>
        /// Returns true if RingOutStatusInfo instances are equal
        /// </summary>
        /// <param name="obj">Instance of RingOutStatusInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RingOutStatusInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CallStatus == other.CallStatus ||
                    this.CallStatus != null &&
                    this.CallStatus.Equals(other.CallStatus)
                ) && 
                (
                    this.CallerStatus == other.CallerStatus ||
                    this.CallerStatus != null &&
                    this.CallerStatus.Equals(other.CallerStatus)
                ) && 
                (
                    this.CalleeStatus == other.CalleeStatus ||
                    this.CalleeStatus != null &&
                    this.CalleeStatus.Equals(other.CalleeStatus)
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
                
                if (this.CallStatus != null)
                    hash = hash * 57 + this.CallStatus.GetHashCode();
                
                if (this.CallerStatus != null)
                    hash = hash * 57 + this.CallerStatus.GetHashCode();
                
                if (this.CalleeStatus != null)
                    hash = hash * 57 + this.CalleeStatus.GetHashCode();
                
                return hash;
            }
        }

    }
}
