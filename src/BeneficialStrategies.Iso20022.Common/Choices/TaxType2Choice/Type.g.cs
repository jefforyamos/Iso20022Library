﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Type.  ISO2002 ID# _ilKssBrfEeOVR9VN6fAMUg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxType2Choice;

/// <summary>
/// Type of tax applied.
/// </summary>
public partial record Type : TaxType2Choice_
{
    public required TaxType9Code Value { get; init; }
}
