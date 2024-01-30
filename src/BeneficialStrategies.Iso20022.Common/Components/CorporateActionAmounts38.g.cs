﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionAmounts38.  ISO2002 ID# _99kH4WXlEeWht50_j0HXAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies amounts in the framework of a corporate action event.
/// </summary>
public partial record CorporateActionAmounts38
{
    #nullable enable
    
    /// <summary>
    /// Amount of money before any deductions and allowances have been made.
    /// </summary>
    public IsoActiveCurrencyAndAmount? GrossCashAmount { get; init; } 
    /// <summary>
    /// Amount of money after deductions and allowances have been made, if any, that is, the total amount +/- charges/fees.
    /// </summary>
    public IsoActiveCurrencyAndAmount? NetCashAmount { get; init; } 
    /// <summary>
    /// Cash premium made available if the securities holder consents or participates to an event, for example consent fees or solicitation fees.
    /// </summary>
    public IsoActiveCurrencyAndAmount? SolicitationFees { get; init; } 
    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    public IsoActiveCurrencyAndAmount? CashInLieuOfShare { get; init; } 
    /// <summary>
    /// Amount of money distributed as the result of a capital gain.
    /// </summary>
    public IsoActiveCurrencyAndAmount? CapitalGain { get; init; } 
    /// <summary>
    /// Amount of money representing a coupon payment.
    /// </summary>
    public IsoActiveCurrencyAndAmount? InterestAmount { get; init; } 
    /// <summary>
    /// Amount of money resulting from a market claim.
    /// </summary>
    public IsoActiveCurrencyAndAmount? MarketClaimAmount { get; init; } 
    /// <summary>
    /// (Unique to France) Amount due to a buyer of securities dealt prior to ex date which may be subject to different rate of taxation.
    /// </summary>
    public IsoActiveCurrencyAndAmount? IndemnityAmount { get; init; } 
    /// <summary>
    /// Amount of money that the borrower pays to the lender as a compensation. It does not entitle the lender to reclaim any tax credit and is sometimes treated differently by the local tax authorities of the lender. Also covers compensation/indemnity of missed dividend concerning early/late settlements if applicable to a market.
    /// </summary>
    public IsoActiveCurrencyAndAmount? ManufacturedDividendPaymentAmount { get; init; } 
    /// <summary>
    /// Amount of money reinvested in additional securities.
    /// </summary>
    public IsoActiveCurrencyAndAmount? ReinvestmentAmount { get; init; } 
    /// <summary>
    /// Amount resulting from a fully franked dividend paid by a company; amount includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// </summary>
    public IsoActiveCurrencyAndAmount? FullyFrankedAmount { get; init; } 
    /// <summary>
    /// Amount resulting from an unfranked dividend paid by a company; the amount does not include tax credit and is subject to withholding tax.
    /// </summary>
    public IsoActiveCurrencyAndAmount? UnfrankedAmount { get; init; } 
    /// <summary>
    /// Amount of money related to taxable income that cannot be categorised.
    /// </summary>
    public IsoActiveCurrencyAndAmount? SundryOrOtherAmount { get; init; } 
    /// <summary>
    /// Amount of money that has not been subject to taxation.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TaxFreeAmount { get; init; } 
    /// <summary>
    /// Amount of income eligible for deferred taxation.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TaxDeferredAmount { get; init; } 
    /// <summary>
    /// Amount of value added tax.
    /// </summary>
    public IsoActiveCurrencyAndAmount? ValueAddedTaxAmount { get; init; } 
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    public IsoActiveCurrencyAndAmount? StampDutyAmount { get; init; } 
    /// <summary>
    /// Amount that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TaxReclaimAmount { get; init; } 
    /// <summary>
    /// Amount of taxes that have been previously paid in relation to the taxable event.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TaxCreditAmount { get; init; } 
    /// <summary>
    /// Amount of additional taxes that cannot be categorised.
    /// </summary>
    public IsoActiveCurrencyAndAmount? AdditionalTaxAmount { get; init; } 
    /// <summary>
    /// Amount of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    public IsoActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; } 
    /// <summary>
    /// Amount of money withheld by the jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    public IsoActiveCurrencyAndAmount? SecondLevelTaxAmount { get; init; } 
    /// <summary>
    /// Amount of fiscal tax to apply.
    /// </summary>
    public IsoActiveCurrencyAndAmount? FiscalStampAmount { get; init; } 
    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    public IsoActiveCurrencyAndAmount? ExecutingBrokerAmount { get; init; } 
    /// <summary>
    /// Amount of paying/sub-paying agent commission.
    /// </summary>
    public IsoActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; init; } 
    /// <summary>
    /// Local broker's commission.
    /// </summary>
    public IsoActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; init; } 
    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, securities and exchange fees.
    /// </summary>
    public IsoActiveCurrencyAndAmount? RegulatoryFeesAmount { get; init; } 
    /// <summary>
    /// All costs related to the physical delivery of documents such as stamps, postage, carrier fees, insurances or messenger services.
    /// </summary>
    public IsoActiveCurrencyAndAmount? ShippingFeesAmount { get; init; } 
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    public IsoActiveCurrencyAndAmount? ChargesAmount { get; init; } 
    /// <summary>
    /// Cash amount based on terms of corporate action event and balance of underlying securities, entitled to/from account owner (which may be positive or negative).
    /// </summary>
    public IsoActiveCurrencyAndAmount? EntitledAmount { get; init; } 
    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    public IsoActiveCurrencyAndAmount? OriginalAmount { get; init; } 
    /// <summary>
    /// Amount of interest that has been accrued in between coupon payment periods.
    /// </summary>
    public IsoActiveCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    /// <summary>
    /// Amount relating to the underlying security for which income is distributed.
    /// </summary>
    public IsoActiveCurrencyAndAmount? IncomePortion { get; init; } 
    /// <summary>
    /// Portion of the fund distribution amount which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    public IsoActiveCurrencyAndAmount? EqualisationAmount { get; init; } 
    /// <summary>
    /// FATCA (Foreign Account Tax Compliance Act) related tax amount.
    /// </summary>
    public IsoActiveCurrencyAndAmount? FATCATaxAmount { get; init; } 
    /// <summary>
    /// Amount of tax related income subject to NRA (Non Resident Alien).
    /// </summary>
    public IsoActiveCurrencyAndAmount? NRATaxAmount { get; init; } 
    /// <summary>
    /// Amount of tax related to back up withholding.
    /// </summary>
    public IsoActiveCurrencyAndAmount? BackUpWithholdingTaxAmount { get; init; } 
    /// <summary>
    /// Amount of overall tax withheld at source by fund managers prior to considering the tax obligation of each unit holder.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TaxOnIncomeAmount { get; init; } 
    /// <summary>
    /// Amount of Transaction tax.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TransactionTax { get; init; } 
    
    #nullable disable
}
