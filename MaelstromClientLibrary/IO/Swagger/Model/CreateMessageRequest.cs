using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace MaelstromClientLibrary.IO.Swagger.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class CreateMessageRequest :  IEquatable<CreateMessageRequest>
    {
        /// <summary>
        /// Gets or Sets RequestSequenceNumber
        /// </summary>
        [DataMember(Name="RequestSequenceNumber", EmitDefaultValue=false)]
        public int? RequestSequenceNumber { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MessageGroupName
        /// </summary>
        [DataMember(Name="MessageGroupName", EmitDefaultValue=false)]
        public string MessageGroupName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets QueueCapabilities
        /// </summary>
        [DataMember(Name="QueueCapabilities", EmitDefaultValue=false)]
        public List<string> QueueCapabilities { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="Content", EmitDefaultValue=false)]
        public string Content { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateMessageRequest {\n");
            sb.Append("  RequestSequenceNumber: ").Append(RequestSequenceNumber).Append("\n");
            sb.Append("  MessageGroupName: ").Append(MessageGroupName).Append("\n");
            sb.Append("  QueueCapabilities: ").Append(QueueCapabilities).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            
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
            return Equals(obj as CreateMessageRequest);
        }

        /// <summary>
        /// Returns true if CreateMessageRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateMessageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateMessageRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    RequestSequenceNumber == other.RequestSequenceNumber ||
                    RequestSequenceNumber != null &&
                    RequestSequenceNumber.Equals(other.RequestSequenceNumber)
                ) && 
                (
                    MessageGroupName == other.MessageGroupName ||
                    MessageGroupName != null &&
                    MessageGroupName.Equals(other.MessageGroupName)
                ) && 
                (
                    QueueCapabilities == other.QueueCapabilities ||
                    QueueCapabilities != null &&
                    QueueCapabilities.SequenceEqual(other.QueueCapabilities)
                ) && 
                (
                    Content == other.Content ||
                    Content != null &&
                    Content.Equals(other.Content)
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
                var hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (RequestSequenceNumber != null)
                    hash = hash * 59 + RequestSequenceNumber.GetHashCode();
                
                if (MessageGroupName != null)
                    hash = hash * 59 + MessageGroupName.GetHashCode();
                
                if (QueueCapabilities != null)
                    hash = hash * 59 + QueueCapabilities.GetHashCode();
                
                if (Content != null)
                    hash = hash * 59 + Content.GetHashCode();
                
                return hash;
            }
        }

    }
}
