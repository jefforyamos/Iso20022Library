﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _uD80wMeUEeysUoBKYz1Ytw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ReferenceType1Choice;

/// <summary>
/// Code identifying the type of reference.
/// </summary>
public partial record Code : IReferenceType1Choice
{
    public required IsoMax4Text Value { get; init; }
}
