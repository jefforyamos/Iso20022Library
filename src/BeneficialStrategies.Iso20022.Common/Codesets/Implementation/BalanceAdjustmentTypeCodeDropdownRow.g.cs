﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BalanceAdjustmentTypeCode.  ISO2002 ID# _6URjCJqlEeGSON8vddiWzQ_-920501493.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the type of allowed balance adjustment.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BalanceAdjustmentTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IBalanceAdjustmentTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6URjCJqlEeGSON8vddiWzQ_-920501493")]
public partial class BalanceAdjustmentTypeCodeDropdownRow : EnumMetadataItem<BalanceAdjustmentTypeCode>, IBalanceAdjustmentTypeCodeDropdownRow
{
    /// <summary>
    /// Defines the type of allowed balance adjustment.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BalanceAdjustmentTypeCodeDropdownRow(BalanceAdjustmentTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
