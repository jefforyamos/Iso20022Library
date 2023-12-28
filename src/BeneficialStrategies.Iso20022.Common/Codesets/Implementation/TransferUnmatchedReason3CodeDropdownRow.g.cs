﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransferUnmatchedReason3Code.  ISO2002 ID# _qfeCYJM5EemKz5EOjv82iQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransferUnmatchedReason3CodeDropdownSource"/>.
/// Implements <seealso cref="ITransferUnmatchedReason3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_qfeCYJM5EemKz5EOjv82iQ")]
public partial class TransferUnmatchedReason3CodeDropdownRow : EnumMetadataItem<TransferUnmatchedReason3Code>, ITransferUnmatchedReason3CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransferUnmatchedReason3CodeDropdownRow(TransferUnmatchedReason3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
