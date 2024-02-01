﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountPricePerFinancialInstrumentQuantity9.  ISO2002 ID# _zuw0oTpyEemk2e6qGBk8IQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a ratio: amount price and price fixing date per financial instrument quantity.
/// </summary>
public partial record AmountPricePerFinancialInstrumentQuantity9
{
    #nullable enable
    
    /// <summary>
    /// Type of amount price.
    /// </summary>
    public required YieldedOrValueType1Choice_ AmountPriceType { get; init; } 
    /// <summary>
    /// Value given to a price.
    /// </summary>
    public required PriceRateOrAmount3Choice_ PriceValue { get; init; } 
    /// <summary>
    /// Quantity of financial instrument.
    /// </summary>
    public required FinancialInstrumentQuantity1Choice_ FinancialInstrumentQuantity { get; init; } 
    /// <summary>
    /// Date at which the actual price for a financial instrument is fixed.
    /// </summary>
    public required IsoISODate PriceFixingDate { get; init; } 
    
    #nullable disable
}
