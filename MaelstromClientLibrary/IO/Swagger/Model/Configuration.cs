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
    public class Configuration :  IEquatable<Configuration>
    {
        /// <summary>
        /// Gets or Sets MessageStatesVersion
        /// </summary>
        [DataMember(Name="MessageStatesVersion", EmitDefaultValue=false)]
        public string MessageStatesVersion { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MessageStates
        /// </summary>
        [DataMember(Name="MessageStates", EmitDefaultValue=false)]
        public List<MessageState> MessageStates { get; set; }
  
        
        /// <summary>
        /// Gets or Sets QueueCapabilitiesVersion
        /// </summary>
        [DataMember(Name="QueueCapabilitiesVersion", EmitDefaultValue=false)]
        public string QueueCapabilitiesVersion { get; set; }
  
        
        /// <summary>
        /// Gets or Sets QueueCapabilities
        /// </summary>
        [DataMember(Name="QueueCapabilities", EmitDefaultValue=false)]
        public List<QueueCapability> QueueCapabilities { get; set; }
  
        
        /// <summary>
        /// Gets or Sets EnvironmentsAndQueues
        /// </summary>
        [DataMember(Name="EnvironmentsAndQueues", EmitDefaultValue=false)]
        public List<EnvironmentAndQueue> EnvironmentsAndQueues { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Configuration {\n");
            sb.Append("  MessageStatesVersion: ").Append(MessageStatesVersion).Append("\n");
            sb.Append("  MessageStates: ").Append(MessageStates).Append("\n");
            sb.Append("  QueueCapabilitiesVersion: ").Append(QueueCapabilitiesVersion).Append("\n");
            sb.Append("  QueueCapabilities: ").Append(QueueCapabilities).Append("\n");
            sb.Append("  EnvironmentsAndQueues: ").Append(EnvironmentsAndQueues).Append("\n");
            
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
            return Equals(obj as Configuration);
        }

        /// <summary>
        /// Returns true if Configuration instances are equal
        /// </summary>
        /// <param name="other">Instance of Configuration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Configuration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    MessageStatesVersion == other.MessageStatesVersion ||
                    MessageStatesVersion != null &&
                    MessageStatesVersion.Equals(other.MessageStatesVersion)
                ) && 
                (
                    MessageStates == other.MessageStates ||
                    MessageStates != null &&
                    MessageStates.SequenceEqual(other.MessageStates)
                ) && 
                (
                    QueueCapabilitiesVersion == other.QueueCapabilitiesVersion ||
                    QueueCapabilitiesVersion != null &&
                    QueueCapabilitiesVersion.Equals(other.QueueCapabilitiesVersion)
                ) && 
                (
                    QueueCapabilities == other.QueueCapabilities ||
                    QueueCapabilities != null &&
                    QueueCapabilities.SequenceEqual(other.QueueCapabilities)
                ) && 
                (
                    EnvironmentsAndQueues == other.EnvironmentsAndQueues ||
                    EnvironmentsAndQueues != null &&
                    EnvironmentsAndQueues.SequenceEqual(other.EnvironmentsAndQueues)
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
                
                if (MessageStatesVersion != null)
                    hash = hash * 59 + MessageStatesVersion.GetHashCode();
                
                if (MessageStates != null)
                    hash = hash * 59 + MessageStates.GetHashCode();
                
                if (QueueCapabilitiesVersion != null)
                    hash = hash * 59 + QueueCapabilitiesVersion.GetHashCode();
                
                if (QueueCapabilities != null)
                    hash = hash * 59 + QueueCapabilities.GetHashCode();
                
                if (EnvironmentsAndQueues != null)
                    hash = hash * 59 + EnvironmentsAndQueues.GetHashCode();
                
                return hash;
            }
        }

    }
}
