﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RepairReason4Code.  ISO2002 ID# _ZuAUYNp-Ed-ak6NoX_4Aeg_964099822.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the settlement instruction has a repair status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RepairReason4CodeDropdownSource"/>.
/// Implements <seealso cref="IRepairReason4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZuAUYNp-Ed-ak6NoX_4Aeg_964099822")]
public partial class RepairReason4CodeDropdownRow : EnumMetadataItem<RepairReason4Code>, IRepairReason4CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why the settlement instruction has a repair status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RepairReason4CodeDropdownRow(RepairReason4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
