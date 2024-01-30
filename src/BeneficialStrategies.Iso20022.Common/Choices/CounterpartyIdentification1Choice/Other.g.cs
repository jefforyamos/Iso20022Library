﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Other.  ISO2002 ID# __jASAZfcEeSfnc-VXAEapg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CounterpartyIdentification1Choice;

/// <summary>
/// Other identification of the counterparty through the sector and the location.
/// </summary>
public partial record Other : ICounterpartyIdentification1Choice
{
    #nullable enable
    /// <summary>
    /// Represents the counterparty institutional section (such as non-financial corporation, central bank.).
    /// </summary>
    public required IsoSNA2008SectorIdentifier Sector { get; init; } 
    /// <summary>
    /// Location of the country in which the counterparty is incorporated.
    /// </summary>
    public required CountryCode Location { get; init; } 
    #nullable disable
}
