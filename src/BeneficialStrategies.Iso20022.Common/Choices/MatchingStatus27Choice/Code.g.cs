﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Y5m_4TqqEeWyoP0PbocV1Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus27Choice;

/// <summary>
/// Provides the matching status of the instruction.
/// </summary>
public partial record Code : IMatchingStatus27Choice
{
    public required MatchingStatus1Code Value { get; init; }
}
