﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _xLnF46OAEeeDTpy0mhI4TQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType73Choice;

/// <summary>
/// Corporate action event type expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ICorporateActionEventType73Choice
{
    public required CorporateActionEventType28Code Value { get; init; }
}
