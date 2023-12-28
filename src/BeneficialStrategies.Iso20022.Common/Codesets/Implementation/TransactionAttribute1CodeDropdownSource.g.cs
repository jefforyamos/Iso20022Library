﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionAttribute1Code.  ISO2002 ID# _43e9gBYgEeiXa46FI4OtcQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Attribute of the transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionAttribute1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_43e9gBYgEeiXa46FI4OtcQ")]
public partial class TransactionAttribute1CodeDropdownSource : EnumMetadataManager<TransactionAttribute1Code,ITransactionAttribute1CodeDropdownRow,TransactionAttribute1CodeDropdownRow>
{
    public TransactionAttribute1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionAttribute1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
