﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FractionDispositionType4Code.  ISO2002 ID# _arjhxdp-Ed-ak6NoX_4Aeg_-1202257975.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_arjhxdp-Ed-ak6NoX_4Aeg_-1202257975")]
[Description(@"Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.")]
[DerivedFrom(typeof(FractionDispositionTypeCode))]
public enum FractionDispositionType4Code
{
    /// <summary>
    /// Buy securities up to next whole number.
    /// Encoded/decoded by serializers as "BuyUp".
    /// </summary>
    [EnumMember(Value = "BUYU")]
    [IsoId("_arjhxtp-Ed-ak6NoX_4Aeg_-1202257973")]
    [Description(@"Buy securities up to next whole number.")]
    BuyUp,
    
    /// <summary>
    /// Fractional part of cash. Take cash in lieu of fractions.
    /// Encoded/decoded by serializers as "CashInLieuOfFraction".
    /// </summary>
    [EnumMember(Value = "CINL")]
    [IsoId("_arjhx9p-Ed-ak6NoX_4Aeg_-1202257957")]
    [Description(@"Fractional part of cash. Take cash in lieu of fractions.")]
    CashInLieuOfFraction,
    
    /// <summary>
    /// Take distribution of fractions in the form of securities.
    /// Encoded/decoded by serializers as "IssueFraction".
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_arjhyNp-Ed-ak6NoX_4Aeg_-1202257956")]
    [Description(@"Take distribution of fractions in the form of securities.")]
    IssueFraction,
    
    /// <summary>
    /// Round down to the nearest whole number.
    /// Encoded/decoded by serializers as "RoundDown".
    /// </summary>
    [EnumMember(Value = "RDDN")]
    [IsoId("_arjhydp-Ed-ak6NoX_4Aeg_-1202257955")]
    [Description(@"Round down to the nearest whole number.")]
    RoundDown,
    
    /// <summary>
    /// Round up to the nearest whole number.
    /// Encoded/decoded by serializers as "RoundUp".
    /// </summary>
    [EnumMember(Value = "RDUP")]
    [IsoId("_arsrsNp-Ed-ak6NoX_4Aeg_-1202257940")]
    [Description(@"Round up to the nearest whole number.")]
    RoundUp,
    
    /// <summary>
    /// If the fraction is greater than or equal to 0.5 of the resulting security then round up, else round down.
    /// Encoded/decoded by serializers as "RoundToNearest".
    /// </summary>
    [EnumMember(Value = "STAN")]
    [IsoId("_arsrsdp-Ed-ak6NoX_4Aeg_-1202257931")]
    [Description(@"If the fraction is greater than or equal to 0.5 of the resulting security then round up, else round down.")]
    RoundToNearest,
    
    /// <summary>
    /// Characteristics of the disposition of fractions are unknown.
    /// Encoded/decoded by serializers as "Unknown".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_arsrstp-Ed-ak6NoX_4Aeg_-501305688")]
    [Description(@"Characteristics of the disposition of fractions are unknown.")]
    Unknown,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FractionDispositionType4CodeMetadataExtensions
{
    private static readonly FractionDispositionType4CodeDropdownSource _dropdownSource = new FractionDispositionType4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFractionDispositionType4CodeDropdownRow GetMetadata(this FractionDispositionType4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


