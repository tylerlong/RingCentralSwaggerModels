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
    public class CallLogRecordLegInfo :  IEquatable<CallLogRecordLegInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallLogRecordLegInfo" /> class.
        /// </summary>
        public CallLogRecordLegInfo()
        {
            
        }

        
        /// <summary>
        /// Action description of the call operation
        /// </summary>
        /// <value>Action description of the call operation</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }
  
        
        /// <summary>
        /// Call direction
        /// </summary>
        /// <value>Call direction</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public string Direction { get; set; }
  
        
        /// <summary>
        /// Call duration in seconds
        /// </summary>
        /// <value>Call duration in seconds</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }
  
        
        /// <summary>
        /// Information on extension
        /// </summary>
        /// <value>Information on extension</value>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public ExtensionInfoCallLog Extension { get; set; }
  
        
        /// <summary>
        /// Leg type
        /// </summary>
        /// <value>Leg type</value>
        [DataMember(Name="legType", EmitDefaultValue=false)]
        public string LegType { get; set; }
  
        
        /// <summary>
        /// The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        /// <value>The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }
  
        
        /// <summary>
        /// Call type
        /// </summary>
        /// <value>Call type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// Status description of the call operation
        /// </summary>
        /// <value>Status description of the call operation</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public string Result { get; set; }
  
        
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
        /// Call transport
        /// </summary>
        /// <value>Call transport</value>
        [DataMember(Name="transport", EmitDefaultValue=false)]
        public string Transport { get; set; }
  
        
        /// <summary>
        /// Call recording data. Returned if the call is recorded
        /// </summary>
        /// <value>Call recording data. Returned if the call is recorded</value>
        [DataMember(Name="recording", EmitDefaultValue=false)]
        public RecordingInfo Recording { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallLogRecordLegInfo {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  LegType: ").Append(LegType).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Transport: ").Append(Transport).Append("\n");
            sb.Append("  Recording: ").Append(Recording).Append("\n");
            
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
            return this.Equals(obj as CallLogRecordLegInfo);
        }

        /// <summary>
        /// Returns true if CallLogRecordLegInfo instances are equal
        /// </summary>
        /// <param name="obj">Instance of CallLogRecordLegInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallLogRecordLegInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) && 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.Extension == other.Extension ||
                    this.Extension != null &&
                    this.Extension.Equals(other.Extension)
                ) && 
                (
                    this.LegType == other.LegType ||
                    this.LegType != null &&
                    this.LegType.Equals(other.LegType)
                ) && 
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
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
                    this.Transport == other.Transport ||
                    this.Transport != null &&
                    this.Transport.Equals(other.Transport)
                ) && 
                (
                    this.Recording == other.Recording ||
                    this.Recording != null &&
                    this.Recording.Equals(other.Recording)
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
                
                if (this.Action != null)
                    hash = hash * 57 + this.Action.GetHashCode();
                
                if (this.Direction != null)
                    hash = hash * 57 + this.Direction.GetHashCode();
                
                if (this.Duration != null)
                    hash = hash * 57 + this.Duration.GetHashCode();
                
                if (this.Extension != null)
                    hash = hash * 57 + this.Extension.GetHashCode();
                
                if (this.LegType != null)
                    hash = hash * 57 + this.LegType.GetHashCode();
                
                if (this.StartTime != null)
                    hash = hash * 57 + this.StartTime.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 57 + this.Type.GetHashCode();
                
                if (this.Result != null)
                    hash = hash * 57 + this.Result.GetHashCode();
                
                if (this.From != null)
                    hash = hash * 57 + this.From.GetHashCode();
                
                if (this.To != null)
                    hash = hash * 57 + this.To.GetHashCode();
                
                if (this.Transport != null)
                    hash = hash * 57 + this.Transport.GetHashCode();
                
                if (this.Recording != null)
                    hash = hash * 57 + this.Recording.GetHashCode();
                
                return hash;
            }
        }

    }
}
