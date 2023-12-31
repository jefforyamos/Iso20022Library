﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RestrictionStatusCode.  ISO2002 ID# _h5LIgCFnEeW9XJWqfgXIIA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a restriction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_h5LIgCFnEeW9XJWqfgXIIA")]
[Description(@"Specifies the status of a restriction.")]
[Derivations(typeof(RestrictionStatus1Code))]
// External derivations that should be provided by the proper interface are: 
public enum RestrictionStatusCode
{
    /// <summary>
    /// Status of the restriction is inactive.
    /// Encoded/decoded by serializers as "INAC".
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_m71xICFnEeW9XJWqfgXIIA")]
    [Description(@"Status of the restriction is inactive.")]
    Inactive,
    
    /// <summary>
    /// Status of the restriction is active.
    /// Encoded/decoded by serializers as "ACTV".
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_q6q-MCFnEeW9XJWqfgXIIA")]
    [Description(@"Status of the restriction is active.")]
    Active,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RestrictionStatusCodeMetadataExtensions
{
    private static readonly RestrictionStatusCodeDropdownSource _dropdownSource = new RestrictionStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRestrictionStatusCodeDropdownRow GetMetadata(this RestrictionStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


