﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _6GVvTZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AutomaticBorrowing11Choice;

/// <summary>
/// Condition for automatic borrowing expressed as an ISO 20022 code.
/// </summary>
public partial record Code : AutomaticBorrowing11Choice_
{
    public required AutoBorrowing2Code Value { get; init; }
}
