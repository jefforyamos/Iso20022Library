﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransactionOperationTypeCode.  ISO2002 ID# _0tTA3JfpEeSfnc-VXAEapg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of process related to a specific transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransactionOperationTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ITransactionOperationTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_0tTA3JfpEeSfnc-VXAEapg")]
public partial class TransactionOperationTypeCodeDropdownRow : EnumMetadataItem<TransactionOperationTypeCode>, ITransactionOperationTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of process related to a specific transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransactionOperationTypeCodeDropdownRow(TransactionOperationTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
