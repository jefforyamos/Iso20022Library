﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PlanStatus1Code.  ISO2002 ID# _QAWLUAjcEeS5F6qHcKOrew.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a plan.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PlanStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IPlanStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_QAWLUAjcEeS5F6qHcKOrew")]
public partial class PlanStatus1CodeDropdownRow : EnumMetadataItem<PlanStatus1Code>, IPlanStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of a plan.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PlanStatus1CodeDropdownRow(PlanStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
