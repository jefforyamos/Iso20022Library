﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Card.  ISO2002 ID# _mpl8YdmpEeeN3v2fup_Shw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification39Choice;

/// <summary>
/// PAN of the card identifying the account.
/// </summary>
public partial record Card : AccountIdentification39Choice_
{
    public required IsoMin8Max28NumericText Value { get; init; }
}
