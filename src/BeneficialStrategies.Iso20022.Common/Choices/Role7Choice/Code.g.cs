﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _5WyhA5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Role7Choice;

/// <summary>
/// Role of the party in the activity expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IRole7Choice
{
    public required InvestmentFundRole2Code Value { get; init; }
}
