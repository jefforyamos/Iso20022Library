﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _6GWWd5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingPosition18Choice;

/// <summary>
/// Processing position expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IProcessingPosition18Choice
{
    public required ProcessingPosition4Code Value { get; init; }
}
