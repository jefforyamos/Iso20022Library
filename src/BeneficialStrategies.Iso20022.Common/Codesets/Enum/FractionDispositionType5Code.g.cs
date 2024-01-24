﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FractionDispositionType5Code.  ISO2002 ID# _1Lg6weHDEd-1Ktb5rVaajw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1Lg6weHDEd-1Ktb5rVaajw")]
[Description(@"Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.")]
[DerivedFrom(typeof(FractionDispositionTypeCode))]
public enum FractionDispositionType5Code
{
    /// <summary>
    /// Take distribution of fractions in the form of securities.
    /// Encoded/decoded by serializers as "DIST".
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_q4hsUGtdEeCY4-KZ9JEyUQ_929256537")]
    [Description(@"Take distribution of fractions in the form of securities.")]
    IssueFraction = FractionDispositionTypeCode.IssueFraction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Round down to the nearest whole number.
    /// Encoded/decoded by serializers as "RDDN".
    /// </summary>
    [EnumMember(Value = "RDDN")]
    [IsoId("_q4hsUWtdEeCY4-KZ9JEyUQ_-67815816")]
    [Description(@"Round down to the nearest whole number.")]
    RoundDown = FractionDispositionTypeCode.RoundDown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Round up to the nearest whole number.
    /// Encoded/decoded by serializers as "RDUP".
    /// </summary>
    [EnumMember(Value = "RDUP")]
    [IsoId("_q4hsUmtdEeCY4-KZ9JEyUQ_-380922856")]
    [Description(@"Round up to the nearest whole number.")]
    RoundUp = FractionDispositionTypeCode.RoundUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// If the fraction is greater than or equal to 0.5 of the resulting security then round up, else round down.
    /// Encoded/decoded by serializers as "STAN".
    /// </summary>
    [EnumMember(Value = "STAN")]
    [IsoId("_q4hsU2tdEeCY4-KZ9JEyUQ_-1351777445")]
    [Description(@"If the fraction is greater than or equal to 0.5 of the resulting security then round up, else round down.")]
    RoundToNearest = FractionDispositionTypeCode.RoundToNearest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Characteristics of the disposition of fractions are unknown.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_q4hsVGtdEeCY4-KZ9JEyUQ_1946117498")]
    [Description(@"Characteristics of the disposition of fractions are unknown.")]
    Unknown = FractionDispositionTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FractionDispositionType5CodeMetadataExtensions
{
    private static readonly FractionDispositionType5CodeDropdownSource _dropdownSource = new FractionDispositionType5CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFractionDispositionType5CodeDropdownRow GetMetadata(this FractionDispositionType5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


