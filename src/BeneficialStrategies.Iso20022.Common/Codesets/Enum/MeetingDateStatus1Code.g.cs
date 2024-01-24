﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MeetingDateStatus1Code.  ISO2002 ID# _aVWBMdp-Ed-ak6NoX_4Aeg_890839689.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the possible statuses of a meeting date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aVWBMdp-Ed-ak6NoX_4Aeg_890839689")]
[Description(@"Identifies the possible statuses of a meeting date.")]
[DerivedFrom(typeof(MeetingDateStatusCode))]
public enum MeetingDateStatus1Code
{
    /// <summary>
    /// Meeting date is tentative.
    /// Encoded/decoded by serializers as "TNTA".
    /// </summary>
    [EnumMember(Value = "TNTA")]
    [IsoId("_aVWBMtp-Ed-ak6NoX_4Aeg_1034907041")]
    [Description(@"Meeting date is tentative.")]
    Tentative = MeetingDateStatusCode.Tentative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Meeting date is confirmed.
    /// Encoded/decoded by serializers as "CNFR".
    /// </summary>
    [EnumMember(Value = "CNFR")]
    [IsoId("_aVWBM9p-Ed-ak6NoX_4Aeg_1049683942")]
    [Description(@"Meeting date is confirmed.")]
    Confirmed = MeetingDateStatusCode.Confirmed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Meeting date has been cancelled.
    /// Encoded/decoded by serializers as "CANC".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_aVWBNNp-Ed-ak6NoX_4Aeg_1064459735")]
    [Description(@"Meeting date has been cancelled.")]
    Cancelled = MeetingDateStatusCode.Cancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Meeting could not take place as the quorum was not reached.
    /// Encoded/decoded by serializers as "NOQO".
    /// </summary>
    [EnumMember(Value = "NOQO")]
    [IsoId("_aVWBNdp-Ed-ak6NoX_4Aeg_-1791743871")]
    [Description(@"Meeting could not take place as the quorum was not reached.")]
    NoQuorum = MeetingDateStatusCode.NoQuorum, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MeetingDateStatus1CodeMetadataExtensions
{
    private static readonly MeetingDateStatus1CodeDropdownSource _dropdownSource = new MeetingDateStatus1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMeetingDateStatus1CodeDropdownRow GetMetadata(this MeetingDateStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


