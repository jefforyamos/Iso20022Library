﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmortisedValue.  ISO2002 ID# _mG9jQxu1EeyhRdHRjakS2w.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity35Choice;

/// <summary>
/// Quantity expressed as an amount representing the current amortised face amount of a bond, for example, a periodic reduction/increase of a bond's principal amount.
/// </summary>
public partial record AmortisedValue : IFinancialInstrumentQuantity35Choice
{
    public required IsoImpliedCurrencyAndAmount Value { get; init; }
}
