﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PartyReport.  ISO2002 ID# _kniH5O5NEeCisYr99QEiWA_-1882219329.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyOrOperationalError1Choice;

/// <summary>
/// Report information about party reference data.
/// </summary>
public partial record PartyReport : IPartyOrOperationalError1Choice
{
    #nullable enable
    /// <summary>
    /// Unique identification to unambiguously identify the party within the system.
    /// </summary>
    public required SystemPartyIdentification3 PartyIdentification { get; init; } 
    /// <summary>
    /// Identifies the returned party reference data or error information.
    /// </summary>
    public required IPartyOrBusinessError1Choice PartyOrError { get; init; } 
    #nullable disable
}
