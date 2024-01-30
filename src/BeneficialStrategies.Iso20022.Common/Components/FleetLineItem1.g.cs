﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FleetLineItem1.  ISO2002 ID# _BF5jY_jUEeiM7KpzmLtmTQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Supplies additional transaction information for fleet transactions.
/// </summary>
public partial record FleetLineItem1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether or not the line item represents a fuel or non-fuel product or service.
    /// True = Fuel item
    /// False = Non-fuel item
    /// </summary>
    public required IsoTrueFalseIndicator FuelIndicator { get; init; } 
    /// <summary>
    /// Type of service received at the acceptor location. 
    /// </summary>
    public FleetServiceType1Code? ServiceType { get; init; } 
    /// <summary>
    /// Code that identifies the brand of the fuel purchased. 
    /// </summary>
    public IsoMax4Text? FuelBrandCode { get; init; } 
    /// <summary>
    /// Product code of fleet product or service being purchased.
    /// </summary>
    public IsoMax4Text? FleetProductCode { get; init; } 
    /// <summary>
    /// Contains a code that identifies a category of fleet products or services. 
    /// </summary>
    public IsoMax35Text? FleetProductCategory { get; init; } 
    /// <summary>
    /// Contains a code that identifies the product qualifier of the fleet product or service. 
    /// </summary>
    public IsoMax6Text? FleetProductQualifier { get; init; } 
    /// <summary>
    /// Contains a code that identifies the product code assigner.
    /// </summary>
    public IsoMax35Text? FleetProductCodeAssigner { get; init; } 
    /// <summary>
    /// Indicates whether or not tax is included in unit price.
    /// True: includes tax 
    /// False: does not include tax.   
    /// </summary>
    public IsoTrueFalseIndicator? UnitPriceTaxIndicator { get; init; } 
    /// <summary>
    /// Unit price of the fleet line item.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? UnitPrice { get; init; } 
    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    /// <summary>
    /// Other unit of measure.
    /// </summary>
    public IsoMax35Text? OtherUnitOfMeasure { get; init; } 
    /// <summary>
    /// Quantity of product or item.
    /// </summary>
    public IsoMax12NumericText? ProductQuantity { get; init; } 
    /// <summary>
    /// Contains the discount amount applied to the fleet transaction (includes coupons).
    /// </summary>
    public IsoImpliedCurrencyAndAmount? DiscountAmount { get; init; } 
    /// <summary>
    /// Indicates whether or not amount of fleet purchase is taxable. 
    /// </summary>
    public IsoTrueFalseIndicator? NonTaxableIndicator { get; init; } 
    /// <summary>
    /// Taxes related to the products or services. 
    /// </summary>
    public Tax33? Tax { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Total amount excluding tax.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? TotalAmountExcludingTax { get; init; } 
    /// <summary>
    /// Total amount including tax.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? TotalAmountIncludingTax { get; init; } 
    
    #nullable disable
}
