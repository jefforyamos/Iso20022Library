﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for QueueIdentification.  ISO2002 ID# _Rbhg0dp-Ed-ak6NoX_4Aeg_-1132471724.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentIdentification3Choice;

/// <summary>
/// Identification of the payment instruction by its position in a queue managed by the clearing agent.
/// </summary>
public partial record QueueIdentification : PaymentIdentification3Choice_
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
