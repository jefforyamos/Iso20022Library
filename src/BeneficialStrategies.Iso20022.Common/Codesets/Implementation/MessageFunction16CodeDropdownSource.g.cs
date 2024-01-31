﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MessageFunction16Code.  ISO2002 ID# _96BnAE9yEeePXdaAO32Uew.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of process related to a financial initiation and financial response message.
/// ISO 8583 MTI
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMessageFunction16CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_96BnAE9yEeePXdaAO32Uew")]
public partial class MessageFunction16CodeDropdownSource : EnumMetadataManager<MessageFunction16Code,IMessageFunction16CodeDropdownRow,MessageFunction16CodeDropdownRow>
{
    public MessageFunction16CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MessageFunction16CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
