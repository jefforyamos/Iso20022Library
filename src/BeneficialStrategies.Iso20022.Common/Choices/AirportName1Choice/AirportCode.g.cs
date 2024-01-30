﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AirportCode.  ISO2002 ID# _SsSlJNp-Ed-ak6NoX_4Aeg_-939167147.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AirportName1Choice;

/// <summary>
/// Identifies an airport by means of its IATA identification code. Example: LHR.
/// </summary>
public partial record AirportCode : IAirportName1Choice
{
    public required IsoMax6Text Value { get; init; }
}
