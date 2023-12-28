﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for VoteInstruction7Code.  ISO2002 ID# _JCPdYfNoEeqRfth943bvEA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of voting instructions.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IVoteInstruction7CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_JCPdYfNoEeqRfth943bvEA")]
public partial class VoteInstruction7CodeDropdownSource : EnumMetadataManager<VoteInstruction7Code,IVoteInstruction7CodeDropdownRow,VoteInstruction7CodeDropdownRow>
{
    public VoteInstruction7CodeDropdownSource()
        : base( (enumValue, memberInfo) => new VoteInstruction7CodeDropdownRow(enumValue, memberInfo))
    {
    }
}