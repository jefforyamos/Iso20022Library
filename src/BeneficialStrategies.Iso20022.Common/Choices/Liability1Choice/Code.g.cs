﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _gHJNoCDMEeWPMvNwVtiMsA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Liability1Choice;

/// <summary>
/// Liability expressed as a code.
/// </summary>
public partial record Code : ILiability1Choice
{
    public required Liability1Code Value { get; init; }
}
