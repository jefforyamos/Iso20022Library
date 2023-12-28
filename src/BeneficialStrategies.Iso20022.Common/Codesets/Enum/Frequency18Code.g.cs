﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Frequency18Code.  ISO2002 ID# _0vb7cR1VEey8XKHwKquEQw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0vb7cR1VEey8XKHwKquEQw")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(FrequencyCode))]
public enum Frequency18Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Annual".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_01vXwR1VEey8XKHwKquEQw")]
    [Description(@"??")]
    Annual,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Daily".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_01vXzx1VEey8XKHwKquEQw")]
    [Description(@"??")]
    Daily,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Fortnightly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_01v-0R1VEey8XKHwKquEQw")]
    [Description(@"??")]
    Fortnightly,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Monthly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_01v-0x1VEey8XKHwKquEQw")]
    [Description(@"??")]
    Monthly,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Quarterly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_01v-4R1VEey8XKHwKquEQw")]
    [Description(@"??")]
    Quarterly,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SemiAnnual".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_01v-7x1VEey8XKHwKquEQw")]
    [Description(@"??")]
    SemiAnnual,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TenDays".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_01v-9x1VEey8XKHwKquEQw")]
    [Description(@"??")]
    TenDays,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Weekly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_01v--R1VEey8XKHwKquEQw")]
    [Description(@"??")]
    Weekly,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TwiceAWeek".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dk4swR1WEey8XKHwKquEQw")]
    [Description(@"??")]
    TwiceAWeek,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Frequency18CodeMetadataExtensions
{
    private static readonly Frequency18CodeDropdownSource _dropdownSource = new Frequency18CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFrequency18CodeDropdownRow GetMetadata(this Frequency18Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


