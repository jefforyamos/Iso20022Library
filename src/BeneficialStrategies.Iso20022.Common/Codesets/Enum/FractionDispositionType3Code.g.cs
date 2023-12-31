﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FractionDispositionType3Code.  ISO2002 ID# _arZwx9p-Ed-ak6NoX_4Aeg_1382196643.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_arZwx9p-Ed-ak6NoX_4Aeg_1382196643")]
[Description(@"Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.")]
[DerivedFrom(typeof(FractionDispositionTypeCode))]
public enum FractionDispositionType3Code
{
    /// <summary>
    /// Buy securities up to next whole number.
    /// Encoded/decoded by serializers as "BuyUp".
    /// </summary>
    [EnumMember(Value = "BUYU")]
    [IsoId("_arjhwNp-Ed-ak6NoX_4Aeg_1382196652")]
    [Description(@"Buy securities up to next whole number.")]
    BuyUp,
    
    /// <summary>
    /// Fractional part of cash. Take cash in lieu of fractions.
    /// Encoded/decoded by serializers as "CashInLieuOfFraction".
    /// </summary>
    [EnumMember(Value = "CINL")]
    [IsoId("_arjhwdp-Ed-ak6NoX_4Aeg_1382196668")]
    [Description(@"Fractional part of cash. Take cash in lieu of fractions.")]
    CashInLieuOfFraction,
    
    /// <summary>
    /// Take distribution of fractions in the form of securities.
    /// Encoded/decoded by serializers as "IssueFraction".
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_arjhwtp-Ed-ak6NoX_4Aeg_1382196669")]
    [Description(@"Take distribution of fractions in the form of securities.")]
    IssueFraction,
    
    /// <summary>
    /// Let fractions expire worthless.
    /// Encoded/decoded by serializers as "Expire".
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_arjhw9p-Ed-ak6NoX_4Aeg_1758992666")]
    [Description(@"Let fractions expire worthless.")]
    Expire,
    
    /// <summary>
    /// Characteristics of the disposition of fractions are unknown.
    /// Encoded/decoded by serializers as "Unknown".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_arjhxNp-Ed-ak6NoX_4Aeg_299584857")]
    [Description(@"Characteristics of the disposition of fractions are unknown.")]
    Unknown,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FractionDispositionType3CodeMetadataExtensions
{
    private static readonly FractionDispositionType3CodeDropdownSource _dropdownSource = new FractionDispositionType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFractionDispositionType3CodeDropdownRow GetMetadata(this FractionDispositionType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


