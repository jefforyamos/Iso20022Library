﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VoteParameters8.  ISO2002 ID# _gIRnsTT7Ee2tRf29bleifQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information describing how the voting process is organised.
/// </summary>
public partial record VoteParameters8
{
    #nullable enable
    
    /// <summary>
    /// Number of holdings required for a vote.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? SecuritiesQuantityRequiredToVote { get; init; } 
    /// <summary>
    /// Indicates whether a vote can be on a part of the entire holding, that is, part of the position is un-voted.
    /// </summary>
    public required IsoYesNoIndicator PartialVoteAllowed { get; init; } 
    /// <summary>
    /// Indicates whether the vote can be split, that is, there could be different votes for different parts of the holding.
    /// </summary>
    public required IsoYesNoIndicator SplitVoteAllowed { get; init; } 
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary.
    /// </summary>
    public DateFormat58Choice_? VoteDeadline { get; init; } 
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the issuer.
    /// </summary>
    public DateFormat58Choice_? VoteMarketDeadline { get; init; } 
    /// <summary>
    /// Specifies the different methods that can be used to vote.
    /// </summary>
    public VoteMethods5? VoteMethods { get; init; } 
    /// <summary>
    /// Electronic location, e-mail or URL address, where the voting ballot can be requested.
    /// </summary>
    public CommunicationAddress11? VotingBallotElectronicAddress { get; init; } 
    /// <summary>
    /// Postal address where the voting ballot can be requested.
    /// </summary>
    public PostalAddress1? VotingBallotRequestAddress { get; init; } 
    /// <summary>
    /// Date until which the instructing party can revoke, change or withdraw its voting instruction. This deadline is specified by an intermediary.
    /// </summary>
    public DateFormat58Choice_? RevocabilityDeadline { get; init; } 
    /// <summary>
    /// Date until which the instructing party can revoke, change or withdraw its voting instruction. This deadline is set by the issuer.
    /// </summary>
    public DateFormat58Choice_? RevocabilityMarketDeadline { get; init; } 
    /// <summary>
    /// Indicates whether beneficiary details, for example, name and address, must be supplied in order to take part in a meeting.
    /// </summary>
    public IsoYesNoIndicator? BeneficialOwnerDisclosure { get; init; } 
    /// <summary>
    /// Cash premium paid to the security holder when voting earlier (before the early vote with a premium deadline).
    /// </summary>
    public IncentivePremium5? EarlyIncentivePremium { get; init; } 
    /// <summary>
    /// Cash premium paid to the security holder when voting.
    /// </summary>
    public IncentivePremium5? IncentivePremium { get; init; } 
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary to take advantage of the early incentive premium.
    /// </summary>
    public DateFormat58Choice_? EarlyVoteWithPremiumDeadline { get; init; } 
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary to take advantage of the premium.
    /// </summary>
    public DateFormat58Choice_? VoteWithPremiumDeadline { get; init; } 
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the issuer to take advantage of the premium.
    /// </summary>
    public DateFormat58Choice_? VoteWithPremiumMarketDeadline { get; init; } 
    /// <summary>
    /// Additional information on specific requirements for allowing a person to vote.
    /// </summary>
    public IsoMax350Text? AdditionalVotingRequirements { get; init; } 
    /// <summary>
    /// Indicates whether the previously sent instructions becomes invalid after a market deadline extension.
    /// </summary>
    public IsoYesNoIndicator? PreviousInstructionInvalidityIndicator { get; init; } 
    
    #nullable disable
}
