﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InstalmentPlanCode.  ISO2002 ID# _pQ8HgDDgEeO9waS4ina8CA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of instalment plan.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InstalmentPlanCodeDropdownSource"/>.
/// Implements <seealso cref="IInstalmentPlanCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_pQ8HgDDgEeO9waS4ina8CA")]
public partial class InstalmentPlanCodeDropdownRow : EnumMetadataItem<InstalmentPlanCode>, IInstalmentPlanCodeDropdownRow
{
    /// <summary>
    /// Type of instalment plan.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InstalmentPlanCodeDropdownRow(InstalmentPlanCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
