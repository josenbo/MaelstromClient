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
    public class MessageContentVersion :  IEquatable<MessageContentVersion>
    {
        /// <summary>
        /// Gets or Sets ContentVersionLabel
        /// </summary>
        [DataMember(Name="ContentVersionLabel", EmitDefaultValue=false)]
        public string ContentVersionLabel { get; set; }
  
        
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
            sb.Append("class MessageContentVersion {\n");
            sb.Append("  ContentVersionLabel: ").Append(ContentVersionLabel).Append("\n");
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
            return Equals(obj as MessageContentVersion);
        }

        /// <summary>
        /// Returns true if MessageContentVersion instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageContentVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageContentVersion other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    ContentVersionLabel == other.ContentVersionLabel ||
                    ContentVersionLabel != null &&
                    ContentVersionLabel.Equals(other.ContentVersionLabel)
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
                
                if (ContentVersionLabel != null)
                    hash = hash * 59 + ContentVersionLabel.GetHashCode();
                
                if (Content != null)
                    hash = hash * 59 + Content.GetHashCode();
                
                return hash;
            }
        }

    }
}
