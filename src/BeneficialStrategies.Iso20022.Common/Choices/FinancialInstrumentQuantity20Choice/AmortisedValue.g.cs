﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmortisedValue.  ISO2002 ID# _pPlzTwFIEeGhYJiRaPcH8g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity20Choice;

/// <summary>
/// Quantity expressed as an amount representing the current amortised face amount of a bond, for example, a periodic reduction/increase of a bond's principal amount.
/// </summary>
public partial record AmortisedValue : FinancialInstrumentQuantity20Choice_
{
    public required IsoImpliedCurrencyAndAmount Value { get; init; }
}
