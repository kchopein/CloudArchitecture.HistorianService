/*
 * IoT Aggregator API
 *
 * Sample API for aggregating data from multiple IoT devices and returning stored running averages.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace HistorianService.Models
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class InlineResponse401 :  IEquatable<InlineResponse401>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse401" /> class.
        /// </summary>
        /// <param name="Code">Code.</param>
        /// <param name="Message">Message.</param>
        public InlineResponse401(string Code = default(string), string Message = default(string))
        {
            this.Code = Code;
            this.Message = Message;
            
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code")]
        public string Code { get; set; }
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message")]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse401 {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((InlineResponse401)obj);
        }

        /// <summary>
        /// Returns true if InlineResponse401 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse401 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse401 other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
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
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                    if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                    if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(InlineResponse401 left, InlineResponse401 right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponse401 left, InlineResponse401 right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
