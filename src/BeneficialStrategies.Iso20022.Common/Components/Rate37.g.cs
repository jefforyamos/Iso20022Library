﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Rate37.  ISO2002 ID# _-lv60QVSEeqjd8n6wD9JVw.
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
/// Provides information about the rates related to securities movement.
/// </summary>
[IsoId("_-lv60QVSEeqjd8n6wD9JVw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Rate")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Rate37
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
    [IsoId("_-lv66QVSEeqjd8n6wD9JVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Tax")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat43Choice_? AdditionalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat43Choice_? AdditionalTax { get; init; } 
    #else
    public RateAndAmountFormat43Choice_? AdditionalTax { get; set; } 
    #endif
    
    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    [IsoId("_-lv66wVSEeqjd8n6wD9JVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Charges Fees")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat43Choice_? ChargesFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat43Choice_? ChargesFees { get; init; } 
    #else
    public RateAndAmountFormat43Choice_? ChargesFees { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    [IsoId("_-lv67QVSEeqjd8n6wD9JVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Fiscal Stamp")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? FiscalStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? FiscalStamp { get; init; } 
    #else
    public System.Decimal? FiscalStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_-lv67wVSEeqjd8n6wD9JVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Gross Dividend Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GrossDividendRateFormat40Choice_? GrossDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GrossDividendRateFormat40Choice_? GrossDividendRate { get; init; } 
    #else
    public GrossDividendRateFormat40Choice_? GrossDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Cash rate made available, as an incentive, in addition to the solicitation fee, in order to encourage early participation in an offer.
    /// </summary>
    [IsoId("_-lv68QVSEeqjd8n6wD9JVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Early Solicitation Fee Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SolicitationFeeRateFormat9Choice_? EarlySolicitationFeeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SolicitationFeeRateFormat9Choice_? EarlySolicitationFeeRate { get; init; } 
    #else
    public SolicitationFeeRateFormat9Choice_? EarlySolicitationFeeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Cash rate made available in an event in order to encourage participation in the offer. As information, Payment is made to a third party who has solicited an entity to take part in the offer.
    /// </summary>
    [IsoId("_-lv68wVSEeqjd8n6wD9JVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Third Party Incentive Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat43Choice_? ThirdPartyIncentiveRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat43Choice_? ThirdPartyIncentiveRate { get; init; } 
    #else
    public RateAndAmountFormat43Choice_? ThirdPartyIncentiveRate { get; set; } 
    #endif
    
    /// <summary>
    /// Actual interest rate used for the payment of the interest for the specified interest period.
    /// </summary>
    [IsoId("_-lv69QVSEeqjd8n6wD9JVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Interest Rate Used For Payment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRateUsedForPaymentFormat9Choice_? InterestRateUsedForPayment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRateUsedForPaymentFormat9Choice_? InterestRateUsedForPayment { get; init; } 
    #else
    public InterestRateUsedForPaymentFormat9Choice_? InterestRateUsedForPayment { get; set; } 
    #endif
    
    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_-lv69wVSEeqjd8n6wD9JVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Net Dividend Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetDividendRateFormat42Choice_? NetDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetDividendRateFormat42Choice_? NetDividendRate { get; init; } 
    #else
    public NetDividendRateFormat42Choice_? NetDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    [IsoId("_-lv6-QVSEeqjd8n6wD9JVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Applicable Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? ApplicableRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ApplicableRate { get; init; } 
    #else
    public System.Decimal? ApplicableRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, for example consent fees or solicitation fee.
    /// </summary>
    [IsoId("_-lv6-wVSEeqjd8n6wD9JVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Solicitation Fee Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SolicitationFeeRateFormat9Choice_? SolicitationFeeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SolicitationFeeRateFormat9Choice_? SolicitationFeeRate { get; init; } 
    #else
    public SolicitationFeeRateFormat9Choice_? SolicitationFeeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    [IsoId("_-lv6_QVSEeqjd8n6wD9JVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tax Credit Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat23Choice_? TaxCreditRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat23Choice_? TaxCreditRate { get; init; } 
    #else
    public RateFormat23Choice_? TaxCreditRate { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_-lv6_wVSEeqjd8n6wD9JVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Withholding Tax Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat45Choice_? WithholdingTaxRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat45Choice_? WithholdingTaxRate { get; init; } 
    #else
    public RateAndAmountFormat45Choice_? WithholdingTaxRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate at which the income will be withheld by a jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate (TAXR) levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    [IsoId("_-lv7AQVSEeqjd8n6wD9JVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Second Level Tax")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat45Choice_? SecondLevelTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat45Choice_? SecondLevelTax { get; init; } 
    #else
    public RateAndAmountFormat45Choice_? SecondLevelTax { get; set; } 
    #endif
    
    /// <summary>
    /// Taxation applied on an amount clearly identified as an income.
    /// </summary>
    [IsoId("_-lv7AwVSEeqjd8n6wD9JVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tax On Income")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat43Choice_? TaxOnIncome { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat43Choice_? TaxOnIncome { get; init; } 
    #else
    public RateAndAmountFormat43Choice_? TaxOnIncome { get; set; } 
    #endif
    
    /// <summary>
    /// Taxation applied on an amount clearly identified as capital profits, capital gains.
    /// </summary>
    [IsoId("_-lv7BQVSEeqjd8n6wD9JVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tax On Profits")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? TaxOnProfits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxOnProfits { get; init; } 
    #else
    public System.Decimal? TaxOnProfits { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of cash that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_-lv7BwVSEeqjd8n6wD9JVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tax Reclaim Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? TaxReclaimRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxReclaimRate { get; init; } 
    #else
    public System.Decimal? TaxReclaimRate { get; set; } 
    #endif
    
    /// <summary>
    /// Portion of the fund distribution which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    [IsoId("_-lv7CQVSEeqjd8n6wD9JVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Equalisation Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAnd13DecimalAmount? EqualisationRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? EqualisationRate { get; init; } 
    #else
    public System.Decimal? EqualisationRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate applied for the calculation of deemed proceeds which are not paid to security holders but on which withholding tax is applicable.
    /// </summary>
    [IsoId("_-lv7CwVSEeqjd8n6wD9JVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Deemed Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat54Choice_? DeemedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat54Choice_? DeemedRate { get; init; } 
    #else
    public RateAndAmountFormat54Choice_? DeemedRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
