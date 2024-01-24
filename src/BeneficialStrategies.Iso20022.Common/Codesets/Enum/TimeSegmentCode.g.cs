﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TimeSegmentCode.  ISO2002 ID# _VEH74F1lEeeu75xdwwAXQw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Segment of time of the day
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VEH74F1lEeeu75xdwwAXQw")]
[Description(@"Segment of time of the day")]
[Derivations(typeof(TimeSegment1Code))]
public enum TimeSegmentCode
{
    /// <summary>
    /// Ante meridiem or before noon time period.
    /// Encoded/decoded by serializers as "AMBN".
    /// </summary>
    [EnumMember(Value = "AMBN")]
    [IsoId("_ZeDJgF1lEeeu75xdwwAXQw")]
    [Description(@"Ante meridiem or before noon time period.")]
    AM,
    
    /// <summary>
    /// Post meridiem or after noon time period.
    /// Encoded/decoded by serializers as "PMAN".
    /// </summary>
    [EnumMember(Value = "PMAN")]
    [IsoId("_q_p_EF1lEeeu75xdwwAXQw")]
    [Description(@"Post meridiem or after noon time period.")]
    PM,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TimeSegmentCodeMetadataExtensions
{
    private static readonly TimeSegmentCodeDropdownSource _dropdownSource = new TimeSegmentCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITimeSegmentCodeDropdownRow GetMetadata(this TimeSegmentCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


