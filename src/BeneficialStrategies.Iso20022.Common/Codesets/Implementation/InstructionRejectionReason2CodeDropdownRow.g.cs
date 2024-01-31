﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InstructionRejectionReason2Code.  ISO2002 ID# _53kiUACpEeqouY-yI_q3qQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason for rejection of a corporate action instruction or of an instruction cancellation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InstructionRejectionReason2CodeDropdownSource"/>.
/// Implements <seealso cref="IInstructionRejectionReason2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_53kiUACpEeqouY-yI_q3qQ")]
public partial class InstructionRejectionReason2CodeDropdownRow : EnumMetadataItem<InstructionRejectionReason2Code>, IInstructionRejectionReason2CodeDropdownRow
{
    /// <summary>
    /// Reason for rejection of a corporate action instruction or of an instruction cancellation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InstructionRejectionReason2CodeDropdownRow(InstructionRejectionReason2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
