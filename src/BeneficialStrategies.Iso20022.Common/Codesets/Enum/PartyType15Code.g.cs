﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartyType15Code.  ISO2002 ID# _XQMV8I33EeWRwov1g9WL_A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Party involved by the data set.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XQMV8I33EeWRwov1g9WL_A")]
[Description(@"Party involved by the data set.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType15Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "POIGroup".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jtF7gY33EeWRwov1g9WL_A")]
    [Description(@"??")]
    POIGroup,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "POISystem".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_j2B1EY33EeWRwov1g9WL_A")]
    [Description(@"??")]
    POISystem,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SinglePOI".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kCQTMY33EeWRwov1g9WL_A")]
    [Description(@"??")]
    SinglePOI,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PartyType15CodeMetadataExtensions
{
    private static readonly PartyType15CodeDropdownSource _dropdownSource = new PartyType15CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPartyType15CodeDropdownRow GetMetadata(this PartyType15Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

