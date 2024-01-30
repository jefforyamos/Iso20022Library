﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Status.  ISO2002 ID# _P8YAl0HREeasdbKMiqizqA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus5Choice;

/// <summary>
/// Status of the individual order is accepted or already executed or sent to next party or received. There is no reason attached.
/// </summary>
public partial record Status : IOrderStatus5Choice
{
    public required OrderStatus4Code Value { get; init; }
}
