﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _woUjoBc_EeK5g-3oYI0_9Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatementFrequencyReason1Choice;

/// <summary>
/// Statement frequency expressed as a code.
/// </summary>
public partial record Code : StatementFrequencyReason1Choice_
{
    public required EventFrequency1Code Value { get; init; }
}
