﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _ctOws5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventProcessingType3Choice;

/// <summary>
/// Standard code to specify the processing type of a corporate action event.
/// </summary>
public partial record Code : CorporateActionEventProcessingType3Choice_
{
    public required CorporateActionEventProcessingType1Code Value { get; init; }
}
