﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AnyBIC.  ISO2002 ID# _Rpl8a-aPEd-q8fx_Zl_34A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification44Choice;

/// <summary>
/// Unique and unambiguous way to identify an organisation.
/// </summary>
public partial record AnyBIC : PartyIdentification44Choice_
{
    public required IsoAnyBICIdentifier Value { get; init; }
}
