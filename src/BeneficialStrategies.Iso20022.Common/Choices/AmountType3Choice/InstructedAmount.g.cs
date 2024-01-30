﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for InstructedAmount.  ISO2002 ID# _P57LMdp-Ed-ak6NoX_4Aeg_326234880.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AmountType3Choice;

/// <summary>
/// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
/// </summary>
public partial record InstructedAmount : IAmountType3Choice
{
    public required IsoActiveOrHistoricCurrencyAndAmount Value { get; init; }
}
