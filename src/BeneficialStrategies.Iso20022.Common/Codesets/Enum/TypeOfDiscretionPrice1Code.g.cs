﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfDiscretionPrice1Code.  ISO2002 ID# _YwUkJtp-Ed-ak6NoX_4Aeg_-578939831.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the type of price to which the discretion offset is related to.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YwUkJtp-Ed-ak6NoX_4Aeg_-578939831")]
[Description(@"Contains the type of price to which the discretion offset is related to.")]
[DerivedFrom(typeof(TypeOfDiscretionPriceCode))]
public enum TypeOfDiscretionPrice1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DisplayedPrice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YwUkJ9p-Ed-ak6NoX_4Aeg_-493976446")]
    [Description(@"??")]
    DisplayedPrice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketPrice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YwduENp-Ed-ak6NoX_4Aeg_-493976411")]
    [Description(@"??")]
    MarketPrice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PrimaryPrice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YwduEdp-Ed-ak6NoX_4Aeg_-493976369")]
    [Description(@"??")]
    PrimaryPrice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LocalPrimaryPrice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YwduEtp-Ed-ak6NoX_4Aeg_-493976316")]
    [Description(@"??")]
    LocalPrimaryPrice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MidpointPrice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YwduE9p-Ed-ak6NoX_4Aeg_-493976274")]
    [Description(@"??")]
    MidpointPrice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "VolumeWeightedAveragePrice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YwduFNp-Ed-ak6NoX_4Aeg_-493976231")]
    [Description(@"??")]
    VolumeWeightedAveragePrice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AveragePriceGuarantee".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YwduFdp-Ed-ak6NoX_4Aeg_-493976196")]
    [Description(@"??")]
    AveragePriceGuarantee,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfDiscretionPrice1CodeMetadataExtensions
{
    private static readonly TypeOfDiscretionPrice1CodeDropdownSource _dropdownSource = new TypeOfDiscretionPrice1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfDiscretionPrice1CodeDropdownRow GetMetadata(this TypeOfDiscretionPrice1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


