﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _UaHY4Np-Ed-ak6NoX_4Aeg_-1588774149.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnmatchedReason1Choice;

/// <summary>
/// Specifies the reason why the instruction has an unmatched status.
/// </summary>
public partial record Code : IUnmatchedReason1Choice
{
    public required UnmatchedReason2Code Value { get; init; }
}
