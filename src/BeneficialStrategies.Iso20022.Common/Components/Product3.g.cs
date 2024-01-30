﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Product3.  ISO2002 ID# _zAYo0Y-LEeWGMsAOtoswqg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Purchased item.
/// </summary>
public partial record Product3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the item inside the purchase transaction.
    /// </summary>
    public IsoMax35Text? ItemIdentification { get; init; } 
    /// <summary>
    /// Product code of the item.
    /// </summary>
    public required IsoMax70Text ProductCode { get; init; } 
    /// <summary>
    /// Additional product code related to the product.
    /// </summary>
    public IsoMax70Text? AdditionalProductCode { get; init; } 
    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    public UnitOfMeasure6Code? UnitOfMeasure { get; init; } 
    /// <summary>
    /// Product quantity.
    /// </summary>
    public IsoDecimalNumber? ProductQuantity { get; init; } 
    /// <summary>
    /// Price per unit of product.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? UnitPrice { get; init; } 
    /// <summary>
    /// Sign of the unit price.
    /// </summary>
    public IsoPlusOrMinusIndicator? UnitPriceSign { get; init; } 
    /// <summary>
    /// Monetary value of purchased product.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount ProductAmount { get; init; } 
    /// <summary>
    /// Sign of the product amount.
    /// </summary>
    public IsoPlusOrMinusIndicator? ProductAmountSign { get; init; } 
    /// <summary>
    /// Value added tax amount of the item included in the product amount.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? ValueAddedTax { get; init; } 
    /// <summary>
    /// Information on tax paid on the product.
    /// </summary>
    public IsoMax35Text? TaxType { get; init; } 
    /// <summary>
    /// Description of the product or item.
    /// </summary>
    public IsoMax140Text? ProductDescription { get; init; } 
    /// <summary>
    /// Location of the delivery of the item, for instance pump number or parking bay.
    /// </summary>
    public IsoMax10Text? DeliveryLocation { get; init; } 
    /// <summary>
    /// Identify the method of delivery or distribution of the item.
    /// </summary>
    public AttendanceContext2Code? DeliveryService { get; init; } 
    
    #nullable disable
}
