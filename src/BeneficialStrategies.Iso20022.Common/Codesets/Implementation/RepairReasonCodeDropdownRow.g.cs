﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RepairReasonCode.  ISO2002 ID# _Zu5sR9p-Ed-ak6NoX_4Aeg_-1795442208.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction is in repair.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RepairReasonCodeDropdownSource"/>.
/// Implements <seealso cref="IRepairReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Zu5sR9p-Ed-ak6NoX_4Aeg_-1795442208")]
public partial class RepairReasonCodeDropdownRow : EnumMetadataItem<RepairReasonCode>, IRepairReasonCodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why the instruction is in repair.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RepairReasonCodeDropdownRow(RepairReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
