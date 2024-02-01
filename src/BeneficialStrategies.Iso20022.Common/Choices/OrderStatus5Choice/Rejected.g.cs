﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rejected.  ISO2002 ID# _P8YAmkHREeasdbKMiqizqA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus5Choice;

/// <summary>
/// Status of the individual order is rejected. This status is used for an order that has not been accepted or entered in an order book.
/// </summary>
public partial record Rejected : OrderStatus5Choice_
{
    #nullable enable
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    public RejectedReason20Choice_? Reason { get; init; } 
    /// <summary>
    /// Additional information about the rejected reason.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #nullable disable
}
