﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MessageItemCondition2Code.  ISO2002 ID# _axD3cXC8Ee2bmOA3bkVsMg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Rule to apply for the presence of a message item.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMessageItemCondition2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_axD3cXC8Ee2bmOA3bkVsMg")]
public partial class MessageItemCondition2CodeDropdownSource : EnumMetadataManager<MessageItemCondition2Code,IMessageItemCondition2CodeDropdownRow,MessageItemCondition2CodeDropdownRow>
{
    public MessageItemCondition2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MessageItemCondition2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
