﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Security.  ISO2002 ID# _GHPngK_7EeaE9YROwd69hA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetHolding1Choice;

/// <summary>
/// Identification and value of the outright investment.
/// </summary>
public partial record Security : IAssetHolding1Choice
{
    #nullable enable
    /// <summary>
    /// ISIN of the outright investment.
    /// </summary>
    public required IsoISINOct2015Identifier Identification { get; init; } 
    /// <summary>
    /// Value of the outright investment according to the CCP’s system of record.
    /// </summary>
    public required IsoActiveCurrencyAnd24Amount MarketValue { get; init; } 
    /// <summary>
    /// Type of a financial instrument: an equity, bond or other.
    /// </summary>
    public required ProductType7Code FinancialInstrumentType { get; init; } 
    #nullable disable
}
