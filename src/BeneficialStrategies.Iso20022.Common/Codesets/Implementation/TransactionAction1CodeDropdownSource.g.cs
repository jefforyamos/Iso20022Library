﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionAction1Code.  ISO2002 ID# _68vWQNuTEeiB5uLfkg9ZJA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Action to realise on a transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionAction1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_68vWQNuTEeiB5uLfkg9ZJA")]
public partial class TransactionAction1CodeDropdownSource : EnumMetadataManager<TransactionAction1Code,ITransactionAction1CodeDropdownRow,TransactionAction1CodeDropdownRow>
{
    public TransactionAction1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionAction1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
