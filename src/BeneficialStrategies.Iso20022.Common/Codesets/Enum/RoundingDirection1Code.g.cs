﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RoundingDirection1Code.  ISO2002 ID# _Y-Bo9dp-Ed-ak6NoX_4Aeg_2066033818.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the rounding direction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y-Bo9dp-Ed-ak6NoX_4Aeg_2066033818")]
[Description(@"Specifies the rounding direction.")]
[DerivedFrom(typeof(RoundingDirectionCode))]
public enum RoundingDirection1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RoundUp".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y-Bo9tp-Ed-ak6NoX_4Aeg_2066033827")]
    [Description(@"??")]
    RoundUp,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RoundDown".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y-Bo99p-Ed-ak6NoX_4Aeg_2066033828")]
    [Description(@"??")]
    RoundDown,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RoundToNearest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y-Bo-Np-Ed-ak6NoX_4Aeg_-1599090070")]
    [Description(@"??")]
    RoundToNearest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IssueFraction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y-LZ8Np-Ed-ak6NoX_4Aeg_-1566769655")]
    [Description(@"??")]
    IssueFraction,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RoundingDirection1CodeMetadataExtensions
{
    private static readonly RoundingDirection1CodeDropdownSource _dropdownSource = new RoundingDirection1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRoundingDirection1CodeDropdownRow GetMetadata(this RoundingDirection1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

