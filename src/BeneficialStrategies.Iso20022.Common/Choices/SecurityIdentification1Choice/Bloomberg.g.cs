﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Bloomberg.  ISO2002 ID# _VcIPg9p-Ed-ak6NoX_4Aeg_-371877998.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification1Choice;

/// <summary>
/// Identifier of a security assigned by the Bloomberg organisation.
/// </summary>
public partial record Bloomberg : ISecurityIdentification1Choice
{
    public required IsoBloombergIdentifier Value { get; init; }
}
