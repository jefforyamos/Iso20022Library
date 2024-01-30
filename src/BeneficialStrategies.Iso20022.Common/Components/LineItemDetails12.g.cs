﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LineItemDetails12.  ISO2002 ID# _9oAg0wy6EeS3puOfnJm56A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Calculation of the current situation of a line item as a result of the submission of a commercial dataset.
/// </summary>
public partial record LineItemDetails12
{
    #nullable enable
    
    /// <summary>
    /// Sequential number assigned to a line item.
    /// </summary>
    public required IsoMax70Text LineItemIdentification { get; init; } 
    /// <summary>
    /// Name of the product detailed in the corresponding line item.
    /// </summary>
    public IsoMax70Text? ProductName { get; init; } 
    /// <summary>
    /// Identifies the product of the corresponding line item.
    /// </summary>
    public IProductIdentifier2Choice? ProductIdentifier { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the characteristic of a product.
    /// </summary>
    public IProductCharacteristics1Choice? ProductCharacteristics { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the category of product.
    /// </summary>
    public IProductCategory1Choice? ProductCategory { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Quantity ordered for a line as indicated in the baseline.
    /// </summary>
    public required Quantity9 OrderedQuantity { get; init; } 
    /// <summary>
    /// Quantity accepted by data set submission.
    /// </summary>
    public required Quantity9 AcceptedQuantity { get; init; } 
    /// <summary>
    /// Difference between the ordered quantity and the accepted one.
    /// </summary>
    public required Quantity9 OutstandingQuantity { get; init; } 
    /// <summary>
    /// Quantity of a product for which a mismatched data set has been submitted and has not yet been accepted or rejected.
    /// </summary>
    public required Quantity9 PendingQuantity { get; init; } 
    /// <summary>
    /// Variance allowed on the quantity of goods.
    /// </summary>
    public PercentageTolerance1? QuantityTolerance { get; init; } 
    /// <summary>
    /// Price multiplied by the ordered quantity for a line as indicated in the baseline.
    /// </summary>
    public required IsoCurrencyAndAmount OrderedAmount { get; init; } 
    /// <summary>
    /// Price multiplied by the accepted quantity for a line.
    /// </summary>
    public required IsoCurrencyAndAmount AcceptedAmount { get; init; } 
    /// <summary>
    /// Price multiplied by the outstanding quantity for a line.
    /// </summary>
    public required IsoCurrencyAndAmount OutstandingAmount { get; init; } 
    /// <summary>
    /// Price multiplied by the pending quantity for a line.
    /// </summary>
    public required IsoCurrencyAndAmount PendingAmount { get; init; } 
    /// <summary>
    /// Variance on price for the goods.
    /// </summary>
    public PercentageTolerance1? PriceTolerance { get; init; } 
    
    #nullable disable
}
