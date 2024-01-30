﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmortisedValue.  ISO2002 ID# _ptJrUTi7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity44Choice;

/// <summary>
/// Quantity expressed as an amount representing the current amortised face amount of a bond, for example, a periodic reduction/increase of a bond's principal amount.
/// </summary>
public partial record AmortisedValue : IFinancialInstrumentQuantity44Choice
{
    public required IsoRestrictedFINImpliedCurrencyAndAmount Value { get; init; }
}
