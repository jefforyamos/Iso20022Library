﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionRate111.  ISO2002 ID# _x_IoER9REeuFz_FaCzCLgQ.
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
/// Specifies rates related to a corporate action option.
/// </summary>
[IsoId("_x_IoER9REeuFz_FaCzCLgQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Corporate Action Rate")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionRate111
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    [IsoId("_x_IoJx9REeuFz_FaCzCLgQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Tax")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat46Choice_? AdditionalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat46Choice_? AdditionalTax { get; init; } 
    #else
    public RateAndAmountFormat46Choice_? AdditionalTax { get; set; } 
    #endif
    
    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_x_IoLx9REeuFz_FaCzCLgQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Gross Dividend Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GrossDividendRateFormat41Choice_? GrossDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GrossDividendRateFormat41Choice_? GrossDividendRate { get; init; } 
    #else
    public GrossDividendRateFormat41Choice_? GrossDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_x_IoNx9REeuFz_FaCzCLgQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Net Dividend Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetDividendRateFormat43Choice_? NetDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetDividendRateFormat43Choice_? NetDividendRate { get; init; } 
    #else
    public NetDividendRateFormat43Choice_? NetDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// The actual interest rate used for the payment of the interest for the specified interest period. |Usage guideline: It is used to provide the applicable rate for the current payment, after all calculations have been performed, that is, application of period and method of interest computation.
    /// </summary>
    [IsoId("_x_IoOR9REeuFz_FaCzCLgQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Interest Rate Used For Payment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRateUsedForPaymentFormat10Choice_? InterestRateUsedForPayment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRateUsedForPaymentFormat10Choice_? InterestRateUsedForPayment { get; init; } 
    #else
    public InterestRateUsedForPaymentFormat10Choice_? InterestRateUsedForPayment { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum percentage of shares available through the over subscription privilege, usually a percentage of the basic subscription shares, for example, an account owner subscribing to 100 shares may over subscribe to a maximum of 50 additional shares when the over subscription maximum is 50 percent.
    /// </summary>
    [IsoId("_x_IoQR9REeuFz_FaCzCLgQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Maximum Allowed Oversubscription Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat3Choice_? MaximumAllowedOversubscriptionRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat3Choice_? MaximumAllowedOversubscriptionRate { get; init; } 
    #else
    public RateFormat3Choice_? MaximumAllowedOversubscriptionRate { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of securities accepted by the offeror/issuer.
    /// </summary>
    [IsoId("_x_IoSR9REeuFz_FaCzCLgQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Proration Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat3Choice_? ProrationRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat3Choice_? ProrationRate { get; init; } 
    #else
    public RateFormat3Choice_? ProrationRate { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_x_IoUR9REeuFz_FaCzCLgQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Withholding Tax Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat47Choice_? WithholdingTaxRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat47Choice_? WithholdingTaxRate { get; init; } 
    #else
    public RateAndAmountFormat47Choice_? WithholdingTaxRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate at which the income will be withheld by a jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate (TAXR) levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    [IsoId("_x_IoWR9REeuFz_FaCzCLgQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Second Level Tax")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat47Choice_? SecondLevelTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat47Choice_? SecondLevelTax { get; init; } 
    #else
    public RateAndAmountFormat47Choice_? SecondLevelTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount included in the dividend/NAV that is identified as gains directly or indirectly derived from interest payments, for example, in the context of the EU Savings directive.
    /// </summary>
    [IsoId("_x_IoWx9REeuFz_FaCzCLgQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Taxable Income Per Dividend Share")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateTypeAndAmountAndStatus33? TaxableIncomePerDividendShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateTypeAndAmountAndStatus33? TaxableIncomePerDividendShare { get; init; } 
    #else
    public RateTypeAndAmountAndStatus33? TaxableIncomePerDividendShare { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate (provided by the issuer) between the dividend or interest rate in the paid currency and the declared dividend or interest rate.
    /// </summary>
    [IsoId("_x_IoXR9REeuFz_FaCzCLgQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Issuer Declared Exchange Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms19? IssuerDeclaredExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms19? IssuerDeclaredExchangeRate { get; init; } 
    #else
    public ForeignExchangeTerms19? IssuerDeclaredExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Overall tax withheld at source by fund managers prior to considering the tax obligation of each unit holder.
    /// </summary>
    [IsoId("_x_IoXx9REeuFz_FaCzCLgQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tax On Income")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat46Choice_? TaxOnIncome { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat46Choice_? TaxOnIncome { get; init; } 
    #else
    public RateAndAmountFormat46Choice_? TaxOnIncome { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptable price increment used for submitting a bid.
    /// </summary>
    [IsoId("_x_IoYR9REeuFz_FaCzCLgQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Bid Interval")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat38Choice_? BidInterval { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat38Choice_? BidInterval { get; init; } 
    #else
    public RateAndAmountFormat38Choice_? BidInterval { get; set; } 
    #endif
    
    
    #nullable disable
    
}
