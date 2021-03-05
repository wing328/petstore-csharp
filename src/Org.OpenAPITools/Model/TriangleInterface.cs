/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// TriangleInterface
    /// </summary>
    [DataContract(Name = "TriangleInterface")]
    public partial class TriangleInterface : IEquatable<TriangleInterface>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriangleInterface" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TriangleInterface() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TriangleInterface" /> class.
        /// </summary>
        /// <param name="triangleType">triangleType (required).</param>
        public TriangleInterface(string triangleType = default(string))
        {
            // to ensure "triangleType" is required (not null)
            this.TriangleType = triangleType ?? throw new ArgumentNullException("triangleType is a required property for TriangleInterface and cannot be null");
        }

        /// <summary>
        /// Gets or Sets TriangleType
        /// </summary>
        [DataMember(Name = "triangleType", IsRequired = true, EmitDefaultValue = false)]
        public string TriangleType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TriangleInterface {\n");
            sb.Append("  TriangleType: ").Append(TriangleType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TriangleInterface);
        }

        /// <summary>
        /// Returns true if TriangleInterface instances are equal
        /// </summary>
        /// <param name="input">Instance of TriangleInterface to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TriangleInterface input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TriangleType == input.TriangleType ||
                    (this.TriangleType != null &&
                    this.TriangleType.Equals(input.TriangleType))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TriangleType != null)
                    hashCode = hashCode * 59 + this.TriangleType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
