﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MessageRejectedReason2Code.  ISO2002 ID# _e6CmIEpIEe2Kv_AXFg3f7A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a message rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_e6CmIEpIEe2Kv_AXFg3f7A")]
[Description(@"Specifies the reason for a message rejected status.")]
[DerivedFrom(typeof(RejectedStatusReasonV2Code))]
public enum MessageRejectedReason2Code
{
    /// <summary>
    /// Sending party is not allowed to send this request.
    /// Encoded/decoded by serializers as "NALO".
    /// </summary>
    [EnumMember(Value = "NALO")]
    [IsoId("_QFfXQUpJEe2Kv_AXFg3f7A")]
    [Description(@"Sending party is not allowed to send this request.")]
    NotAllowedRequest = RejectedStatusReasonV2Code.NotAllowedRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request contains an invalid or unrecognised business reference.
    /// Encoded/decoded by serializers as "REFE".
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_Tb6ggUpJEe2Kv_AXFg3f7A")]
    [Description(@"Request contains an invalid or unrecognised business reference.")]
    InvalidOrUnrecognisedReference = RejectedStatusReasonV2Code.InvalidOrUnrecognisedReference, // same ordinal as derivation source for type conversions
    
}
