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
    public class Environment :  IEquatable<Environment>
    {
        /// <summary>
        /// Gets or Sets EnvironmentName
        /// </summary>
        [DataMember(Name="EnvironmentName", EmitDefaultValue=false)]
        public string EnvironmentName { get; set; }
  
        
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
        /// Gets or Sets Queues
        /// </summary>
        [DataMember(Name="Queues", EmitDefaultValue=false)]
        public List<Queue> Queues { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Environment {\n");
            sb.Append("  EnvironmentName: ").Append(EnvironmentName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Queues: ").Append(Queues).Append("\n");
            
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
            return Equals(obj as Environment);
        }

        /// <summary>
        /// Returns true if Environment instances are equal
        /// </summary>
        /// <param name="other">Instance of Environment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Environment other)
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
                    Queues == other.Queues ||
                    Queues != null &&
                    Queues.SequenceEqual(other.Queues)
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
                
                if (Description != null)
                    hash = hash * 59 + Description.GetHashCode();
                
                if (IsActive != null)
                    hash = hash * 59 + IsActive.GetHashCode();
                
                if (Queues != null)
                    hash = hash * 59 + Queues.GetHashCode();
                
                return hash;
            }
        }

    }
}
