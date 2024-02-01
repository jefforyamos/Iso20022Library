﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _UH8Dytp-Ed-ak6NoX_4Aeg_872458980.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AmountAndRateFormat2Choice;

/// <summary>
/// Number of monetary units specified in a currency.
/// </summary>
public partial record Amount : AmountAndRateFormat2Choice_
{
    public required IsoActiveCurrencyAndAmount Value { get; init; }
}
