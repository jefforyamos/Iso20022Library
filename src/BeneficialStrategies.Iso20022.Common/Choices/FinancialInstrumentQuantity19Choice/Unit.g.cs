﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Unit.  ISO2002 ID# _dPPy-_mWEeCcAY_zfcalaA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity19Choice;

/// <summary>
/// Quantity expressed as a number, for example, a number of shares.
/// </summary>
public partial record Unit : IFinancialInstrumentQuantity19Choice
{
    public required IsoDecimalNumber Value { get; init; }
}
