﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionReversalReason2Code.  ISO2002 ID# _YuO5c9p-Ed-ak6NoX_4Aeg_1617912332.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a transaction to be reversed by an instructed agent or somebody acting on behalf of an instructed agent.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionReversalReason2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YuO5c9p-Ed-ak6NoX_4Aeg_1617912332")]
public partial class TransactionReversalReason2CodeDropdownSource : EnumMetadataManager<TransactionReversalReason2Code,ITransactionReversalReason2CodeDropdownRow,TransactionReversalReason2CodeDropdownRow>
{
    public TransactionReversalReason2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionReversalReason2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
