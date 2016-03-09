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
    public class Message :  IEquatable<Message>
    {
        /// <summary>
        /// Gets or Sets MessageName
        /// </summary>
        [DataMember(Name="MessageName", EmitDefaultValue=false)]
        public string MessageName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MessageGroupName
        /// </summary>
        [DataMember(Name="MessageGroupName", EmitDefaultValue=false)]
        public string MessageGroupName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CurrentState
        /// </summary>
        [DataMember(Name="CurrentState", EmitDefaultValue=false)]
        public string CurrentState { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MessageChanges
        /// </summary>
        [DataMember(Name="MessageChanges", EmitDefaultValue=false)]
        public List<MessageChange> MessageChanges { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MessageContentVersions
        /// </summary>
        [DataMember(Name="MessageContentVersions", EmitDefaultValue=false)]
        public List<MessageContentVersion> MessageContentVersions { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Message {\n");
            sb.Append("  MessageName: ").Append(MessageName).Append("\n");
            sb.Append("  MessageGroupName: ").Append(MessageGroupName).Append("\n");
            sb.Append("  CurrentState: ").Append(CurrentState).Append("\n");
            sb.Append("  MessageChanges: ").Append(MessageChanges).Append("\n");
            sb.Append("  MessageContentVersions: ").Append(MessageContentVersions).Append("\n");
            
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
            return Equals(obj as Message);
        }

        /// <summary>
        /// Returns true if Message instances are equal
        /// </summary>
        /// <param name="other">Instance of Message to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Message other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    MessageName == other.MessageName ||
                    MessageName != null &&
                    MessageName.Equals(other.MessageName)
                ) && 
                (
                    MessageGroupName == other.MessageGroupName ||
                    MessageGroupName != null &&
                    MessageGroupName.Equals(other.MessageGroupName)
                ) && 
                (
                    CurrentState == other.CurrentState ||
                    CurrentState != null &&
                    CurrentState.Equals(other.CurrentState)
                ) && 
                (
                    MessageChanges == other.MessageChanges ||
                    MessageChanges != null &&
                    MessageChanges.SequenceEqual(other.MessageChanges)
                ) && 
                (
                    MessageContentVersions == other.MessageContentVersions ||
                    MessageContentVersions != null &&
                    MessageContentVersions.SequenceEqual(other.MessageContentVersions)
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
                
                if (MessageName != null)
                    hash = hash * 59 + MessageName.GetHashCode();
                
                if (MessageGroupName != null)
                    hash = hash * 59 + MessageGroupName.GetHashCode();
                
                if (CurrentState != null)
                    hash = hash * 59 + CurrentState.GetHashCode();
                
                if (MessageChanges != null)
                    hash = hash * 59 + MessageChanges.GetHashCode();
                
                if (MessageContentVersions != null)
                    hash = hash * 59 + MessageContentVersions.GetHashCode();
                
                return hash;
            }
        }

    }
}
