﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Vote16.  ISO2002 ID# _o2ZR4fNwEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vote results for one resolution.
/// </summary>
public partial record Vote16
{
    #nullable enable
    
    /// <summary>
    /// Number of the resolution as specified by the issuer or its agent.
    /// </summary>
    public required IsoMax35Text IssuerLabel { get; init; } 
    /// <summary>
    /// Acceptance status of the resolution.
    /// </summary>
    public required ResolutionStatus2Code ResolutionStatus { get; init; } 
    /// <summary>
    /// Number of votes in favour of one resolution.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? For { get; init; } 
    /// <summary>
    /// Number of votes against one resolution.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? Against { get; init; } 
    /// <summary>
    /// Number of abstention votes.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? Abstain { get; init; } 
    /// <summary>
    /// Total votes withheld, for example, in the case where a shareholder wishes not to endorse the election of a board member.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? Withhold { get; init; } 
    /// <summary>
    /// Number of votes in line with the votes of the management.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? WithManagement { get; init; } 
    /// <summary>
    /// Number of votes against the voting recommendation of the management.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? AgainstManagement { get; init; } 
    /// <summary>
    /// Number of votes for which the decision is left to the party that will exercise the voting right.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? Discretionary { get; init; } 
    /// <summary>
    /// Number of votes in favour for one year for "say on pay" type of resolution.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? OneYear { get; init; } 
    /// <summary>
    /// Number of votes in favour of two years for "say on pay" type of resolution.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? TwoYears { get; init; } 
    /// <summary>
    /// Number of votes in favour of three years for "say on pay" type of resolution.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? ThreeYears { get; init; } 
    /// <summary>
    /// Number of votes for which no action has been taken.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? NoAction { get; init; } 
    /// <summary>
    /// Vote is cast as empty but the vote is counted.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? Blank { get; init; } 
    /// <summary>
    /// Other type of vote expressed as a proprietary code.
    /// </summary>
    public ProprietaryVote2[] Proprietary { get; init; } = [];
    
    #nullable disable
}
