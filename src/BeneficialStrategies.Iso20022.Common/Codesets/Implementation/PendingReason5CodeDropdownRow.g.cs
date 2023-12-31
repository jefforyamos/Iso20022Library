﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PendingReason5Code.  ISO2002 ID# _aCuAJdp-Ed-ak6NoX_4Aeg_1990265941.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Standard code to specify the reason why the instruction/event has a pending status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PendingReason5CodeDropdownSource"/>.
/// Implements <seealso cref="IPendingReason5CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aCuAJdp-Ed-ak6NoX_4Aeg_1990265941")]
public partial class PendingReason5CodeDropdownRow : EnumMetadataItem<PendingReason5Code>, IPendingReason5CodeDropdownRow
{
    /// <summary>
    /// Standard code to specify the reason why the instruction/event has a pending status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PendingReason5CodeDropdownRow(PendingReason5Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
