﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for VoteInstructionV2Code.  ISO2002 ID# _QoCAzq4IEemG7MmivSuE5g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the possible types of voting instructions.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="VoteInstructionV2CodeDropdownSource"/>.
/// Implements <seealso cref="IVoteInstructionV2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_QoCAzq4IEemG7MmivSuE5g")]
public partial class VoteInstructionV2CodeDropdownRow : EnumMetadataItem<VoteInstructionV2Code>, IVoteInstructionV2CodeDropdownRow
{
    /// <summary>
    /// Specifies the possible types of voting instructions.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public VoteInstructionV2CodeDropdownRow(VoteInstructionV2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
