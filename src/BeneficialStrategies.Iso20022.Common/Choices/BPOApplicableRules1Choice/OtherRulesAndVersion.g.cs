﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherRulesAndVersion.  ISO2002 ID# _GHRpoNNrEeKdOs2hjJ_3WQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.BPOApplicableRules1Choice;

/// <summary>
/// Applicable rules are not URBPO and are specified here with version.
/// </summary>
public partial record OtherRulesAndVersion : IBPOApplicableRules1Choice
{
    public required IsoMax35Text Value { get; init; }
}
