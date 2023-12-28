﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MessageRejectedReason2Code.  ISO2002 ID# _e6CmIEpIEe2Kv_AXFg3f7A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// Encoded/decoded by serializers as "NotAllowedRequest".
    /// </summary>
    [EnumMember(Value = "NALO")]
    [IsoId("_QFfXQUpJEe2Kv_AXFg3f7A")]
    [Description(@"Sending party is not allowed to send this request.")]
    NotAllowedRequest,
    
    /// <summary>
    /// Request contains an invalid or unrecognised business reference.
    /// Encoded/decoded by serializers as "InvalidOrUnrecognisedReference".
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_Tb6ggUpJEe2Kv_AXFg3f7A")]
    [Description(@"Request contains an invalid or unrecognised business reference.")]
    InvalidOrUnrecognisedReference,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MessageRejectedReason2CodeMetadataExtensions
{
    private static readonly MessageRejectedReason2CodeDropdownSource _dropdownSource = new MessageRejectedReason2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMessageRejectedReason2CodeDropdownRow GetMetadata(this MessageRejectedReason2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


