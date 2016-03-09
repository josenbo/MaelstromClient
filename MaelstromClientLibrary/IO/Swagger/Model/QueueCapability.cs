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
    public class QueueCapability :  IEquatable<QueueCapability>
    {
        /// <summary>
        /// Gets or Sets CapabiltyName
        /// </summary>
        [DataMember(Name="CapabiltyName", EmitDefaultValue=false)]
        public string CapabiltyName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }
  
        
        /// <summary>
        /// Gets or Sets UponRequest
        /// </summary>
        [DataMember(Name="UponRequest", EmitDefaultValue=false)]
        public bool? UponRequest { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueCapability {\n");
            sb.Append("  CapabiltyName: ").Append(CapabiltyName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UponRequest: ").Append(UponRequest).Append("\n");
            
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
            return Equals(obj as QueueCapability);
        }

        /// <summary>
        /// Returns true if QueueCapability instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueCapability to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueCapability other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    CapabiltyName == other.CapabiltyName ||
                    CapabiltyName != null &&
                    CapabiltyName.Equals(other.CapabiltyName)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    UponRequest == other.UponRequest ||
                    UponRequest != null &&
                    UponRequest.Equals(other.UponRequest)
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
                
                if (CapabiltyName != null)
                    hash = hash * 59 + CapabiltyName.GetHashCode();
                
                if (Description != null)
                    hash = hash * 59 + Description.GetHashCode();
                
                if (UponRequest != null)
                    hash = hash * 59 + UponRequest.GetHashCode();
                
                return hash;
            }
        }

    }
}
