﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentAttributes15.  ISO2002 ID# _3GaD4d0SEd-Cb-IGbQ4hBQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Elements characterising a financial instrument.
/// </summary>
[IsoId("_3GaD4d0SEd-Cb-IGbQ4hBQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Financial Instrument Attributes")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentAttributes15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    [IsoId("_3GaD490SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Place Of Listing")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketIdentification5? PlaceOfListing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification5? PlaceOfListing { get; init; } 
    #else
    public MarketIdentification5? PlaceOfListing { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    [IsoId("_fnmm4fk8Ed-u1pLmCBlmpg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Day Count Basis")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestComputationMethodFormat1Choice_? DayCountBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestComputationMethodFormat1Choice_? DayCountBasis { get; init; } 
    #else
    public InterestComputationMethodFormat1Choice_? DayCountBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the form, that is, ownership, of the security.
    /// </summary>
    [IsoId("_3GaD590SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Registration Form")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FormOfSecurity2Choice_? RegistrationForm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FormOfSecurity2Choice_? RegistrationForm { get; init; } 
    #else
    public FormOfSecurity2Choice_? RegistrationForm { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the frequency of an interest payment.
    /// </summary>
    [IsoId("_3GaD6d0SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Frequency")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency3Choice_? PaymentFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency3Choice_? PaymentFrequency { get; init; } 
    #else
    public Frequency3Choice_? PaymentFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Status of payment of a security at a particular time.
    /// </summary>
    [IsoId("_3GaD690SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesPaymentStatus2Choice_? PaymentStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesPaymentStatus2Choice_? PaymentStatus { get; init; } 
    #else
    public SecuritiesPaymentStatus2Choice_? PaymentStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the direction of payment for asset or mortgage backed securities, that is, whether the repaid capital is distributed (payment direction is down) or capitalized (payment direction is up).
    /// </summary>
    [IsoId("_3GaD7d0SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Direction")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentDirection2Choice_? PaymentDirection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentDirection2Choice_? PaymentDirection { get; init; } 
    #else
    public PaymentDirection2Choice_? PaymentDirection { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the frequency of change to the variable rate of an interest bearing instrument.
    /// </summary>
    [IsoId("_3GaD790SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Variable Rate Change Frequency")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency3Choice_? VariableRateChangeFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency3Choice_? VariableRateChangeFrequency { get; init; } 
    #else
    public Frequency3Choice_? VariableRateChangeFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the level of priority to claim on income and assets of the company in case of the payment of dividends and in the event of a bankruptcy, for example, ordinary/common stocks, preferred stocks, subordinated debt, etc.
    /// </summary>
    [IsoId("_3GaD8d0SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Preference To Income")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PreferenceToIncome2Choice_? PreferenceToIncome { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PreferenceToIncome2Choice_? PreferenceToIncome { get; init; } 
    #else
    public PreferenceToIncome2Choice_? PreferenceToIncome { get; set; } 
    #endif
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_3GaD890SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Classification Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClassificationType2Choice_? ClassificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClassificationType2Choice_? ClassificationType { get; init; } 
    #else
    public ClassificationType2Choice_? ClassificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how an option can be exercised (American, European, Bermudan).
    /// </summary>
    [IsoId("_3GaD9d0SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Option Style")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionStyle4Choice_? OptionStyle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionStyle4Choice_? OptionStyle { get; init; } 
    #else
    public OptionStyle4Choice_? OptionStyle { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_3GaD990SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Option Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionType2Choice_? OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionType2Choice_? OptionType { get; init; } 
    #else
    public OptionType2Choice_? OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_3GaD-d0SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Denomination Currency")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? DenominationCurrency { get; init; } 
    #else
    public string? DenominationCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Next payment date of an interest bearing financial instrument.
    /// </summary>
    [IsoId("_3GaD-90SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Coupon Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? CouponDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? CouponDate { get; init; } 
    #else
    public System.DateOnly? CouponDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which a privilege expires.
    /// </summary>
    [IsoId("_3GaD_d0SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Expiry Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ExpiryDate { get; init; } 
    #else
    public System.DateOnly? ExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the interest rate of an interest bearing security will be calculated and reset, according to the terms of the issue.
    /// </summary>
    [IsoId("_3GaD_90SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Floating Rate Fixing Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? FloatingRateFixingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? FloatingRateFixingDate { get; init; } 
    #else
    public System.DateOnly? FloatingRateFixingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_3GaEAd0SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Maturity Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? MaturityDate { get; init; } 
    #else
    public System.DateOnly? MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the security was made available.
    /// </summary>
    [IsoId("_3GaEA90SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Issue Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? IssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? IssueDate { get; init; } 
    #else
    public System.DateOnly? IssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Next date at which the issuer has the right to pay the security prior to maturity.
    /// </summary>
    [IsoId("_3GaEBd0SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Next Callable Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? NextCallableDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? NextCallableDate { get; init; } 
    #else
    public System.DateOnly? NextCallableDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the holder has the right to ask for redemption of the security prior to final maturity.
    /// </summary>
    [IsoId("_3GaEB90SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Putable Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? PutableDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? PutableDate { get; init; } 
    #else
    public System.DateOnly? PutableDate { get; set; } 
    #endif
    
    /// <summary>
    /// First date at which a security begins to accrue interest.
    /// </summary>
    [IsoId("_3GaECd0SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Dated Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DatedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DatedDate { get; init; } 
    #else
    public System.DateOnly? DatedDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the first interest payment is due to holders of the security.
    /// </summary>
    [IsoId("_3GaEC90SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("First Payment Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? FirstPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? FirstPaymentDate { get; init; } 
    #else
    public System.DateOnly? FirstPaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 that was applicable before the current factor and defines the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_3GaEDd0SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Previous Factor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? PreviousFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PreviousFactor { get; init; } 
    #else
    public System.Decimal? PreviousFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 defining the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_3GaED90SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Current Factor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? CurrentFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CurrentFactor { get; init; } 
    #else
    public System.Decimal? CurrentFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 that will be applicable as of the next factor date and defines the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_3GaEEd0SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Next Factor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? NextFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? NextFactor { get; init; } 
    #else
    public System.Decimal? NextFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Per annum ratio of interest paid to the principal amount of the financial instrument for a specific period of time.
    /// </summary>
    [IsoId("_3GaEE90SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Interest Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? InterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? InterestRate { get; init; } 
    #else
    public System.Decimal? InterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate applicable to the next interest payment period in relation to variable rate instruments.
    /// </summary>
    [IsoId("_3GaEFd0SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Next Interest Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? NextInterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? NextInterestRate { get; init; } 
    #else
    public System.Decimal? NextInterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reference rate for fixed income instruments where the |price of the instrument is indexed to the price of an underlying benchmark.
    /// </summary>
    [IsoId("_3GaEF90SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Index Rate Basis")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? IndexRateBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? IndexRateBasis { get; init; } 
    #else
    public System.Decimal? IndexRateBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Number of the coupon attached to the physical security.
    /// </summary>
    [IsoId("_3GaEGd0SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Coupon Attached Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Number2Choice_? CouponAttachedNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Number2Choice_? CouponAttachedNumber { get; init; } 
    #else
    public Number2Choice_? CouponAttachedNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying a group of underlying assets assigned by the issuer of a factored security.
    /// </summary>
    [IsoId("_3GaEG90SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Pool Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Number2Choice_? PoolNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Number2Choice_? PoolNumber { get; init; } 
    #else
    public Number2Choice_? PoolNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the interest rate of an interest bearing instrument is reset periodically.
    /// </summary>
    [IsoId("_3GaEHd0SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Variable Rate Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? VariableRateIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? VariableRateIndicator { get; init; } 
    #else
    public System.String? VariableRateIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the issuer has the right to pay the security prior to maturity. Also called RetractableIndicator.
    /// </summary>
    [IsoId("_3GaEH90SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Callable Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CallableIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CallableIndicator { get; init; } 
    #else
    public System.String? CallableIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the holder has the right to ask for redemption of the security prior to final maturity. Also called RedeemableIndicator.
    /// </summary>
    [IsoId("_3GaEId0SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Putable Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PutableIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PutableIndicator { get; init; } 
    #else
    public System.String? PutableIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the price, for example, as a currency and value per unit or as a percentage.
    /// </summary>
    [IsoId("_3GaEI90SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Market Or Indicative Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceType1Choice_? MarketOrIndicativePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceType1Choice_? MarketOrIndicativePrice { get; init; } 
    #else
    public PriceType1Choice_? MarketOrIndicativePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Predetermined price at which the holder of a derivative will buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_3GaEJd0SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Exercise Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price2? ExercisePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price2? ExercisePrice { get; init; } 
    #else
    public Price2? ExercisePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Pre-determined price at which the holder of a right is entitled to buy the underlying instrument.
    /// </summary>
    [IsoId("_3GaEJ90SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Subscription Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price2? SubscriptionPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price2? SubscriptionPrice { get; init; } 
    #else
    public Price2? SubscriptionPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Price of one target security in the conversion.
    /// </summary>
    [IsoId("_3GaEKd0SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Conversion Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price2? ConversionPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price2? ConversionPrice { get; init; } 
    #else
    public Price2? ConversionPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Predetermined price at which the holder will have to buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_3GaEK90SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Strike Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price2? StrikePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price2? StrikePrice { get; init; } 
    #else
    public Price2? StrikePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the minimum tradable quantity of a security.
    /// </summary>
    [IsoId("_3GaELd0SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Minimum Nominal Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? MinimumNominalQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? MinimumNominalQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? MinimumNominalQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a quantity.
    /// </summary>
    [IsoId("_3GaEL90SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Contract Size")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? ContractSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? ContractSize { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? ContractSize { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the underlying security by an ISIN.
    /// </summary>
    [IsoId("_3GaEMd0SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Underlying Financial Instrument Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification14? UnderlyingFinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14? UnderlyingFinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification14? UnderlyingFinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the financial instrument in narrative form.
    /// </summary>
    [IsoId("_3GaEM90SEd-Cb-IGbQ4hBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Financial Instrument Attribute Additional Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? FinancialInstrumentAttributeAdditionalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FinancialInstrumentAttributeAdditionalDetails { get; init; } 
    #else
    public System.String? FinancialInstrumentAttributeAdditionalDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
