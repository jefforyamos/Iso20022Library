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
[DataContract]
[XmlType]
public partial record DetailedInstructionStatus10
{
    #nullable enable
    
    /// <summary>
    /// Identifies the detailed instruction with an instruction message.
    /// </summary>
    [DataMember]
    public required IsoMax35Text InstructionIdentification { get; init; } 
    /// <summary>
    /// Identifies the safekeeping account.
    /// </summary>
    [DataMember]
    public IsoMax35Text? AccountIdentification { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [DataMember]
    public PartyIdentification40Choice_? AccountOwner { get; init; } 
    /// <summary>
    /// Identifies the subaccount of the safekeeping account.
    /// </summary>
    [DataMember]
    public IsoMax35Text? SubAccountIdentification { get; init; } 
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    [DataMember]
    public ValueList<PartyIdentification40Choice_> RightsHolder { get; init; } = [];
    /// <summary>
    /// Indicates whether standing instructions have been applied or not.
    /// </summary>
    [DataMember]
    public required IsoYesNoIndicator StandingInstruction { get; init; } 
    /// <summary>
    /// Details of the vote.
    /// </summary>
    [DataMember]
    public ValueList<Vote6> VotePerResolution { get; init; } = [];
    
    #nullable disable
}
