﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _C7IDQRb-EeiyVv5j1vf1VQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AddressType3Choice;

/// <summary>
/// Type of address expressed as a code.
/// </summary>
public partial record Code : AddressType3Choice_
{
    public required AddressType2Code Value { get; init; }
}
