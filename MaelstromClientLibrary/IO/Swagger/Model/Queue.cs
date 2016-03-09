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
    public class Queue :  IEquatable<Queue>
    {
        /// <summary>
        /// Gets or Sets QueueName
        /// </summary>
        [DataMember(Name="QueueName", EmitDefaultValue=false)]
        public string QueueName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="IsActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }
  
        
        /// <summary>
        /// Gets or Sets QueueCapabilities
        /// </summary>
        [DataMember(Name="QueueCapabilities", EmitDefaultValue=false)]
        public List<string> QueueCapabilities { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Queue {\n");
            sb.Append("  QueueName: ").Append(QueueName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  QueueCapabilities: ").Append(QueueCapabilities).Append("\n");
            
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
            return Equals(obj as Queue);
        }

        /// <summary>
        /// Returns true if Queue instances are equal
        /// </summary>
        /// <param name="other">Instance of Queue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Queue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    QueueName == other.QueueName ||
                    QueueName != null &&
                    QueueName.Equals(other.QueueName)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    IsActive == other.IsActive ||
                    IsActive != null &&
                    IsActive.Equals(other.IsActive)
                ) && 
                (
                    QueueCapabilities == other.QueueCapabilities ||
                    QueueCapabilities != null &&
                    QueueCapabilities.SequenceEqual(other.QueueCapabilities)
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
                
                if (QueueName != null)
                    hash = hash * 59 + QueueName.GetHashCode();
                
                if (Description != null)
                    hash = hash * 59 + Description.GetHashCode();
                
                if (IsActive != null)
                    hash = hash * 59 + IsActive.GetHashCode();
                
                if (QueueCapabilities != null)
                    hash = hash * 59 + QueueCapabilities.GetHashCode();
                
                return hash;
            }
        }

    }
}
