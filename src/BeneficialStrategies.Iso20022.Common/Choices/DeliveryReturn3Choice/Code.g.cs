﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _MOLBETtEEeWRTLSN0i0tng.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DeliveryReturn3Choice;

/// <summary>
/// Delivery return expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IDeliveryReturn3Choice
{
    public required DeliveryReturn1Code Value { get; init; }
}
