﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LineItemDetails13.  ISO2002 ID# _krToMTcjEeSaC-PiOaz_KQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Goods or services that are part of a commercial trade agreement.
/// </summary>
public partial record LineItemDetails13
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned to a line item.
    /// </summary>
    public required IsoMax70Text LineItemIdentification { get; init; } 
    /// <summary>
    /// Specifies the quantity of goods on a line in a trade transaction.
    /// </summary>
    public required Quantity9 Quantity { get; init; } 
    /// <summary>
    /// Variance allowed in the quantity of goods.
    /// </summary>
    public PercentageTolerance1? QuantityTolerance { get; init; } 
    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    public UnitPrice18? UnitPrice { get; init; } 
    /// <summary>
    /// Variance allowed on a price.
    /// </summary>
    public PercentageTolerance1? PriceTolerance { get; init; } 
    /// <summary>
    /// Name of the product detailed in the corresponding line item.
    /// </summary>
    public IsoMax70Text? ProductName { get; init; } 
    /// <summary>
    /// Identifies the product of the corresponding line item.
    /// </summary>
    public ProductIdentifier2Choice_[] ProductIdentifier { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the characteristics of a product.
    /// </summary>
    public ProductCharacteristics1Choice_[] ProductCharacteristics { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the category of product.
    /// </summary>
    public ProductCategory1Choice_[] ProductCategory { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Country from which the product originates.
    /// </summary>
    public CountryCode[] ProductOrigin { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the shipment schedule for the goods.
    /// </summary>
    public ShipmentSchedule2Choice_? ShipmentSchedule { get; init; } 
    /// <summary>
    /// Information related to the conveyance of goods.
    /// </summary>
    public TransportMeans5? RoutingSummary { get; init; } 
    /// <summary>
    /// Variance on price for the goods.
    /// </summary>
    public Adjustment7[] Adjustment { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Maximum charges related to the conveyance of goods.
    /// </summary>
    public Charge24? FreightCharges { get; init; } 
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters linked to the value of the goods in a trade transaction.
    /// </summary>
    public Tax23[] Tax { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Total amount of the line item after adjustments have been applied.
    /// </summary>
    public required IsoCurrencyAndAmount TotalAmount { get; init; } 
    /// <summary>
    /// Specifies the applicable Incoterms and associated location. Latest version of Incoterms in effect at the date of message creation.
    /// </summary>
    public Incoterms4? Incoterms { get; init; } 
    
    #nullable disable
}
