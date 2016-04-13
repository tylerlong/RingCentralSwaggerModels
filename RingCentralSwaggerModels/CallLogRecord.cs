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
    public class CallLogRecord :  IEquatable<CallLogRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallLogRecord" /> class.
        /// </summary>
        public CallLogRecord()
        {
            
        }

        
        /// <summary>
        /// Internal identifier of a cal log record
        /// </summary>
        /// <value>Internal identifier of a cal log record</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Canonical URI of a call log record
        /// </summary>
        /// <value>Canonical URI of a call log record</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
  
        
        /// <summary>
        /// Internal identifier of a call session
        /// </summary>
        /// <value>Internal identifier of a call session</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }
  
        
        /// <summary>
        /// Caller information
        /// </summary>
        /// <value>Caller information</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public CallLogCallerInfo From { get; set; }
  
        
        /// <summary>
        /// Callee information
        /// </summary>
        /// <value>Callee information</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public CallLogCallerInfo To { get; set; }
  
        
        /// <summary>
        /// Call type
        /// </summary>
        /// <value>Call type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// Call direction
        /// </summary>
        /// <value>Call direction</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public string Direction { get; set; }
  
        
        /// <summary>
        /// Action description of the call operation
        /// </summary>
        /// <value>Action description of the call operation</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }
  
        
        /// <summary>
        /// Status description of the call operation
        /// </summary>
        /// <value>Status description of the call operation</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public string Result { get; set; }
  
        
        /// <summary>
        /// The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        /// <value>The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }
  
        
        /// <summary>
        /// Call duration in seconds
        /// </summary>
        /// <value>Call duration in seconds</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }
  
        
        /// <summary>
        /// Call recording data. Returned if the call is recorded, the withRecording parameter is set to 'True' in this case
        /// </summary>
        /// <value>Call recording data. Returned if the call is recorded, the withRecording parameter is set to 'True' in this case</value>
        [DataMember(Name="recording", EmitDefaultValue=false)]
        public RecordingInfo Recording { get; set; }
  
        
        /// <summary>
        /// For 'Detailed' view only. The datetime when the call log record was modified in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        /// <value>For 'Detailed' view only. The datetime when the call log record was modified in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z</value>
        [DataMember(Name="lastModifiedTime", EmitDefaultValue=false)]
        public DateTime? LastModifiedTime { get; set; }
  
        
        /// <summary>
        /// For 'Detailed' view only. Call transport
        /// </summary>
        /// <value>For 'Detailed' view only. Call transport</value>
        [DataMember(Name="transport", EmitDefaultValue=false)]
        public string Transport { get; set; }
  
        
        /// <summary>
        /// For 'Detailed' view only. Leg description
        /// </summary>
        /// <value>For 'Detailed' view only. Leg description</value>
        [DataMember(Name="legs", EmitDefaultValue=false)]
        public List<CallLogRecordLegInfo> Legs { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallLogRecord {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Recording: ").Append(Recording).Append("\n");
            sb.Append("  LastModifiedTime: ").Append(LastModifiedTime).Append("\n");
            sb.Append("  Transport: ").Append(Transport).Append("\n");
            sb.Append("  Legs: ").Append(Legs).Append("\n");
            
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
            return this.Equals(obj as CallLogRecord);
        }

        /// <summary>
        /// Returns true if CallLogRecord instances are equal
        /// </summary>
        /// <param name="obj">Instance of CallLogRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallLogRecord other)
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
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) && 
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) && 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
                ) && 
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) && 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.Recording == other.Recording ||
                    this.Recording != null &&
                    this.Recording.Equals(other.Recording)
                ) && 
                (
                    this.LastModifiedTime == other.LastModifiedTime ||
                    this.LastModifiedTime != null &&
                    this.LastModifiedTime.Equals(other.LastModifiedTime)
                ) && 
                (
                    this.Transport == other.Transport ||
                    this.Transport != null &&
                    this.Transport.Equals(other.Transport)
                ) && 
                (
                    this.Legs == other.Legs ||
                    this.Legs != null &&
                    this.Legs.SequenceEqual(other.Legs)
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
                
                if (this.SessionId != null)
                    hash = hash * 57 + this.SessionId.GetHashCode();
                
                if (this.From != null)
                    hash = hash * 57 + this.From.GetHashCode();
                
                if (this.To != null)
                    hash = hash * 57 + this.To.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 57 + this.Type.GetHashCode();
                
                if (this.Direction != null)
                    hash = hash * 57 + this.Direction.GetHashCode();
                
                if (this.Action != null)
                    hash = hash * 57 + this.Action.GetHashCode();
                
                if (this.Result != null)
                    hash = hash * 57 + this.Result.GetHashCode();
                
                if (this.StartTime != null)
                    hash = hash * 57 + this.StartTime.GetHashCode();
                
                if (this.Duration != null)
                    hash = hash * 57 + this.Duration.GetHashCode();
                
                if (this.Recording != null)
                    hash = hash * 57 + this.Recording.GetHashCode();
                
                if (this.LastModifiedTime != null)
                    hash = hash * 57 + this.LastModifiedTime.GetHashCode();
                
                if (this.Transport != null)
                    hash = hash * 57 + this.Transport.GetHashCode();
                
                if (this.Legs != null)
                    hash = hash * 57 + this.Legs.GetHashCode();
                
                return hash;
            }
        }

    }
}
