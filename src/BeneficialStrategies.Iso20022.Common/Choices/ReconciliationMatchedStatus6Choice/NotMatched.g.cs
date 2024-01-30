﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotMatched.  ISO2002 ID# _C44f8__oEemm3skPVSMJQg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReconciliationMatchedStatus6Choice;

/// <summary>
/// Indication that the reports subject of reconciliation do not match.
/// </summary>
public partial record NotMatched : IReconciliationMatchedStatus6Choice
{
    #nullable enable
    /// <summary>
    /// First side of the contract that needs to be matched.
    /// </summary>
    public required IOrganisationIdentification9Choice Counterparty1 { get; init; } 
    /// <summary>
    /// Second side of the contract that needs to be matched.
    /// </summary>
    public required IOrganisationIdentification9Choice Counterparty2 { get; init; } 
    /// <summary>
    /// Criteria used to match the sides of the contract.
    /// </summary>
    public required MatchingCriteria7 MatchingCriteria { get; init; } 
    #nullable disable
}
