﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _s36_sIOsEeWqmeP8QNJBew.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DeliveryInterconnectionPoint1Choice;

/// <summary>
/// Identification of delivery/interconnection point or zone in a proprietary format.
/// </summary>
public partial record Proprietary : IDeliveryInterconnectionPoint1Choice
{
    public required IsoMax52Text Value { get; init; }
}
