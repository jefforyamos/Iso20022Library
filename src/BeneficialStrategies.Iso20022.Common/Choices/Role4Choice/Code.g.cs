﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _vrgEwB6YEeOolf0-cMYhrw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Role4Choice;

/// <summary>
/// Role of the party in the activity expressed as a code.
/// </summary>
public partial record Code : Role4Choice_
{
    public required InvestmentFundRole2Code Value { get; init; }
}
