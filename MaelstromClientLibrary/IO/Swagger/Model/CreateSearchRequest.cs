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
    public class CreateSearchRequest :  IEquatable<CreateSearchRequest>
    {
        /// <summary>
        /// Gets or Sets MessageGroupName
        /// </summary>
        [DataMember(Name="MessageGroupName", EmitDefaultValue=false)]
        public string MessageGroupName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MaxNumberOfSecondsSinceStatusUpdate
        /// </summary>
        [DataMember(Name="MaxNumberOfSecondsSinceStatusUpdate", EmitDefaultValue=false)]
        public int? MaxNumberOfSecondsSinceStatusUpdate { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ReturnOnlyMessagesInFinalStates
        /// </summary>
        [DataMember(Name="ReturnOnlyMessagesInFinalStates", EmitDefaultValue=false)]
        public bool? ReturnOnlyMessagesInFinalStates { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MessageNamesFilter
        /// </summary>
        [DataMember(Name="MessageNamesFilter", EmitDefaultValue=false)]
        public List<string> MessageNamesFilter { get; set; }
  
        
        /// <summary>
        /// Gets or Sets StateNamesToIncludeContentFor
        /// </summary>
        [DataMember(Name="StateNamesToIncludeContentFor", EmitDefaultValue=false)]
        public List<string> StateNamesToIncludeContentFor { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSearchRequest {\n");
            sb.Append("  MessageGroupName: ").Append(MessageGroupName).Append("\n");
            sb.Append("  MaxNumberOfSecondsSinceStatusUpdate: ").Append(MaxNumberOfSecondsSinceStatusUpdate).Append("\n");
            sb.Append("  ReturnOnlyMessagesInFinalStates: ").Append(ReturnOnlyMessagesInFinalStates).Append("\n");
            sb.Append("  MessageNamesFilter: ").Append(MessageNamesFilter).Append("\n");
            sb.Append("  StateNamesToIncludeContentFor: ").Append(StateNamesToIncludeContentFor).Append("\n");
            
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
            return Equals(obj as CreateSearchRequest);
        }

        /// <summary>
        /// Returns true if CreateSearchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSearchRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    MessageGroupName == other.MessageGroupName ||
                    MessageGroupName != null &&
                    MessageGroupName.Equals(other.MessageGroupName)
                ) && 
                (
                    MaxNumberOfSecondsSinceStatusUpdate == other.MaxNumberOfSecondsSinceStatusUpdate ||
                    MaxNumberOfSecondsSinceStatusUpdate != null &&
                    MaxNumberOfSecondsSinceStatusUpdate.Equals(other.MaxNumberOfSecondsSinceStatusUpdate)
                ) && 
                (
                    ReturnOnlyMessagesInFinalStates == other.ReturnOnlyMessagesInFinalStates ||
                    ReturnOnlyMessagesInFinalStates != null &&
                    ReturnOnlyMessagesInFinalStates.Equals(other.ReturnOnlyMessagesInFinalStates)
                ) && 
                (
                    MessageNamesFilter == other.MessageNamesFilter ||
                    MessageNamesFilter != null &&
                    MessageNamesFilter.SequenceEqual(other.MessageNamesFilter)
                ) && 
                (
                    StateNamesToIncludeContentFor == other.StateNamesToIncludeContentFor ||
                    StateNamesToIncludeContentFor != null &&
                    StateNamesToIncludeContentFor.SequenceEqual(other.StateNamesToIncludeContentFor)
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
                
                if (MessageGroupName != null)
                    hash = hash * 59 + MessageGroupName.GetHashCode();
                
                if (MaxNumberOfSecondsSinceStatusUpdate != null)
                    hash = hash * 59 + MaxNumberOfSecondsSinceStatusUpdate.GetHashCode();
                
                if (ReturnOnlyMessagesInFinalStates != null)
                    hash = hash * 59 + ReturnOnlyMessagesInFinalStates.GetHashCode();
                
                if (MessageNamesFilter != null)
                    hash = hash * 59 + MessageNamesFilter.GetHashCode();
                
                if (StateNamesToIncludeContentFor != null)
                    hash = hash * 59 + StateNamesToIncludeContentFor.GetHashCode();
                
                return hash;
            }
        }

    }
}
