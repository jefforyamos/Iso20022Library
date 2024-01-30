﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InstructedCorporateActionOption9.  ISO2002 ID# _qrHuZc3iEee5nJBZsW8MFQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides corporate action option details about total instructed balance.
/// </summary>
public partial record InstructedCorporateActionOption9
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    public IsoExact3NumericText? OptionNumber { get; init; } 
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    public required ICorporateActionOption23Choice OptionType { get; init; } 
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    public required IBalanceFormat7Choice InstructedBalance { get; init; } 
    /// <summary>
    /// Indicates the default action related to a corporate action event.
    /// </summary>
    public IDefaultProcessingOrStandingInstruction1Choice? DefaultAction { get; init; } 
    /// <summary>
    /// Provides information about the deadlines related to a corporate action option.
    /// </summary>
    public required CorporateActionEventDeadlines2 EventDeadlines { get; init; } 
    
    #nullable disable
}
