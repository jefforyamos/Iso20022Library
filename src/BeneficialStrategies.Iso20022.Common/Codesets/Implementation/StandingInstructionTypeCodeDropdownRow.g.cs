﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for StandingInstructionTypeCode.  ISO2002 ID# _ZP6DINp-Ed-ak6NoX_4Aeg_1021868679.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of standing instruction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="StandingInstructionTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IStandingInstructionTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZP6DINp-Ed-ak6NoX_4Aeg_1021868679")]
public partial class StandingInstructionTypeCodeDropdownRow : EnumMetadataItem<StandingInstructionTypeCode>, IStandingInstructionTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of standing instruction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public StandingInstructionTypeCodeDropdownRow(StandingInstructionTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
