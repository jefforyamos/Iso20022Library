﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _-XasJbTUEee_k7HqaUKERA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionPrice4Choice;

/// <summary>
/// Proprietary price specification related to the underlying transaction.
/// </summary>
public partial record Proprietary : TransactionPrice4Choice_
{
    #nullable enable
    /// <summary>
    /// Specifies the type of price.
    /// </summary>
    public required IsoMax35Text Type { get; init; } 
    /// <summary>
    /// Proprietary price specification related to the underlying transaction.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Price { get; init; } 
    #nullable disable
}
