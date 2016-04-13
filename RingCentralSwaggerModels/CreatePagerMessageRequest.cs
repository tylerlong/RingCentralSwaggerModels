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
    public class CreatePagerMessageRequest :  IEquatable<CreatePagerMessageRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePagerMessageRequest" /> class.
        /// </summary>
        public CreatePagerMessageRequest()
        {
            
        }

        
        /// <summary>
        /// Sender of a pager message. The extensionNumber property must be filled
        /// </summary>
        /// <value>Sender of a pager message. The extensionNumber property must be filled</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public MessageStoreCallerInfoRequest From { get; set; }
  
        
        /// <summary>
        /// Internal identifier of a message this message replies to
        /// </summary>
        /// <value>Internal identifier of a message this message replies to</value>
        [DataMember(Name="replyOn", EmitDefaultValue=false)]
        public int? ReplyOn { get; set; }
  
        
        /// <summary>
        /// Text of a pager message. Max length is 1024 symbols (2-byte UTF-16 encoded). If a character is encoded in 4 bytes in UTF-16 it is treated as 2 characters, thus restricting the maximum message length to 512 symbols
        /// </summary>
        /// <value>Text of a pager message. Max length is 1024 symbols (2-byte UTF-16 encoded). If a character is encoded in 4 bytes in UTF-16 it is treated as 2 characters, thus restricting the maximum message length to 512 symbols</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
  
        
        /// <summary>
        /// Optional if replyOn parameter is specified. Receiver of a pager message. The extensionNumber property must be filled
        /// </summary>
        /// <value>Optional if replyOn parameter is specified. Receiver of a pager message. The extensionNumber property must be filled</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public List<MessageStoreCallerInfoRequest> To { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePagerMessageRequest {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  ReplyOn: ").Append(ReplyOn).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            
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
            return this.Equals(obj as CreatePagerMessageRequest);
        }

        /// <summary>
        /// Returns true if CreatePagerMessageRequest instances are equal
        /// </summary>
        /// <param name="obj">Instance of CreatePagerMessageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePagerMessageRequest other)
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
                    this.ReplyOn == other.ReplyOn ||
                    this.ReplyOn != null &&
                    this.ReplyOn.Equals(other.ReplyOn)
                ) && 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) && 
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.SequenceEqual(other.To)
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
                
                if (this.ReplyOn != null)
                    hash = hash * 57 + this.ReplyOn.GetHashCode();
                
                if (this.Text != null)
                    hash = hash * 57 + this.Text.GetHashCode();
                
                if (this.To != null)
                    hash = hash * 57 + this.To.GetHashCode();
                
                return hash;
            }
        }

    }
}
