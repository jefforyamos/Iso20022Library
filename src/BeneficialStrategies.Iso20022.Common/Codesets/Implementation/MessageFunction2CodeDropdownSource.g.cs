﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MessageFunction2Code.  ISO2002 ID# _TRnmlQEcEeCQm6a_G2yO_w_1237934743.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the function of the message.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMessageFunction2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TRnmlQEcEeCQm6a_G2yO_w_1237934743")]
public partial class MessageFunction2CodeDropdownSource : EnumMetadataManager<MessageFunction2Code,IMessageFunction2CodeDropdownRow,MessageFunction2CodeDropdownRow>
{
    public MessageFunction2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MessageFunction2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
