﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ReinvestmentPlanCode.  ISO2002 ID# _tyUxkVf8EeOuDtoQo1qilA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the specific reinvestment plan type.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ReinvestmentPlanCodeDropdownSource"/>.
/// Implements <seealso cref="IReinvestmentPlanCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_tyUxkVf8EeOuDtoQo1qilA")]
public partial class ReinvestmentPlanCodeDropdownRow : EnumMetadataItem<ReinvestmentPlanCode>, IReinvestmentPlanCodeDropdownRow
{
    /// <summary>
    /// Indicates the specific reinvestment plan type.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ReinvestmentPlanCodeDropdownRow(ReinvestmentPlanCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
