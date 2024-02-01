﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GrossDividendRateFormat6SD1.  ISO2002 ID# _1eZc4zLhEeGkgP4mOiMAHQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension to choose between an amount or an unspecified rate.
/// </summary>
public partial record GrossDividendRateFormat6SD1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Provides the maximum dividend rate as announced by the Issuer.
    /// </summary>
    public RateAndAmountFormat16Choice_? MaximumDividendRate { get; init; } 
    /// <summary>
    /// Provides the minimum dividend rate as announced by the Issuer.
    /// </summary>
    public RateAndAmountFormat16Choice_? MinimumDividendRate { get; init; } 
    
    #nullable disable
}
