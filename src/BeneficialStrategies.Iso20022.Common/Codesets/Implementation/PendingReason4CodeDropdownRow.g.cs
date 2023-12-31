﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PendingReason4Code.  ISO2002 ID# _aCk2Odp-Ed-ak6NoX_4Aeg_1137066794.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Standard code to specify the reason why the instruction/event has a pending status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PendingReason4CodeDropdownSource"/>.
/// Implements <seealso cref="IPendingReason4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aCk2Odp-Ed-ak6NoX_4Aeg_1137066794")]
public partial class PendingReason4CodeDropdownRow : EnumMetadataItem<PendingReason4Code>, IPendingReason4CodeDropdownRow
{
    /// <summary>
    /// Standard code to specify the reason why the instruction/event has a pending status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PendingReason4CodeDropdownRow(PendingReason4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
