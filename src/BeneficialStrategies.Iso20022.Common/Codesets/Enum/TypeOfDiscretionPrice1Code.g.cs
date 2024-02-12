﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfDiscretionPrice1Code.  ISO2002 ID# _YwUkJtp-Ed-ak6NoX_4Aeg_-578939831.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Indicates that the offset value is related to displayed price.
    /// Encoded/decoded by serializers as "DISP".
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_YwUkJ9p-Ed-ak6NoX_4Aeg_-493976446")]
    [Description(@"Indicates that the offset value is related to displayed price.")]
    DisplayedPrice = TypeOfDiscretionPriceCode.DisplayedPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the offset value is related to market price.
    /// Encoded/decoded by serializers as "MRKT".
    /// </summary>
    [EnumMember(Value = "MRKT")]
    [IsoId("_YwduENp-Ed-ak6NoX_4Aeg_-493976411")]
    [Description(@"Indicates that the offset value is related to market price.")]
    MarketPrice = TypeOfDiscretionPriceCode.MarketPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the offset value is related to primary price.
    /// Encoded/decoded by serializers as "PRIM".
    /// </summary>
    [EnumMember(Value = "PRIM")]
    [IsoId("_YwduEdp-Ed-ak6NoX_4Aeg_-493976369")]
    [Description(@"Indicates that the offset value is related to primary price.")]
    PrimaryPrice = TypeOfDiscretionPriceCode.PrimaryPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the offset value is related to local primary price.
    /// Encoded/decoded by serializers as "LPRI".
    /// </summary>
    [EnumMember(Value = "LPRI")]
    [IsoId("_YwduEtp-Ed-ak6NoX_4Aeg_-493976316")]
    [Description(@"Indicates that the offset value is related to local primary price.")]
    LocalPrimaryPrice = TypeOfDiscretionPriceCode.LocalPrimaryPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the offset value is related to midpoint price.
    /// Encoded/decoded by serializers as "MIDP".
    /// </summary>
    [EnumMember(Value = "MIDP")]
    [IsoId("_YwduE9p-Ed-ak6NoX_4Aeg_-493976274")]
    [Description(@"Indicates that the offset value is related to midpoint price.")]
    MidpointPrice = TypeOfDiscretionPriceCode.MidpointPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the offset value is related to VWAP price.
    /// Encoded/decoded by serializers as "VWAP".
    /// </summary>
    [EnumMember(Value = "VWAP")]
    [IsoId("_YwduFNp-Ed-ak6NoX_4Aeg_-493976231")]
    [Description(@"Indicates that the offset value is related to VWAP price.")]
    VolumeWeightedAveragePrice = TypeOfDiscretionPriceCode.VolumeWeightedAveragePrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the offset value is related to average price guarantee.
    /// Encoded/decoded by serializers as "AVPG".
    /// </summary>
    [EnumMember(Value = "AVPG")]
    [IsoId("_YwduFdp-Ed-ak6NoX_4Aeg_-493976196")]
    [Description(@"Indicates that the offset value is related to average price guarantee.")]
    AveragePriceGuarantee = TypeOfDiscretionPriceCode.AveragePriceGuarantee, // same ordinal as derivation source for type conversions
    
}
