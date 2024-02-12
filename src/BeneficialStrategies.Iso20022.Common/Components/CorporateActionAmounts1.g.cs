﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionAmounts1.  ISO2002 ID# _TeEAUtp-Ed-ak6NoX_4Aeg_1803502106.
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
/// Specifies amounts in the framework of a corporate action event.
/// </summary>
[IsoId("_TeEAUtp-Ed-ak6NoX_4Aeg_1803502106")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Corporate Action Amounts")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionAmounts1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money before any deductions and allowances have been made.
    /// </summary>
    [IsoId("_TeEAU9p-Ed-ak6NoX_4Aeg_2143357834")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Gross Cash Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? GrossCashAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? GrossCashAmount { get; init; } 
    #else
    public System.Decimal? GrossCashAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money after deductions and allowances have been made, if any, ie, the total amount +/- charges/fees.
    /// </summary>
    [IsoId("_TeEAVNp-Ed-ak6NoX_4Aeg_2143357865")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Net Cash Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? NetCashAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? NetCashAmount { get; init; } 
    #else
    public System.Decimal? NetCashAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money defined as a discount on a new issue or on a tranche of an existing issue.
    /// </summary>
    [IsoId("_TeEAVdp-Ed-ak6NoX_4Aeg_2143357888")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Issue Discount Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? IssueDiscountAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? IssueDiscountAmount { get; init; } 
    #else
    public System.Decimal? IssueDiscountAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of cash premium made available in order to encourage participation in the offer. Payment is made to a third party who has solicited an entity to take part in the offer.
    /// </summary>
    [IsoId("_TeEAVtp-Ed-ak6NoX_4Aeg_2143358167")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Solicitation Fees")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? SolicitationFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? SolicitationFees { get; init; } 
    #else
    public System.Decimal? SolicitationFees { get; set; } 
    #endif
    
    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, eg, equity.
    /// </summary>
    [IsoId("_TeEAV9p-Ed-ak6NoX_4Aeg_2143358228")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cash In Lieu Of Share")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? CashInLieuOfShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CashInLieuOfShare { get; init; } 
    #else
    public System.Decimal? CashInLieuOfShare { get; set; } 
    #endif
    
    /// <summary>
    /// Amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_TeEAWNp-Ed-ak6NoX_4Aeg_695553989")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? OriginalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? OriginalAmount { get; init; } 
    #else
    public System.Decimal? OriginalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money distributed as the result of a capital gain.
    /// </summary>
    [IsoId("_TeNxUNp-Ed-ak6NoX_4Aeg_2143358259")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Capital Gain")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? CapitalGain { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CapitalGain { get; init; } 
    #else
    public System.Decimal? CapitalGain { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money representing a coupon payment.
    /// </summary>
    [IsoId("_TeNxUdp-Ed-ak6NoX_4Aeg_2143358598")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Interest Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? InterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? InterestAmount { get; init; } 
    #else
    public System.Decimal? InterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// (Unique to France) Amount due to a buyer of securities dealt prior to ex date which may be subject to different rate of taxation.
    /// </summary>
    [IsoId("_TeNxUtp-Ed-ak6NoX_4Aeg_2143358660")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Indemnity Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? IndemnityAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? IndemnityAmount { get; init; } 
    #else
    public System.Decimal? IndemnityAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money (not interest) in addition to the principal at the redemption of a bond.
    /// </summary>
    [IsoId("_TeNxU9p-Ed-ak6NoX_4Aeg_2143358690")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Redemption Premium Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? RedemptionPremiumAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? RedemptionPremiumAmount { get; init; } 
    #else
    public System.Decimal? RedemptionPremiumAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that the borrower pays to the lender as a compensation. It does not entitle the lender to reclaim any tax credit and is sometimes treated differently by the local tax authorities of the lender.
    /// </summary>
    [IsoId("_TeNxVNp-Ed-ak6NoX_4Aeg_2143358752")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Manufactured Dividend Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? ManufacturedDividendAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ManufacturedDividendAmount { get; init; } 
    #else
    public System.Decimal? ManufacturedDividendAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money representing a distribution of a bond's principal, eg, repayment of outstanding debt.
    /// </summary>
    [IsoId("_TeNxVdp-Ed-ak6NoX_4Aeg_2143358782")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Principal Or Corpus")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? PrincipalOrCorpus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PrincipalOrCorpus { get; init; } 
    #else
    public System.Decimal? PrincipalOrCorpus { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money reinvested in additional securities.
    /// </summary>
    [IsoId("_TeNxVtp-Ed-ak6NoX_4Aeg_2143358843")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reinvestment Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? ReinvestmentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ReinvestmentAmount { get; init; } 
    #else
    public System.Decimal? ReinvestmentAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money resulting from a market claim.
    /// </summary>
    [IsoId("_TeNxV9p-Ed-ak6NoX_4Aeg_2143359122")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Market Claim Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? MarketClaimAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? MarketClaimAmount { get; init; } 
    #else
    public System.Decimal? MarketClaimAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount resulting from a fully franked dividend paid by a company; amount includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// </summary>
    [IsoId("_TeNxWNp-Ed-ak6NoX_4Aeg_2143359152")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Fully Franked Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? FullyFrankedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? FullyFrankedAmount { get; init; } 
    #else
    public System.Decimal? FullyFrankedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount resulting from an unfranked dividend paid by a company; the amount does not include tax credit and is subject to withholding tax.
    /// </summary>
    [IsoId("_TeNxWdp-Ed-ak6NoX_4Aeg_2144279208")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Unfranked Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? UnfrankedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? UnfrankedAmount { get; init; } 
    #else
    public System.Decimal? UnfrankedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money related to taxable income that cannot be categorised.
    /// </summary>
    [IsoId("_TeW7QNp-Ed-ak6NoX_4Aeg_2144279269")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sundry Or Other Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? SundryOrOtherAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? SundryOrOtherAmount { get; init; } 
    #else
    public System.Decimal? SundryOrOtherAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of drawdown or other reduction from or in addition to the deal price.
    /// </summary>
    [IsoId("_TeW7Qdp-Ed-ak6NoX_4Aeg_2144279331")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Special Concession Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? SpecialConcessionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? SpecialConcessionAmount { get; init; } 
    #else
    public System.Decimal? SpecialConcessionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Cash amount based on terms of corporate action event and balance of underlying securities, entitled to/from account owner (which may be positive or negative).
    /// </summary>
    [IsoId("_TeW7Qtp-Ed-ak6NoX_4Aeg_2144279392")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Entitled Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? EntitledAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? EntitledAmount { get; init; } 
    #else
    public System.Decimal? EntitledAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, e.g. consent fees.
    /// </summary>
    [IsoId("_TeW7Q9p-Ed-ak6NoX_4Aeg_2144279731")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cash Incentive")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? CashIncentive { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CashIncentive { get; init; } 
    #else
    public System.Decimal? CashIncentive { get; set; } 
    #endif
    
    /// <summary>
    /// Additional costs - coming on top of the subscription costs - which the subscriber should pay as per the subscription process. Not to be used for the subscription cost itself.
    /// </summary>
    [IsoId("_TeW7RNp-Ed-ak6NoX_4Aeg_2144279885")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Subscription Cost")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? AdditionalSubscriptionCost { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? AdditionalSubscriptionCost { get; init; } 
    #else
    public System.Decimal? AdditionalSubscriptionCost { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that has not been subject to taxation.
    /// </summary>
    [IsoId("_TeW7Rdp-Ed-ak6NoX_4Aeg_-1937354060")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tax Free Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? TaxFreeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxFreeAmount { get; init; } 
    #else
    public System.Decimal? TaxFreeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of income eligible for deferred taxation.
    /// </summary>
    [IsoId("_TeW7Rtp-Ed-ak6NoX_4Aeg_-1937353750")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tax Deferred Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? TaxDeferredAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxDeferredAmount { get; init; } 
    #else
    public System.Decimal? TaxDeferredAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Local tax (ZAS Anrechnungsbetrag) subject to interest down payment tax (proportion of interest liable for interest down payment tax/interim profit that is not covered by the tax exempt amount).
    /// </summary>
    [IsoId("_TeW7R9p-Ed-ak6NoX_4Aeg_-1937353659")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("German Local Tax 1 Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? GermanLocalTax1Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? GermanLocalTax1Amount { get; init; } 
    #else
    public System.Decimal? GermanLocalTax1Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Local tax (ZAS Pflichtige Zinsen) interest liable for interest down payment tax (proportion of gross interest per unit/interim profits that is not covered by the credit in the interest pool).
    /// </summary>
    [IsoId("_TeW7SNp-Ed-ak6NoX_4Aeg_-1937353567")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("German Local Tax 2 Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? GermanLocalTax2Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? GermanLocalTax2Amount { get; init; } 
    #else
    public System.Decimal? GermanLocalTax2Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Local tax (Zinstopf) offset interest per unit against tax exempt amount (variation to offset interest per unit in relation to tax exempt amount).
    /// </summary>
    [IsoId("_TeW7Sdp-Ed-ak6NoX_4Aeg_-1937353505")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("German Local Tax 3 Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? GermanLocalTax3Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? GermanLocalTax3Amount { get; init; } 
    #else
    public System.Decimal? GermanLocalTax3Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Local tax (Ertrag Besitzanteilig) yield liable for interest down payment tax.
    /// </summary>
    [IsoId("_TegsQNp-Ed-ak6NoX_4Aeg_-1937353227")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("German Local Tax 4 Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? GermanLocalTax4Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? GermanLocalTax4Amount { get; init; } 
    #else
    public System.Decimal? GermanLocalTax4Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_TegsQdp-Ed-ak6NoX_4Aeg_-1937353143")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Stock Exchange Tax Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? StockExchangeTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? StockExchangeTaxAmount { get; init; } 
    #else
    public System.Decimal? StockExchangeTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Tax levied on a transfer of ownership of financial instrument.
    /// </summary>
    [IsoId("_TegsQtp-Ed-ak6NoX_4Aeg_-1937352803")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transfer Tax Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? TransferTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TransferTaxAmount { get; init; } 
    #else
    public System.Decimal? TransferTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    [IsoId("_TegsQ9p-Ed-ak6NoX_4Aeg_-1937352742")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Tax Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? TransactionTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TransactionTaxAmount { get; init; } 
    #else
    public System.Decimal? TransactionTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Tax on value added.
    /// </summary>
    [IsoId("_TegsRNp-Ed-ak6NoX_4Aeg_-1937352650")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Value Added Tax Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? ValueAddedTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ValueAddedTaxAmount { get; init; } 
    #else
    public System.Decimal? ValueAddedTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of tax withheld at source in conformance with the EU Savings Directive.
    /// </summary>
    [IsoId("_TegsRdp-Ed-ak6NoX_4Aeg_-1937352589")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("EU Retention Tax Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? EURetentionTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? EURetentionTaxAmount { get; init; } 
    #else
    public System.Decimal? EURetentionTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of tax charged by the jurisdiction in which the financial instrument settles.
    /// </summary>
    [IsoId("_TegsRtp-Ed-ak6NoX_4Aeg_-1937352280")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Local Tax Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? LocalTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? LocalTaxAmount { get; init; } 
    #else
    public System.Decimal? LocalTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Payment levy tax.
    /// </summary>
    [IsoId("_TegsR9p-Ed-ak6NoX_4Aeg_-1937352226")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Levy Tax Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? PaymentLevyTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PaymentLevyTaxAmount { get; init; } 
    #else
    public System.Decimal? PaymentLevyTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of country, national or federal tax charged by the jurisdiction in which the account servicer is located.
    /// </summary>
    [IsoId("_TegsSNp-Ed-ak6NoX_4Aeg_-1937352134")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Country National Federal Tax Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? CountryNationalFederalTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CountryNationalFederalTaxAmount { get; init; } 
    #else
    public System.Decimal? CountryNationalFederalTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_TegsSdp-Ed-ak6NoX_4Aeg_-1937351825")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Stamp Duty Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? StampDutyAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? StampDutyAmount { get; init; } 
    #else
    public System.Decimal? StampDutyAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_Tep2MNp-Ed-ak6NoX_4Aeg_-1937351733")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tax Reclaim Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? TaxReclaimAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxReclaimAmount { get; init; } 
    #else
    public System.Decimal? TaxReclaimAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of taxes that have been previously paid in relation to the taxable event.
    /// </summary>
    [IsoId("_Tep2Mdp-Ed-ak6NoX_4Aeg_-1937351641")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tax Credit Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? TaxCreditAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxCreditAmount { get; init; } 
    #else
    public System.Decimal? TaxCreditAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_Tep2Mtp-Ed-ak6NoX_4Aeg_-1937351580")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Withholding Of Foreign Tax Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? WithholdingOfForeignTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? WithholdingOfForeignTaxAmount { get; init; } 
    #else
    public System.Decimal? WithholdingOfForeignTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_Tep2M9p-Ed-ak6NoX_4Aeg_-1937351271")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Withholding Of Local Tax Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? WithholdingOfLocalTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? WithholdingOfLocalTaxAmount { get; init; } 
    #else
    public System.Decimal? WithholdingOfLocalTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of additional taxes that cannot be categorised.
    /// </summary>
    [IsoId("_Tep2NNp-Ed-ak6NoX_4Aeg_-1936431208")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Tax Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? AdditionalTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? AdditionalTaxAmount { get; init; } 
    #else
    public System.Decimal? AdditionalTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_Tep2Ndp-Ed-ak6NoX_4Aeg_-1936431123")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Withholding Tax Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? WithholdingTaxAmount { get; init; } 
    #else
    public System.Decimal? WithholdingTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of fiscal tax to apply.
    /// </summary>
    [IsoId("_Tep2Ntp-Ed-ak6NoX_4Aeg_-1936431031")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Fiscal Stamp Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? FiscalStampAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? FiscalStampAmount { get; init; } 
    #else
    public System.Decimal? FiscalStampAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_Tep2N9p-Ed-ak6NoX_4Aeg_-1248405467")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Executing Broker Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? ExecutingBrokerAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ExecutingBrokerAmount { get; init; } 
    #else
    public System.Decimal? ExecutingBrokerAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of paying/sub-paying agent commission.
    /// </summary>
    [IsoId("_Tep2ONp-Ed-ak6NoX_4Aeg_-1248405158")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Paying Agent Commission Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PayingAgentCommissionAmount { get; init; } 
    #else
    public System.Decimal? PayingAgentCommissionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Local broker's commission.
    /// </summary>
    [IsoId("_Tep2Odp-Ed-ak6NoX_4Aeg_-1248405066")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Local Broker Commission Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? LocalBrokerCommissionAmount { get; init; } 
    #else
    public System.Decimal? LocalBrokerCommissionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money paid for delivery by regular post mail.
    /// </summary>
    [IsoId("_TeznMNp-Ed-ak6NoX_4Aeg_-1248404974")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Postage Fee Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? PostageFeeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PostageFeeAmount { get; init; } 
    #else
    public System.Decimal? PostageFeeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money charged by a regulatory authority, eg, Securities and Exchange fees.
    /// </summary>
    [IsoId("_TeznMdp-Ed-ak6NoX_4Aeg_-1248404604")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Regulatory Fees Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? RegulatoryFeesAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? RegulatoryFeesAmount { get; init; } 
    #else
    public System.Decimal? RegulatoryFeesAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money (including insurance) paid for delivery by carrier.
    /// </summary>
    [IsoId("_TeznMtp-Ed-ak6NoX_4Aeg_-1247484541")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Shipping Fees Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? ShippingFeesAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ShippingFeesAmount { get; init; } 
    #else
    public System.Decimal? ShippingFeesAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_TeznM9p-Ed-ak6NoX_4Aeg_-1247484449")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Charges Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? ChargesAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ChargesAmount { get; init; } 
    #else
    public System.Decimal? ChargesAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
