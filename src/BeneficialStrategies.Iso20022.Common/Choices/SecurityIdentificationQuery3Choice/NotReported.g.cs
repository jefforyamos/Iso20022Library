﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotReported.  ISO2002 ID# _P-19C9GgEeaQk737TH1Fzw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentificationQuery3Choice;

/// <summary>
/// Field can be queried for not reported value.
/// </summary>
public partial record NotReported : ISecurityIdentificationQuery3Choice
{
    public required NotReported1Code Value { get; init; }
}
