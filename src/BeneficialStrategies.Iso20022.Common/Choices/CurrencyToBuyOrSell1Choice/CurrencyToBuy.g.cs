﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CurrencyToBuy.  ISO2002 ID# _QsvIMtp-Ed-ak6NoX_4Aeg_-894055874.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CurrencyToBuyOrSell1Choice;

/// <summary>
/// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds.
/// </summary>
public partial record CurrencyToBuy : CurrencyToBuyOrSell1Choice_
{
    public required ActiveCurrencyCode Value { get; init; }
}
