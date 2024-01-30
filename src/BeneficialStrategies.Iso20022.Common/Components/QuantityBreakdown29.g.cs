﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for QuantityBreakdown29.  ISO2002 ID# _QEL1MTnXEeWV5sr121Fc8A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of breakdown of a quantity.
/// </summary>
public partial record QuantityBreakdown29
{
    #nullable enable
    
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    public GenericIdentification37? LotNumber { get; init; } 
    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    public IFinancialInstrumentQuantity1Choice? LotQuantity { get; init; } 
    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    public GenericIdentification30? SecuritiesSubBalanceType { get; init; } 
    /// <summary>
    /// Date/time at which the lot was purchased.
    /// </summary>
    public IDateAndDateTimeChoice? LotDateTime { get; init; } 
    /// <summary>
    /// Price at which the lot was purchased.
    /// </summary>
    public Price2? LotPrice { get; init; } 
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    public ITypeOfPrice29Choice? TypeOfPrice { get; init; } 
    
    #nullable disable
}
