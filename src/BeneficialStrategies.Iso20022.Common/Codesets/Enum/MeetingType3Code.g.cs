﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MeetingType3Code.  ISO2002 ID# _3APSkFuKEeSmO6RkXg92Lg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of security holders meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3APSkFuKEeSmO6RkXg92Lg")]
[Description(@"Specifies the type of security holders meeting.")]
[DerivedFrom(typeof(MeetingTypeCode))]
public enum MeetingType3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Extraordinary".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_62UMQVuKEeSmO6RkXg92Lg")]
    [Description(@"??")]
    Extraordinary,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "General".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7KtH4VuKEeSmO6RkXg92Lg")]
    [Description(@"??")]
    General,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Mixed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7hUREVuKEeSmO6RkXg92Lg")]
    [Description(@"??")]
    Mixed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Special".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_78P5kVuKEeSmO6RkXg92Lg")]
    [Description(@"??")]
    Special,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BondHolderMeeting".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_LLzM8VuLEeSmO6RkXg92Lg")]
    [Description(@"??")]
    BondHolderMeeting,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MeetingType3CodeMetadataExtensions
{
    private static readonly MeetingType3CodeDropdownSource _dropdownSource = new MeetingType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMeetingType3CodeDropdownRow GetMetadata(this MeetingType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


