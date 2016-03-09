using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace MaelstromClientLibrary.IO.Swagger.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class MessageChange :  IEquatable<MessageChange>
    {
        /// <summary>
        /// Gets or Sets MessageStateName
        /// </summary>
        [DataMember(Name="MessageStateName", EmitDefaultValue=false)]
        public string MessageStateName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="CreatedAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MessageContentVersionLabel
        /// </summary>
        [DataMember(Name="MessageContentVersionLabel", EmitDefaultValue=false)]
        public string MessageContentVersionLabel { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageChange {\n");
            sb.Append("  MessageStateName: ").Append(MessageStateName).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  MessageContentVersionLabel: ").Append(MessageContentVersionLabel).Append("\n");
            
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
            return Equals(obj as MessageChange);
        }

        /// <summary>
        /// Returns true if MessageChange instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageChange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageChange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    MessageStateName == other.MessageStateName ||
                    MessageStateName != null &&
                    MessageStateName.Equals(other.MessageStateName)
                ) && 
                (
                    CreatedAt == other.CreatedAt ||
                    CreatedAt != null &&
                    CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    MessageContentVersionLabel == other.MessageContentVersionLabel ||
                    MessageContentVersionLabel != null &&
                    MessageContentVersionLabel.Equals(other.MessageContentVersionLabel)
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
                
                if (MessageStateName != null)
                    hash = hash * 59 + MessageStateName.GetHashCode();
                
                if (CreatedAt != null)
                    hash = hash * 59 + CreatedAt.GetHashCode();
                
                if (MessageContentVersionLabel != null)
                    hash = hash * 59 + MessageContentVersionLabel.GetHashCode();
                
                return hash;
            }
        }

    }
}
