﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AdjustmentDirectionCode.  ISO2002 ID# _bnKOY9p-Ed-ak6NoX_4Aeg_-700576555.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the adjustment is added or substracted to the total amount.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AdjustmentDirectionCodeDropdownSource"/>.
/// Implements <seealso cref="IAdjustmentDirectionCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bnKOY9p-Ed-ak6NoX_4Aeg_-700576555")]
public partial class AdjustmentDirectionCodeDropdownRow : EnumMetadataItem<AdjustmentDirectionCode>, IAdjustmentDirectionCodeDropdownRow
{
    /// <summary>
    /// Specifies whether the adjustment is added or substracted to the total amount.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AdjustmentDirectionCodeDropdownRow(AdjustmentDirectionCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
