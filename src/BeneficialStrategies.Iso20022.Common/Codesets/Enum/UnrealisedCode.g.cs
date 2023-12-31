﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnrealisedCode.  ISO2002 ID# _m50OY_NBEeCuA5Tr22BnwA_1824968417.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies unrealised parameter.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m50OY_NBEeCuA5Tr22BnwA_1824968417")]
[Description(@"Specifies unrealised parameter.")]
[Derivations(typeof(Unrealised1Code))]
// External derivations that should be provided by the proper interface are: 
public enum UnrealisedCode
{
    /// <summary>
    /// Unrealised gain.
    /// Encoded/decoded by serializers as "GAIN".
    /// </summary>
    [EnumMember(Value = "GAIN")]
    [IsoId("_m50OZPNBEeCuA5Tr22BnwA_667402002")]
    [Description(@"Unrealised gain.")]
    Gain,
    
    /// <summary>
    /// Unrealised loss.
    /// Encoded/decoded by serializers as "LOSS".
    /// </summary>
    [EnumMember(Value = "LOSS")]
    [IsoId("_m50OZfNBEeCuA5Tr22BnwA_-1644430516")]
    [Description(@"Unrealised loss.")]
    Loss,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UnrealisedCodeMetadataExtensions
{
    private static readonly UnrealisedCodeDropdownSource _dropdownSource = new UnrealisedCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUnrealisedCodeDropdownRow GetMetadata(this UnrealisedCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


