﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Exchange.  ISO2002 ID# _TCfeodp-Ed-ak6NoX_4Aeg_-1323317101.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PlaceOfTradeIdentification1Choice;

/// <summary>
/// Exchange at which the transaction is executed.
/// </summary>
public partial record Exchange : IPlaceOfTradeIdentification1Choice
{
    public required IsoMICIdentifier Value { get; init; }
}
