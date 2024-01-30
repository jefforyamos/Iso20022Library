﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _5m6oV5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AutomaticBorrowing8Choice;

/// <summary>
/// Condition for automatic borrowing expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IAutomaticBorrowing8Choice
{
    public required AutoBorrowing1Code Value { get; init; }
}
