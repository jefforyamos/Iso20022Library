﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MessageReason2Code.  ISO2002 ID# _sVbosE0eEeea0Mdu1TOzDQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Reason to send the message.
/// ISO 8583:93/2003 bit 25.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MessageReason2CodeDropdownSource"/>.
/// Implements <seealso cref="IMessageReason2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_sVbosE0eEeea0Mdu1TOzDQ")]
public partial class MessageReason2CodeDropdownRow : EnumMetadataItem<MessageReason2Code>, IMessageReason2CodeDropdownRow
{
    /// <summary>
    /// Reason to send the message.
    /// ISO 8583:93/2003 bit 25.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MessageReason2CodeDropdownRow(MessageReason2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
