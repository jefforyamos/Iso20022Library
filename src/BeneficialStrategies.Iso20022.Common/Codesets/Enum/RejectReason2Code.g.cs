﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectReason2Code.  ISO2002 ID# _QF27QWp1EeSMqvBfBY1c9A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason of transmission of a rejection message in response to a request or an advice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QF27QWp1EeSMqvBfBY1c9A")]
[Description(@"Reason of transmission of a rejection message in response to a request or an advice.")]
[DerivedFrom(typeof(RejectReasonCode))]
public enum RejectReason2Code
{
    /// <summary>
    /// Not possible to process the message, for instance the security module is unavailable, the hardware is unavailable, or there is a problem of resource.
    /// Encoded/decoded by serializers as "UNPR".
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_QSOjUWp1EeSMqvBfBY1c9A")]
    [Description(@"Not possible to process the message, for instance the security module is unavailable, the hardware is unavailable, or there is a problem of resource.")]
    UnableToProcess = RejectReasonCode.UnableToProcess, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid envelope of the message.
    /// Encoded/decoded by serializers as "IMSG".
    /// </summary>
    [EnumMember(Value = "IMSG")]
    [IsoId("_QSOjU2p1EeSMqvBfBY1c9A")]
    [Description(@"Invalid envelope of the message.")]
    InvalidMessage = RejectReasonCode.InvalidMessage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid message: At least one of the data element or data structure is not present, the format, or the content of one data element or one data structure is not correct.
    /// Encoded/decoded by serializers as "PARS".
    /// </summary>
    [EnumMember(Value = "PARS")]
    [IsoId("_QSOjVWp1EeSMqvBfBY1c9A")]
    [Description(@"Invalid message: At least one of the data element or data structure is not present, the format, or the content of one data element or one data structure is not correct.")]
    ParsingError = RejectReasonCode.ParsingError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Security error (for example an invalid key or an incorrect MAC value).
    /// Encoded/decoded by serializers as "SECU".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_QSOjV2p1EeSMqvBfBY1c9A")]
    [Description(@"Security error (for example an invalid key or an incorrect MAC value).")]
    Security = RejectReasonCode.Security, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid identification data for the sender.
    /// Encoded/decoded by serializers as "INTP".
    /// </summary>
    [EnumMember(Value = "INTP")]
    [IsoId("_QSOjWWp1EeSMqvBfBY1c9A")]
    [Description(@"Invalid identification data for the sender.")]
    InitiatingParty = RejectReasonCode.InitiatingParty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid identification data for the the receiver.
    /// Encoded/decoded by serializers as "RCPP".
    /// </summary>
    [EnumMember(Value = "RCPP")]
    [IsoId("_QSOjW2p1EeSMqvBfBY1c9A")]
    [Description(@"Invalid identification data for the the receiver.")]
    RecipientParty = RejectReasonCode.RecipientParty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Version of the protocol couldn't be supported by the recipient.
    /// Encoded/decoded by serializers as "VERS".
    /// </summary>
    [EnumMember(Value = "VERS")]
    [IsoId("_QSOjX2p1EeSMqvBfBY1c9A")]
    [Description(@"Version of the protocol couldn't be supported by the recipient.")]
    ProtocolVersion = RejectReasonCode.ProtocolVersion, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of message the recipient receives is unknow or unsupported.
    /// Encoded/decoded by serializers as "MSGT".
    /// </summary>
    [EnumMember(Value = "MSGT")]
    [IsoId("_QSOjYWp1EeSMqvBfBY1c9A")]
    [Description(@"Type of message the recipient receives is unknow or unsupported.")]
    MessageType = RejectReasonCode.MessageType, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectReason2CodeMetadataExtensions
{
    private static readonly RejectReason2CodeDropdownSource _dropdownSource = new RejectReason2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectReason2CodeDropdownRow GetMetadata(this RejectReason2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


