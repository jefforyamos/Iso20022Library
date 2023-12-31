﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for VoteChannel1Code.  ISO2002 ID# _dQw9IDT9Ee2tRf29bleifQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the network channel through which the vote should be sent.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IVoteChannel1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_dQw9IDT9Ee2tRf29bleifQ")]
public partial class VoteChannel1CodeDropdownSource : EnumMetadataManager<VoteChannel1Code,IVoteChannel1CodeDropdownRow,VoteChannel1CodeDropdownRow>
{
    public VoteChannel1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new VoteChannel1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
