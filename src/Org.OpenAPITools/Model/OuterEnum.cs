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
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Defines OuterEnum
    /// </summary>
    [CLSCompliant(true)]
    [ComVisible(true)]
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OuterEnum
    {
        /// <summary>
        /// Enum Placed for value: placed
        /// </summary>
        [EnumMember(Value = "placed")]
        Placed = 1,

        /// <summary>
        /// Enum Approved for value: approved
        /// </summary>
        [EnumMember(Value = "approved")]
        Approved = 2,

        /// <summary>
        /// Enum Delivered for value: delivered
        /// </summary>
        [EnumMember(Value = "delivered")]
        Delivered = 3

    }

}
