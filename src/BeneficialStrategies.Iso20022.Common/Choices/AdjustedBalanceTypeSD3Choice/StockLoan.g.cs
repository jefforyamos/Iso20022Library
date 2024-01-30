﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for StockLoan.  ISO2002 ID# _RZHzQaGGEeSpipW1FBSFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AdjustedBalanceTypeSD3Choice;

/// <summary>
/// Stock loan transaction position. Stock loan is loaned / borrowed from / to a third party.
/// </summary>
public partial record StockLoan : IAdjustedBalanceTypeSD3Choice
{
    #nullable enable
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    public required ShortLong1Code ShortLongPosition { get; init; } 
    /// <summary>
    /// Quantity of security.
    /// </summary>
    public required IFinancialInstrumentQuantity15Choice Quantity { get; init; } 
    #nullable disable
}
