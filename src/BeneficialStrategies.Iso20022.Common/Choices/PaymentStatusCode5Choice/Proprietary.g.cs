﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _72FYF6MgEeCJ6YNENx4h-w_110402669.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusCode5Choice;

/// <summary>
/// Qualifies further the proprietary status.
/// </summary>
public partial record Proprietary : IPaymentStatusCode5Choice
{
    public required IsoMax4AlphaNumericText Value { get; init; }
}
