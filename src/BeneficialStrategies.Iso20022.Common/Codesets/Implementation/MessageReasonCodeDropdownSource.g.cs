﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MessageReasonCode.  ISO2002 ID# _xKIOEHs3EeSTS7uHCe8FPQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Reason to send an card acquirer to issuer message.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMessageReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_xKIOEHs3EeSTS7uHCe8FPQ")]
public partial class MessageReasonCodeDropdownSource : EnumMetadataManager<MessageReasonCode,IMessageReasonCodeDropdownRow,MessageReasonCodeDropdownRow>
{
    public MessageReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new MessageReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}