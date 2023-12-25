﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionActionCode.  ISO2002 ID# _VgL1MNuTEeiB5uLfkg9ZJA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Action to realise on a transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionActionCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VgL1MNuTEeiB5uLfkg9ZJA")]
public partial class TransactionActionCodeDropdownSource : EnumMetadataManager<TransactionActionCode,ITransactionActionCodeDropdownRow,TransactionActionCodeDropdownRow>
{
    public TransactionActionCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionActionCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
