﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _RcH9xNp-Ed-ak6NoX_4Aeg_1127275052.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceType2Choice;

/// <summary>
/// Specifies a proprietary code for the balance type.
/// </summary>
public partial record Proprietary : IBalanceType2Choice
{
    public required IsoMax35Text Value { get; init; }
}
