﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _UXb4Udp-Ed-ak6NoX_4Aeg_-1471943913.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AcknowledgementReason3Choice;

/// <summary>
/// Specifies additional information about the processed instruction.
/// </summary>
public partial record Code : IAcknowledgementReason3Choice
{
    public required RepoCallAcknowledgementReason2Code Value { get; init; }
}
