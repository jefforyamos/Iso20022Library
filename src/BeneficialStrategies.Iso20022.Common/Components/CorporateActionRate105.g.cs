﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionRate105.  ISO2002 ID# _YT-8Re29Eeqc-LCjwLsUVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rates of a corporate action.
/// </summary>
public partial record CorporateActionRate105
{
    #nullable enable
    
    /// <summary>
    /// Annualised interest rate of a financial instrument used to calculate the actual interest rate of the coupon or the accrued interest.
    /// </summary>
    public IRateAndAmountFormat37Choice? InterestRate { get; init; } 
    /// <summary>
    /// Percentage of securities the offeror/issuer will purchase or redeem under the terms of the event.
    /// </summary>
    public IRateFormat7Choice? PercentageSought { get; init; } 
    /// <summary>
    /// Index rate related to the interest rate of the forthcoming interest payment.
    /// </summary>
    public IRateFormat3Choice? RelatedIndex { get; init; } 
    /// <summary>
    /// Margin allowed over or under a given rate.
    /// </summary>
    public IRateFormat3Choice? Spread { get; init; } 
    /// <summary>
    /// Acceptable price increment used for submitting a bid.
    /// </summary>
    public IRateAndAmountFormat38Choice? BidInterval { get; init; } 
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) until the next redemption (factor) date.
    /// </summary>
    public IRateFormat12Choice? PreviousFactor { get; init; } 
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) that will applicable after the redemption (factor) date.
    /// </summary>
    public IRateFormat12Choice? NextFactor { get; init; } 
    /// <summary>
    /// Rate of discount for securities purchased through a reinvestment scheme as compared to the current market price of security.
    /// </summary>
    public IRateFormat3Choice? ReinvestmentDiscountRateToMarket { get; init; } 
    /// <summary>
    /// For structured security issues where there is a set schedule of principal and interest payments for the life of the issue, this is the difference between the actual rate of the interest payment and the expected or scheduled rate of the interest payment.
    /// </summary>
    public IRateAndAmountFormat39Choice? InterestShortfall { get; init; } 
    /// <summary>
    /// For structured security issues where there is a set schedule of principal and interest payments for the life of the issue, this is the difference between the actual rate of the capital or principal repayment and the scheduled capital repayment.
    /// </summary>
    public IRateAndAmountFormat39Choice? RealisedLoss { get; init; } 
    /// <summary>
    /// Dividend or interest rate declared by the issuer.
    /// </summary>
    public IRateAndAmountFormat39Choice? DeclaredRate { get; init; } 
    /// <summary>
    /// Public index rate applied to the amount paid to adjust it to inflation.
    /// </summary>
    public IRateAndAmountFormat37Choice? IndexFactor { get; init; } 
    
    #nullable disable
}
