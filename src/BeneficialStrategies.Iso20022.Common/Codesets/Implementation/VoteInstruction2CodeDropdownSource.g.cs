﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for VoteInstruction2Code.  ISO2002 ID# _Y9IRE9p-Ed-ak6NoX_4Aeg_325588560.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the possible types of voting instructions.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IVoteInstruction2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y9IRE9p-Ed-ak6NoX_4Aeg_325588560")]
public partial class VoteInstruction2CodeDropdownSource : EnumMetadataManager<VoteInstruction2Code,IVoteInstruction2CodeDropdownRow,VoteInstruction2CodeDropdownRow>
{
    public VoteInstruction2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new VoteInstruction2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
