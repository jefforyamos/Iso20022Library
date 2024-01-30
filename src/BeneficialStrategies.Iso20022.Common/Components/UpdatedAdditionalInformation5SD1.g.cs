﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UpdatedAdditionalInformation5SD1.  ISO2002 ID# _y2PfPjYnEeGFarbLo5oXPg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension for updated additional information.
/// </summary>
public partial record UpdatedAdditionalInformation5SD1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Total distribution fund rate per share.
    /// 一株あたりの交付金先等の額.
    /// </summary>
    public IRateAndAmountFormat2Choice? DistributionAmountPerShare { get; init; } 
    /// <summary>
    /// Rate information of how much net asset decrease happens as a result of the fund distribution.
    /// </summary>
    public IsoPercentageRate? NetAssetDecreaseRatio { get; init; } 
    /// <summary>
    /// Distribution amount of accumulated profit per share.
    /// 一株あたり利益剰余金の額.
    /// </summary>
    public IRateAndAmountFormat2Choice? AccumulatedProfitPerShare { get; init; } 
    /// <summary>
    /// Taxable distribution amount of dividend.
    /// 一株あたりみなし配当の額.
    /// </summary>
    public IRateAndAmountFormat2Choice? DeemedDividendPerShare { get; init; } 
    /// <summary>
    /// Tax exempted distribution amount of dividend. 
    /// 一株あたりみなし譲渡収入の額.
    /// </summary>
    public IRateAndAmountFormat2Choice? ResidualDistributionAmountPerShare { get; init; } 
    
    #nullable disable
}
