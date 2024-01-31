﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MessageFunction6Code.  ISO2002 ID# _r7c3QHrKEeSfJf8ETXpBxg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of process related to the message. It partially correspond to the message type identifier (MTI) of ISO 8583.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMessageFunction6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_r7c3QHrKEeSfJf8ETXpBxg")]
public partial class MessageFunction6CodeDropdownSource : EnumMetadataManager<MessageFunction6Code,IMessageFunction6CodeDropdownRow,MessageFunction6CodeDropdownRow>
{
    public MessageFunction6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MessageFunction6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
