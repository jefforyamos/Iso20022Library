﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _XiELgQd3Ee2fOITqoTnSLQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnaffirmedReason3Choice;

/// <summary>
/// Specifies the reason why the instruction/request has an unaffirmed status.
/// </summary>
public partial record Code : IUnaffirmedReason3Choice
{
    public required UnaffirmedReason1Code Value { get; init; }
}
