﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Cleared.  ISO2002 ID# _gKmIUcg4Eeu4ecZgAYuz5w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Cleared16Choice;

/// <summary>
/// Indicates that the contract has been cleared.
/// </summary>
public partial record Cleared : ICleared16Choice
{
    #nullable enable
    /// <summary>
    /// In the case of a contract that has been cleared, the unique code for the clearing counterparty that has cleared the contract.
    /// </summary>
    public IOrganisationIdentification15Choice? CCP { get; init; } 
    /// <summary>
    /// Time and date when clearing took place.
    /// </summary>
    public IsoISODateTime? ClearingDateTime { get; init; } 
    /// <summary>
    /// Unique number to indicate a group of reports which relate to the same execution.
    /// </summary>
    public IsoMax52Text? ReportTrackingNumber { get; init; } 
    /// <summary>
    /// Unique code determined by the reporting counterparty identifying the portfolio.
    /// </summary>
    public IsoMax52Text? PortfolioCode { get; init; } 
    #nullable disable
}
