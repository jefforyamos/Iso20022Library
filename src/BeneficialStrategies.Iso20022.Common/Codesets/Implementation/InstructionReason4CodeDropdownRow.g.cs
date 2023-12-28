﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InstructionReason4Code.  ISO2002 ID# _lc0n0TDvEey2N-DB7H7A5A.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Reason for a corporate action instruction or an instruction cancellation being rejected or pending.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InstructionReason4CodeDropdownSource"/>.
/// Implements <seealso cref="IInstructionReason4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_lc0n0TDvEey2N-DB7H7A5A")]
public partial class InstructionReason4CodeDropdownRow : EnumMetadataItem<InstructionReason4Code>, IInstructionReason4CodeDropdownRow
{
    /// <summary>
    /// Reason for a corporate action instruction or an instruction cancellation being rejected or pending.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InstructionReason4CodeDropdownRow(InstructionReason4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}