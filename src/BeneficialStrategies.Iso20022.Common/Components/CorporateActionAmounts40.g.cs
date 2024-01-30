﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionAmounts40.  ISO2002 ID# _ctlWi5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies amounts in the framework of a corporate action event.
/// </summary>
public partial record CorporateActionAmounts40
{
    #nullable enable
    
    /// <summary>
    /// Amount of money before any deductions and allowances have been made.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? GrossCashAmount { get; init; } 
    /// <summary>
    /// Amount of money after deductions and allowances have been made, if any, that is, the total amount +/- charges/fees.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? NetCashAmount { get; init; } 
    /// <summary>
    /// Cash premium made available if the securities holder consents or participates to an event, for example consent fees or solicitation fees.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? SolicitationFees { get; init; } 
    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? CashInLieuOfShare { get; init; } 
    /// <summary>
    /// Amount of money distributed as the result of a capital gain.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? CapitalGain { get; init; } 
    /// <summary>
    /// Amount of money representing a coupon payment.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? InterestAmount { get; init; } 
    /// <summary>
    /// Amount of money resulting from a market claim.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? MarketClaimAmount { get; init; } 
    /// <summary>
    /// (Unique to France) Amount due to a buyer of securities dealt prior to ex date which may be subject to different rate of taxation.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? IndemnityAmount { get; init; } 
    /// <summary>
    /// Amount of money that the borrower pays to the lender as a compensation. It does not entitle the lender to reclaim any tax credit and is sometimes treated differently by the local tax authorities of the lender. Also covers compensation/indemnity of missed dividend concerning early/late settlements if applicable to a market.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? ManufacturedDividendPaymentAmount { get; init; } 
    /// <summary>
    /// Amount of money reinvested in additional securities.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? ReinvestmentAmount { get; init; } 
    /// <summary>
    /// Amount resulting from a fully franked dividend paid by a company; amount includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? FullyFrankedAmount { get; init; } 
    /// <summary>
    /// Amount resulting from an unfranked dividend paid by a company; the amount does not include tax credit and is subject to withholding tax.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? UnfrankedAmount { get; init; } 
    /// <summary>
    /// Amount of money related to taxable income that cannot be categorised.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? SundryOrOtherAmount { get; init; } 
    /// <summary>
    /// Amount of money that has not been subject to taxation.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? TaxFreeAmount { get; init; } 
    /// <summary>
    /// Amount of income eligible for deferred taxation.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? TaxDeferredAmount { get; init; } 
    /// <summary>
    /// Amount of value added tax.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? ValueAddedTaxAmount { get; init; } 
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? StampDutyAmount { get; init; } 
    /// <summary>
    /// Amount that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? TaxReclaimAmount { get; init; } 
    /// <summary>
    /// Amount of taxes that have been previously paid in relation to the taxable event.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? TaxCreditAmount { get; init; } 
    /// <summary>
    /// Amount of additional taxes that cannot be categorised.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? AdditionalTaxAmount { get; init; } 
    /// <summary>
    /// Amount of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; } 
    /// <summary>
    /// Amount of money withheld by the jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    public IsoActiveCurrencyAndAmount? SecondLevelTaxAmount { get; init; } 
    /// <summary>
    /// Amount of fiscal tax to apply.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? FiscalStampAmount { get; init; } 
    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? ExecutingBrokerAmount { get; init; } 
    /// <summary>
    /// Amount of paying/sub-paying agent commission.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; init; } 
    /// <summary>
    /// Local broker's commission.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; init; } 
    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, securities and exchange fees.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? RegulatoryFeesAmount { get; init; } 
    /// <summary>
    /// All costs related to the physical delivery of documents such as stamps, postage, carrier fees, insurances or messenger services.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? ShippingFeesAmount { get; init; } 
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? ChargesAmount { get; init; } 
    /// <summary>
    /// Cash amount based on terms of corporate action event and balance of underlying securities, entitled to/from account owner (which may be positive or negative).
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? EntitledAmount { get; init; } 
    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? OriginalAmount { get; init; } 
    /// <summary>
    /// Amount of interest that has been accrued in between coupon payment periods.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    /// <summary>
    /// Amount relating to the underlying security for which income is distributed.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? IncomePortion { get; init; } 
    /// <summary>
    /// Portion of the fund distribution amount which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? EqualisationAmount { get; init; } 
    /// <summary>
    /// FATCA (Foreign Account Tax Compliance Act) related tax amount.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? FATCATaxAmount { get; init; } 
    /// <summary>
    /// Amount of tax related income subject to NRA (Non Resident Alien).
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? NRATaxAmount { get; init; } 
    /// <summary>
    /// Amount of tax related to back up withholding.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? BackUpWithholdingTaxAmount { get; init; } 
    /// <summary>
    /// Amount of overall tax withheld at source by fund managers prior to considering the tax obligation of each unit holder.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? TaxOnIncomeAmount { get; init; } 
    /// <summary>
    /// Amount of Transaction tax.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? TransactionTax { get; init; } 
    
    #nullable disable
}
