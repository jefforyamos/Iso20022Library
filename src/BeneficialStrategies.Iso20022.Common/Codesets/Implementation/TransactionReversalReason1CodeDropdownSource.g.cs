﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionReversalReason1Code.  ISO2002 ID# _YuFIdtp-Ed-ak6NoX_4Aeg_1201919260.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a transaction to be reversed by an instructed agent or somebody acting on behalf of an instructed agent.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionReversalReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YuFIdtp-Ed-ak6NoX_4Aeg_1201919260")]
public partial class TransactionReversalReason1CodeDropdownSource : EnumMetadataManager<TransactionReversalReason1Code,ITransactionReversalReason1CodeDropdownRow,TransactionReversalReason1CodeDropdownRow>
{
    public TransactionReversalReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionReversalReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
