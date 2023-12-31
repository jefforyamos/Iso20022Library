﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MessageFunction11Code.  ISO2002 ID# _evJWQa1xEeWMg5rOByfExw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of process related to an ATM message.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMessageFunction11CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_evJWQa1xEeWMg5rOByfExw")]
public partial class MessageFunction11CodeDropdownSource : EnumMetadataManager<MessageFunction11Code,IMessageFunction11CodeDropdownRow,MessageFunction11CodeDropdownRow>
{
    public MessageFunction11CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MessageFunction11CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
