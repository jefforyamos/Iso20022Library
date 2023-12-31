﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ERISAEligibilityCode.  ISO2002 ID# _ah3aQNp-Ed-ak6NoX_4Aeg_-672768404.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies information about ERISA (Eligibility to federal Employee Retirement Income Security Act) eligibility.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ERISAEligibilityCodeDropdownSource"/>.
/// Implements <seealso cref="IERISAEligibilityCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ah3aQNp-Ed-ak6NoX_4Aeg_-672768404")]
public partial class ERISAEligibilityCodeDropdownRow : EnumMetadataItem<ERISAEligibilityCode>, IERISAEligibilityCodeDropdownRow
{
    /// <summary>
    /// Specifies information about ERISA (Eligibility to federal Employee Retirement Income Security Act) eligibility.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ERISAEligibilityCodeDropdownRow(ERISAEligibilityCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
