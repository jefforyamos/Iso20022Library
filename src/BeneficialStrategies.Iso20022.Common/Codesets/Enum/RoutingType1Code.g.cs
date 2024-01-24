﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RoutingType1Code.  ISO2002 ID# _Y-Uj59p-Ed-ak6NoX_4Aeg_1478221166.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the type of routing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y-Uj59p-Ed-ak6NoX_4Aeg_1478221166")]
[Description(@"Indicates the type of routing.")]
[DerivedFrom(typeof(RoutingTypeCode))]
public enum RoutingType1Code
{
    /// <summary>
    /// Indicates that routing is allowed.
    /// Encoded/decoded by serializers as "ALLO".
    /// </summary>
    [EnumMember(Value = "ALLO")]
    [IsoId("_Y-Uj6Np-Ed-ak6NoX_4Aeg_1903962381")]
    [Description(@"Indicates that routing is allowed.")]
    Allowed = RoutingTypeCode.Allowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that routing is blocked.
    /// Encoded/decoded by serializers as "BLOC".
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_Y-Uj6dp-Ed-ak6NoX_4Aeg_1903962382")]
    [Description(@"Indicates that routing is blocked.")]
    Blocked = RoutingTypeCode.Blocked, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RoutingType1CodeMetadataExtensions
{
    private static readonly RoutingType1CodeDropdownSource _dropdownSource = new RoutingType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRoutingType1CodeDropdownRow GetMetadata(this RoutingType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


