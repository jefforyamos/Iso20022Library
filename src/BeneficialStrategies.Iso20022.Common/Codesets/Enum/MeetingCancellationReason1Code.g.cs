﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MeetingCancellationReason1Code.  ISO2002 ID# _Vp1UVtp-Ed-ak6NoX_4Aeg_-1464937039.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for cancelling a meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vp1UVtp-Ed-ak6NoX_4Aeg_-1464937039")]
[Description(@"Specifies the reason for cancelling a meeting.")]
[DerivedFrom(typeof(MeetingCancellationReasonCode))]
public enum MeetingCancellationReason1Code
{
    /// <summary>
    /// Cancellation due to insufficient participation to the vote.
    /// Encoded/decoded by serializers as "QORM".
    /// </summary>
    [EnumMember(Value = "QORM")]
    [IsoId("_Vp_FUNp-Ed-ak6NoX_4Aeg_-1410451064")]
    [Description(@"Cancellation due to insufficient participation to the vote.")]
    Quorum = MeetingCancellationReasonCode.Quorum, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation due to a processing error.
    /// Encoded/decoded by serializers as "PROC".
    /// </summary>
    [EnumMember(Value = "PROC")]
    [IsoId("_Vp_FUdp-Ed-ak6NoX_4Aeg_-1398443912")]
    [Description(@"Cancellation due to a processing error.")]
    Processing = MeetingCancellationReasonCode.Processing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation due to another reason.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Vp_FUtp-Ed-ak6NoX_4Aeg_-1315309873")]
    [Description(@"Cancellation due to another reason.")]
    Other = MeetingCancellationReasonCode.Other, // same ordinal as derivation source for type conversions
    
}
