﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _8JKFEaMgEeCJ6YNENx4h-w_799887441.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReservationType1Choice;

/// <summary>
/// Liquidity transfer request type, in a coded form.
/// </summary>
public partial record Code : IReservationType1Choice
{
    public required ReservationType2Code Value { get; init; }
}
