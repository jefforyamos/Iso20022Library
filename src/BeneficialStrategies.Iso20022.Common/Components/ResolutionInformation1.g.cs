﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ResolutionInformation1.  ISO2002 ID# _QJIE2tp-Ed-ak6NoX_4Aeg_-774810951.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the return or reversal expected by the party that initiated the initial payment instruction after a cancellation or modification request.
/// </summary>
public partial record ResolutionInformation1
{
    #nullable enable
    
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; init; } 
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    public IsoISODate? InterbankSettlementDate { get; init; } 
    /// <summary>
    /// Specifies the clearing channel to be used to process the payment instruction.
    /// </summary>
    public ClearingChannel2Code? ClearingChannel { get; init; } 
    
    #nullable disable
}
