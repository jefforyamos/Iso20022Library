﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _6GWWM5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.UnilateralSplit4Choice;

/// <summary>
/// Unilateral split expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IUnilateralSplit4Choice
{
    public required SecuritiesTransactionType5Code Value { get; init; }
}
