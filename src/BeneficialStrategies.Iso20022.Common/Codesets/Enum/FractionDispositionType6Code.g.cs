﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FractionDispositionType6Code.  ISO2002 ID# _UZBfoeHEEd-1Ktb5rVaajw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UZBfoeHEEd-1Ktb5rVaajw")]
[Description(@"Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.")]
[DerivedFrom(typeof(FractionDispositionTypeCode))]
public enum FractionDispositionType6Code
{
    /// <summary>
    /// Buy securities up to next whole number.
    /// Encoded/decoded by serializers as "BuyUp".
    /// </summary>
    [EnumMember(Value = "BUYU")]
    [IsoId("_q4hsVWtdEeCY4-KZ9JEyUQ_1821179655")]
    [Description(@"Buy securities up to next whole number.")]
    BuyUp,
    
    /// <summary>
    /// Fractional part of cash. Take cash in lieu of fractions.
    /// Encoded/decoded by serializers as "CashInLieuOfFraction".
    /// </summary>
    [EnumMember(Value = "CINL")]
    [IsoId("_q4hsVmtdEeCY4-KZ9JEyUQ_-844509347")]
    [Description(@"Fractional part of cash. Take cash in lieu of fractions.")]
    CashInLieuOfFraction,
    
    /// <summary>
    /// Take distribution of fractions in the form of securities.
    /// Encoded/decoded by serializers as "IssueFraction".
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_q4rdUGtdEeCY4-KZ9JEyUQ_1872116818")]
    [Description(@"Take distribution of fractions in the form of securities.")]
    IssueFraction,
    
    /// <summary>
    /// Let fractions expire worthless.
    /// Encoded/decoded by serializers as "Expire".
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_q4rdUWtdEeCY4-KZ9JEyUQ_875044465")]
    [Description(@"Let fractions expire worthless.")]
    Expire,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FractionDispositionType6CodeMetadataExtensions
{
    private static readonly FractionDispositionType6CodeDropdownSource _dropdownSource = new FractionDispositionType6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFractionDispositionType6CodeDropdownRow GetMetadata(this FractionDispositionType6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


