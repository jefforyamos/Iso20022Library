﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransactionAttribute1Code.  ISO2002 ID# _43e9gBYgEeiXa46FI4OtcQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Attribute of the transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransactionAttribute1CodeDropdownSource"/>.
/// Implements <seealso cref="ITransactionAttribute1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_43e9gBYgEeiXa46FI4OtcQ")]
public partial class TransactionAttribute1CodeDropdownRow : EnumMetadataItem<TransactionAttribute1Code>, ITransactionAttribute1CodeDropdownRow
{
    /// <summary>
    /// Attribute of the transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransactionAttribute1CodeDropdownRow(TransactionAttribute1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
