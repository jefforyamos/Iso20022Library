﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MessageFunction29Code.  ISO2002 ID# _T3DTEFaGEeeFltjJxERUxw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of process related to the message.
/// Fee collection header.
/// ISO 8583 MTI
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMessageFunction29CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_T3DTEFaGEeeFltjJxERUxw")]
public partial class MessageFunction29CodeDropdownSource : EnumMetadataManager<MessageFunction29Code,IMessageFunction29CodeDropdownRow,MessageFunction29CodeDropdownRow>
{
    public MessageFunction29CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MessageFunction29CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
