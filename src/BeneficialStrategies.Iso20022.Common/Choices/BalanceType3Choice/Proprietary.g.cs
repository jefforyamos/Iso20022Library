﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _RcRuxdp-Ed-ak6NoX_4Aeg_-1428944435.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceType3Choice;

/// <summary>
/// Specifies a proprietary code for the balance type.
/// </summary>
public partial record Proprietary : BalanceType3Choice_
{
    public required IsoMax35Text Value { get; init; }
}
