﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _JPlZKfmREeC_eLZALo-S0A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType8Choice;

/// <summary>
/// Event types expressed as a code.
/// </summary>
public partial record Code : CorporateActionEventType8Choice_
{
    public required CorporateActionEventType9Code Value { get; init; }
}
