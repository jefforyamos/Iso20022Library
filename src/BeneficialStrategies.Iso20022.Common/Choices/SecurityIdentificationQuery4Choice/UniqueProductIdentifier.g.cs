﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for UniqueProductIdentifier.  ISO2002 ID# _PJPwp5NeEeytjZlcgApf6A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentificationQuery4Choice;

/// <summary>
/// Identification through a unique product identifier.
/// </summary>
public partial record UniqueProductIdentifier : SecurityIdentificationQuery4Choice_
{
    public required IsoMax52Text Value { get; init; }
}
