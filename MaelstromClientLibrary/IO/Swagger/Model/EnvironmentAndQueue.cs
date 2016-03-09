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
    public class EnvironmentAndQueue :  IEquatable<EnvironmentAndQueue>
    {
        /// <summary>
        /// Gets or Sets EnvironmentName
        /// </summary>
        [DataMember(Name="EnvironmentName", EmitDefaultValue=false)]
        public string EnvironmentName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets QueueName
        /// </summary>
        [DataMember(Name="QueueName", EmitDefaultValue=false)]
        public string QueueName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="IsActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvironmentAndQueue {\n");
            sb.Append("  EnvironmentName: ").Append(EnvironmentName).Append("\n");
            sb.Append("  QueueName: ").Append(QueueName).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            
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
            return Equals(obj as EnvironmentAndQueue);
        }

        /// <summary>
        /// Returns true if EnvironmentAndQueue instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvironmentAndQueue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvironmentAndQueue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    EnvironmentName == other.EnvironmentName ||
                    EnvironmentName != null &&
                    EnvironmentName.Equals(other.EnvironmentName)
                ) && 
                (
                    QueueName == other.QueueName ||
                    QueueName != null &&
                    QueueName.Equals(other.QueueName)
                ) && 
                (
                    IsActive == other.IsActive ||
                    IsActive != null &&
                    IsActive.Equals(other.IsActive)
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
                
                if (EnvironmentName != null)
                    hash = hash * 59 + EnvironmentName.GetHashCode();
                
                if (QueueName != null)
                    hash = hash * 59 + QueueName.GetHashCode();
                
                if (IsActive != null)
                    hash = hash * 59 + IsActive.GetHashCode();
                
                return hash;
            }
        }

    }
}
