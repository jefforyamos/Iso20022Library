﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ProcessingPosition5Code.  ISO2002 ID# _7_v2oGaxEeWZev0W8F756g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies when a transaction/instruction is to be executed relative to a linked transaction/instruction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ProcessingPosition5CodeDropdownSource"/>.
/// Implements <seealso cref="IProcessingPosition5CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_7_v2oGaxEeWZev0W8F756g")]
public partial class ProcessingPosition5CodeDropdownRow : EnumMetadataItem<ProcessingPosition5Code>, IProcessingPosition5CodeDropdownRow
{
    /// <summary>
    /// Specifies when a transaction/instruction is to be executed relative to a linked transaction/instruction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ProcessingPosition5CodeDropdownRow(ProcessingPosition5Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
