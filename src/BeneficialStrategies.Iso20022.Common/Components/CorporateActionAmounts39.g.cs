﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionAmounts39.  ISO2002 ID# _ckK7iZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies amounts in the framework of a corporate action event.
/// </summary>
[DataContract]
[XmlType]
public partial record CorporateActionAmounts39
{
    #nullable enable
    
    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    [DataMember]
    public required IsoRestrictedFINActiveCurrencyAndAmount PostingAmount { get; init; } 
    /// <summary>
    /// Amount of money before any deductions and allowances have been made.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? GrossCashAmount { get; init; } 
    /// <summary>
    /// Amount of money after deductions and allowances have been made, if any, that is, the total amount +/- charges/fees.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? NetCashAmount { get; init; } 
    /// <summary>
    /// Cash premium made available if the securities holder consents or participates to an event, for example consent fees or solicitation fees.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? SolicitationFees { get; init; } 
    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? CashInLieuOfShare { get; init; } 
    /// <summary>
    /// Amount of money distributed as the result of a capital gain.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? CapitalGain { get; init; } 
    /// <summary>
    /// Amount of money representing a coupon payment.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? InterestAmount { get; init; } 
    /// <summary>
    /// Amount of money resulting from a market claim.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? MarketClaimAmount { get; init; } 
    /// <summary>
    /// (Unique to France) Amount due to a buyer of securities dealt prior to ex date which may be subject to different rate of taxation.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? IndemnityAmount { get; init; } 
    /// <summary>
    /// Amount of money that the borrower pays to the lender as a compensation. It does not entitle the lender to reclaim any tax credit and is sometimes treated differently by the local tax authorities of the lender. Also covers compensation/indemnity of missed dividend concerning early/late settlements if applicable to a market.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? ManufacturedDividendPaymentAmount { get; init; } 
    /// <summary>
    /// Amount of money reinvested in additional securities.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? ReinvestmentAmount { get; init; } 
    /// <summary>
    /// Amount resulting from a fully franked dividend paid by a company; amount includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? FullyFrankedAmount { get; init; } 
    /// <summary>
    /// Amount resulting from an unfranked dividend paid by a company; the amount does not include tax credit and is subject to withholding tax.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? UnfrankedAmount { get; init; } 
    /// <summary>
    /// Amount of money related to taxable income that cannot be categorised.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? SundryOrOtherAmount { get; init; } 
    /// <summary>
    /// Amount of money that has not been subject to taxation.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? TaxFreeAmount { get; init; } 
    /// <summary>
    /// Amount of income eligible for deferred taxation.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? TaxDeferredAmount { get; init; } 
    /// <summary>
    /// Tax on value added.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? ValueAddedTaxAmount { get; init; } 
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? StampDutyAmount { get; init; } 
    /// <summary>
    /// Amount that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? TaxReclaimAmount { get; init; } 
    /// <summary>
    /// Amount of taxes that have been previously paid in relation to the taxable event.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? TaxCreditAmount { get; init; } 
    /// <summary>
    /// Amount of additional taxes that cannot be categorised.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? AdditionalTaxAmount { get; init; } 
    /// <summary>
    /// Amount of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; } 
    /// <summary>
    /// Amount of money withheld by the jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? SecondLevelTaxAmount { get; init; } 
    /// <summary>
    /// Amount of fiscal tax to apply.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? FiscalStampAmount { get; init; } 
    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? ExecutingBrokerAmount { get; init; } 
    /// <summary>
    /// Amount of paying/sub-paying agent commission.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; init; } 
    /// <summary>
    /// Local broker's commission.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; init; } 
    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? RegulatoryFeesAmount { get; init; } 
    /// <summary>
    /// All costs related to the physical delivery of documents such as stamps, postage, carrier fees, insurances or messenger services.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? ShippingFeesAmount { get; init; } 
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? ChargesAmount { get; init; } 
    /// <summary>
    /// Indicates cash retained from previous dividend.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? CashAmountBroughtForward { get; init; } 
    /// <summary>
    /// Indicates the balance carried forward to next dividend.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? CashAmountCarriedForward { get; init; } 
    /// <summary>
    /// Amount of cash that would have been payable if the dividend had been taken in the form of cash rather than shares.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? NotionalDividendPayableAmount { get; init; } 
    /// <summary>
    /// Where new securities are issued in lieu of a cash dividend, the notional tax is the tax on the amount of cash that would have been paid.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? NotionalTaxAmount { get; init; } 
    /// <summary>
    /// Amount of money paid by the Tax Authorities in addition to the payment of the tax refund itself.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? TaxArrearsAmount { get; init; } 
    /// <summary>
    /// Posting/settlement Amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? OriginalAmount { get; init; } 
    /// <summary>
    /// Amount of money representing a distribution of a bond's principal, for example, repayment of outstanding debt.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? PrincipalOrCorpus { get; init; } 
    /// <summary>
    /// Amount of money (not interest) in addition to the principal at the redemption of a bond.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? RedemptionPremiumAmount { get; init; } 
    /// <summary>
    /// Amount relating to the underlying security for which income is distributed.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? IncomePortion { get; init; } 
    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? StockExchangeTax { get; init; } 
    /// <summary>
    /// Total amount of tax withheld at source in conformance with the EU Savings Directive.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? EUTaxRetentionAmount { get; init; } 
    /// <summary>
    /// Amount of interest that has been accrued in between coupon payment periods.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    /// <summary>
    /// Portion of the fund distribution amount which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? EqualisationAmount { get; init; } 
    /// <summary>
    /// FATCA (Foreign Account Tax Compliance Act) related tax amount.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? FATCATaxAmount { get; init; } 
    /// <summary>
    /// Amount of tax related income subject to NRA (Non Resident Alien).
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? NRATaxAmount { get; init; } 
    /// <summary>
    /// Amount of tax related to back up withholding.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? BackUpWithholdingTaxAmount { get; init; } 
    /// <summary>
    /// Amount of overall tax withheld at source by fund managers prior to considering the tax obligation of each unit holder.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? TaxOnIncomeAmount { get; init; } 
    /// <summary>
    /// Amount of Transaction tax.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAndAmount? TransactionTax { get; init; } 
    
    #nullable disable
}
