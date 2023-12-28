﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfDiscretionPriceCode.  ISO2002 ID# _YwduFtp-Ed-ak6NoX_4Aeg_337179698.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the type of price to which the discretion offset is related to.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YwduFtp-Ed-ak6NoX_4Aeg_337179698")]
[Description(@"Contains the type of price to which the discretion offset is related to.")]
[Derivations(typeof(TypeOfDiscretionPrice1Code))]
// External derivations that should be provided by the proper interface are: 
public enum TypeOfDiscretionPriceCode
{
    /// <summary>
    /// Indicates that the offset value is related to displayed price.
    /// Encoded/decoded by serializers as "DISP".
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_YwduF9p-Ed-ak6NoX_4Aeg_337179699")]
    [Description(@"Indicates that the offset value is related to displayed price.")]
    DisplayedPrice,
    
    /// <summary>
    /// Indicates that the offset value is related to market price.
    /// Encoded/decoded by serializers as "MRKT".
    /// </summary>
    [EnumMember(Value = "MRKT")]
    [IsoId("_YwduGNp-Ed-ak6NoX_4Aeg_337179700")]
    [Description(@"Indicates that the offset value is related to market price.")]
    MarketPrice,
    
    /// <summary>
    /// Indicates that the offset value is related to primary price.
    /// Encoded/decoded by serializers as "PRIM".
    /// </summary>
    [EnumMember(Value = "PRIM")]
    [IsoId("_YwnfENp-Ed-ak6NoX_4Aeg_337179701")]
    [Description(@"Indicates that the offset value is related to primary price.")]
    PrimaryPrice,
    
    /// <summary>
    /// Indicates that the offset value is related to local primary price.
    /// Encoded/decoded by serializers as "LPRI".
    /// </summary>
    [EnumMember(Value = "LPRI")]
    [IsoId("_YwnfEdp-Ed-ak6NoX_4Aeg_337179702")]
    [Description(@"Indicates that the offset value is related to local primary price.")]
    LocalPrimaryPrice,
    
    /// <summary>
    /// Indicates that the offset value is related to midpoint price.
    /// Encoded/decoded by serializers as "MIDP".
    /// </summary>
    [EnumMember(Value = "MIDP")]
    [IsoId("_YwnfEtp-Ed-ak6NoX_4Aeg_337179703")]
    [Description(@"Indicates that the offset value is related to midpoint price.")]
    MidpointPrice,
    
    /// <summary>
    /// Indicates that the offset value is related to VWAP price.
    /// Encoded/decoded by serializers as "VWAP".
    /// </summary>
    [EnumMember(Value = "VWAP")]
    [IsoId("_YwnfE9p-Ed-ak6NoX_4Aeg_-1352175476")]
    [Description(@"Indicates that the offset value is related to VWAP price.")]
    VolumeWeightedAveragePrice,
    
    /// <summary>
    /// Indicates that the offset value is related to average price guarantee.
    /// Encoded/decoded by serializers as "AVPG".
    /// </summary>
    [EnumMember(Value = "AVPG")]
    [IsoId("_YwnfFNp-Ed-ak6NoX_4Aeg_-1352175416")]
    [Description(@"Indicates that the offset value is related to average price guarantee.")]
    AveragePriceGuarantee,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfDiscretionPriceCodeMetadataExtensions
{
    private static readonly TypeOfDiscretionPriceCodeDropdownSource _dropdownSource = new TypeOfDiscretionPriceCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfDiscretionPriceCodeDropdownRow GetMetadata(this TypeOfDiscretionPriceCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


