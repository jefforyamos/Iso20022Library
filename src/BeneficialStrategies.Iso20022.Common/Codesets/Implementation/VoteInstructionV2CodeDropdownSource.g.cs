﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for VoteInstructionV2Code.  ISO2002 ID# _QoCAzq4IEemG7MmivSuE5g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the possible types of voting instructions.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IVoteInstructionV2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_QoCAzq4IEemG7MmivSuE5g")]
public partial class VoteInstructionV2CodeDropdownSource : EnumMetadataManager<VoteInstructionV2Code,IVoteInstructionV2CodeDropdownRow,VoteInstructionV2CodeDropdownRow>
{
    public VoteInstructionV2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new VoteInstructionV2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
