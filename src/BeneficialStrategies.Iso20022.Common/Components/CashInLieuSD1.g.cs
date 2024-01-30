﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashInLieuSD1.  ISO2002 ID# _1cTtpTL3EeKU9IrkkToqcw_-1781577744.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash in lieu election details.
/// </summary>
public partial record CashInLieuSD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Quantity elected.
    /// </summary>
    public required IFinancialInstrumentQuantity15Choice Quantity { get; init; } 
    
    #nullable disable
}
