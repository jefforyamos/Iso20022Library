﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VoteDetails3.  ISO2002 ID# _hU-5QV66EeSjaerr_EM7AQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies detailed voting instructions.
/// </summary>
public partial record VoteDetails3
{
    #nullable enable
    
    /// <summary>
    /// Indicates the vote instruction for the resolutions that are announced via the meeting agenda in advance of the meeting.
    /// </summary>
    public required Vote3Choice_ VoteInstructionForAgendaResolution { get; init; } 
    /// <summary>
    /// Indicates the vote instruction for the resolutions that may arise at the meeting but were not previously provided in the agenda.
    /// </summary>
    public VoteInstructionForMeetingResolution2Choice_? VoteInstructionForMeetingResolution { get; init; } 
    
    #nullable disable
}
