﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for QuantityBreakdown60.  ISO2002 ID# _VR4TUyp_EeyR9JrVGfaMKw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of breakdown of a quantity.
/// </summary>
public partial record QuantityBreakdown60
{
    #nullable enable
    
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    public required GenericIdentification37 LotNumber { get; init; } 
    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    public IFinancialInstrumentQuantity33Choice? LotQuantity { get; init; } 
    
    #nullable disable
}
