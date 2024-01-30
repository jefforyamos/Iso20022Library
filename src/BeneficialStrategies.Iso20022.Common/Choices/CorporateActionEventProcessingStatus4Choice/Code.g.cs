﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _8Qbor5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventProcessingStatus4Choice;

/// <summary>
/// Status of a corporate action or the status of a payment expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ICorporateActionEventProcessingStatus4Choice
{
    public required CorporateActionEventProcessingStatus1Code Value { get; init; }
}
