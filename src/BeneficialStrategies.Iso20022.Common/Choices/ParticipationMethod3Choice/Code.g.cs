﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _XuYKkRrlEeyhRdHRjakS2w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ParticipationMethod3Choice;

/// <summary>
/// Method of participation in the general meeting vote expressed as a code.
/// </summary>
public partial record Code : IParticipationMethod3Choice
{
    public required VotingParticipationMethod3Code Value { get; init; }
}
