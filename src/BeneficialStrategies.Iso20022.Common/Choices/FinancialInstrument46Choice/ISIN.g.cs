﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ISIN.  ISO2002 ID# _X1A7Ub38EeWvRsMSLyTf-A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument46Choice;

/// <summary>
/// Identifies the financial instrument using an International Securities Identification Number (ISIN).
/// </summary>
public partial record ISIN : FinancialInstrument46Choice_
{
    public required IsoISINOct2015Identifier Value { get; init; }
}
