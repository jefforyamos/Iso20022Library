﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Reference5.  ISO2002 ID# _Q_XJRdp-Ed-ak6NoX_4Aeg_-1514589671.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional references linked to the quote response.
/// </summary>
public partial record Reference5
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier for quote.
    /// </summary>
    public IsoMax35Text? QuoteIdentification { get; init; } 
    /// <summary>
    /// Unique identifier for quote request.
    /// </summary>
    public IsoMax35Text? QuoteRequestIdentification { get; init; } 
    /// <summary>
    /// Unique identifier of indication of interest message.
    /// </summary>
    public IsoMax35Text? IOIIdentification { get; init; } 
    /// <summary>
    /// Unique identifier for order as assigned by the buy-side ( institution, broker, intermediary.).
    /// </summary>
    public IsoMax35Text? ClientOrderIdentification { get; init; } 
    
    #nullable disable
}
