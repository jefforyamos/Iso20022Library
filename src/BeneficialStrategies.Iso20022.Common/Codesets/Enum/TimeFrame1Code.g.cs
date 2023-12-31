﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TimeFrame1Code.  ISO2002 ID# _fFUKADccEeidBoT_PugKiA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a time frame.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fFUKADccEeidBoT_PugKiA")]
[Description(@"Specifies a time frame.")]
[DerivedFrom(typeof(TimeFrameCode))]
public enum TimeFrame1Code
{
    /// <summary>
    /// Greater than five years.
    /// Encoded/decoded by serializers as "LongTerm".
    /// </summary>
    [EnumMember(Value = "LONG")]
    [IsoId("_gS0e8TccEeidBoT_PugKiA")]
    [Description(@"Greater than five years.")]
    LongTerm,
    
    /// <summary>
    /// Greater than or equal to three years.
    /// Encoded/decoded by serializers as "MediumTerm".
    /// </summary>
    [EnumMember(Value = "MEDM")]
    [IsoId("_gWZXYTccEeidBoT_PugKiA")]
    [Description(@"Greater than or equal to three years.")]
    MediumTerm,
    
    /// <summary>
    /// Time frame is neutral.
    /// Encoded/decoded by serializers as "Neutral".
    /// </summary>
    [EnumMember(Value = "NEUT")]
    [IsoId("_gatPoTccEeidBoT_PugKiA")]
    [Description(@"Time frame is neutral.")]
    Neutral,
    
    /// <summary>
    /// Greater than or equal to one year.
    /// Encoded/decoded by serializers as "ShortTerm".
    /// </summary>
    [EnumMember(Value = "SHOR")]
    [IsoId("_gfBu8TccEeidBoT_PugKiA")]
    [Description(@"Greater than or equal to one year.")]
    ShortTerm,
    
    /// <summary>
    /// Less than one year.
    /// Encoded/decoded by serializers as "VeryShortTerm".
    /// </summary>
    [EnumMember(Value = "VSHT")]
    [IsoId("_gjL2MTccEeidBoT_PugKiA")]
    [Description(@"Less than one year.")]
    VeryShortTerm,
    
    /// <summary>
    /// Hold to maturity.
    /// Encoded/decoded by serializers as "Hold".
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_FlJAgYEMEeiw-daIkkmMqQ")]
    [Description(@"Hold to maturity.")]
    Hold,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TimeFrame1CodeMetadataExtensions
{
    private static readonly TimeFrame1CodeDropdownSource _dropdownSource = new TimeFrame1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITimeFrame1CodeDropdownRow GetMetadata(this TimeFrame1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


