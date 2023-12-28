﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfPrice9Code.  ISO2002 ID# _YyZnxtp-Ed-ak6NoX_4Aeg_-1063876985.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YyZnxtp-Ed-ak6NoX_4Aeg_-1063876985")]
[Description(@"Specifies the type of price.")]
[DerivedFrom(typeof(TypeOfPriceCode))]
public enum TypeOfPrice9Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Bid".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YyZnx9p-Ed-ak6NoX_4Aeg_-571640820")]
    [Description(@"??")]
    Bid,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Offer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YyZnyNp-Ed-ak6NoX_4Aeg_-571640795")]
    [Description(@"??")]
    Offer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NetAssetValue".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YyjYwNp-Ed-ak6NoX_4Aeg_-571640778")]
    [Description(@"??")]
    NetAssetValue,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Creation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YyjYwdp-Ed-ak6NoX_4Aeg_-571640718")]
    [Description(@"??")]
    Creation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Cancellation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YyjYwtp-Ed-ak6NoX_4Aeg_-571640700")]
    [Description(@"??")]
    Cancellation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Interim".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YyjYw9p-Ed-ak6NoX_4Aeg_-571640640")]
    [Description(@"??")]
    Interim,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Swing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YyjYxNp-Ed-ak6NoX_4Aeg_-571640623")]
    [Description(@"??")]
    Swing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Mid".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YyjYxdp-Ed-ak6NoX_4Aeg_-571640328")]
    [Description(@"??")]
    Mid,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Reinvestment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YyjYxtp-Ed-ak6NoX_4Aeg_-571640311")]
    [Description(@"??")]
    Reinvestment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Switch".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YyjYx9p-Ed-ak6NoX_4Aeg_-571639908")]
    [Description(@"??")]
    Switch,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DailyDividendRate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YyjYyNp-Ed-ak6NoX_4Aeg_-571639830")]
    [Description(@"??")]
    DailyDividendRate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Actual".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YyjYydp-Ed-ak6NoX_4Aeg_-571639770")]
    [Description(@"??")]
    Actual,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonAdjustedUnpublished".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YyjYytp-Ed-ak6NoX_4Aeg_-571639735")]
    [Description(@"??")]
    NonAdjustedUnpublished,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Guaranteed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YytJwNp-Ed-ak6NoX_4Aeg_52660274")]
    [Description(@"??")]
    Guaranteed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EstimatedNAV".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YytJwdp-Ed-ak6NoX_4Aeg_52660299")]
    [Description(@"??")]
    EstimatedNAV,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfPrice9CodeMetadataExtensions
{
    private static readonly TypeOfPrice9CodeDropdownSource _dropdownSource = new TypeOfPrice9CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfPrice9CodeDropdownRow GetMetadata(this TypeOfPrice9Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


