﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _c5V6bZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionChangeTypeFormat8Choice;

/// <summary>
/// Standard code to specify the type of changes.
/// </summary>
public partial record Code : ICorporateActionChangeTypeFormat8Choice
{
    public required CorporateActionChangeType1Code Value { get; init; }
}
