﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoSpecifiedReason.  ISO2002 ID# _UWF0gtp-Ed-ak6NoX_4Aeg_-443856486.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnmatchedStatus2Choice;

/// <summary>
/// Indicates that there is no reason available or to report.
/// </summary>
public partial record NoSpecifiedReason : UnmatchedStatus2Choice_
{
    public required NoReasonCode Value { get; init; }
}
