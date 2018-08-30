// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AzureStorageType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AzureStorageType
    {
        [EnumMember(Value = "AzureFiles")]
        AzureFiles,
        [EnumMember(Value = "AzureBlob")]
        AzureBlob
    }
    internal static class AzureStorageTypeEnumExtension
    {
        internal static string ToSerializedValue(this AzureStorageType? value)
        {
            return value == null ? null : ((AzureStorageType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AzureStorageType value)
        {
            switch( value )
            {
                case AzureStorageType.AzureFiles:
                    return "AzureFiles";
                case AzureStorageType.AzureBlob:
                    return "AzureBlob";
            }
            return null;
        }

        internal static AzureStorageType? ParseAzureStorageType(this string value)
        {
            switch( value )
            {
                case "AzureFiles":
                    return AzureStorageType.AzureFiles;
                case "AzureBlob":
                    return AzureStorageType.AzureBlob;
            }
            return null;
        }
    }
}
