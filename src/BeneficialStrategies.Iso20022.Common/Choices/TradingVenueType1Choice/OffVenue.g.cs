﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OffVenue.  ISO2002 ID# _5_yR8Hy7Eeu1BeE84IrnAQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradingVenueType1Choice;

/// <summary>
/// Whether the Securities Financing Transaction was concluded off-venue.
/// </summary>
public partial record OffVenue : TradingVenueType1Choice_
{
    public required NoReasonCode Value { get; init; }
}
