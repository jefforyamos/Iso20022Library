﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _b2fBPJK2EeKOmdt7wkELkg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Status13Choice;

/// <summary>
/// Status expressed in a proprietary form.
/// </summary>
public partial record Proprietary : IStatus13Choice
{
    public required IsoMax35Text Value { get; init; }
}
