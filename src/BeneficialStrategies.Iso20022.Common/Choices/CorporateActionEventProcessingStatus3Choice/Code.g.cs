﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _NVdnQTqqEeWyoP0PbocV1Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventProcessingStatus3Choice;

/// <summary>
/// Status of a corporate action or the status of a payment expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ICorporateActionEventProcessingStatus3Choice
{
    public required CorporateActionEventProcessingStatus1Code Value { get; init; }
}
