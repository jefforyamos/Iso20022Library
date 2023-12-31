﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InstructionRejectionReason3Code.  ISO2002 ID# _BNsdQFCDEe2KGNXAcFL5RA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Reason for rejection of a corporate action instruction or of an instruction cancellation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InstructionRejectionReason3CodeDropdownSource"/>.
/// Implements <seealso cref="IInstructionRejectionReason3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_BNsdQFCDEe2KGNXAcFL5RA")]
public partial class InstructionRejectionReason3CodeDropdownRow : EnumMetadataItem<InstructionRejectionReason3Code>, IInstructionRejectionReason3CodeDropdownRow
{
    /// <summary>
    /// Reason for rejection of a corporate action instruction or of an instruction cancellation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InstructionRejectionReason3CodeDropdownRow(InstructionRejectionReason3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
