﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransactionOperationTypeV2Code.  ISO2002 ID# _TxnhUE2XEe2bQ-Ksk8mwQg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of process related to a specific transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransactionOperationTypeV2CodeDropdownSource"/>.
/// Implements <seealso cref="ITransactionOperationTypeV2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TxnhUE2XEe2bQ-Ksk8mwQg")]
public partial class TransactionOperationTypeV2CodeDropdownRow : EnumMetadataItem<TransactionOperationTypeV2Code>, ITransactionOperationTypeV2CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of process related to a specific transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransactionOperationTypeV2CodeDropdownRow(TransactionOperationTypeV2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
