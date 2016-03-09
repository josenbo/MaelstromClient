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
    public class MessageState :  IEquatable<MessageState>
    {
        /// <summary>
        /// Gets or Sets MessageStateName
        /// </summary>
        [DataMember(Name="MessageStateName", EmitDefaultValue=false)]
        public string MessageStateName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IsInitialState
        /// </summary>
        [DataMember(Name="IsInitialState", EmitDefaultValue=false)]
        public bool? IsInitialState { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IsFinalState
        /// </summary>
        [DataMember(Name="IsFinalState", EmitDefaultValue=false)]
        public bool? IsFinalState { get; set; }
  
        
        /// <summary>
        /// Gets or Sets HasFailed
        /// </summary>
        [DataMember(Name="HasFailed", EmitDefaultValue=false)]
        public bool? HasFailed { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Predecessors
        /// </summary>
        [DataMember(Name="Predecessors", EmitDefaultValue=false)]
        public List<string> Predecessors { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Successors
        /// </summary>
        [DataMember(Name="Successors", EmitDefaultValue=false)]
        public List<string> Successors { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageState {\n");
            sb.Append("  MessageStateName: ").Append(MessageStateName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsInitialState: ").Append(IsInitialState).Append("\n");
            sb.Append("  IsFinalState: ").Append(IsFinalState).Append("\n");
            sb.Append("  HasFailed: ").Append(HasFailed).Append("\n");
            sb.Append("  Predecessors: ").Append(Predecessors).Append("\n");
            sb.Append("  Successors: ").Append(Successors).Append("\n");
            
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
            return Equals(obj as MessageState);
        }

        /// <summary>
        /// Returns true if MessageState instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageState other)
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
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    IsInitialState == other.IsInitialState ||
                    IsInitialState != null &&
                    IsInitialState.Equals(other.IsInitialState)
                ) && 
                (
                    IsFinalState == other.IsFinalState ||
                    IsFinalState != null &&
                    IsFinalState.Equals(other.IsFinalState)
                ) && 
                (
                    HasFailed == other.HasFailed ||
                    HasFailed != null &&
                    HasFailed.Equals(other.HasFailed)
                ) && 
                (
                    Predecessors == other.Predecessors ||
                    Predecessors != null &&
                    Predecessors.SequenceEqual(other.Predecessors)
                ) && 
                (
                    Successors == other.Successors ||
                    Successors != null &&
                    Successors.SequenceEqual(other.Successors)
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
                
                if (Description != null)
                    hash = hash * 59 + Description.GetHashCode();
                
                if (IsInitialState != null)
                    hash = hash * 59 + IsInitialState.GetHashCode();
                
                if (IsFinalState != null)
                    hash = hash * 59 + IsFinalState.GetHashCode();
                
                if (HasFailed != null)
                    hash = hash * 59 + HasFailed.GetHashCode();
                
                if (Predecessors != null)
                    hash = hash * 59 + Predecessors.GetHashCode();
                
                if (Successors != null)
                    hash = hash * 59 + Successors.GetHashCode();
                
                return hash;
            }
        }

    }
}
