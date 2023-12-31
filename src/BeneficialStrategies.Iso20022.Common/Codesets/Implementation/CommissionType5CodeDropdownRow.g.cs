﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CommissionType5Code.  ISO2002 ID# _VkKxNtp-Ed-ak6NoX_4Aeg_377990975.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of investment fund commission.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CommissionType5CodeDropdownSource"/>.
/// Implements <seealso cref="ICommissionType5CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VkKxNtp-Ed-ak6NoX_4Aeg_377990975")]
public partial class CommissionType5CodeDropdownRow : EnumMetadataItem<CommissionType5Code>, ICommissionType5CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of investment fund commission.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CommissionType5CodeDropdownRow(CommissionType5Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
