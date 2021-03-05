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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ChildCat
    /// </summary>
    [DataContract(Name = "ChildCat")]
    [JsonConverter(typeof(JsonSubtypes), "PetType")]
    public partial class ChildCat : ParentPet, IEquatable<ChildCat>, IValidatableObject
    {
        /// <summary>
        /// Defines PetType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PetTypeEnum
        {
            /// <summary>
            /// Enum ChildCat for value: ChildCat
            /// </summary>
            [EnumMember(Value = "ChildCat")]
            ChildCat = 1

        }

        /// <summary>
        /// Gets or Sets PetType
        /// </summary>
        [DataMember(Name = "pet_type", IsRequired = true, EmitDefaultValue = false)]
        public PetTypeEnum PetType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChildCat" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChildCat() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChildCat" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="petType">petType (required) (default to PetTypeEnum.ChildCat).</param>
        public ChildCat(string name = default(string), PetTypeEnum petType = PetTypeEnum.ChildCat) : base()
        {
            this.PetType = petType;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChildCat {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PetType: ").Append(PetType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as ChildCat);
        }

        /// <summary>
        /// Returns true if ChildCat instances are equal
        /// </summary>
        /// <param name="input">Instance of ChildCat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChildCat input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.PetType == input.PetType ||
                    this.PetType.Equals(input.PetType)
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
                int hashCode = base.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.PetType.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
