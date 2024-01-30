﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionRate3.  ISO2002 ID# _TZcmGdp-Ed-ak6NoX_4Aeg_-1920684142.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rates of a corporate action.
/// </summary>
public partial record CorporateActionRate3
{
    #nullable enable
    
    /// <summary>
    /// Annual rate of a financial instrument.
    /// </summary>
    public IRateAndAmountFormat3Choice? Interest { get; init; } 
    /// <summary>
    /// Percentage of securities the offeror/issuer will purchase or redeem under the terms of the event. This can be a number or the term "any and all".
    /// </summary>
    public IRateFormat5Choice? PercentageSought { get; init; } 
    /// <summary>
    /// Index rate related to the interest rate of the forthcoming interest payment.
    /// </summary>
    public IRateFormat2Choice? RelatedIndex { get; init; } 
    /// <summary>
    /// Margin allowed over or under a given rate.
    /// </summary>
    public IRateFormat2Choice? Spread { get; init; } 
    /// <summary>
    /// Acceptable price increment used for submitting a bid.
    /// </summary>
    public IRateAndAmountFormat3Choice? BidInterval { get; init; } 
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) until the next redemption (factor) date.
    /// </summary>
    public IRateFormat3Choice? PreviousFactor { get; init; } 
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) that will applicable after the redemption (factor) date.
    /// </summary>
    public IRateFormat3Choice? NextFactor { get; init; } 
    /// <summary>
    /// Rate of discount for securities purchased through a reinvestment scheme as compared to the current market price of security.
    /// </summary>
    public IRateFormat2Choice? ReinvestmentDiscountRateToMarket { get; init; } 
    
    #nullable disable
}
