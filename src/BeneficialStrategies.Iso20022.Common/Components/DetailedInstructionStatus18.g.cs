﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedInstructionStatus18.  ISO2002 ID# __hC9MTUCEe2tRf29bleifQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a meeting instruction vote.
/// </summary>
public partial record DetailedInstructionStatus18
{
    #nullable enable
    
    /// <summary>
    /// Identification of the specific individual instruction from the original meeting instruction message for which the confirmation is provided.
    /// </summary>
    public required IsoMax35Text SingleInstructionIdentification { get; init; } 
    /// <summary>
    /// Identification of the safekeeping account.
    /// </summary>
    public IsoMax35Text? AccountIdentification { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification231Choice_? AccountOwner { get; init; } 
    /// <summary>
    /// Identification of the subaccount within the safekeeping account.
    /// </summary>
    public IsoMax35Text? SubAccountIdentification { get; init; } 
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    public PartyIdentification246Choice_[] RightsHolder { get; init; } = [];
    /// <summary>
    /// Identification of the person appointed by the security holder as the proxy.
    /// </summary>
    public PartyIdentification232Choice_? Proxy { get; init; } 
    /// <summary>
    /// Indicates whether standing instructions have been applied or not.
    /// </summary>
    public IsoYesNoIndicator? StandingInstruction { get; init; } 
    /// <summary>
    /// Modality through which the votes that have been recorded and counted were received by the issuer, including whether this is ahead of the meeting or at the meeting.
    /// </summary>
    public required ModalityOfCounting1Choice_ ModalityOfCounting { get; init; } 
    /// <summary>
    /// Date or date and time at which the votes that have been recorded and counted were received.
    /// </summary>
    public DateAndDateTime1Choice_? VoteReceiptDateTime { get; init; } 
    /// <summary>
    /// Details of the vote.
    /// </summary>
    public Vote17[] VotePerResolution { get; init; } = [];
    
    #nullable disable
}
