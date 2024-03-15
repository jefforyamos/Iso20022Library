﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionAmounts46.  ISO2002 ID# _k9uwj83xEee5nJBZsW8MFQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
[IsoId("_k9uwj83xEee5nJBZsW8MFQ")]
[DisplayName("Corporate Action Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionAmounts46
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
    [IsoId("_k9uwk83xEee5nJBZsW8MFQ")]
    [DisplayName("Gross Cash Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssCshAmt")]
    #endif
    [IsoXmlTag("GrssCshAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? GrossCashAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? GrossCashAmount { get; init; } 
    #else
    public System.Decimal? GrossCashAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money after deductions and allowances have been made, if any, that is, the total amount +/- charges/fees.
    /// </summary>
    [IsoId("_k9uwm83xEee5nJBZsW8MFQ")]
    [DisplayName("Net Cash Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetCshAmt")]
    #endif
    [IsoXmlTag("NetCshAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? NetCashAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? NetCashAmount { get; init; } 
    #else
    public System.Decimal? NetCashAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Cash premium made available if the securities holder consents or participates to an event, for example consent fees or solicitation fees.
    /// </summary>
    [IsoId("_k9uwo83xEee5nJBZsW8MFQ")]
    [DisplayName("Solicitation Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SlctnFees")]
    #endif
    [IsoXmlTag("SlctnFees")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? SolicitationFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? SolicitationFees { get; init; } 
    #else
    public System.Decimal? SolicitationFees { get; set; } 
    #endif
    
    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    [IsoId("_k9uwq83xEee5nJBZsW8MFQ")]
    [DisplayName("Cash In Lieu Of Share")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshInLieuOfShr")]
    #endif
    [IsoXmlTag("CshInLieuOfShr")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? CashInLieuOfShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CashInLieuOfShare { get; init; } 
    #else
    public System.Decimal? CashInLieuOfShare { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money distributed as the result of a capital gain.
    /// </summary>
    [IsoId("_k9uws83xEee5nJBZsW8MFQ")]
    [DisplayName("Capital Gain")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CptlGn")]
    #endif
    [IsoXmlTag("CptlGn")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? CapitalGain { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CapitalGain { get; init; } 
    #else
    public System.Decimal? CapitalGain { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money representing a coupon payment.
    /// </summary>
    [IsoId("_k9uwu83xEee5nJBZsW8MFQ")]
    [DisplayName("Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstAmt")]
    #endif
    [IsoXmlTag("IntrstAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? InterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? InterestAmount { get; init; } 
    #else
    public System.Decimal? InterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money resulting from a market claim.
    /// </summary>
    [IsoId("_k9uww83xEee5nJBZsW8MFQ")]
    [DisplayName("Market Claim Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktClmAmt")]
    #endif
    [IsoXmlTag("MktClmAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? MarketClaimAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? MarketClaimAmount { get; init; } 
    #else
    public System.Decimal? MarketClaimAmount { get; set; } 
    #endif
    
    /// <summary>
    /// (Unique to France) Amount due to a buyer of securities dealt prior to ex date which may be subject to different rate of taxation.
    /// </summary>
    [IsoId("_k9uwy83xEee5nJBZsW8MFQ")]
    [DisplayName("Indemnity Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndmntyAmt")]
    #endif
    [IsoXmlTag("IndmntyAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? IndemnityAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? IndemnityAmount { get; init; } 
    #else
    public System.Decimal? IndemnityAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that the borrower pays to the lender as a compensation. It does not entitle the lender to reclaim any tax credit and is sometimes treated differently by the local tax authorities of the lender. Also covers compensation/indemnity of missed dividend concerning early/late settlements if applicable to a market.
    /// </summary>
    [IsoId("_k9uw083xEee5nJBZsW8MFQ")]
    [DisplayName("Manufactured Dividend Payment Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ManfctrdDvddPmtAmt")]
    #endif
    [IsoXmlTag("ManfctrdDvddPmtAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? ManufacturedDividendPaymentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ManufacturedDividendPaymentAmount { get; init; } 
    #else
    public System.Decimal? ManufacturedDividendPaymentAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money reinvested in additional securities.
    /// </summary>
    [IsoId("_k9uw1c3xEee5nJBZsW8MFQ")]
    [DisplayName("Reinvestment Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RinvstmtAmt")]
    #endif
    [IsoXmlTag("RinvstmtAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? ReinvestmentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ReinvestmentAmount { get; init; } 
    #else
    public System.Decimal? ReinvestmentAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount resulting from a fully franked dividend paid by a company; amount includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// </summary>
    [IsoId("_k9uw3c3xEee5nJBZsW8MFQ")]
    [DisplayName("Fully Franked Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FullyFrnkdAmt")]
    #endif
    [IsoXmlTag("FullyFrnkdAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? FullyFrankedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? FullyFrankedAmount { get; init; } 
    #else
    public System.Decimal? FullyFrankedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount resulting from an unfranked dividend paid by a company; the amount does not include tax credit and is subject to withholding tax.
    /// </summary>
    [IsoId("_k9uw5c3xEee5nJBZsW8MFQ")]
    [DisplayName("Unfranked Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UfrnkdAmt")]
    #endif
    [IsoXmlTag("UfrnkdAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? UnfrankedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? UnfrankedAmount { get; init; } 
    #else
    public System.Decimal? UnfrankedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money related to taxable income that cannot be categorised.
    /// </summary>
    [IsoId("_k9uw7c3xEee5nJBZsW8MFQ")]
    [DisplayName("Sundry Or Other Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndryOrOthrAmt")]
    #endif
    [IsoXmlTag("SndryOrOthrAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? SundryOrOtherAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? SundryOrOtherAmount { get; init; } 
    #else
    public System.Decimal? SundryOrOtherAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that has not been subject to taxation.
    /// </summary>
    [IsoId("_k9uw9c3xEee5nJBZsW8MFQ")]
    [DisplayName("Tax Free Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxFreeAmt")]
    #endif
    [IsoXmlTag("TaxFreeAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? TaxFreeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxFreeAmount { get; init; } 
    #else
    public System.Decimal? TaxFreeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of income eligible for deferred taxation.
    /// </summary>
    [IsoId("_k9uw_c3xEee5nJBZsW8MFQ")]
    [DisplayName("Tax Deferred Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxDfrrdAmt")]
    #endif
    [IsoXmlTag("TaxDfrrdAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? TaxDeferredAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxDeferredAmount { get; init; } 
    #else
    public System.Decimal? TaxDeferredAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of value added tax.
    /// </summary>
    [IsoId("_k9uxBc3xEee5nJBZsW8MFQ")]
    [DisplayName("Value Added Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValAddedTaxAmt")]
    #endif
    [IsoXmlTag("ValAddedTaxAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? ValueAddedTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ValueAddedTaxAmount { get; init; } 
    #else
    public System.Decimal? ValueAddedTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_k9uxDc3xEee5nJBZsW8MFQ")]
    [DisplayName("Stamp Duty Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmpDtyAmt")]
    #endif
    [IsoXmlTag("StmpDtyAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? StampDutyAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? StampDutyAmount { get; init; } 
    #else
    public System.Decimal? StampDutyAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_k9uxFc3xEee5nJBZsW8MFQ")]
    [DisplayName("Tax Reclaim Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRclmAmt")]
    #endif
    [IsoXmlTag("TaxRclmAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? TaxReclaimAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxReclaimAmount { get; init; } 
    #else
    public System.Decimal? TaxReclaimAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of taxes that have been previously paid in relation to the taxable event.
    /// </summary>
    [IsoId("_k9uxHc3xEee5nJBZsW8MFQ")]
    [DisplayName("Tax Credit Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxCdtAmt")]
    #endif
    [IsoXmlTag("TaxCdtAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? TaxCreditAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxCreditAmount { get; init; } 
    #else
    public System.Decimal? TaxCreditAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of additional taxes that cannot be categorised.
    /// </summary>
    [IsoId("_k9uxJc3xEee5nJBZsW8MFQ")]
    [DisplayName("Additional Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlTaxAmt")]
    #endif
    [IsoXmlTag("AddtlTaxAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? AdditionalTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? AdditionalTaxAmount { get; init; } 
    #else
    public System.Decimal? AdditionalTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_k9uxLc3xEee5nJBZsW8MFQ")]
    [DisplayName("Withholding Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgTaxAmt")]
    #endif
    [IsoXmlTag("WhldgTaxAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? WithholdingTaxAmount { get; init; } 
    #else
    public System.Decimal? WithholdingTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money withheld by the jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    [IsoId("_k9uxNc3xEee5nJBZsW8MFQ")]
    [DisplayName("Second Level Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndLvlTaxAmt")]
    #endif
    [IsoXmlTag("ScndLvlTaxAmt")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? SecondLevelTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? SecondLevelTaxAmount { get; init; } 
    #else
    public System.Decimal? SecondLevelTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of fiscal tax to apply.
    /// </summary>
    [IsoId("_k9uxN83xEee5nJBZsW8MFQ")]
    [DisplayName("Fiscal Stamp Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FsclStmpAmt")]
    #endif
    [IsoXmlTag("FsclStmpAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? FiscalStampAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? FiscalStampAmount { get; init; } 
    #else
    public System.Decimal? FiscalStampAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_k9uxP83xEee5nJBZsW8MFQ")]
    [DisplayName("Executing Broker Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctgBrkrAmt")]
    #endif
    [IsoXmlTag("ExctgBrkrAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? ExecutingBrokerAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ExecutingBrokerAmount { get; init; } 
    #else
    public System.Decimal? ExecutingBrokerAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of paying/sub-paying agent commission.
    /// </summary>
    [IsoId("_k9uxR83xEee5nJBZsW8MFQ")]
    [DisplayName("Paying Agent Commission Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PngAgtComssnAmt")]
    #endif
    [IsoXmlTag("PngAgtComssnAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PayingAgentCommissionAmount { get; init; } 
    #else
    public System.Decimal? PayingAgentCommissionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Local broker&apos;s commission.
    /// </summary>
    [IsoId("_k9vWwc3xEee5nJBZsW8MFQ")]
    [DisplayName("Local Broker Commission Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclBrkrComssnAmt")]
    #endif
    [IsoXmlTag("LclBrkrComssnAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? LocalBrokerCommissionAmount { get; init; } 
    #else
    public System.Decimal? LocalBrokerCommissionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, securities and exchange fees.
    /// </summary>
    [IsoId("_k9vWyc3xEee5nJBZsW8MFQ")]
    [DisplayName("Regulatory Fees Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RgltryFeesAmt")]
    #endif
    [IsoXmlTag("RgltryFeesAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? RegulatoryFeesAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? RegulatoryFeesAmount { get; init; } 
    #else
    public System.Decimal? RegulatoryFeesAmount { get; set; } 
    #endif
    
    /// <summary>
    /// All costs related to the physical delivery of documents such as stamps, postage, carrier fees, insurances or messenger services.
    /// </summary>
    [IsoId("_k9vW0c3xEee5nJBZsW8MFQ")]
    [DisplayName("Shipping Fees Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShppgFeesAmt")]
    #endif
    [IsoXmlTag("ShppgFeesAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? ShippingFeesAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ShippingFeesAmount { get; init; } 
    #else
    public System.Decimal? ShippingFeesAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_k9vW2c3xEee5nJBZsW8MFQ")]
    [DisplayName("Charges Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsAmt")]
    #endif
    [IsoXmlTag("ChrgsAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? ChargesAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ChargesAmount { get; init; } 
    #else
    public System.Decimal? ChargesAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Cash amount based on the terms of the corporate action event and balance of underlying securities, entitled to/from account owner (which may be positive or negative).
    /// </summary>
    [IsoId("_k9vW4c3xEee5nJBZsW8MFQ")]
    [DisplayName("Entitled Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EntitldAmt")]
    #endif
    [IsoXmlTag("EntitldAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? EntitledAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? EntitledAmount { get; init; } 
    #else
    public System.Decimal? EntitledAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_k9vW6c3xEee5nJBZsW8MFQ")]
    [DisplayName("Original Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlAmt")]
    #endif
    [IsoXmlTag("OrgnlAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? OriginalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? OriginalAmount { get; init; } 
    #else
    public System.Decimal? OriginalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of interest that has been accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_k9vW8c3xEee5nJBZsW8MFQ")]
    [DisplayName("Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstAmt")]
    #endif
    [IsoXmlTag("AcrdIntrstAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? AccruedInterestAmount { get; init; } 
    #else
    public System.Decimal? AccruedInterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount relating to the underlying security for which income is distributed.
    /// </summary>
    [IsoId("_k9vW-c3xEee5nJBZsW8MFQ")]
    [DisplayName("Income Portion")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmPrtn")]
    #endif
    [IsoXmlTag("IncmPrtn")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? IncomePortion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? IncomePortion { get; init; } 
    #else
    public System.Decimal? IncomePortion { get; set; } 
    #endif
    
    /// <summary>
    /// Portion of the fund distribution amount which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    [IsoId("_k9vXAc3xEee5nJBZsW8MFQ")]
    [DisplayName("Equalisation Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EqulstnAmt")]
    #endif
    [IsoXmlTag("EqulstnAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? EqualisationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? EqualisationAmount { get; init; } 
    #else
    public System.Decimal? EqualisationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// FATCA (Foreign Account Tax Compliance Act) related tax amount.
    /// </summary>
    [IsoId("_k9vXA83xEee5nJBZsW8MFQ")]
    [DisplayName("FATCA Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FATCATaxAmt")]
    #endif
    [IsoXmlTag("FATCATaxAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? FATCATaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? FATCATaxAmount { get; init; } 
    #else
    public System.Decimal? FATCATaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of tax related income subject to NRA (Non Resident Alien).
    /// </summary>
    [IsoId("_k9vXBc3xEee5nJBZsW8MFQ")]
    [DisplayName("NRA Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NRATaxAmt")]
    #endif
    [IsoXmlTag("NRATaxAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? NRATaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? NRATaxAmount { get; init; } 
    #else
    public System.Decimal? NRATaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of tax related to back up withholding.
    /// </summary>
    [IsoId("_k9vXB83xEee5nJBZsW8MFQ")]
    [DisplayName("Back Up Withholding Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BckUpWhldgTaxAmt")]
    #endif
    [IsoXmlTag("BckUpWhldgTaxAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? BackUpWithholdingTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? BackUpWithholdingTaxAmount { get; init; } 
    #else
    public System.Decimal? BackUpWithholdingTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of overall tax withheld at source by fund managers prior to considering the tax obligation of each unit holder.
    /// </summary>
    [IsoId("_k9vXCc3xEee5nJBZsW8MFQ")]
    [DisplayName("Tax On Income Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxOnIncmAmt")]
    #endif
    [IsoXmlTag("TaxOnIncmAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? TaxOnIncomeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxOnIncomeAmount { get; init; } 
    #else
    public System.Decimal? TaxOnIncomeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    [IsoId("_k9vXC83xEee5nJBZsW8MFQ")]
    [DisplayName("Transaction Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTax")]
    #endif
    [IsoXmlTag("TxTax")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? TransactionTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TransactionTax { get; init; } 
    #else
    public System.Decimal? TransactionTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of proceeds which is not actually paid to the security holder but on which withholding tax is applicable.
    /// </summary>
    [IsoId("_k9vXDc3xEee5nJBZsW8MFQ")]
    [DisplayName("Deemed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmdAmt")]
    #endif
    [IsoXmlTag("DmdAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? DeemedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? DeemedAmount { get; init; } 
    #else
    public System.Decimal? DeemedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount relating to a conduit foreign income.
    /// </summary>
    [IsoId("_k9vXD83xEee5nJBZsW8MFQ")]
    [DisplayName("Conduit Foreign Income Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CndtFrgnIncmAmt")]
    #endif
    [IsoXmlTag("CndtFrgnIncmAmt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? ConduitForeignIncomeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ConduitForeignIncomeAmount { get; init; } 
    #else
    public System.Decimal? ConduitForeignIncomeAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
