﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentAttributes122.  ISO2002 ID# _ceeMZzi8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Elements characterising a financial instrument.
/// </summary>
public partial record FinancialInstrumentAttributes122
{
    #nullable enable
    
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    public IMarketIdentification4Choice? PlaceOfListing { get; init; } 
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    public IInterestComputationMethodFormat5Choice? DayCountBasis { get; init; } 
    /// <summary>
    /// Specifies the form, this is, ownership, of the security.
    /// </summary>
    public IFormOfSecurity7Choice? RegistrationForm { get; init; } 
    /// <summary>
    /// Specifies the frequency of an interest payment.
    /// </summary>
    public IFrequency27Choice? PaymentFrequency { get; init; } 
    /// <summary>
    /// Status of payment of a security at a particular time.
    /// </summary>
    public ISecuritiesPaymentStatus6Choice? PaymentStatus { get; init; } 
    /// <summary>
    /// Specifies the frequency of change to the variable rate of an interest bearing instrument.
    /// </summary>
    public IFrequency27Choice? VariableRateChangeFrequency { get; init; } 
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    public IClassificationType33Choice? ClassificationType { get; init; } 
    /// <summary>
    /// Specifies how an option can be exercised (American, European, Bermudan).
    /// </summary>
    public IOptionStyle9Choice? OptionStyle { get; init; } 
    /// <summary>
    /// Specifies whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
    /// </summary>
    public IOptionType7Choice? OptionType { get; init; } 
    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; } 
    /// <summary>
    /// Next payment date of an interest bearing financial instrument.
    /// </summary>
    public IsoISODate? CouponDate { get; init; } 
    /// <summary>
    /// Date on which a privilege expires.
    /// </summary>
    public IsoISODate? ExpiryDate { get; init; } 
    /// <summary>
    /// Date at which the interest rate of an interest bearing security will be calculated and reset, according to the terms of the issue.
    /// </summary>
    public IsoISODate? FloatingRateFixingDate { get; init; } 
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    public IsoISODate? MaturityDate { get; init; } 
    /// <summary>
    /// Date at which the security was made available.
    /// </summary>
    public IsoISODate? IssueDate { get; init; } 
    /// <summary>
    /// Next date at which the issuer has the right to pay the security prior to maturity.
    /// </summary>
    public IsoISODate? NextCallableDate { get; init; } 
    /// <summary>
    /// Date at which the holder has the right to ask for redemption of the security prior to final maturity.
    /// </summary>
    public IsoISODate? PutableDate { get; init; } 
    /// <summary>
    /// First date at which a security begins to accrue interest.
    /// </summary>
    public IsoISODate? DatedDate { get; init; } 
    /// <summary>
    /// Date at which the first interest payment is due to holders of the security.
    /// </summary>
    public IsoISODate? FirstPaymentDate { get; init; } 
    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 that was applicable before the current factor and defines the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    public IsoBaseOneRate? PreviousFactor { get; init; } 
    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 defining the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    public IsoBaseOneRate? CurrentFactor { get; init; } 
    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 that will be applicable as of the next factor date and defines the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    public IsoBaseOneRate? NextFactor { get; init; } 
    /// <summary>
    /// Per annum ratio of interest paid to the principal amount of the financial instrument for a specific period of time.
    /// </summary>
    public IsoPercentageRate? InterestRate { get; init; } 
    /// <summary>
    /// Rate of return anticipated on a bond when held until maturity date.
    /// </summary>
    public IsoPercentageRate? YieldToMaturityRate { get; init; } 
    /// <summary>
    /// Interest rate applicable to the next interest payment period in relation to variable rate instruments.
    /// </summary>
    public IsoPercentageRate? NextInterestRate { get; init; } 
    /// <summary>
    /// Specifies the reference rate for fixed income instruments where the |price of the instrument is indexed to the price of an underlying benchmark.
    /// </summary>
    public IsoPercentageRate? IndexRateBasis { get; init; } 
    /// <summary>
    /// Number of the coupon attached to the physical security.
    /// </summary>
    public INumber23Choice? CouponAttachedNumber { get; init; } 
    /// <summary>
    /// Number identifying a group of underlying assets assigned by the issuer of a factored security.
    /// </summary>
    public GenericIdentification39? PoolNumber { get; init; } 
    /// <summary>
    /// Indicates whether the interest rate of an interest bearing instrument is reset periodically.
    /// </summary>
    public IsoYesNoIndicator? VariableRateIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the issuer has the right to pay the security prior to maturity. Also called RetractableIndicator.
    /// </summary>
    public IsoYesNoIndicator? CallableIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the holder has the right to ask for redemption of the security prior to final maturity. Also called RedeemableIndicator.
    /// </summary>
    public IsoYesNoIndicator? PutableIndicator { get; init; } 
    /// <summary>
    /// Value of the price, for example, as a currency and value per unit or as a percentage.
    /// </summary>
    public IPriceType5Choice? MarketOrIndicativePrice { get; init; } 
    /// <summary>
    /// Predetermined price at which the holder of a derivative will buy or sell the underlying instrument.
    /// </summary>
    public Price3? ExercisePrice { get; init; } 
    /// <summary>
    /// Pre-determined price at which the holder of a right is entitled to buy the underlying instrument.
    /// </summary>
    public Price3? SubscriptionPrice { get; init; } 
    /// <summary>
    /// Price of one target security in the conversion.
    /// </summary>
    public Price3? ConversionPrice { get; init; } 
    /// <summary>
    /// Predetermined price at which the holder will have to buy or sell the underlying instrument.
    /// </summary>
    public Price3? StrikePrice { get; init; } 
    /// <summary>
    /// Minimum nominal quantity of financial instrument.
    /// </summary>
    public IFinancialInstrumentQuantity36Choice? MinimumNominalQuantity { get; init; } 
    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a quantity.
    /// </summary>
    public IFinancialInstrumentQuantity36Choice? ContractSize { get; init; } 
    /// <summary>
    /// Identification of the underlying security.
    /// </summary>
    public SecurityIdentification20? UnderlyingFinancialInstrumentIdentification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional information about the financial instrument in narrative form.
    /// </summary>
    public IsoRestrictedFINXMax350Text? FinancialInstrumentAttributeAdditionalDetails { get; init; } 
    
    #nullable disable
}
