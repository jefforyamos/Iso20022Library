﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TaxExemptQuantitySD2.  ISO2002 ID# _2m0Rsb5YEeexmbB7KsjCwA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax exempt election details.
/// </summary>
public partial record TaxExemptQuantitySD2
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Tax control identification.
    /// </summary>
    public required IsoMax6Text ControlIdentification { get; init; } 
    /// <summary>
    /// Elected quantity.
    /// </summary>
    public required IFinancialInstrumentQuantity15Choice Quantity { get; init; } 
    
    #nullable disable
}
