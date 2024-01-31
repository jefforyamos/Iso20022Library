﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CommissionType6Code.  ISO2002 ID# _a_9rg9p-Ed-ak6NoX_4Aeg_2025119069.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of investment fund commission.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CommissionType6CodeDropdownSource"/>.
/// Implements <seealso cref="ICommissionType6CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a_9rg9p-Ed-ak6NoX_4Aeg_2025119069")]
public partial class CommissionType6CodeDropdownRow : EnumMetadataItem<CommissionType6Code>, ICommissionType6CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of investment fund commission.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CommissionType6CodeDropdownRow(CommissionType6Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
