﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionPriceSD3.  ISO2002 ID# _1TODEzL3EeKU9IrkkToqcw_-1032866259.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action details price details.
/// </summary>
public partial record CorporateActionPriceSD3
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Cost to subscribe to additional share(s) of the underlying security.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAnd13DecimalAmount? SubscriptionPrice { get; init; } 
    
    #nullable disable
}
