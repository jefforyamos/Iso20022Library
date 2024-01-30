﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmortisedValue.  ISO2002 ID# _SoH20Np-Ed-ak6NoX_4Aeg_1583790695.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantityChoice;

/// <summary>
/// Quantity expressed as an amount representing the current amortised face amount of a bond, eg, a periodic reduction of a bond's principal amount.
/// </summary>
public partial record AmortisedValue : IFinancialInstrumentQuantityChoice
{
    public required IsoImpliedCurrencyAndAmount Value { get; init; }
}
