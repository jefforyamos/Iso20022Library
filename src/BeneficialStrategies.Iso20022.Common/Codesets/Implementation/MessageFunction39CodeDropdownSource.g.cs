﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MessageFunction39Code.  ISO2002 ID# _7NuDMcsZEeizUq4cFQ71-Q.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of process related to the message.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMessageFunction39CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_7NuDMcsZEeizUq4cFQ71-Q")]
public partial class MessageFunction39CodeDropdownSource : EnumMetadataManager<MessageFunction39Code,IMessageFunction39CodeDropdownRow,MessageFunction39CodeDropdownRow>
{
    public MessageFunction39CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MessageFunction39CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
