﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ProcessingPosition4Code.  ISO2002 ID# _A2UAQBEhEeKG5rB3aM9OkQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies when a transaction/instruction is to be executed relative to a linked transaction/instruction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ProcessingPosition4CodeDropdownSource"/>.
/// Implements <seealso cref="IProcessingPosition4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_A2UAQBEhEeKG5rB3aM9OkQ")]
public partial class ProcessingPosition4CodeDropdownRow : EnumMetadataItem<ProcessingPosition4Code>, IProcessingPosition4CodeDropdownRow
{
    /// <summary>
    /// Specifies when a transaction/instruction is to be executed relative to a linked transaction/instruction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ProcessingPosition4CodeDropdownRow(ProcessingPosition4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
