﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransactionOperationType11Code.  ISO2002 ID# _7UXS0E2XEe2bQ-Ksk8mwQg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the transaction operation action type.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransactionOperationType11CodeDropdownSource"/>.
/// Implements <seealso cref="ITransactionOperationType11CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_7UXS0E2XEe2bQ-Ksk8mwQg")]
public partial class TransactionOperationType11CodeDropdownRow : EnumMetadataItem<TransactionOperationType11Code>, ITransactionOperationType11CodeDropdownRow
{
    /// <summary>
    /// Specifies the transaction operation action type.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransactionOperationType11CodeDropdownRow(TransactionOperationType11Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}