﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _chdlnZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BeneficiaryCertificationType11Choice;

/// <summary>
/// Standard code to specify the type of certification required.
/// </summary>
public partial record Code : IBeneficiaryCertificationType11Choice
{
    public required BeneficiaryCertificationType5Code Value { get; init; }
}
