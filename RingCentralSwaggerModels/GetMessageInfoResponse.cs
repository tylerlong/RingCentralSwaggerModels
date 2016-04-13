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
    public class GetMessageInfoResponse :  IEquatable<GetMessageInfoResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMessageInfoResponse" /> class.
        /// </summary>
        public GetMessageInfoResponse()
        {
            
        }

        
        /// <summary>
        /// Internal identifier of a message
        /// </summary>
        /// <value>Internal identifier of a message</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Canonical URI of a message
        /// </summary>
        /// <value>Canonical URI of a message</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
  
        
        /// <summary>
        /// The list of message attachments
        /// </summary>
        /// <value>The list of message attachments</value>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<MessageAttachmentInfo> Attachments { get; set; }
  
        
        /// <summary>
        /// Message availability status. Message in 'Deleted' state is still preserved with all its attachments and can be restored. 'Purged' means that all attachments are already deleted and the message itself is about to be physically deleted shortly
        /// </summary>
        /// <value>Message availability status. Message in 'Deleted' state is still preserved with all its attachments and can be restored. 'Purged' means that all attachments are already deleted and the message itself is about to be physically deleted shortly</value>
        [DataMember(Name="availability", EmitDefaultValue=false)]
        public string Availability { get; set; }
  
        
        /// <summary>
        /// SMS and Pager only. Identifier of the conversation the message belongs to
        /// </summary>
        /// <value>SMS and Pager only. Identifier of the conversation the message belongs to</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public long? ConversationId { get; set; }
  
        
        /// <summary>
        /// Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        /// <value>Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z</value>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public DateTime? CreationTime { get; set; }
  
        
        /// <summary>
        /// SMS only. Delivery error code returned by gateway
        /// </summary>
        /// <value>SMS only. Delivery error code returned by gateway</value>
        [DataMember(Name="deliveryErrorCode", EmitDefaultValue=false)]
        public string DeliveryErrorCode { get; set; }
  
        
        /// <summary>
        /// Message direction. Note that for some message types not all directions are allowed. For example voicemail messages can be only inbound
        /// </summary>
        /// <value>Message direction. Note that for some message types not all directions are allowed. For example voicemail messages can be only inbound</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public string Direction { get; set; }
  
        
        /// <summary>
        /// Fax only. Page count in fax message
        /// </summary>
        /// <value>Fax only. Page count in fax message</value>
        [DataMember(Name="faxPageCount", EmitDefaultValue=false)]
        public int? FaxPageCount { get; set; }
  
        
        /// <summary>
        /// Fax only. Resolution of fax message. ('High' for black and white image scanned at 200 dpi, 'Low' for black and white image scanned at 100 dpi)
        /// </summary>
        /// <value>Fax only. Resolution of fax message. ('High' for black and white image scanned at 200 dpi, 'Low' for black and white image scanned at 100 dpi)</value>
        [DataMember(Name="faxResolution", EmitDefaultValue=false)]
        public string FaxResolution { get; set; }
  
        
        /// <summary>
        /// Sender information
        /// </summary>
        /// <value>Sender information</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public MessageStoreCallerInfoResponse From { get; set; }
  
        
        /// <summary>
        /// The datetime when the message was modified on server in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        /// <value>The datetime when the message was modified on server in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z</value>
        [DataMember(Name="lastModifiedTime", EmitDefaultValue=false)]
        public DateTime? LastModifiedTime { get; set; }
  
        
        /// <summary>
        /// Message status. Different message types may have different allowed status values.For outbound faxes the aggregated message status is returned: If status for at least one recipient is 'Queued', then 'Queued' value is returned If status for at least one recipient is 'SendingFailed', then 'SendingFailed' value is returned In other cases Sent status is returned
        /// </summary>
        /// <value>Message status. Different message types may have different allowed status values.For outbound faxes the aggregated message status is returned: If status for at least one recipient is 'Queued', then 'Queued' value is returned If status for at least one recipient is 'SendingFailed', then 'SendingFailed' value is returned In other cases Sent status is returned</value>
        [DataMember(Name="messageStatus", EmitDefaultValue=false)]
        public string MessageStatus { get; set; }
  
        
        /// <summary>
        /// Pager only True if at least one of the message recipients is Department extension
        /// </summary>
        /// <value>Pager only True if at least one of the message recipients is Department extension</value>
        [DataMember(Name="pgToDepartment", EmitDefaultValue=false)]
        public bool? PgToDepartment { get; set; }
  
        
        /// <summary>
        /// Message priority
        /// </summary>
        /// <value>Message priority</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public string Priority { get; set; }
  
        
        /// <summary>
        /// Message read status
        /// </summary>
        /// <value>Message read status</value>
        [DataMember(Name="readStatus", EmitDefaultValue=false)]
        public string ReadStatus { get; set; }
  
        
        /// <summary>
        /// SMS only. The datetime when outbound SMS was delivered to recipient's handset in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. It is filled only if the carrier sends a delivery receipt to RingCentral
        /// </summary>
        /// <value>SMS only. The datetime when outbound SMS was delivered to recipient's handset in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. It is filled only if the carrier sends a delivery receipt to RingCentral</value>
        [DataMember(Name="smsDeliveryTime", EmitDefaultValue=false)]
        public DateTime? SmsDeliveryTime { get; set; }
  
        
        /// <summary>
        /// SMS only. Number of attempts made to send an outbound SMS to the gateway (if gateway is temporary unavailable)
        /// </summary>
        /// <value>SMS only. Number of attempts made to send an outbound SMS to the gateway (if gateway is temporary unavailable)</value>
        [DataMember(Name="smsSendingAttemptsCount", EmitDefaultValue=false)]
        public int? SmsSendingAttemptsCount { get; set; }
  
        
        /// <summary>
        /// Message subject. For SMS and Pager messages it replicates message text which is also returned as an attachment
        /// </summary>
        /// <value>Message subject. For SMS and Pager messages it replicates message text which is also returned as an attachment</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }
  
        
        /// <summary>
        /// Recipient information
        /// </summary>
        /// <value>Recipient information</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public List<MessageStoreCallerInfoResponse> To { get; set; }
  
        
        /// <summary>
        /// Message type
        /// </summary>
        /// <value>Message type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// Voicemail only. Status of voicemail to text transcription. If VoicemailToText feature is not activated for account, the 'NotAvailable' value is returned
        /// </summary>
        /// <value>Voicemail only. Status of voicemail to text transcription. If VoicemailToText feature is not activated for account, the 'NotAvailable' value is returned</value>
        [DataMember(Name="vmTranscriptionStatus", EmitDefaultValue=false)]
        public string VmTranscriptionStatus { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetMessageInfoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  DeliveryErrorCode: ").Append(DeliveryErrorCode).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  FaxPageCount: ").Append(FaxPageCount).Append("\n");
            sb.Append("  FaxResolution: ").Append(FaxResolution).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  LastModifiedTime: ").Append(LastModifiedTime).Append("\n");
            sb.Append("  MessageStatus: ").Append(MessageStatus).Append("\n");
            sb.Append("  PgToDepartment: ").Append(PgToDepartment).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  ReadStatus: ").Append(ReadStatus).Append("\n");
            sb.Append("  SmsDeliveryTime: ").Append(SmsDeliveryTime).Append("\n");
            sb.Append("  SmsSendingAttemptsCount: ").Append(SmsSendingAttemptsCount).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VmTranscriptionStatus: ").Append(VmTranscriptionStatus).Append("\n");
            
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
            return this.Equals(obj as GetMessageInfoResponse);
        }

        /// <summary>
        /// Returns true if GetMessageInfoResponse instances are equal
        /// </summary>
        /// <param name="obj">Instance of GetMessageInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetMessageInfoResponse other)
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
                    this.Attachments == other.Attachments ||
                    this.Attachments != null &&
                    this.Attachments.SequenceEqual(other.Attachments)
                ) && 
                (
                    this.Availability == other.Availability ||
                    this.Availability != null &&
                    this.Availability.Equals(other.Availability)
                ) && 
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) && 
                (
                    this.CreationTime == other.CreationTime ||
                    this.CreationTime != null &&
                    this.CreationTime.Equals(other.CreationTime)
                ) && 
                (
                    this.DeliveryErrorCode == other.DeliveryErrorCode ||
                    this.DeliveryErrorCode != null &&
                    this.DeliveryErrorCode.Equals(other.DeliveryErrorCode)
                ) && 
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) && 
                (
                    this.FaxPageCount == other.FaxPageCount ||
                    this.FaxPageCount != null &&
                    this.FaxPageCount.Equals(other.FaxPageCount)
                ) && 
                (
                    this.FaxResolution == other.FaxResolution ||
                    this.FaxResolution != null &&
                    this.FaxResolution.Equals(other.FaxResolution)
                ) && 
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) && 
                (
                    this.LastModifiedTime == other.LastModifiedTime ||
                    this.LastModifiedTime != null &&
                    this.LastModifiedTime.Equals(other.LastModifiedTime)
                ) && 
                (
                    this.MessageStatus == other.MessageStatus ||
                    this.MessageStatus != null &&
                    this.MessageStatus.Equals(other.MessageStatus)
                ) && 
                (
                    this.PgToDepartment == other.PgToDepartment ||
                    this.PgToDepartment != null &&
                    this.PgToDepartment.Equals(other.PgToDepartment)
                ) && 
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) && 
                (
                    this.ReadStatus == other.ReadStatus ||
                    this.ReadStatus != null &&
                    this.ReadStatus.Equals(other.ReadStatus)
                ) && 
                (
                    this.SmsDeliveryTime == other.SmsDeliveryTime ||
                    this.SmsDeliveryTime != null &&
                    this.SmsDeliveryTime.Equals(other.SmsDeliveryTime)
                ) && 
                (
                    this.SmsSendingAttemptsCount == other.SmsSendingAttemptsCount ||
                    this.SmsSendingAttemptsCount != null &&
                    this.SmsSendingAttemptsCount.Equals(other.SmsSendingAttemptsCount)
                ) && 
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) && 
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.SequenceEqual(other.To)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.VmTranscriptionStatus == other.VmTranscriptionStatus ||
                    this.VmTranscriptionStatus != null &&
                    this.VmTranscriptionStatus.Equals(other.VmTranscriptionStatus)
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
                
                if (this.Attachments != null)
                    hash = hash * 57 + this.Attachments.GetHashCode();
                
                if (this.Availability != null)
                    hash = hash * 57 + this.Availability.GetHashCode();
                
                if (this.ConversationId != null)
                    hash = hash * 57 + this.ConversationId.GetHashCode();
                
                if (this.CreationTime != null)
                    hash = hash * 57 + this.CreationTime.GetHashCode();
                
                if (this.DeliveryErrorCode != null)
                    hash = hash * 57 + this.DeliveryErrorCode.GetHashCode();
                
                if (this.Direction != null)
                    hash = hash * 57 + this.Direction.GetHashCode();
                
                if (this.FaxPageCount != null)
                    hash = hash * 57 + this.FaxPageCount.GetHashCode();
                
                if (this.FaxResolution != null)
                    hash = hash * 57 + this.FaxResolution.GetHashCode();
                
                if (this.From != null)
                    hash = hash * 57 + this.From.GetHashCode();
                
                if (this.LastModifiedTime != null)
                    hash = hash * 57 + this.LastModifiedTime.GetHashCode();
                
                if (this.MessageStatus != null)
                    hash = hash * 57 + this.MessageStatus.GetHashCode();
                
                if (this.PgToDepartment != null)
                    hash = hash * 57 + this.PgToDepartment.GetHashCode();
                
                if (this.Priority != null)
                    hash = hash * 57 + this.Priority.GetHashCode();
                
                if (this.ReadStatus != null)
                    hash = hash * 57 + this.ReadStatus.GetHashCode();
                
                if (this.SmsDeliveryTime != null)
                    hash = hash * 57 + this.SmsDeliveryTime.GetHashCode();
                
                if (this.SmsSendingAttemptsCount != null)
                    hash = hash * 57 + this.SmsSendingAttemptsCount.GetHashCode();
                
                if (this.Subject != null)
                    hash = hash * 57 + this.Subject.GetHashCode();
                
                if (this.To != null)
                    hash = hash * 57 + this.To.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 57 + this.Type.GetHashCode();
                
                if (this.VmTranscriptionStatus != null)
                    hash = hash * 57 + this.VmTranscriptionStatus.GetHashCode();
                
                return hash;
            }
        }

    }
}
