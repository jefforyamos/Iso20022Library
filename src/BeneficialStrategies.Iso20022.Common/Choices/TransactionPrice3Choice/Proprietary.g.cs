﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _tqJEMFkyEeGeoaLUQk__nA_1612231068.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TransactionPrice3Choice;

/// <summary>
/// Proprietary price specification related to the underlying transaction.
/// </summary>
public partial record Proprietary : ITransactionPrice3Choice
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
