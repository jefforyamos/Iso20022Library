﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionPrice18.  ISO2002 ID# _oc_1a-EJEd-udr336SN7mQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies prices related to a corporate action option.
/// </summary>
public partial record CorporateActionPrice18
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the price is an indicative price or a market price.
    /// </summary>
    public IndicativeOrMarketPrice5Choice_? IndicativeOrMarketPrice { get; init; } 
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    public PriceFormat19Choice_? CashInLieuOfSharePrice { get; init; } 
    
    #nullable disable
}
