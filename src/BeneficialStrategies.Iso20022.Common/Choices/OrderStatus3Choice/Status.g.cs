﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Status.  ISO2002 ID# _vIDnYUH7EeaV3ab_pHzFIQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus3Choice;

/// <summary>
/// Status of all the orders in the order message. There is no reason attached.
/// </summary>
public partial record Status : OrderStatus3Choice_
{
    public required OrderStatus4Code Value { get; init; }
}
