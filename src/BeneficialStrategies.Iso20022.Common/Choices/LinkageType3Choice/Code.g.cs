﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _LiheYTt4EeW638lNyHKv7A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LinkageType3Choice;

/// <summary>
/// Linkage type expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ILinkageType3Choice
{
    public required LinkageType1Code Value { get; init; }
}
