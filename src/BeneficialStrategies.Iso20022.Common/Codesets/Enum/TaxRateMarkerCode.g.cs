﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxRateMarkerCode.  ISO2002 ID# _YwYvUQ2XEeStB9HSJRk0Qw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the rate of tax levied.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YwYvUQ2XEeStB9HSJRk0Qw")]
[Description(@"Specifies the rate of tax levied.")]
[Derivations(typeof(TaxRateMarker1Code))]
public enum TaxRateMarkerCode
{
    /// <summary>
    /// Specifies an amount before the deduction of tax.
    /// Encoded/decoded by serializers as "GRSS".
    /// </summary>
    [EnumMember(Value = "GRSS")]
    [IsoId("_bBcL8A2XEeStB9HSJRk0Qw")]
    [Description(@"Specifies an amount before the deduction of tax.")]
    GrossAmount,
    
    /// <summary>
    /// Specifies the amount quoted less standard rate income tax.
    /// Encoded/decoded by serializers as "ALIT".
    /// </summary>
    [EnumMember(Value = "ALIT")]
    [IsoId("_c7SpgA2XEeStB9HSJRk0Qw")]
    [Description(@"Specifies the amount quoted less standard rate income tax.")]
    AmountQuotedLessStandardRate,
    
    /// <summary>
    /// Specifies the amount quoted less life assurance premium rate income tax.
    /// Encoded/decoded by serializers as "ALPR".
    /// </summary>
    [EnumMember(Value = "ALPR")]
    [IsoId("_exjnkA2XEeStB9HSJRk0Qw")]
    [Description(@"Specifies the amount quoted less life assurance premium rate income tax.")]
    AmountQuotedLessLifeAssurance,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxRateMarkerCodeMetadataExtensions
{
    private static readonly TaxRateMarkerCodeDropdownSource _dropdownSource = new TaxRateMarkerCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxRateMarkerCodeDropdownRow GetMetadata(this TaxRateMarkerCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


