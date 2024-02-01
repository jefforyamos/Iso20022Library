﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ContractForDifference.  ISO2002 ID# _JXb7AWkwEeaLAKoEUNsD9g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Derivative2Choice;

/// <summary>
/// Details specific for Contract for difference (CFDs).
/// </summary>
public partial record ContractForDifference : Derivative2Choice_
{
    #nullable enable
    /// <summary>
    /// Underlying type of the contract for difference.
    /// </summary>
    public required UnderlyingContractForDifferenceType3Code UnderlyingType { get; init; } 
    /// <summary>
    /// Currency 1 of the underlying currency pair.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? NotionalCurrency1 { get; init; } 
    /// <summary>
    /// Currency 2 of the underlying currency pair.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? NotionalCurrency2 { get; init; } 
    #nullable disable
}
