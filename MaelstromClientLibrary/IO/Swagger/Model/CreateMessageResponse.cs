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
    public class CreateMessageResponse :  IEquatable<CreateMessageResponse>
    {
        /// <summary>
        /// Gets or Sets RequestSequenceNumber
        /// </summary>
        [DataMember(Name="RequestSequenceNumber", EmitDefaultValue=false)]
        public int? RequestSequenceNumber { get; set; }
  
        
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
        /// Gets or Sets MessageName
        /// </summary>
        [DataMember(Name="MessageName", EmitDefaultValue=false)]
        public string MessageName { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateMessageResponse {\n");
            sb.Append("  RequestSequenceNumber: ").Append(RequestSequenceNumber).Append("\n");
            sb.Append("  IsSuccessful: ").Append(IsSuccessful).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  MessageName: ").Append(MessageName).Append("\n");
            
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
            return Equals(obj as CreateMessageResponse);
        }

        /// <summary>
        /// Returns true if CreateMessageResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateMessageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateMessageResponse other)
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
                    MessageName == other.MessageName ||
                    MessageName != null &&
                    MessageName.Equals(other.MessageName)
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
                
                if (IsSuccessful != null)
                    hash = hash * 59 + IsSuccessful.GetHashCode();
                
                if (ErrorMessage != null)
                    hash = hash * 59 + ErrorMessage.GetHashCode();
                
                if (MessageName != null)
                    hash = hash * 59 + MessageName.GetHashCode();
                
                return hash;
            }
        }

    }
}
