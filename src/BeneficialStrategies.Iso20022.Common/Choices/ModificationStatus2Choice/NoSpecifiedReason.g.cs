﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoSpecifiedReason.  ISO2002 ID# _0kkl0glIEeGATtfOBToyew_629331254.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ModificationStatus2Choice;

/// <summary>
/// Indicates that there is no reason available or to report.
/// </summary>
public partial record NoSpecifiedReason : ModificationStatus2Choice_
{
    public required NoReasonCode Value { get; init; }
}
