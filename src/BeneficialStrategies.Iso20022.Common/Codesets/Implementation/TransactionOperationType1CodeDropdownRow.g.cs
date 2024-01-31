﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransactionOperationType1Code.  ISO2002 ID# _8-aicJfpEeSfnc-VXAEapg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of process related to a specific transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransactionOperationType1CodeDropdownSource"/>.
/// Implements <seealso cref="ITransactionOperationType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8-aicJfpEeSfnc-VXAEapg")]
public partial class TransactionOperationType1CodeDropdownRow : EnumMetadataItem<TransactionOperationType1Code>, ITransactionOperationType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of process related to a specific transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransactionOperationType1CodeDropdownRow(TransactionOperationType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
