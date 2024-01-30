﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AnyInformation.  ISO2002 ID# _7MMKYdjKEeq5MfBBxQig1Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnableToApplyJustification4Choice;

/// <summary>
/// Indicates whether or not all available information on the underlying payment instruction is requested.
/// </summary>
public partial record AnyInformation : IUnableToApplyJustification4Choice
{
    public required IsoYesNoIndicator Value { get; init; }
}
