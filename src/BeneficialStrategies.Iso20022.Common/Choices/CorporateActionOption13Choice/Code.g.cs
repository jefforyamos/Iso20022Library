﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _wyvtJwrAEeGFLZ_5tFfOnw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionOption13Choice;

/// <summary>
/// Specifies the corporate action options available to the account owner.
/// </summary>
public partial record Code : CorporateActionOption13Choice_
{
    public required CorporateActionOption10Code Value { get; init; }
}
