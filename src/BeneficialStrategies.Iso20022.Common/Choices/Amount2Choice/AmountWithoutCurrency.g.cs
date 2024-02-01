﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmountWithoutCurrency.  ISO2002 ID# _75DzlaMgEeCJ6YNENx4h-w_-106626338.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Amount2Choice;

/// <summary>
/// Number of monetary units specified in a currency where the unit of currency is implied by the context.
/// </summary>
public partial record AmountWithoutCurrency : Amount2Choice_
{
    public required IsoImpliedCurrencyAndAmount Value { get; init; }
}
