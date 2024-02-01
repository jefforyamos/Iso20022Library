﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DeficitAmount.  ISO2002 ID# _Qk1wd9p-Ed-ak6NoX_4Aeg_-1636463476.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarginResult1Choice;

/// <summary>
/// Deficit amount that the central counterparty will provide to the clearing member.
/// </summary>
public partial record DeficitAmount : MarginResult1Choice_
{
    public required IsoActiveCurrencyAndAmount Value { get; init; }
}
