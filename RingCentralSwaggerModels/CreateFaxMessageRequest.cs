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
    public class CreateFaxMessageRequest :  IEquatable<CreateFaxMessageRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFaxMessageRequest" /> class.
        /// </summary>
        public CreateFaxMessageRequest()
        {
            
        }

        
        /// <summary>
        /// Recipient information. Phone number property is mandatory. Optional for resend fax request
        /// </summary>
        /// <value>Recipient information. Phone number property is mandatory. Optional for resend fax request</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public List<MessageStoreCallerInfoRequest> To { get; set; }
  
        
        /// <summary>
        /// Fax resolution
        /// </summary>
        /// <value>Fax resolution</value>
        [DataMember(Name="resolution", EmitDefaultValue=false)]
        public string Resolution { get; set; }
  
        
        /// <summary>
        /// The datetime to send fax at, in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. If time is not specified, the fax will be send immediately
        /// </summary>
        /// <value>The datetime to send fax at, in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. If time is not specified, the fax will be send immediately</value>
        [DataMember(Name="sendTime", EmitDefaultValue=false)]
        public DateTime? SendTime { get; set; }
  
        
        /// <summary>
        /// Optional. Cover page text, entered by the fax sender and printed on the cover page. Maximum length is limited to 1024 symbols
        /// </summary>
        /// <value>Optional. Cover page text, entered by the fax sender and printed on the cover page. Maximum length is limited to 1024 symbols</value>
        [DataMember(Name="coverPageText", EmitDefaultValue=false)]
        public string CoverPageText { get; set; }
  
        
        /// <summary>
        /// Internal identifier of the original fax message which needs to be resent. Mandatory for resend fax request
        /// </summary>
        /// <value>Internal identifier of the original fax message which needs to be resent. Mandatory for resend fax request</value>
        [DataMember(Name="originalMessageId", EmitDefaultValue=false)]
        public string OriginalMessageId { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFaxMessageRequest {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  SendTime: ").Append(SendTime).Append("\n");
            sb.Append("  CoverPageText: ").Append(CoverPageText).Append("\n");
            sb.Append("  OriginalMessageId: ").Append(OriginalMessageId).Append("\n");
            
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
            return this.Equals(obj as CreateFaxMessageRequest);
        }

        /// <summary>
        /// Returns true if CreateFaxMessageRequest instances are equal
        /// </summary>
        /// <param name="obj">Instance of CreateFaxMessageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFaxMessageRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.SequenceEqual(other.To)
                ) && 
                (
                    this.Resolution == other.Resolution ||
                    this.Resolution != null &&
                    this.Resolution.Equals(other.Resolution)
                ) && 
                (
                    this.SendTime == other.SendTime ||
                    this.SendTime != null &&
                    this.SendTime.Equals(other.SendTime)
                ) && 
                (
                    this.CoverPageText == other.CoverPageText ||
                    this.CoverPageText != null &&
                    this.CoverPageText.Equals(other.CoverPageText)
                ) && 
                (
                    this.OriginalMessageId == other.OriginalMessageId ||
                    this.OriginalMessageId != null &&
                    this.OriginalMessageId.Equals(other.OriginalMessageId)
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
                
                if (this.To != null)
                    hash = hash * 57 + this.To.GetHashCode();
                
                if (this.Resolution != null)
                    hash = hash * 57 + this.Resolution.GetHashCode();
                
                if (this.SendTime != null)
                    hash = hash * 57 + this.SendTime.GetHashCode();
                
                if (this.CoverPageText != null)
                    hash = hash * 57 + this.CoverPageText.GetHashCode();
                
                if (this.OriginalMessageId != null)
                    hash = hash * 57 + this.OriginalMessageId.GetHashCode();
                
                return hash;
            }
        }

    }
}
