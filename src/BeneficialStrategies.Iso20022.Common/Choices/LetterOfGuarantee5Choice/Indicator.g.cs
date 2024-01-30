﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Indicator.  ISO2002 ID# _6ScRh5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.LetterOfGuarantee5Choice;

/// <summary>
/// Specifies whether physical settlement may be executed using a letter of guarantee or if the physical certificates should be used.
/// </summary>
public partial record Indicator : ILetterOfGuarantee5Choice
{
    public required IsoYesNoIndicator Value { get; init; }
}
