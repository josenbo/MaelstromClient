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
    public class CreateSearchResponse :  IEquatable<CreateSearchResponse>
    {
        /// <summary>
        /// Gets or Sets IsSuccessful
        /// </summary>
        [DataMember(Name="IsSuccessful", EmitDefaultValue=false)]
        public bool? IsSuccessful { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="ErrorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name="Messages", EmitDefaultValue=false)]
        public List<Message> Messages { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSearchResponse {\n");
            sb.Append("  IsSuccessful: ").Append(IsSuccessful).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            
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
            return Equals(obj as CreateSearchResponse);
        }

        /// <summary>
        /// Returns true if CreateSearchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSearchResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    IsSuccessful == other.IsSuccessful ||
                    IsSuccessful != null &&
                    IsSuccessful.Equals(other.IsSuccessful)
                ) && 
                (
                    ErrorMessage == other.ErrorMessage ||
                    ErrorMessage != null &&
                    ErrorMessage.Equals(other.ErrorMessage)
                ) && 
                (
                    Messages == other.Messages ||
                    Messages != null &&
                    Messages.SequenceEqual(other.Messages)
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
                
                if (IsSuccessful != null)
                    hash = hash * 59 + IsSuccessful.GetHashCode();
                
                if (ErrorMessage != null)
                    hash = hash * 59 + ErrorMessage.GetHashCode();
                
                if (Messages != null)
                    hash = hash * 59 + Messages.GetHashCode();
                
                return hash;
            }
        }

    }
}
