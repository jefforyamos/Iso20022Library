﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Party.  ISO2002 ID# _TCfeotp-Ed-ak6NoX_4Aeg_-508773714.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PlaceOfTradeIdentification1Choice;

/// <summary>
/// Party's location at which the transaction is executed.
/// </summary>
public partial record Party : IPlaceOfTradeIdentification1Choice
{
    public required IsoAnyBICIdentifier Value { get; init; }
}
