﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _FF1NQe35Eeqc-LCjwLsUVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionOption40Choice;

/// <summary>
/// Specifies the corporate action options available to the account owner.
/// </summary>
public partial record Code : ICorporateActionOption40Choice
{
    public required CorporateActionOption16Code Value { get; init; }
}
