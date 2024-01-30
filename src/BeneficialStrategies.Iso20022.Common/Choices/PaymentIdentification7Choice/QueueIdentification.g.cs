﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for QueueIdentification.  ISO2002 ID# _5uqG8wKxEe2rHs6fbn9-0A.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentIdentification7Choice;

/// <summary>
/// Identification of the payment instruction by its position in a queue managed by the clearing agent.
/// </summary>
public partial record QueueIdentification : IPaymentIdentification7Choice
{
    #nullable enable
    /// <summary>
    /// Identification of the payment queue where the payment instruction resides.
    /// </summary>
    public required IsoMax16Text QueueIdentificationValue { get; init; } 
    /// <summary>
    /// Position of the payment instruction within the identified queue.
    /// </summary>
    public required IsoMax16Text PositionInQueue { get; init; } 
    #nullable disable
}
