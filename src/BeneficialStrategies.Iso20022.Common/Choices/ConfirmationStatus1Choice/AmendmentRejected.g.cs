﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmendmentRejected.  ISO2002 ID# _1BFlFEhCEea8pJjypp-yMQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ConfirmationStatus1Choice;

/// <summary>
/// Status of the order confirmation amendment is rejected.
/// </summary>
public partial record AmendmentRejected : IConfirmationStatus1Choice
{
    #nullable enable
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    public IConfirmationRejectedReason1Choice? Reason { get; init; } 
    /// <summary>
    /// Additional information about the rejected reason.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #nullable disable
}
