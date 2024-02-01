﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DirectionOfTheFirstLeg.  ISO2002 ID# _oKFn0Xg-Eeu3kecHd7QKUQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Direction2Choice;

/// <summary>
/// Identifies whether the reporting counterparty is the payer (Taker) or the receiver (Maker) of the first leg as determined at the time of transaction.
/// </summary>
public partial record DirectionOfTheFirstLeg : Direction2Choice_
{
    public required OptionParty3Code Value { get; init; }
}
