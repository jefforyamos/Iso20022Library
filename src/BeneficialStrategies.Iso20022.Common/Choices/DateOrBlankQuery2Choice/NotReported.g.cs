﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotReported.  ISO2002 ID# _cmD8M9GgEeaQk737TH1Fzw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateOrBlankQuery2Choice;

/// <summary>
/// Field may be queried for not reported value.
/// </summary>
public partial record NotReported : DateOrBlankQuery2Choice_
{
    public required NotReported1Code Value { get; init; }
}
