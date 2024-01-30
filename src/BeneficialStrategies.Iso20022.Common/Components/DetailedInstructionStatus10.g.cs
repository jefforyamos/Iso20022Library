﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedInstructionStatus10.  ISO2002 ID# _qwFXEVtfEeSwKe7KuKvXhg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status applying to individual instructions of a MeetingInstruction.
/// </summary>
public partial record DetailedInstructionStatus10
{
    #nullable enable
    
    /// <summary>
    /// Identifies the detailed instruction with an instruction message.
    /// </summary>
    public required IsoMax35Text InstructionIdentification { get; init; } 
    /// <summary>
    /// Identifies the safekeeping account.
    /// </summary>
    public IsoMax35Text? AccountIdentification { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public IPartyIdentification40Choice? AccountOwner { get; init; } 
    /// <summary>
    /// Identifies the subaccount of the safekeeping account.
    /// </summary>
    public IsoMax35Text? SubAccountIdentification { get; init; } 
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    // public IReadOnlyCollection<IPartyIdentification40Choice> RightsHolder { get; init; }
    /// <summary>
    /// Indicates whether standing instructions have been applied or not.
    /// </summary>
    public required IsoYesNoIndicator StandingInstruction { get; init; } 
    /// <summary>
    /// Details of the vote.
    /// </summary>
    // public IReadOnlyCollection<Vote6> VotePerResolution { get; init; }
    
    #nullable disable
}
