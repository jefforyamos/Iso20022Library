﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VoteInstructionForMeetingResolution1.  ISO2002 ID# _TLJEUNp-Ed-ak6NoX_4Aeg_1597899369.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vote instruction applying to resolutions added during the meeting.
/// </summary>
public partial record VoteInstructionForMeetingResolution1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the vote recommendation for resolutions added during the meeting.
    /// </summary>
    public required VoteInstructionAtMeeting1Code VoteIndication { get; init; } 
    /// <summary>
    /// Specifies the name and address of the shareholder to whom the rights to vote are transferred for resolutions added during the meeting.
    /// </summary>
    public required NameAndAddress9 Shareholder { get; init; } 
    
    #nullable disable
}
