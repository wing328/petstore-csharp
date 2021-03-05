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
    /// IsoscelesTriangle
    /// </summary>
    [DataContract(Name = "IsoscelesTriangle")]
    public partial class IsoscelesTriangle : IEquatable<IsoscelesTriangle>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsoscelesTriangle" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IsoscelesTriangle() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IsoscelesTriangle" /> class.
        /// </summary>
        /// <param name="shapeType">shapeType (required).</param>
        /// <param name="triangleType">triangleType (required).</param>
        public IsoscelesTriangle(string shapeType = default(string), string triangleType = default(string))
        {
            // to ensure "shapeType" is required (not null)
            this.ShapeType = shapeType ?? throw new ArgumentNullException("shapeType is a required property for IsoscelesTriangle and cannot be null");
            // to ensure "triangleType" is required (not null)
            this.TriangleType = triangleType ?? throw new ArgumentNullException("triangleType is a required property for IsoscelesTriangle and cannot be null");
        }

        /// <summary>
        /// Gets or Sets ShapeType
        /// </summary>
        [DataMember(Name = "shapeType", IsRequired = true, EmitDefaultValue = false)]
        public string ShapeType { get; set; }

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
            sb.Append("class IsoscelesTriangle {\n");
            sb.Append("  ShapeType: ").Append(ShapeType).Append("\n");
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
            return this.Equals(input as IsoscelesTriangle);
        }

        /// <summary>
        /// Returns true if IsoscelesTriangle instances are equal
        /// </summary>
        /// <param name="input">Instance of IsoscelesTriangle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsoscelesTriangle input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShapeType == input.ShapeType ||
                    (this.ShapeType != null &&
                    this.ShapeType.Equals(input.ShapeType))
                ) && 
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
                if (this.ShapeType != null)
                    hashCode = hashCode * 59 + this.ShapeType.GetHashCode();
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
