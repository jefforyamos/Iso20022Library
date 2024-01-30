﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Card.  ISO2002 ID# _5q1FoVHSEey4xOoMoOPSJQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification54Choice;

/// <summary>
/// PAN of the card identifying the account.
/// </summary>
public partial record Card : IAccountIdentification54Choice
{
    public required IsoMin8Max28NumericText Value { get; init; }
}
