﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NameAndAddress.  ISO2002 ID# _ckEN75KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification111Choice;

/// <summary>
/// Unique and unambiguous way to identify an organisation.
/// </summary>
public partial record NameAndAddress : PartyIdentification111Choice_
{
    #nullable enable
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public required IsoRestrictedFINXMax140Text Name { get; init; } 
    #nullable disable
}
