﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BatchTransactionType1Code.  ISO2002 ID# _KUq-g31DEeCF8NjrBemJWQ_-2092931546.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of transactions to include in a batch transfer.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BatchTransactionType1CodeDropdownSource"/>.
/// Implements <seealso cref="IBatchTransactionType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KUq-g31DEeCF8NjrBemJWQ_-2092931546")]
public partial class BatchTransactionType1CodeDropdownRow : EnumMetadataItem<BatchTransactionType1Code>, IBatchTransactionType1CodeDropdownRow
{
    /// <summary>
    /// Type of transactions to include in a batch transfer.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BatchTransactionType1CodeDropdownRow(BatchTransactionType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
