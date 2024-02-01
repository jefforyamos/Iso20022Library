﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NonConfirmed.  ISO2002 ID# _SDySEA28EeWmAKKPnqYEVQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeConfirmation1Choice;

/// <summary>
/// Indicates that contract was not confirmed.
/// </summary>
public partial record NonConfirmed : TradeConfirmation1Choice_
{
    #nullable enable
    /// <summary>
    /// Specifies that the contract remains unconfirmed.
    /// </summary>
    public required TradeConfirmationType2Code Type { get; init; } 
    #nullable disable
}
