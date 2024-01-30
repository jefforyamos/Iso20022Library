﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PartiallySettled.  ISO2002 ID# _vIDnbUH7EeaV3ab_pHzFIQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus3Choice;

/// <summary>
/// Status of all the orders in the order message is partially settled.
/// </summary>
public partial record PartiallySettled : IOrderStatus3Choice
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
