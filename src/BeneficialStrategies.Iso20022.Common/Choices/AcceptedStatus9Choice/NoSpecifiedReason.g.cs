﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoSpecifiedReason.  ISO2002 ID# _cgn39ZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AcceptedStatus9Choice;

/// <summary>
/// Reason not specified.
/// </summary>
public partial record NoSpecifiedReason : AcceptedStatus9Choice_
{
    public required NoReasonCode Value { get; init; }
}
