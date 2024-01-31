﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FractionDispositionType12Code.  ISO2002 ID# _KmzLEJFGEeanIpS4qvJ1tw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the processing to apply to fractions of securities.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KmzLEJFGEeanIpS4qvJ1tw")]
[Description(@"Indicates the processing to apply to fractions of securities.")]
[DerivedFrom(typeof(FractionDispositionTypeCode))]
public enum FractionDispositionType12Code
{
    /// <summary>
    /// Round down to the nearest whole number.
    /// Encoded/decoded by serializers as "RDDN".
    /// </summary>
    [EnumMember(Value = "RDDN")]
    [IsoId("_Of_qMZFGEeanIpS4qvJ1tw")]
    [Description(@"Round down to the nearest whole number.")]
    RoundDown = FractionDispositionTypeCode.RoundDown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Round up to the nearest whole number.
    /// Encoded/decoded by serializers as "RDUP".
    /// </summary>
    [EnumMember(Value = "RDUP")]
    [IsoId("_OqaKcZFGEeanIpS4qvJ1tw")]
    [Description(@"Round up to the nearest whole number.")]
    RoundUp = FractionDispositionTypeCode.RoundUp, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FractionDispositionType12CodeMetadataExtensions
{
    private static readonly FractionDispositionType12CodeDropdownSource _dropdownSource = new FractionDispositionType12CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFractionDispositionType12CodeDropdownRow GetMetadata(this FractionDispositionType12Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


