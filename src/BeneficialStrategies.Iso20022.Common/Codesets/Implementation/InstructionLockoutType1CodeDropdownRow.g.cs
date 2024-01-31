﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InstructionLockoutType1Code.  ISO2002 ID# _YXPTYA7xEeuZI5Sr_GAcuA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specify the type of blocking when instructions are temporarily blocked for an event.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InstructionLockoutType1CodeDropdownSource"/>.
/// Implements <seealso cref="IInstructionLockoutType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YXPTYA7xEeuZI5Sr_GAcuA")]
public partial class InstructionLockoutType1CodeDropdownRow : EnumMetadataItem<InstructionLockoutType1Code>, IInstructionLockoutType1CodeDropdownRow
{
    /// <summary>
    /// Specify the type of blocking when instructions are temporarily blocked for an event.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InstructionLockoutType1CodeDropdownRow(InstructionLockoutType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
