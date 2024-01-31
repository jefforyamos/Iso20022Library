﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionOperationType11Code.  ISO2002 ID# _7UXS0E2XEe2bQ-Ksk8mwQg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction operation action type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionOperationType11CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_7UXS0E2XEe2bQ-Ksk8mwQg")]
public partial class TransactionOperationType11CodeDropdownSource : EnumMetadataManager<TransactionOperationType11Code,ITransactionOperationType11CodeDropdownRow,TransactionOperationType11CodeDropdownRow>
{
    public TransactionOperationType11CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionOperationType11CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
