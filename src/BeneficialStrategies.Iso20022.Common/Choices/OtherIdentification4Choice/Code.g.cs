﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _TF0IAUHLEeWeNKJ6kJGSFw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OtherIdentification4Choice;

/// <summary>
/// Type of identification expressed as a code.
/// </summary>
public partial record Code : IOtherIdentification4Choice
{
    public required PersonIdentificationType6Code Value { get; init; }
}
