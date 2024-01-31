﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PlanOwnerCode.  ISO2002 ID# _799uQNuJEei2qvU6FBLZYA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains list of plan owners
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PlanOwnerCodeDropdownSource"/>.
/// Implements <seealso cref="IPlanOwnerCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_799uQNuJEei2qvU6FBLZYA")]
public partial class PlanOwnerCodeDropdownRow : EnumMetadataItem<PlanOwnerCode>, IPlanOwnerCodeDropdownRow
{
    /// <summary>
    /// Contains list of plan owners
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PlanOwnerCodeDropdownRow(PlanOwnerCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
