﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionRate96.  ISO2002 ID# _Dron0c3yEee5nJBZsW8MFQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rates of a corporate action.
/// </summary>
public partial record CorporateActionRate96
{
    #nullable enable
    
    /// <summary>
    /// Annualised interest rate of a financial instrument used to calculate the actual interest rate of the coupon or the accrued interest.
    /// </summary>
    public RateAndAmountFormat46Choice_? InterestRate { get; init; } 
    /// <summary>
    /// Percentage of securities the offeror/issuer will purchase or redeem under the terms of the event.
    /// </summary>
    public RateFormat7Choice_? PercentageSought { get; init; } 
    /// <summary>
    /// Index rate related to the interest rate of the forthcoming interest payment.
    /// </summary>
    public RateFormat3Choice_? RelatedIndex { get; init; } 
    /// <summary>
    /// Margin allowed over or under a given rate.
    /// </summary>
    public RateFormat3Choice_? Spread { get; init; } 
    /// <summary>
    /// Acceptable price increment used for submitting a bid.
    /// </summary>
    public RateAndAmountFormat50Choice_? BidInterval { get; init; } 
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) until the next redemption (factor) date.
    /// </summary>
    public RateFormat12Choice_? PreviousFactor { get; init; } 
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) that will applicable after the redemption (factor) date.
    /// </summary>
    public RateFormat12Choice_? NextFactor { get; init; } 
    /// <summary>
    /// Rate of discount for securities purchased through a reinvestment scheme as compared to the current market price of security.
    /// </summary>
    public RateFormat3Choice_? ReinvestmentDiscountRateToMarket { get; init; } 
    /// <summary>
    /// For structured security issues where there is a set schedule of principal and interest payments for the life of the issue, this is the difference between the actual rate of the interest payment and the expected or scheduled rate of the interest payment.
    /// </summary>
    public RateAndAmountFormat43Choice_? InterestShortfall { get; init; } 
    /// <summary>
    /// For structured security issues where there is a set schedule of principal and interest payments for the life of the issue, this is the difference between the actual rate of the capital or principal repayment and the scheduled capital repayment.
    /// </summary>
    public RateAndAmountFormat43Choice_? RealisedLoss { get; init; } 
    /// <summary>
    /// Dividend or interest rate declared by the issuer.
    /// </summary>
    public RateAndAmountFormat43Choice_? DeclaredRate { get; init; } 
    
    #nullable disable
}
