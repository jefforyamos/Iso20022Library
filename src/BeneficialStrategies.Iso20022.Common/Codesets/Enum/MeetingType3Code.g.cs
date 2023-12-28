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
    /// Meeting that takes place as needed, in addition to the general meetings, is extraordinary as per the bylaws. The resolutions are related to the unusual business of the company, for example approval of takeovers or mergers or spin-offs. These meetings are always issuer initiated.
    /// Encoded/decoded by serializers as "Extraordinary".
    /// </summary>
    [EnumMember(Value = "XMET")]
    [IsoId("_62UMQVuKEeSmO6RkXg92Lg")]
    [Description(@"Meeting that takes place as needed, in addition to the general meetings, is extraordinary as per the bylaws. The resolutions are related to the unusual business of the company, for example approval of takeovers or mergers or spin-offs. These meetings are always issuer initiated.")]
    Extraordinary,
    
    /// <summary>
    /// Includes annual and ordinary meeting. Statutory meeting(s) usually held at least once a year. The resolutions are related to the usual business of the company, for example approval of dividends, directors, etc. These meetings are always issuer initiated.
    /// Encoded/decoded by serializers as "General".
    /// </summary>
    [EnumMember(Value = "GMET")]
    [IsoId("_7KtH4VuKEeSmO6RkXg92Lg")]
    [Description(@"Includes annual and ordinary meeting. Statutory meeting(s) usually held at least once a year. The resolutions are related to the usual business of the company, for example approval of dividends, directors, etc. These meetings are always issuer initiated.")]
    General,
    
    /// <summary>
    /// Specifies a meeting which contains both ordinary and extraordinary resolutions.
    /// Encoded/decoded by serializers as "Mixed".
    /// </summary>
    [EnumMember(Value = "MIXD")]
    [IsoId("_7hUREVuKEeSmO6RkXg92Lg")]
    [Description(@"Specifies a meeting which contains both ordinary and extraordinary resolutions.")]
    Mixed,
    
    /// <summary>
    /// Meeting that takes place as needed that is neither ordinary nor extraordinary.
    /// Encoded/decoded by serializers as "Special".
    /// </summary>
    [EnumMember(Value = "SPCL")]
    [IsoId("_78P5kVuKEeSmO6RkXg92Lg")]
    [Description(@"Meeting that takes place as needed that is neither ordinary nor extraordinary.")]
    Special,
    
    /// <summary>
    /// Physical meeting of bond holders.
    /// Encoded/decoded by serializers as "BondHolderMeeting".
    /// </summary>
    [EnumMember(Value = "BMET")]
    [IsoId("_LLzM8VuLEeSmO6RkXg92Lg")]
    [Description(@"Physical meeting of bond holders.")]
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


