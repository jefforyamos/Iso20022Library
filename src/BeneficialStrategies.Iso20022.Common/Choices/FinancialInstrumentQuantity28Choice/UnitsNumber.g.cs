﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for UnitsNumber.  ISO2002 ID# _ZipfAThUEeaRwdGFv45qTQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity28Choice;

/// <summary>
/// Number of investment fund units redeemed.
/// </summary>
public partial record UnitsNumber : IFinancialInstrumentQuantity28Choice
{
    public required IsoDecimalNumber Value { get; init; }
}
