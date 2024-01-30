﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Product5.  ISO2002 ID# _lPknoZVaEeWuuIjj4l7kpg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Product to purchase.
/// </summary>
public partial record Product5
{
    #nullable enable
    
    /// <summary>
    /// Product code of the item.
    /// </summary>
    public required IsoMax70Text ProductCode { get; init; } 
    /// <summary>
    /// Additional product code related to the product.
    /// </summary>
    public IsoMax70Text? AdditionalProductCode { get; init; } 
    /// <summary>
    /// Amount limit for the product.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? AmountLimit { get; init; } 
    /// <summary>
    /// Quantity limit for the product.
    /// </summary>
    public IsoDecimalNumber? QuantityLimit { get; init; } 
    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    public UnitOfMeasure6Code? UnitOfMeasure { get; init; } 
    
    #nullable disable
}
