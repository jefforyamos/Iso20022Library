﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Country.  ISO2002 ID# _TCfeoNp-Ed-ak6NoX_4Aeg_-1351023386.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PlaceOfTradeIdentification1Choice;

/// <summary>
/// Country in which the transaction is executed.
/// </summary>
public partial record Country : IPlaceOfTradeIdentification1Choice
{
    public required CountryCode Value { get; init; }
}
