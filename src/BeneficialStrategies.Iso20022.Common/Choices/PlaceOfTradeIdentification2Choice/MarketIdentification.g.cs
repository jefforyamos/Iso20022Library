﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MarketIdentification.  ISO2002 ID# _TCfepdp-Ed-ak6NoX_4Aeg_-1823256759.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PlaceOfTradeIdentification2Choice;

/// <summary>
/// Exchange or Multilateral Trading Facility (MTF) on which the transaction is executed.
/// </summary>
public partial record MarketIdentification : IPlaceOfTradeIdentification2Choice
{
    public required IsoMICIdentifier Value { get; init; }
}
