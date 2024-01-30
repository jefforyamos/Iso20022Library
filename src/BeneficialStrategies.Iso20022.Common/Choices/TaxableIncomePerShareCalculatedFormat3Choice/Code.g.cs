﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _RmsUIUEGEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxableIncomePerShareCalculatedFormat3Choice;

/// <summary>
/// Standard code to specify whether the fund calculates the taxable income per dividend/taxable income per share (TID/TIS).
/// </summary>
public partial record Code : ITaxableIncomePerShareCalculatedFormat3Choice
{
    public required CorporateActionTaxableIncomePerShareCalculated1Code Value { get; init; }
}
