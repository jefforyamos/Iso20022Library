﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InstructionRejectionReasonCode.  ISO2002 ID# _vvgkkMYMEeexPc-mfUU5zQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Reason for rejection of a corporate action instruction or of an instruction cancellation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InstructionRejectionReasonCodeDropdownSource"/>.
/// Implements <seealso cref="IInstructionRejectionReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_vvgkkMYMEeexPc-mfUU5zQ")]
public partial class InstructionRejectionReasonCodeDropdownRow : EnumMetadataItem<InstructionRejectionReasonCode>, IInstructionRejectionReasonCodeDropdownRow
{
    /// <summary>
    /// Reason for rejection of a corporate action instruction or of an instruction cancellation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InstructionRejectionReasonCodeDropdownRow(InstructionRejectionReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
