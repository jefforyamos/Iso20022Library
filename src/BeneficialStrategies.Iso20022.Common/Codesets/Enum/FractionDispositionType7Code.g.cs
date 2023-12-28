﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FractionDispositionType7Code.  ISO2002 ID# _hhACgeHEEd-1Ktb5rVaajw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hhACgeHEEd-1Ktb5rVaajw")]
[Description(@"Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.")]
[DerivedFrom(typeof(FractionDispositionTypeCode))]
public enum FractionDispositionType7Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BuyUp".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_q4rdUmtdEeCY4-KZ9JEyUQ_571987950")]
    [Description(@"??")]
    BuyUp,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashInLieuOfFraction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_q4rdU2tdEeCY4-KZ9JEyUQ_1068282124")]
    [Description(@"??")]
    CashInLieuOfFraction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IssueFraction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_q4rdVGtdEeCY4-KZ9JEyUQ_71209771")]
    [Description(@"??")]
    IssueFraction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RoundDown".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_q4rdVWtdEeCY4-KZ9JEyUQ_1522369393")]
    [Description(@"??")]
    RoundDown,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RoundUp".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_q4rdVmtdEeCY4-KZ9JEyUQ_1847486900")]
    [Description(@"??")]
    RoundUp,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RoundToNearest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_q40nQGtdEeCY4-KZ9JEyUQ_850414547")]
    [Description(@"??")]
    RoundToNearest,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FractionDispositionType7CodeMetadataExtensions
{
    private static readonly FractionDispositionType7CodeDropdownSource _dropdownSource = new FractionDispositionType7CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFractionDispositionType7CodeDropdownRow GetMetadata(this FractionDispositionType7Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


