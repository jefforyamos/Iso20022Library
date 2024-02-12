﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FXAmountTypeCode.  ISO2002 ID# _7XcKNQNyEe2-vqzwMUAewg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of amount for foreign exchange commissions or fees.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7XcKNQNyEe2-vqzwMUAewg")]
[Description(@"Specifies the type of amount for foreign exchange commissions or fees.")]
[Derivations(typeof(FXAmountType1Code))]
public enum FXAmountTypeCode
{
    /// <summary>
    /// Tax is on income deducted at source, which the paying agent is legally obliged to deduct from its payments of interest on deposits and other proceeds of a financial instrument.
    /// Encoded/decoded by serializers as "WITH".
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_7XdYLgNyEe2-vqzwMUAewg")]
    [Description(@"Tax is on income deducted at source, which the paying agent is legally obliged to deduct from its payments of interest on deposits and other proceeds of a financial instrument.")]
    WithholdingTax,
    
    /// <summary>
    /// Tax is on certain documents and transactions.
    /// Encoded/decoded by serializers as "STAM".
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_7XdYHANyEe2-vqzwMUAewg")]
    [Description(@"Tax is on certain documents and transactions.")]
    StampDuty,
    
    /// <summary>
    /// Investor's subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// Encoded/decoded by serializers as "EQUL".
    /// </summary>
    [EnumMember(Value = "EQUL")]
    [IsoId("_7XdYEgNyEe2-vqzwMUAewg")]
    [Description(@"Investor's subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.")]
    Equalisation,
    
    /// <summary>
    /// Tax that is levied on goods and services purchased by customers, and is added to the retail price.
    /// Encoded/decoded by serializers as "COAX".
    /// </summary>
    [EnumMember(Value = "COAX")]
    [IsoId("_7XdYMANyEe2-vqzwMUAewg")]
    [Description(@"Tax that is levied on goods and services purchased by customers, and is added to the retail price.")]
    ConsumptionTax,
    
    /// <summary>
    /// Tax that is charged by a local settlement system or local jurisdiction.
    /// Encoded/decoded by serializers as "LOCL".
    /// </summary>
    [EnumMember(Value = "LOCL")]
    [IsoId("_7XdYGgNyEe2-vqzwMUAewg")]
    [Description(@"Tax that is charged by a local settlement system or local jurisdiction.")]
    LocalTax,
    
    /// <summary>
    /// Tax is a country, national, or federal tax that is usually charged by the custodian.
    /// Encoded/decoded by serializers as "COUN".
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_7XdYJANyEe2-vqzwMUAewg")]
    [Description(@"Tax is a country, national, or federal tax that is usually charged by the custodian.")]
    NationalFederalTax,
    
    /// <summary>
    /// Tax collected by a stock exchange.
    /// Encoded/decoded by serializers as "STEX".
    /// </summary>
    [EnumMember(Value = "STEX")]
    [IsoId("_7XdYJwNyEe2-vqzwMUAewg")]
    [Description(@"Tax collected by a stock exchange.")]
    StockExchangeTax,
    
    /// <summary>
    /// Tax levied on a transaction.
    /// Encoded/decoded by serializers as "TRAX".
    /// </summary>
    [EnumMember(Value = "TRAX")]
    [IsoId("_7XdYFgNyEe2-vqzwMUAewg")]
    [Description(@"Tax levied on a transaction.")]
    TransactionTax,
    
    /// <summary>
    /// Tax levied on a transfer.
    /// Encoded/decoded by serializers as "TRAN".
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_7XcKNwNyEe2-vqzwMUAewg")]
    [Description(@"Tax levied on a transfer.")]
    TransferTax,
    
    /// <summary>
    /// Tax is a value added tax.
    /// Encoded/decoded by serializers as "VATA".
    /// </summary>
    [EnumMember(Value = "VATA")]
    [IsoId("_7XdYGANyEe2-vqzwMUAewg")]
    [Description(@"Tax is a value added tax.")]
    ValueAddedTax,
    
    /// <summary>
    /// Local broker's commission amount.
    /// Encoded/decoded by serializers as "LOCO".
    /// </summary>
    [EnumMember(Value = "LOCO")]
    [IsoId("_7XdYEANyEe2-vqzwMUAewg")]
    [Description(@"Local broker's commission amount.")]
    LocalBrokerCommission,
    
    /// <summary>
    /// Executing broker's commission amount.
    /// Encoded/decoded by serializers as "EXEC".
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_7XdYMwNyEe2-vqzwMUAewg")]
    [Description(@"Executing broker's commission amount.")]
    ExecutingBrokerCommission,
    
    /// <summary>
    /// Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.
    /// Encoded/decoded by serializers as "EUTR".
    /// </summary>
    [EnumMember(Value = "EUTR")]
    [IsoId("_7XdYEQNyEe2-vqzwMUAewg")]
    [Description(@"Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.")]
    EUTaxRetention,
    
    /// <summary>
    /// Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the old Investment Tax Act (Investmentsteuergesetz).
    /// Encoded/decoded by serializers as "AKTI".
    /// </summary>
    [EnumMember(Value = "AKTI")]
    [IsoId("_7XdYIANyEe2-vqzwMUAewg")]
    [Description(@"Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the old Investment Tax Act (Investmentsteuergesetz).")]
    Aktiengewinn,
    
    /// <summary>
    /// Zwischengewinn.
    /// Encoded/decoded by serializers as "ZWIS".
    /// </summary>
    [EnumMember(Value = "ZWIS")]
    [IsoId("_7XdYEwNyEe2-vqzwMUAewg")]
    [Description(@"Zwischengewinn.")]
    Zwischengewinn,
    
    /// <summary>
    /// Another type of commission or fees.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_7XdYMQNyEe2-vqzwMUAewg")]
    [Description(@"Another type of commission or fees.")]
    OtherAmount,
    
    /// <summary>
    /// Local tax (Zinstopf) offset interest per unit against tax exempt amount (variation to offset interest per unit in relation to tax exempt amount).
    /// Encoded/decoded by serializers as "LOTE".
    /// </summary>
    [EnumMember(Value = "LOTE")]
    [IsoId("_7XdYHQNyEe2-vqzwMUAewg")]
    [Description(@"Local tax (Zinstopf) offset interest per unit against tax exempt amount (variation to offset interest per unit in relation to tax exempt amount).")]
    GermanLocalTax3,
    
    /// <summary>
    /// Local tax (Ertrag Besitzanteilig) yield liable for interest down payment tax.
    /// Encoded/decoded by serializers as "LYDT".
    /// </summary>
    [EnumMember(Value = "LYDT")]
    [IsoId("_7XdYGwNyEe2-vqzwMUAewg")]
    [Description(@"Local tax (Ertrag Besitzanteilig) yield liable for interest down payment tax.")]
    GermanLocalTax4,
    
    /// <summary>
    /// Local tax (ZAS pflichtige Zinsen) - interest liable for interest down payment tax (proportion of gross interest per unit/interim profits that is not covered by the credit in the interest pool).
    /// Encoded/decoded by serializers as "LIDT".
    /// </summary>
    [EnumMember(Value = "LIDT")]
    [IsoId("_7XdYLQNyEe2-vqzwMUAewg")]
    [Description(@"Local tax (ZAS pflichtige Zinsen) - interest liable for interest down payment tax (proportion of gross interest per unit/interim profits that is not covered by the credit in the interest pool).")]
    GermanLocalTax2,
    
    /// <summary>
    /// Charge of the correspondent bank for transferring money.
    /// Encoded/decoded by serializers as "CBCH".
    /// </summary>
    [EnumMember(Value = "CBCH")]
    [IsoId("_mAL1gQOTEe2299Tau02hgw")]
    [Description(@"Charge of the correspondent bank for transferring money.")]
    CorrespondentBankCharge,
    
    /// <summary>
    /// Total amount of all commissions or fees
    /// Encoded/decoded by serializers as "TOTL".
    /// </summary>
    [EnumMember(Value = "TOTL")]
    [IsoId("_utsQ0QOWEe2299Tau02hgw")]
    [Description(@"Total amount of all commissions or fees")]
    Total,
    
    /// <summary>
    /// Subscription interest.
    /// Encoded/decoded by serializers as "SUBS".
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("__KG_8QOWEe2299Tau02hgw")]
    [Description(@"Subscription interest.")]
    Subscription,
    
    /// <summary>
    /// Charge for shipping, including the insurance of securities.
    /// Encoded/decoded by serializers as "SHIP".
    /// </summary>
    [EnumMember(Value = "SHIP")]
    [IsoId("_Xdj8yAOXEe2299Tau02hgw")]
    [Description(@"Charge for shipping, including the insurance of securities.")]
    ShippingCharge,
    
    /// <summary>
    /// Fees, drawdown, or other reduction from or in addition to the deal price.
    /// Encoded/decoded by serializers as "SPCN".
    /// </summary>
    [EnumMember(Value = "SPCN")]
    [IsoId("_Xdj8yQOXEe2299Tau02hgw")]
    [Description(@"Fees, drawdown, or other reduction from or in addition to the deal price.")]
    SpecialConcessions,
    
    /// <summary>
    /// Margin amount related commissions and fees.
    /// Encoded/decoded by serializers as "MARG".
    /// </summary>
    [EnumMember(Value = "MARG")]
    [IsoId("_2mQTEAOXEe2299Tau02hgw")]
    [Description(@"Margin amount related commissions and fees.")]
    MarginAmount,
    
    /// <summary>
    /// Fee charged for matching and/or confirmation.
    /// Encoded/decoded by serializers as "MACO".
    /// </summary>
    [EnumMember(Value = "MACO")]
    [IsoId("_ENngpAOYEe2299Tau02hgw")]
    [Description(@"Fee charged for matching and/or confirmation.")]
    MatchingOrConfirmationFees,
    
    /// <summary>
    /// Early redemption fees.
    /// Encoded/decoded by serializers as "ERFE".
    /// </summary>
    [EnumMember(Value = "ERFE")]
    [IsoId("_QbtOIAOYEe2299Tau02hgw")]
    [Description(@"Early redemption fees.")]
    EarlyRedemptionFeeAmount,
    
    /// <summary>
    /// Trade deal amount fees.
    /// Encoded/decoded by serializers as "DEAL".
    /// </summary>
    [EnumMember(Value = "DEAL")]
    [IsoId("_oI7RYQOYEe2299Tau02hgw")]
    [Description(@"Trade deal amount fees.")]
    TradeDealAmount,
    
    /// <summary>
    /// Rebate or bonification fees or commission amount.
    /// Encoded/decoded by serializers as "CREB".
    /// </summary>
    [EnumMember(Value = "CREB")]
    [IsoId("_wc0aMAOYEe2299Tau02hgw")]
    [Description(@"Rebate or bonification fees or commission amount.")]
    RebateBonification,
    
    /// <summary>
    /// Amount of unpaid interest (on bonds which have defaulted and have subsequently 
    /// restructured), which is capitalized and added to the original principal amount of the bond.
    /// Encoded/decoded by serializers as "ACCA".
    /// </summary>
    [EnumMember(Value = "ACCA")]
    [IsoId("_UQsiQAQSEe24oO8ckv9xmw")]
    [Description(@"Amount of unpaid interest (on bonds which have defaulted and have subsequently |restructured), which is capitalized and added to the original principal amount of the bond.")]
    AccruedCapitalisation,
    
    /// <summary>
    /// Amount of interest earned on a debt, such as a bond, but not yet collected.
    /// Encoded/decoded by serializers as "ACRU".
    /// </summary>
    [EnumMember(Value = "ACRU")]
    [IsoId("_aepSQAQSEe24oO8ckv9xmw")]
    [Description(@"Amount of interest earned on a debt, such as a bond, but not yet collected.")]
    AccruedInterest,
    
    /// <summary>
    /// Amount paid by investors when selling mutual fund shares.
    /// Encoded/decoded by serializers as "BAKL".
    /// </summary>
    [EnumMember(Value = "BAKL")]
    [IsoId("_nNRrkAQTEe24oO8ckv9xmw")]
    [Description(@"Amount paid by investors when selling mutual fund shares.")]
    BackLoadFee,
    
    /// <summary>
    /// Amount representing the difference between the cost and the current price of a security. In the context of securities settlement, it is the amount paid or received when the instructions are netted or paired off.
    /// Encoded/decoded by serializers as "ANTO".
    /// </summary>
    [EnumMember(Value = "ANTO")]
    [IsoId("_vGV5kAQTEe24oO8ckv9xmw")]
    [Description(@"Amount representing the difference between the cost and the current price of a security. In the context of securities settlement, it is the amount paid or received when the instructions are netted or paired off.")]
    NetGainLoss,
    
    /// <summary>
    /// Amount of money that cannot be categorised by another qualifier.
    /// Encoded/decoded by serializers as "CHAR".
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_lNGC4QQbEe24oO8ckv9xmw")]
    [Description(@"Amount of money that cannot be categorised by another qualifier.")]
    ChargesAndFees,
    
    /// <summary>
    /// Entrance fees amount
    /// Encoded/decoded by serializers as "ENTF".
    /// </summary>
    [EnumMember(Value = "ENTF")]
    [IsoId("_8zS4IAQbEe24oO8ckv9xmw")]
    [Description(@"Entrance fees amount")]
    EntranceFees,
    
    /// <summary>
    /// Aggregate amount of discount.
    /// Encoded/decoded by serializers as "DSCA".
    /// </summary>
    [EnumMember(Value = "DSCA")]
    [IsoId("_FXVfgARNEe29PP19jELcvQ")]
    [Description(@"Aggregate amount of discount.")]
    DiscountAmount,
    
    /// <summary>
    /// Amount due and payable to a hedge counterparty under a hedge agreement during the relevant period.
    /// Encoded/decoded by serializers as "HDGE".
    /// </summary>
    [EnumMember(Value = "HDGE")]
    [IsoId("_sUc0YARNEe29PP19jELcvQ")]
    [Description(@"Amount due and payable to a hedge counterparty under a hedge agreement during the relevant period.")]
    HedgingCost,
    
    /// <summary>
    /// Amount of money defined as a discount on a new issue or on a tranche of an existing issue.
    /// Encoded/decoded by serializers as "ISDI".
    /// </summary>
    [EnumMember(Value = "ISDI")]
    [IsoId("_2X090ARNEe29PP19jELcvQ")]
    [Description(@"Amount of money defined as a discount on a new issue or on a tranche of an existing issue.")]
    IssueDiscountAllowance,
    
    /// <summary>
    /// Local tax (ZAS Anrechnungsbetrag) subject to interest down payment tax (proportion of interest liable for interest down payment tax/interim profit that is not covered by the tax exempt amount).
    /// Encoded/decoded by serializers as "LADT".
    /// </summary>
    [EnumMember(Value = "LADT")]
    [IsoId("_eC92UAROEe29PP19jELcvQ")]
    [Description(@"Local tax (ZAS Anrechnungsbetrag) subject to interest down payment tax (proportion of interest liable for interest down payment tax/interim profit that is not covered by the tax exempt amount).")]
    GermanLocalTax1,
    
    /// <summary>
    /// Tax levied on a payment.
    /// Encoded/decoded by serializers as "LEVY".
    /// </summary>
    [EnumMember(Value = "LEVY")]
    [IsoId("_kx3-UAROEe29PP19jELcvQ")]
    [Description(@"Tax levied on a payment.")]
    PaymentLevyTax,
    
    /// <summary>
    /// Amount of all settled transactions.
    /// Encoded/decoded by serializers as "SETT".
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_KqNccQRPEe29PP19jELcvQ")]
    [Description(@"Amount of all settled transactions.")]
    SettlementAmount,
    
    /// <summary>
    /// Financial metric used to assess a firm's financial health by revealing the proportion of money left over from revenues after accounting for the cost of goods sold. Gross profit margin serves as the source for paying additional expenses and future savings.
    /// Encoded/decoded by serializers as "SAMG".
    /// </summary>
    [EnumMember(Value = "SAMG")]
    [IsoId("_ZDJ38QRPEe29PP19jELcvQ")]
    [Description(@"Financial metric used to assess a firm's financial health by revealing the proportion of money left over from revenues after accounting for the cost of goods sold. Gross profit margin serves as the source for paying additional expenses and future savings.")]
    SalesMargin,
    
    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// Encoded/decoded by serializers as "REGF".
    /// </summary>
    [EnumMember(Value = "REGF")]
    [IsoId("_7dJm8ARPEe29PP19jELcvQ")]
    [Description(@"Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.")]
    RegulatoryFees,
    
    /// <summary>
    /// Counter value of a foreign exchange conversion.
    /// Encoded/decoded by serializers as "RESU".
    /// </summary>
    [EnumMember(Value = "RESU")]
    [IsoId("_PCeAsARQEe29PP19jELcvQ")]
    [Description(@"Counter value of a foreign exchange conversion.")]
    ResultingAmount,
    
    /// <summary>
    /// Amount of any other remuneration received or to be received by the broker in connection with the transaction.
    /// Encoded/decoded by serializers as "REMU".
    /// </summary>
    [EnumMember(Value = "REMU")]
    [IsoId("_Wi2o8ARQEe29PP19jELcvQ")]
    [Description(@"Amount of any other remuneration received or to be received by the broker in connection with the transaction.")]
    RemunerationAmount,
    
    /// <summary>
    /// Difference between the amount of money of the first leg and the amount of the second leg of the transaction.
    /// Encoded/decoded by serializers as "PRMA".
    /// </summary>
    [EnumMember(Value = "PRMA")]
    [IsoId("_jxxhUARQEe29PP19jELcvQ")]
    [Description(@"Difference between the amount of money of the first leg and the amount of the second leg of the transaction.")]
    PremiumAmount,
    
    /// <summary>
    /// Amount is an on top margin.
    /// Encoded/decoded by serializers as "OTMG".
    /// </summary>
    [EnumMember(Value = "OTMG")]
    [IsoId("_yPRFoARQEe29PP19jELcvQ")]
    [Description(@"Amount is an on top margin.")]
    OnTopMargin,
    
    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// Encoded/decoded by serializers as "OCMT".
    /// </summary>
    [EnumMember(Value = "OCMT")]
    [IsoId("_7jitYARQEe29PP19jELcvQ")]
    [Description(@"Posting/settlement amount in its original currency when conversion from/into another currency has occurred.")]
    OriginalCurrencyAmount,
    
    /// <summary>
    /// Difference between the deal price and another reference price.
    /// Encoded/decoded by serializers as "PRDF".
    /// </summary>
    [EnumMember(Value = "PRDF")]
    [IsoId("_mgZ_4ARSEe29PP19jELcvQ")]
    [Description(@"Difference between the deal price and another reference price.")]
    DifferenceInPrice,
    
    /// <summary>
    /// Amount retained by a fund and paid out later at a time decided by the fund.
    /// Encoded/decoded by serializers as "PRWI".
    /// </summary>
    [EnumMember(Value = "PRWI")]
    [IsoId("_vb-zwARSEe29PP19jELcvQ")]
    [Description(@"Amount retained by a fund and paid out later at a time decided by the fund.")]
    PartialRedemptionWithholdingAmount,
    
    /// <summary>
    /// Amount of the expected refund.
    /// Encoded/decoded by serializers as "REFD".
    /// </summary>
    [EnumMember(Value = "REFD")]
    [IsoId("_5A2cQARSEe29PP19jELcvQ")]
    [Description(@"Amount of the expected refund.")]
    ExpectedRefund,
    
    /// <summary>
    /// Charge or commission paid by the investor to a distributor/intermediary or other service provider for the provision of financial research.
    /// Encoded/decoded by serializers as "RSCH".
    /// </summary>
    [EnumMember(Value = "RSCH")]
    [IsoId("_KM4DYARTEe29PP19jELcvQ")]
    [Description(@"Charge or commission paid by the investor to a distributor/intermediary or other service provider for the provision of financial research.")]
    ResearchFee,
    
}
