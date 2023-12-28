﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MeetingCancellationReasonCode.  ISO2002 ID# _aVM3RNp-Ed-ak6NoX_4Aeg_-1321527474.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for cancelling a meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aVM3RNp-Ed-ak6NoX_4Aeg_-1321527474")]
[Description(@"Specifies the reason for cancelling a meeting.")]
public enum MeetingCancellationReasonCode
{
    /// <summary>
    /// Cancellation due to insufficient participation to the vote.
    /// Encoded/decoded by serializers as "QORM".
    /// </summary>
    [EnumMember(Value = "QORM")]
    [IsoId("_aVM3Rdp-Ed-ak6NoX_4Aeg_1851096275")]
    [Description(@"Cancellation due to insufficient participation to the vote.")]
    Quorum,
    
    /// <summary>
    /// Cancellation due to a processing error.
    /// Encoded/decoded by serializers as "PROC".
    /// </summary>
    [EnumMember(Value = "PROC")]
    [IsoId("_aVM3Rtp-Ed-ak6NoX_4Aeg_-2055992756")]
    [Description(@"Cancellation due to a processing error.")]
    Processing,
    
    /// <summary>
    /// Cancellation due to another reason.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_aVM3R9p-Ed-ak6NoX_4Aeg_-1646853934")]
    [Description(@"Cancellation due to another reason.")]
    Other,
    
    /// <summary>
    /// Cancellation due to the meeting being cancelled by the issuer.
    /// Encoded/decoded by serializers as "WITH".
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_aVWBMNp-Ed-ak6NoX_4Aeg_-2132220464")]
    [Description(@"Cancellation due to the meeting being cancelled by the issuer.")]
    Withdrawal,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MeetingCancellationReasonCodeMetadataExtensions
{
    private static readonly MeetingCancellationReasonCodeDropdownSource _dropdownSource = new MeetingCancellationReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMeetingCancellationReasonCodeDropdownRow GetMetadata(this MeetingCancellationReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

