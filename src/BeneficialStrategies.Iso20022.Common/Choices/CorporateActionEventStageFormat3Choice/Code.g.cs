﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Dw-HQ-HPEd-1Ktb5rVaajw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventStageFormat3Choice;

/// <summary>
/// Standard code to specify the stage of the corporate action event.
/// </summary>
public partial record Code : ICorporateActionEventStageFormat3Choice
{
    public required CorporateActionEventStage1Code Value { get; init; }
}
