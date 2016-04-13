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
    public class MakeRingOutRequest :  IEquatable<MakeRingOutRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MakeRingOutRequest" /> class.
        /// </summary>
        public MakeRingOutRequest()
        {
            
        }

        
        /// <summary>
        /// Phone number of the caller. This number corresponds to the 1st leg of the RingOut call. This number can be one of user's configured forwarding numbers or arbitrary number
        /// </summary>
        /// <value>Phone number of the caller. This number corresponds to the 1st leg of the RingOut call. This number can be one of user's configured forwarding numbers or arbitrary number</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public MakeRingOutCallerInfoRequestFrom From { get; set; }
  
        
        /// <summary>
        /// Phone number of the called party. This number corresponds to the 2nd leg of the RingOut call
        /// </summary>
        /// <value>Phone number of the called party. This number corresponds to the 2nd leg of the RingOut call</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public MakeRingOutCallerInfoRequestTo To { get; set; }
  
        
        /// <summary>
        /// The number which will be displayed to the called party
        /// </summary>
        /// <value>The number which will be displayed to the called party</value>
        [DataMember(Name="callerId", EmitDefaultValue=false)]
        public MakeRingOutCallerInfoRequestTo CallerId { get; set; }
  
        
        /// <summary>
        /// The audio prompt that the calling party hears when the call is connected
        /// </summary>
        /// <value>The audio prompt that the calling party hears when the call is connected</value>
        [DataMember(Name="playPrompt", EmitDefaultValue=false)]
        public bool? PlayPrompt { get; set; }
  
        
        /// <summary>
        /// Optional. Dialing plan country data. If not specified, then extension home country is applied by default
        /// </summary>
        /// <value>Optional. Dialing plan country data. If not specified, then extension home country is applied by default</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public MakeRingOutCoutryInfo Country { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MakeRingOutRequest {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  CallerId: ").Append(CallerId).Append("\n");
            sb.Append("  PlayPrompt: ").Append(PlayPrompt).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            
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
            return this.Equals(obj as MakeRingOutRequest);
        }

        /// <summary>
        /// Returns true if MakeRingOutRequest instances are equal
        /// </summary>
        /// <param name="obj">Instance of MakeRingOutRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MakeRingOutRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) && 
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
                ) && 
                (
                    this.CallerId == other.CallerId ||
                    this.CallerId != null &&
                    this.CallerId.Equals(other.CallerId)
                ) && 
                (
                    this.PlayPrompt == other.PlayPrompt ||
                    this.PlayPrompt != null &&
                    this.PlayPrompt.Equals(other.PlayPrompt)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
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
                
                if (this.From != null)
                    hash = hash * 57 + this.From.GetHashCode();
                
                if (this.To != null)
                    hash = hash * 57 + this.To.GetHashCode();
                
                if (this.CallerId != null)
                    hash = hash * 57 + this.CallerId.GetHashCode();
                
                if (this.PlayPrompt != null)
                    hash = hash * 57 + this.PlayPrompt.GetHashCode();
                
                if (this.Country != null)
                    hash = hash * 57 + this.Country.GetHashCode();
                
                return hash;
            }
        }

    }
}
