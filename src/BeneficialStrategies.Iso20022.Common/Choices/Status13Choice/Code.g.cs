﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _b2fBP5K2EeKOmdt7wkELkg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status13Choice;

/// <summary>
/// Status expressed as a code.
/// </summary>
public partial record Code : IStatus13Choice
{
    public required TradeStatus5Code Value { get; init; }
}
