﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Q0CqE9p-Ed-ak6NoX_4Aeg_-289326791.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionOption5Choice;

/// <summary>
/// Specifies the corporate action options available to the account owner.
/// </summary>
public partial record Code : ICorporateActionOption5Choice
{
    public required CorporateActionOption6Code Value { get; init; }
}
