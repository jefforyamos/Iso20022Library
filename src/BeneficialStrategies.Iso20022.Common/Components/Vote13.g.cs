﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Vote13.  ISO2002 ID# _d3vDAbqPEemCAOifqHrKJw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vote expressed for one resolution.
/// </summary>
public partial record Vote13
{
    #nullable enable
    
    /// <summary>
    /// Number of the resolution as specified by the issuer or its agent.
    /// </summary>
    public required IsoMax35Text IssuerLabel { get; init; } 
    /// <summary>
    /// Number of votes in favour of one resolution.
    /// </summary>
    public IFinancialInstrumentQuantity18Choice? For { get; init; } 
    /// <summary>
    /// Number of votes against one resolution.
    /// </summary>
    public IFinancialInstrumentQuantity18Choice? Against { get; init; } 
    /// <summary>
    /// Number of votes expressed as abstain for one resolution.
    /// </summary>
    public IFinancialInstrumentQuantity18Choice? Abstain { get; init; } 
    /// <summary>
    /// Number of votes withheld for one resolution.
    /// </summary>
    public IFinancialInstrumentQuantity18Choice? Withhold { get; init; } 
    /// <summary>
    /// Number of votes in line with the votes of the management.
    /// </summary>
    public IFinancialInstrumentQuantity18Choice? WithManagement { get; init; } 
    /// <summary>
    /// Number of votes against the voting recommendation of the management.
    /// </summary>
    public IFinancialInstrumentQuantity18Choice? AgainstManagement { get; init; } 
    /// <summary>
    /// Number of votes for which decision is left to the party that will exercise the voting right.
    /// </summary>
    public IFinancialInstrumentQuantity18Choice? Discretionary { get; init; } 
    /// <summary>
    /// Number of votes in favour for one year for "say on pay" type of resolution.
    /// </summary>
    public IFinancialInstrumentQuantity18Choice? OneYear { get; init; } 
    /// <summary>
    /// Number of votes in favour of two years for "say on pay" type of resolution.
    /// </summary>
    public IFinancialInstrumentQuantity18Choice? TwoYears { get; init; } 
    /// <summary>
    /// Number of votes in favour of three years for "say on pay" type of resolution.
    /// </summary>
    public IFinancialInstrumentQuantity18Choice? ThreeYears { get; init; } 
    /// <summary>
    /// Number of votes for which no action has been taken.
    /// </summary>
    public IFinancialInstrumentQuantity18Choice? NoAction { get; init; } 
    /// <summary>
    /// Vote is cast as empty but the vote is counted.
    /// </summary>
    public IFinancialInstrumentQuantity18Choice? Blank { get; init; } 
    /// <summary>
    /// Other type of vote expressed as a proprietary code.
    /// </summary>
    public IReadOnlyCollection<ProprietaryVote2> Proprietary { get; init; } = [];
    /// <summary>
    /// Indicates the resolution was withdrawn at the meeting.
    /// </summary>
    public IsoYesNoIndicator? Withdrawn { get; init; } 
    
    #nullable disable
}
