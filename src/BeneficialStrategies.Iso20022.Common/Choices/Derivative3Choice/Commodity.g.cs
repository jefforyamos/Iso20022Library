﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Commodity.  ISO2002 ID# _xH-zYSe0Eei12pGEsJIAeQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Derivative3Choice;

/// <summary>
/// Details specific for commodity derivatives.
/// </summary>
public partial record Commodity : IDerivative3Choice
{
    #nullable enable
    /// <summary>
    /// Provides specific information related to commodity derivatives.
    /// </summary>
    public ICommodityDerivative2Choice? ClassSpecific { get; init; } 
    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    public required ActiveOrHistoricCurrencyCode NotionalCurrency { get; init; } 
    #nullable disable
}
