﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VoteDetails2.  ISO2002 ID# _RDYtoNp-Ed-ak6NoX_4Aeg_1302554579.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies detailed voting instructions.
/// </summary>
public partial record VoteDetails2
{
    #nullable enable
    
    /// <summary>
    /// Indicates the vote instruction for the resolutions which are announced via the meeting agenda in advance of the meeting.
    /// </summary>
    public required IVote2Choice VoteInstructionForAgendaResolution { get; init; } 
    /// <summary>
    /// Indicates the vote instruction for the resolutions that may arise at the meeting but were not previously provided in the agenda.
    /// </summary>
    public IVoteInstructionForMeetingResolution1Choice? VoteInstructionForMeetingResolution { get; init; } 
    
    #nullable disable
}
