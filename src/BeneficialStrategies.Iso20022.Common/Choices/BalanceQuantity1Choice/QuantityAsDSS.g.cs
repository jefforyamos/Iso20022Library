﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for QuantityAsDSS.  ISO2002 ID# _RCMa0Np-Ed-ak6NoX_4Aeg_1824828268.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceQuantity1Choice;

/// <summary>
/// Total quantity of financial instruments of the balance.
/// </summary>
public partial record QuantityAsDSS : BalanceQuantity1Choice_
{
    #nullable enable
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public required IsoMax8Text Issuer { get; init; } 
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    public required IsoExact4AlphaNumericText Information { get; init; } 
    /// <summary>
    /// Value of the balance.
    /// </summary>
    public required IsoNumber Balance { get; init; } 
    #nullable disable
}
