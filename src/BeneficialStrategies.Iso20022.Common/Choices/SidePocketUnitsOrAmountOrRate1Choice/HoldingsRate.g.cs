﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for HoldingsRate.  ISO2002 ID# _Rhe-5Np-Ed-ak6NoX_4Aeg_659901338.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SidePocketUnitsOrAmountOrRate1Choice;

/// <summary>
/// Percentage of the financial instrument quantity to be invested or redeemed in the side pocket or lot.
/// </summary>
public partial record HoldingsRate : SidePocketUnitsOrAmountOrRate1Choice_
{
    public required IsoPercentageRate Value { get; init; }
}
