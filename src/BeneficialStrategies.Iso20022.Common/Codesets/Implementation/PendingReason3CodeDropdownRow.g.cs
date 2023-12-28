﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PendingReason3Code.  ISO2002 ID# _aBreUNp-Ed-ak6NoX_4Aeg_1193465665.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PendingReason3CodeDropdownSource"/>.
/// Implements <seealso cref="IPendingReason3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aBreUNp-Ed-ak6NoX_4Aeg_1193465665")]
public partial class PendingReason3CodeDropdownRow : EnumMetadataItem<PendingReason3Code>, IPendingReason3CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PendingReason3CodeDropdownRow(PendingReason3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}