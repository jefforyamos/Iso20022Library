﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Qwm7lNp-Ed-ak6NoX_4Aeg_-1115232892.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Role2Choice;

/// <summary>
/// Role of the party in the activity expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IRole2Choice
{
    public required InvestmentFundRole2Code Value { get; init; }
}
