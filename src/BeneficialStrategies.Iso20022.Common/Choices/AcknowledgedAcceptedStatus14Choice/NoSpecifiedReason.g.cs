﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoSpecifiedReason.  ISO2002 ID# _0jYTAglIEeGATtfOBToyew_935925983.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AcknowledgedAcceptedStatus14Choice;

/// <summary>
/// Indicates that there is no reason available or to report.
/// </summary>
public partial record NoSpecifiedReason : AcknowledgedAcceptedStatus14Choice_
{
    public required NoReasonCode Value { get; init; }
}
