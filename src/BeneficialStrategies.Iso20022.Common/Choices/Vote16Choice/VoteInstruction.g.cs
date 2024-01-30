﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for VoteInstruction.  ISO2002 ID# _XbSmlfNoEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Vote16Choice;

/// <summary>
/// Instruction specifying the instructed quantity of voting rights per resolution. Split votes can be indicated. If only one type of decision is indicated, the number of votes cast must not be adjusted if the position of the voting party increases.
/// </summary>
public partial record VoteInstruction : IVote16Choice
{
    #nullable enable
    /// <summary>
    /// Number of the resolution as specified by the issuer or its agent.
    /// </summary>
    public required IsoMax35Text IssuerLabel { get; init; } 
    /// <summary>
    /// Identifies under the same label a group of agenda resolutions for which a vote in favour can be assigned to only one resolution of that group.
    /// </summary>
    public IsoMax35Text? ListingGroupResolutionLabel { get; init; } 
    /// <summary>
    /// Number of votes in favour of one resolution.
    /// </summary>
    public IQuantityOrCode1Choice? For { get; init; } 
    /// <summary>
    /// Number of votes against one resolution.
    /// </summary>
    public IQuantityOrCode1Choice? Against { get; init; } 
    /// <summary>
    /// Number of abstention votes for one resolution.
    /// </summary>
    public IQuantityOrCode1Choice? Abstain { get; init; } 
    /// <summary>
    /// Number of votes withheld for one resolution.
    /// </summary>
    public IQuantityOrCode1Choice? Withhold { get; init; } 
    /// <summary>
    /// Number of votes in line with the votes of the management.
    /// </summary>
    public IQuantityOrCode1Choice? WithManagement { get; init; } 
    /// <summary>
    /// Number of votes against the voting recommendation of the management.
    /// </summary>
    public IQuantityOrCode1Choice? AgainstManagement { get; init; } 
    /// <summary>
    /// Number of votes for which decision is left to the party that will exercise the voting right.
    /// </summary>
    public IQuantityOrCode1Choice? Discretionary { get; init; } 
    /// <summary>
    /// Number of votes in favour for one year for "say on pay" type of resolution.
    /// </summary>
    public IQuantityOrCode1Choice? OneYear { get; init; } 
    /// <summary>
    /// Number of votes in favour of two years for "say on pay" type of resolution.
    /// </summary>
    public IQuantityOrCode1Choice? TwoYears { get; init; } 
    /// <summary>
    /// Number of votes in favour of three years for "say on pay" type of resolution.
    /// </summary>
    public IQuantityOrCode1Choice? ThreeYears { get; init; } 
    /// <summary>
    /// Do not vote.
    /// </summary>
    public IQuantityOrCode1Choice? NoAction { get; init; } 
    /// <summary>
    /// Vote is cast as empty but the vote is counted.
    /// </summary>
    public IQuantityOrCode1Choice? Blank { get; init; } 
    /// <summary>
    /// Other type of vote expressed as a proprietary code.
    /// </summary>
    // public IReadOnlyCollection<ProprietaryVote1> Proprietary { get; init; }
    #nullable disable
}
