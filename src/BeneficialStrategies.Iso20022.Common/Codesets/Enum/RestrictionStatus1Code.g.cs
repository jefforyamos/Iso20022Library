﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RestrictionStatus1Code.  ISO2002 ID# _v1wYICFnEeW9XJWqfgXIIA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a restriction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_v1wYICFnEeW9XJWqfgXIIA")]
[Description(@"Specifies the status of a restriction.")]
[DerivedFrom(typeof(RestrictionStatusCode))]
public enum RestrictionStatus1Code
{
    /// <summary>
    /// Status of the restriction is active.
    /// Encoded/decoded by serializers as "ACTV".
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_yA_goSFnEeW9XJWqfgXIIA")]
    [Description(@"Status of the restriction is active.")]
    Active = RestrictionStatusCode.Active, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status of the restriction is inactive.
    /// Encoded/decoded by serializers as "INAC".
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_yH-5cSFnEeW9XJWqfgXIIA")]
    [Description(@"Status of the restriction is inactive.")]
    Inactive = RestrictionStatusCode.Inactive, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RestrictionStatus1CodeMetadataExtensions
{
    private static readonly RestrictionStatus1CodeDropdownSource _dropdownSource = new RestrictionStatus1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRestrictionStatus1CodeDropdownRow GetMetadata(this RestrictionStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


