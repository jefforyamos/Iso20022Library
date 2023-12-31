﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InstructionRejectionReason1Code.  ISO2002 ID# _W_GJgMYNEeexPc-mfUU5zQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Reason for rejection of a corporate action instruction or of an instruction cancellation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InstructionRejectionReason1CodeDropdownSource"/>.
/// Implements <seealso cref="IInstructionRejectionReason1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_W_GJgMYNEeexPc-mfUU5zQ")]
public partial class InstructionRejectionReason1CodeDropdownRow : EnumMetadataItem<InstructionRejectionReason1Code>, IInstructionRejectionReason1CodeDropdownRow
{
    /// <summary>
    /// Reason for rejection of a corporate action instruction or of an instruction cancellation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InstructionRejectionReason1CodeDropdownRow(InstructionRejectionReason1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
