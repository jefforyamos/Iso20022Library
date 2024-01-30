﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RedemptionLegIdentification.  ISO2002 ID# _1CxGQkglEea9YuSvQGoi-w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LegIdentification1Choice;

/// <summary>
/// Unique technical identifier for the instance of the leg within a switch.
/// </summary>
public partial record RedemptionLegIdentification : ILegIdentification1Choice
{
    public required IsoMax35Text Value { get; init; }
}
