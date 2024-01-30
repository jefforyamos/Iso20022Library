﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for QuantityBreakdown48.  ISO2002 ID# _qInsC83yEee5nJBZsW8MFQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of breakdown of a quantity.
/// </summary>
public partial record QuantityBreakdown48
{
    #nullable enable
    
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    public GenericIdentification39? LotNumber { get; init; } 
    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    public IFinancialInstrumentQuantity15Choice? LotQuantity { get; init; } 
    /// <summary>
    /// Date/time at which the lot was purchased.
    /// </summary>
    public IDateAndDateTime2Choice? LotDateTime { get; init; } 
    /// <summary>
    /// Price at which the lot was purchased.
    /// </summary>
    public Price3? LotPrice { get; init; } 
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    public ITypeOfPrice32Choice? TypeOfPrice { get; init; } 
    
    #nullable disable
}
