﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _RcH9x9p-Ed-ak6NoX_4Aeg_290565985.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceType1Choice;

/// <summary>
/// Specifies a proprietary code for the balance type.
/// </summary>
public partial record Proprietary : BalanceType1Choice_
{
    public required IsoMax35Text Value { get; init; }
}
