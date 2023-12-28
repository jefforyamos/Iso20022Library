﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MessageFunction1Code.  ISO2002 ID# _TTQlWAEcEeCQm6a_G2yO_w_1318301826.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the message function within a card payment exchange.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMessageFunction1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TTQlWAEcEeCQm6a_G2yO_w_1318301826")]
public partial class MessageFunction1CodeDropdownSource : EnumMetadataManager<MessageFunction1Code,IMessageFunction1CodeDropdownRow,MessageFunction1CodeDropdownRow>
{
    public MessageFunction1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MessageFunction1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
