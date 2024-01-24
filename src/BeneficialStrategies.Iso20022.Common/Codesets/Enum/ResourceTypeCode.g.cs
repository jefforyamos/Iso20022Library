﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ResourceTypeCode.  ISO2002 ID# _lu4ewC8CEeu125Ip9zFcsQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of resource.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lu4ewC8CEeu125Ip9zFcsQ")]
[Description(@"Type of resource.")]
[Derivations(typeof(ResourceType1Code))]
public enum ResourceTypeCode
{
    /// <summary>
    /// Voice synthesis.
    /// Encoded/decoded by serializers as "TEXT".
    /// </summary>
    [EnumMember(Value = "TEXT")]
    [IsoId("_togtcC8CEeu125Ip9zFcsQ")]
    [Description(@"Voice synthesis.")]
    TextToSpeech,
    
    /// <summary>
    /// String of characters that unambiguously identifies a particular resource.
    /// Encoded/decoded by serializers as "URLI".
    /// </summary>
    [EnumMember(Value = "URLI")]
    [IsoId("_1mAIcC8CEeu125Ip9zFcsQ")]
    [Description(@"String of characters that unambiguously identifies a particular resource.")]
    UniformResourceIdentifier,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ResourceTypeCodeMetadataExtensions
{
    private static readonly ResourceTypeCodeDropdownSource _dropdownSource = new ResourceTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IResourceTypeCodeDropdownRow GetMetadata(this ResourceTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


