﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _72YTAaMgEeCJ6YNENx4h-w_-1019332916.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentType3Choice;

/// <summary>
/// Payment type that is not included in a predefined list.
/// </summary>
public partial record Proprietary : PaymentType3Choice_
{
    public required IsoMax4AlphaNumericText Value { get; init; }
}
