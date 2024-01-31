﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BatchTransactionTypeCode.  ISO2002 ID# _KUq-iH1DEeCF8NjrBemJWQ_-1037208756.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of transactions to include in a batch transfer.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BatchTransactionTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IBatchTransactionTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KUq-iH1DEeCF8NjrBemJWQ_-1037208756")]
public partial class BatchTransactionTypeCodeDropdownRow : EnumMetadataItem<BatchTransactionTypeCode>, IBatchTransactionTypeCodeDropdownRow
{
    /// <summary>
    /// Type of transactions to include in a batch transfer.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BatchTransactionTypeCodeDropdownRow(BatchTransactionTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
