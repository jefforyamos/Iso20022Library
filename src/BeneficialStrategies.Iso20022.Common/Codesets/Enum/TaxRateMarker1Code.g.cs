﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxRateMarker1Code.  ISO2002 ID# _zFFVsA2YEeSNWNtJlXOAhg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the rate of tax levied.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zFFVsA2YEeSNWNtJlXOAhg")]
[Description(@"Specifies the rate of tax levied.")]
[DerivedFrom(typeof(TaxRateMarkerCode))]
public enum TaxRateMarker1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AmountQuotedLessLifeAssurance".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_z5l70Q2YEeSNWNtJlXOAhg")]
    [Description(@"??")]
    AmountQuotedLessLifeAssurance,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AmountQuotedLessStandardRate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_z-DlEQ2YEeSNWNtJlXOAhg")]
    [Description(@"??")]
    AmountQuotedLessStandardRate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "GrossAmount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_0Cq_UQ2YEeSNWNtJlXOAhg")]
    [Description(@"??")]
    GrossAmount,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxRateMarker1CodeMetadataExtensions
{
    private static readonly TaxRateMarker1CodeDropdownSource _dropdownSource = new TaxRateMarker1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxRateMarker1CodeDropdownRow GetMetadata(this TaxRateMarker1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

