﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FaceAmount.  ISO2002 ID# _Wr_799p-Ed-ak6NoX_4Aeg_-1724212604.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity15Choice;

/// <summary>
/// Quantity expressed as an amount representing the face amount, that is, the principal of a debt instrument.
/// </summary>
public partial record FaceAmount : FinancialInstrumentQuantity15Choice_
{
    public required IsoRestrictedFINImpliedCurrencyAndAmount Value { get; init; }
}
