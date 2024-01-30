﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Commodity.  ISO2002 ID# _Bv9MQWkwEeaLAKoEUNsD9g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Derivative2Choice;

/// <summary>
/// Details specific for commodity derivatives.
/// </summary>
public partial record Commodity : IDerivative2Choice
{
    #nullable enable
    /// <summary>
    /// Provides specific information related to commodity derivatives.
    /// </summary>
    public ICommodityDerivate2Choice? ClassSpecific { get; init; } 
    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    public required ActiveOrHistoricCurrencyCode NotionalCurrency { get; init; } 
    #nullable disable
}
