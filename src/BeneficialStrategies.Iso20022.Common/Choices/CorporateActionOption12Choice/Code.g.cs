﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _bheH4QrAEeGFLZ_5tFfOnw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionOption12Choice;

/// <summary>
/// Specifies the corporate action options available to the account owner.
/// </summary>
public partial record Code : ICorporateActionOption12Choice
{
    public required CorporateActionOption9Code Value { get; init; }
}
