﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _c5V6JZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventStageFormat20Choice;

/// <summary>
/// Standard code to specify the stage of the corporate action event.
/// </summary>
public partial record Code : CorporateActionEventStageFormat20Choice_
{
    public required CorporateActionEventStage3Code Value { get; init; }
}
