﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _E0y-eSM9EeKqJ_haxcymCw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType16Choice;

/// <summary>
/// Event types expressed as a code.
/// </summary>
public partial record Code : ICorporateActionEventType16Choice
{
    public required CorporateActionEventType14Code Value { get; init; }
}
