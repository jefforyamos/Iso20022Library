﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FaceAmount.  ISO2002 ID# _ptGAjTi7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity43Choice;

/// <summary>
/// Quantity expressed as an amount representing the face amount, that is, the principal, of a debt instrument.
/// </summary>
public partial record FaceAmount : IFinancialInstrumentQuantity43Choice
{
    public required IsoRestrictedFINImpliedCurrencyAndAmount Value { get; init; }
}
