﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# __rM9XabkEeKvUvwX_r3tzA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DocumentLineType1Choice;

/// <summary>
/// Proprietary identification of the type of the remittance document.
/// </summary>
public partial record Proprietary : DocumentLineType1Choice_
{
    public required IsoMax35Text Value { get; init; }
}
