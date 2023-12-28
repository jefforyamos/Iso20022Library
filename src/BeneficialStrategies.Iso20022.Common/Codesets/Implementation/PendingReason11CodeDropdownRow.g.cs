﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PendingReason11Code.  ISO2002 ID# _dc-9MCdcEeOXAt_43VmZGw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PendingReason11CodeDropdownSource"/>.
/// Implements <seealso cref="IPendingReason11CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_dc-9MCdcEeOXAt_43VmZGw")]
public partial class PendingReason11CodeDropdownRow : EnumMetadataItem<PendingReason11Code>, IPendingReason11CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PendingReason11CodeDropdownRow(PendingReason11Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
