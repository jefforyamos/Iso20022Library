﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CommissionType7Code.  ISO2002 ID# _a_9rh9p-Ed-ak6NoX_4Aeg_1912267455.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of investment fund commission.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CommissionType7CodeDropdownSource"/>.
/// Implements <seealso cref="ICommissionType7CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a_9rh9p-Ed-ak6NoX_4Aeg_1912267455")]
public partial class CommissionType7CodeDropdownRow : EnumMetadataItem<CommissionType7Code>, ICommissionType7CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of investment fund commission.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CommissionType7CodeDropdownRow(CommissionType7Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
