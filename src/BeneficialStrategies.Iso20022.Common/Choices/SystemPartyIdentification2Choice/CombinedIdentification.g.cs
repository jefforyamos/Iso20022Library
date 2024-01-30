﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CombinedIdentification.  ISO2002 ID# _w8OZg2c-EemvNLufWGIVOQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SystemPartyIdentification2Choice;

/// <summary>
/// Identifies the party with the combined identification of both the responsible entity and the party itself.
/// </summary>
public partial record CombinedIdentification : ISystemPartyIdentification2Choice
{
    #nullable enable
    /// <summary>
    /// Unique identification to unambiguously identify the party within the system.
    /// </summary>
    public required PartyIdentification136 Identification { get; init; } 
    /// <summary>
    /// Unique identification of the party responsible for the maintenance of the party reference data.
    /// </summary>
    public PartyIdentification136? ResponsiblePartyIdentification { get; init; } 
    #nullable disable
}
