﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for QuantityBreakdown27.  ISO2002 ID# _OjrUlznGEeWV5sr121Fc8A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of breakdown of a quantity.
/// </summary>
public partial record QuantityBreakdown27
{
    #nullable enable
    
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    public GenericIdentification37? LotNumber { get; init; } 
    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    public Balance7? LotQuantity { get; init; } 
    /// <summary>
    /// Date/time at which the lot was purchased.
    /// </summary>
    public DateAndDateTimeChoice_? LotDateTime { get; init; } 
    /// <summary>
    /// Price at which the lot was purchased.
    /// </summary>
    public Price2? LotPrice { get; init; } 
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    public TypeOfPrice29Choice_? TypeOfPrice { get; init; } 
    
    #nullable disable
}
