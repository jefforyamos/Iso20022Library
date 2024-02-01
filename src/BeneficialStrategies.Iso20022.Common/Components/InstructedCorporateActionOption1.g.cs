﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InstructedCorporateActionOption1.  ISO2002 ID# _UFP8K9p-Ed-ak6NoX_4Aeg_468448382.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides corporate action option details about total instructed balance.
/// </summary>
public partial record InstructedCorporateActionOption1
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    public IsoExact3NumericText? OptionNumber { get; init; } 
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    public required CorporateActionOption2Choice_ OptionType { get; init; } 
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    public required BalanceFormat1Choice_ InstructedBalance { get; init; } 
    /// <summary>
    /// Indicates the default action related to a corporate action event.
    /// </summary>
    public DefaultProcessingOrStandingInstruction1Choice_? DefaultAction { get; init; } 
    /// <summary>
    /// Any deadline chosen by the account servicer (service level agreement).
    /// </summary>
    public required IsoISODateTime DeadlineDateTime { get; init; } 
    /// <summary>
    /// Specifies the type of deadline for instructing.
    /// </summary>
    public required DeadlineCode1Choice_ DeadlineType { get; init; } 
    
    #nullable disable
}
