﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PartyReport.  ISO2002 ID# _enGS0fAzEeWPfa2xBhBfLQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyOrOperationalError2Choice;

/// <summary>
/// Report information about party reference data.
/// </summary>
public partial record PartyReport : IPartyOrOperationalError2Choice
{
    #nullable enable
    /// <summary>
    /// Unique identification to unambiguously identify the party within the system.
    /// </summary>
    public required SystemPartyIdentification3 PartyIdentification { get; init; } 
    /// <summary>
    /// Identifies the returned party reference data or error information.
    /// </summary>
    public required IPartyOrBusinessError2Choice PartyOrError { get; init; } 
    #nullable disable
}
