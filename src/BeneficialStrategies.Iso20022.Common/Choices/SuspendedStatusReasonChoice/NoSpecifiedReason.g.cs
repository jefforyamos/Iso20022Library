﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoSpecifiedReason.  ISO2002 ID# _RfQKQdp-Ed-ak6NoX_4Aeg_1235905146.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SuspendedStatusReasonChoice;

/// <summary>
/// Indicates that there is no reason available or to report.
/// </summary>
public partial record NoSpecifiedReason : ISuspendedStatusReasonChoice
{
    public required NoReasonCode Value { get; init; }
}
