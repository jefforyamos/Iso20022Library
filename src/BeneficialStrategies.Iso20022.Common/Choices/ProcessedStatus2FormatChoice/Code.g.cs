﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _RnJiB9p-Ed-ak6NoX_4Aeg_-2111312844.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessedStatus2FormatChoice;

/// <summary>
/// Standard code to specify the processing status of a cancellation request.
/// </summary>
public partial record Code : ProcessedStatus2FormatChoice_
{
    public required ProcessedStatus2Code Value { get; init; }
}
