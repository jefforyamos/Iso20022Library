﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for VotingParticipationMethod2Code.  ISO2002 ID# _Blwy0PNqEeqRfth943bvEA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the different methods allowed for participating to the vote of agenda resolutions in a general meeting.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IVotingParticipationMethod2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Blwy0PNqEeqRfth943bvEA")]
public partial class VotingParticipationMethod2CodeDropdownSource : EnumMetadataManager<VotingParticipationMethod2Code,IVotingParticipationMethod2CodeDropdownRow,VotingParticipationMethod2CodeDropdownRow>
{
    public VotingParticipationMethod2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new VotingParticipationMethod2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}