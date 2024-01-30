﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _c5WhFZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TaxableIncomePerShareCalculatedFormat4Choice;

/// <summary>
/// Standard code to specify whether the fund calculates the taxable income per dividend/taxable income per share (TID/TIS).
/// </summary>
public partial record Code : ITaxableIncomePerShareCalculatedFormat4Choice
{
    public required CorporateActionTaxableIncomePerShareCalculated1Code Value { get; init; }
}
