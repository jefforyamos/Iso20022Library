﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PresentationUnderConfirmation.  ISO2002 ID# _97kuFHltEeG7BsjMvd1mEw_1998762195.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PlaceOrUnderConfirmationChoice1;

/// <summary>
/// Place of presentation when there is a confirmation.
/// </summary>
public partial record PresentationUnderConfirmation : IPlaceOrUnderConfirmationChoice1
{
    public required PresentationParty1Code Value { get; init; }
}
