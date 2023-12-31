﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TimeFrameCode.  ISO2002 ID# _EKEEgDccEeidBoT_PugKiA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a time frame.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EKEEgDccEeidBoT_PugKiA")]
[Description(@"Specifies a time frame.")]
[Derivations(typeof(TimeFrame1Code),typeof(TimeFrame2Code))]
// External derivations that should be provided by the proper interface are: 
public enum TimeFrameCode
{
    /// <summary>
    /// Less than one year.
    /// Encoded/decoded by serializers as "VSHT".
    /// </summary>
    [EnumMember(Value = "VSHT")]
    [IsoId("_M-z3oDccEeidBoT_PugKiA")]
    [Description(@"Less than one year.")]
    VeryShortTerm,
    
    /// <summary>
    /// Greater than or equal to one year.
    /// Encoded/decoded by serializers as "SHOR".
    /// </summary>
    [EnumMember(Value = "SHOR")]
    [IsoId("_REf6oDccEeidBoT_PugKiA")]
    [Description(@"Greater than or equal to one year.")]
    ShortTerm,
    
    /// <summary>
    /// Greater than or equal to three years.
    /// Encoded/decoded by serializers as "MEDM".
    /// </summary>
    [EnumMember(Value = "MEDM")]
    [IsoId("_WWEh8DccEeidBoT_PugKiA")]
    [Description(@"Greater than or equal to three years.")]
    MediumTerm,
    
    /// <summary>
    /// Greater than five years.
    /// Encoded/decoded by serializers as "LONG".
    /// </summary>
    [EnumMember(Value = "LONG")]
    [IsoId("_ZR0hYDccEeidBoT_PugKiA")]
    [Description(@"Greater than five years.")]
    LongTerm,
    
    /// <summary>
    /// Time frame is neutral.
    /// Encoded/decoded by serializers as "NEUT".
    /// </summary>
    [EnumMember(Value = "NEUT")]
    [IsoId("_bgDTgDccEeidBoT_PugKiA")]
    [Description(@"Time frame is neutral.")]
    Neutral,
    
    /// <summary>
    /// Hold to maturity.
    /// Encoded/decoded by serializers as "HOLD".
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_3DJ9wIELEeiw-daIkkmMqQ")]
    [Description(@"Hold to maturity.")]
    Hold,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TimeFrameCodeMetadataExtensions
{
    private static readonly TimeFrameCodeDropdownSource _dropdownSource = new TimeFrameCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITimeFrameCodeDropdownRow GetMetadata(this TimeFrameCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


