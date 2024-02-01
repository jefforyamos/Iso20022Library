﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentAttributes109.  ISO2002 ID# _QldRFxuyEeyhRdHRjakS2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Description of the financial instrument.
/// </summary>
public partial record FinancialInstrumentAttributes109
{
    #nullable enable
    
    /// <summary>
    /// Identification of a financial instrument.
    /// </summary>
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Place where the referenced financial instrument is listed.
    /// </summary>
    public MarketIdentification3Choice_? PlaceOfListing { get; init; } 
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the financial instrument.
    /// </summary>
    public InterestComputationMethodFormat4Choice_? DayCountBasis { get; init; } 
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI).
    /// </summary>
    public ClassificationType32Choice_? ClassificationType { get; init; } 
    /// <summary>
    /// Currency in which a financial instrument is currently denominated.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; } 
    /// <summary>
    /// Next payment date of an interest bearing financial instrument.
    /// </summary>
    public IsoISODate? NextCouponDate { get; init; } 
    /// <summary>
    /// Date on which an order expires or at which a privilege or offer terminates.
    /// </summary>
    public IsoISODate? ExpiryDate { get; init; } 
    /// <summary>
    /// Date on which the interest rate or redemption price will be/was calculated according to the terms of the issue.
    /// </summary>
    public IsoISODate? FloatingRateFixingDate { get; init; } 
    /// <summary>
    /// Date on which a financial instrument becomes due and assets are to be repaid.
    /// </summary>
    public IsoISODate? MaturityDate { get; init; } 
    /// <summary>
    /// Date on which the financial instrument is issued.
    /// </summary>
    public IsoISODate? IssueDate { get; init; } 
    /// <summary>
    /// Date on which a financial instrument is called away/redeemed before its scheduled maturity.
    /// </summary>
    public IsoISODate? NextCallableDate { get; init; } 
    /// <summary>
    /// Date on which a holder of a financial instrument has the right to request redemption of the principal amount prior to its scheduled maturity date.
    /// </summary>
    public IsoISODate? PutableDate { get; init; } 
    /// <summary>
    /// Date on which an interest bearing financial instrument begins to accrue interest.
    /// </summary>
    public IsoISODate? DatedDate { get; init; } 
    /// <summary>
    /// Deadline by which a convertible security must be converted, according to the terms of the issue.
    /// </summary>
    public IsoISODate? ConversionDate { get; init; } 
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) until the next redemption (factor) date.
    /// </summary>
    public IsoBaseOne14Rate? PreviousFactor { get; init; } 
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) that will applicable after the redemption (factor) date.
    /// </summary>
    public IsoBaseOne14Rate? NextFactor { get; init; } 
    /// <summary>
    /// Annualised interest rate of a financial instrument used to calculate the actual interest rate of the coupon or the accrued interest.
    /// </summary>
    public IsoPercentageRate? InterestRate { get; init; } 
    /// <summary>
    /// Interest rate applicable to the next interest payment period in relation to variable rate instruments.
    /// </summary>
    public IsoPercentageRate? NextInterestRate { get; init; } 
    /// <summary>
    /// Minimum nominal quantity of financial instrument.
    /// </summary>
    public FinancialInstrumentQuantity33Choice_? MinimumNominalQuantity { get; init; } 
    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a financial instrument quantity.
    /// </summary>
    public FinancialInstrumentQuantity33Choice_? ContractSize { get; init; } 
    
    #nullable disable
}
