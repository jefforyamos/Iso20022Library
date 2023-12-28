﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionChannelCode.  ISO2002 ID# _TVWQBgEcEeCQm6a_G2yO_w_644173117.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of communication channel.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionChannelCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TVWQBgEcEeCQm6a_G2yO_w_644173117")]
public partial class TransactionChannelCodeDropdownSource : EnumMetadataManager<TransactionChannelCode,ITransactionChannelCodeDropdownRow,TransactionChannelCodeDropdownRow>
{
    public TransactionChannelCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionChannelCodeDropdownRow(enumValue, memberInfo))
    {
    }
}