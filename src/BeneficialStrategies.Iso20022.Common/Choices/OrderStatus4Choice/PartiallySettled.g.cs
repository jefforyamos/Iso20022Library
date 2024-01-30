﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PartiallySettled.  ISO2002 ID# _9wxHzUH8EeaV3ab_pHzFIQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus4Choice;

/// <summary>
/// Status of the switch order is partially settled.
/// </summary>
public partial record PartiallySettled : IOrderStatus4Choice
{
    #nullable enable
    /// <summary>
    /// Reason for the partially settled status.
    /// </summary>
    public required IPartiallySettled21Choice Reason { get; init; } 
    /// <summary>
    /// Additional information about the partially settled reason.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #nullable disable
}
