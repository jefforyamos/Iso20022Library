﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _RnTTBdp-Ed-ak6NoX_4Aeg_-735203961.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessedStatus3FormatChoice;

/// <summary>
/// Standard code to specify the processing status of an advice, a request or a movement.
/// </summary>
public partial record Code : IProcessedStatus3FormatChoice
{
    public required ProcessedStatus3Code Value { get; init; }
}
