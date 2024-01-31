﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionOperationType7Code.  ISO2002 ID# _0_mwii42Eeuxhbw_aW6haw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction operation action type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionOperationType7CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_0_mwii42Eeuxhbw_aW6haw")]
public partial class TransactionOperationType7CodeDropdownSource : EnumMetadataManager<TransactionOperationType7Code,ITransactionOperationType7CodeDropdownRow,TransactionOperationType7CodeDropdownRow>
{
    public TransactionOperationType7CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionOperationType7CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
