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
    public class UpdateMessageRequest :  IEquatable<UpdateMessageRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMessageRequest" /> class.
        /// </summary>
        public UpdateMessageRequest()
        {
            
        }

        
        /// <summary>
        /// Read status of a message to be changed. Multiple values are accepted
        /// </summary>
        /// <value>Read status of a message to be changed. Multiple values are accepted</value>
        [DataMember(Name="readStatus", EmitDefaultValue=false)]
        public string ReadStatus { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMessageRequest {\n");
            sb.Append("  ReadStatus: ").Append(ReadStatus).Append("\n");
            
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
            return this.Equals(obj as UpdateMessageRequest);
        }

        /// <summary>
        /// Returns true if UpdateMessageRequest instances are equal
        /// </summary>
        /// <param name="obj">Instance of UpdateMessageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateMessageRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReadStatus == other.ReadStatus ||
                    this.ReadStatus != null &&
                    this.ReadStatus.Equals(other.ReadStatus)
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
                
                if (this.ReadStatus != null)
                    hash = hash * 57 + this.ReadStatus.GetHashCode();
                
                return hash;
            }
        }

    }
}
