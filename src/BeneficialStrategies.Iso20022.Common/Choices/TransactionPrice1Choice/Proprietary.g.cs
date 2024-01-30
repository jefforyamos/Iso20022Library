﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _RUrR9tp-Ed-ak6NoX_4Aeg_969960515.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionPrice1Choice;

/// <summary>
/// Proprietary price specification of the underlying transaction.
/// </summary>
public partial record Proprietary : ITransactionPrice1Choice
{
    #nullable enable
    /// <summary>
    /// Identifies the type of price reported.
    /// </summary>
    public required IsoMax35Text Type { get; init; } 
    /// <summary>
    /// Proprietary price specification related to the underlying transaction.
    /// </summary>
    public required IsoCurrencyAndAmount Price { get; init; } 
    #nullable disable
}
