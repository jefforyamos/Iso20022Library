﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Type.  ISO2002 ID# _1AYR4Qf_EeSaceXTzyiZRg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateAction1Choice;

/// <summary>
/// Corporate action event type expressed as a code.
/// </summary>
public partial record Type : ICorporateAction1Choice
{
    public required CorporateActionEventType1Code Value { get; init; }
}
