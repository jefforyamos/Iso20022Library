﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BalanceType11Code.  ISO2002 ID# _blNtp9p-Ed-ak6NoX_4Aeg_-1113424332.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the balance, eg, opening balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_blNtp9p-Ed-ak6NoX_4Aeg_-1113424332")]
[Description(@"Specifies the nature of the balance, eg, opening balance.")]
[DerivedFrom(typeof(BalanceTypeCode))]
public enum BalanceType11Code
{
    /// <summary>
    /// Book balance of the account at the beginning of the account servicer's business day. It always equals the closing book balance from the previous business day. Note: the available balance at the beginning of the account servicer's business day may be different from the closing book balance from the previous business day.
    /// Encoded/decoded by serializers as "Opening".
    /// </summary>
    [EnumMember(Value = "OPNG")]
    [IsoId("_blNtqNp-Ed-ak6NoX_4Aeg_-1113424301")]
    [Description(@"Book balance of the account at the beginning of the account servicer's business day. It always equals the closing book balance from the previous business day. Note: the available balance at the beginning of the account servicer's business day may be different from the closing book balance from the previous business day.")]
    Opening,
    
    /// <summary>
    /// Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as "Interim".
    /// </summary>
    [EnumMember(Value = "INTM")]
    [IsoId("_blXeoNp-Ed-ak6NoX_4Aeg_-1113424271")]
    [Description(@"Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.")]
    Interim,
    
    /// <summary>
    /// Balance of the account at the end of the account servicer's business day. It is the sum of the opening balance at the beginning of the day and all entries booked to the account during the account servicer's business day.
    /// Encoded/decoded by serializers as "Closing".
    /// </summary>
    [EnumMember(Value = "CLSG")]
    [IsoId("_blXeodp-Ed-ak6NoX_4Aeg_-1113424270")]
    [Description(@"Balance of the account at the end of the account servicer's business day. It is the sum of the opening balance at the beginning of the day and all entries booked to the account during the account servicer's business day.")]
    Closing,
    
    /// <summary>
    /// Balance that is registered in the books of the account servicer.
    /// Encoded/decoded by serializers as "Book".
    /// </summary>
    [EnumMember(Value = "BOOK")]
    [IsoId("_blXeotp-Ed-ak6NoX_4Aeg_-1113424024")]
    [Description(@"Balance that is registered in the books of the account servicer.")]
    Book,
    
    /// <summary>
    /// Balance of the account at a precise moment in time.
    /// Encoded/decoded by serializers as "Current".
    /// </summary>
    [EnumMember(Value = "CRRT")]
    [IsoId("_blXeo9p-Ed-ak6NoX_4Aeg_-1113424023")]
    [Description(@"Balance of the account at a precise moment in time.")]
    Current,
    
    /// <summary>
    /// Balance of securities pending delivery, eg, orders to sell securities have been executed but settlement of the open transactions has not been confirmed.
    /// Encoded/decoded by serializers as "Pending".
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_blXepNp-Ed-ak6NoX_4Aeg_-1113423993")]
    [Description(@"Balance of securities pending delivery, eg, orders to sell securities have been executed but settlement of the open transactions has not been confirmed.")]
    Pending,
    
    /// <summary>
    /// Balance of a specific limit value, eg, a bilateral balance is calculated in relation to a given bilateral limit.
    /// Encoded/decoded by serializers as "LimitRelated".
    /// </summary>
    [EnumMember(Value = "LRLD")]
    [IsoId("_blXepdp-Ed-ak6NoX_4Aeg_-1113423992")]
    [Description(@"Balance of a specific limit value, eg, a bilateral balance is calculated in relation to a given bilateral limit.")]
    LimitRelated,
    
    /// <summary>
    /// Balance of money or securities that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "Available".
    /// </summary>
    [EnumMember(Value = "AVLB")]
    [IsoId("_blXeptp-Ed-ak6NoX_4Aeg_-1113423962")]
    [Description(@"Balance of money or securities that is at the disposal of the account owner on the date specified.")]
    Available,
    
    /// <summary>
    /// Balance composed of the sum of all liquidity transfers made to or from an account.
    /// Encoded/decoded by serializers as "LiquidityTransfer".
    /// </summary>
    [EnumMember(Value = "LTSF")]
    [IsoId("_blXep9p-Ed-ak6NoX_4Aeg_-1113423939")]
    [Description(@"Balance composed of the sum of all liquidity transfers made to or from an account.")]
    LiquidityTransfer,
    
    /// <summary>
    /// Balance representing the sum of all credit entries booked to an account.
    /// Encoded/decoded by serializers as "Credit".
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_blXeqNp-Ed-ak6NoX_4Aeg_-1113423931")]
    [Description(@"Balance representing the sum of all credit entries booked to an account.")]
    Credit,
    
    /// <summary>
    /// Balance representing the potential loan a Central Bank would make in cash if the collateral is pledged, eg, securities available and eligible as collateral with the Central Bank.
    /// Encoded/decoded by serializers as "EligibleAssets".
    /// </summary>
    [EnumMember(Value = "EAST")]
    [IsoId("_blXeqdp-Ed-ak6NoX_4Aeg_-1113423908")]
    [Description(@"Balance representing the potential loan a Central Bank would make in cash if the collateral is pledged, eg, securities available and eligible as collateral with the Central Bank.")]
    EligibleAssets,
    
    /// <summary>
    /// Balance representing the sum of entries as a result of payments processing. Entries relating to fees, interest, or other movements not a result of payments sent or received by the account owner are not included.
    /// Encoded/decoded by serializers as "Payment".
    /// </summary>
    [EnumMember(Value = "PYMT")]
    [IsoId("_blhPoNp-Ed-ak6NoX_4Aeg_-1113423900")]
    [Description(@"Balance representing the sum of entries as a result of payments processing. Entries relating to fees, interest, or other movements not a result of payments sent or received by the account owner are not included.")]
    Payment,
    
    /// <summary>
    /// Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, eg, the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes. In some countries, a blocked balance is known as a 'reserve' balance.
    /// Encoded/decoded by serializers as "Blocked".
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_blhPodp-Ed-ak6NoX_4Aeg_-1113423877")]
    [Description(@"Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, eg, the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes. In some countries, a blocked balance is known as a 'reserve' balance.")]
    Blocked,
    
    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.
    /// Encoded/decoded by serializers as "Expected".
    /// </summary>
    [EnumMember(Value = "XPCD")]
    [IsoId("_blhPotp-Ed-ak6NoX_4Aeg_-1113423599")]
    [Description(@"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.")]
    Expected,
    
    /// <summary>
    /// Balance representing the intra day overdraft granted by the Central Bank to financial institutions participating in a RTGS system. This balance may vary over time and shall be offset at the end of the day.
    /// Encoded/decoded by serializers as "DaylightOverdraft".
    /// </summary>
    [EnumMember(Value = "DLOD")]
    [IsoId("_blhPo9p-Ed-ak6NoX_4Aeg_-1113423598")]
    [Description(@"Balance representing the intra day overdraft granted by the Central Bank to financial institutions participating in a RTGS system. This balance may vary over time and shall be offset at the end of the day.")]
    DaylightOverdraft,
    
    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day credit balance if everything books to the account and no other credit entry is posted.
    /// Encoded/decoded by serializers as "ExpectedCredit".
    /// </summary>
    [EnumMember(Value = "XCRD")]
    [IsoId("_blhPpNp-Ed-ak6NoX_4Aeg_-1113423590")]
    [Description(@"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day credit balance if everything books to the account and no other credit entry is posted.")]
    ExpectedCredit,
    
    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day debit balance if everything books to the account and no other debit entry is posted.
    /// Encoded/decoded by serializers as "ExpectedDebit".
    /// </summary>
    [EnumMember(Value = "XDBT")]
    [IsoId("_blhPpdp-Ed-ak6NoX_4Aeg_-1113423568")]
    [Description(@"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day debit balance if everything books to the account and no other debit entry is posted.")]
    ExpectedDebit,
    
    /// <summary>
    /// Balance to be held in the settlement account in order to comply with the average reserve due, in the event that the bank's balance is equal to the reserve due during the remaining days of the maintenance period.
    /// Encoded/decoded by serializers as "Adjustment".
    /// </summary>
    [EnumMember(Value = "ADJT")]
    [IsoId("_blhPptp-Ed-ak6NoX_4Aeg_-1113423567")]
    [Description(@"Balance to be held in the settlement account in order to comply with the average reserve due, in the event that the bank's balance is equal to the reserve due during the remaining days of the maintenance period.")]
    Adjustment,
    
    /// <summary>
    /// Average of the daily balances on the account used to fulfil the reserve requirements calculated from the beginning of the maintenance period.
    /// Encoded/decoded by serializers as "ProgressiveAverage".
    /// </summary>
    [EnumMember(Value = "PRAV")]
    [IsoId("_blhPp9p-Ed-ak6NoX_4Aeg_-1113423559")]
    [Description(@"Average of the daily balances on the account used to fulfil the reserve requirements calculated from the beginning of the maintenance period.")]
    ProgressiveAverage,
    
    /// <summary>
    /// Balance representing the sum of all debit entries booked to an account.
    /// Encoded/decoded by serializers as "Debit".
    /// </summary>
    [EnumMember(Value = "DBIT")]
    [IsoId("_blhPqNp-Ed-ak6NoX_4Aeg_-1113423538")]
    [Description(@"Balance representing the sum of all debit entries booked to an account.")]
    Debit,
    
    /// <summary>
    /// Balance representing the amount that will be destined for investment. Difference between available balance and threshold for investment limit.
    /// Encoded/decoded by serializers as "Threshold".
    /// </summary>
    [EnumMember(Value = "THRE")]
    [IsoId("_blhPqdp-Ed-ak6NoX_4Aeg_-1113423537")]
    [Description(@"Balance representing the amount that will be destined for investment. Difference between available balance and threshold for investment limit.")]
    Threshold,
    
    /// <summary>
    /// Balance representing the amount that a financial institution has set aside for a specific reason and which is therefore not available.
    /// Encoded/decoded by serializers as "Noted".
    /// </summary>
    [EnumMember(Value = "NOTE")]
    [IsoId("_blhPqtp-Ed-ak6NoX_4Aeg_-1113423536")]
    [Description(@"Balance representing the amount that a financial institution has set aside for a specific reason and which is therefore not available.")]
    Noted,
    
    /// <summary>
    /// Balance representing the forecast of total of all cash legs for trades that are ready to settle via CSD. Amounts shown are still subject to processing of the securities settlement.
    /// Encoded/decoded by serializers as "ForecastSettlement".
    /// </summary>
    [EnumMember(Value = "FSET")]
    [IsoId("_blqZkNp-Ed-ak6NoX_4Aeg_-1113423507")]
    [Description(@"Balance representing the forecast of total of all cash legs for trades that are ready to settle via CSD. Amounts shown are still subject to processing of the securities settlement.")]
    ForecastSettlement,
    
    /// <summary>
    /// Balance representing the projected total of all cash legs for trades settling via CSD that have been matched but blocked in order to not settle. These blocked trades are included in the calculation for settlement (eg, to avoid overdrafts).|Usage rule: Blocking can be done by account owner or its counterparties. Usually this is done to chain transactions or to prioritise other trades. Blocked trades have an indicator that prevents the transactions from settling. Once matched, they can settle whenever the freeze is lifted. In this case they will move to FSET. Lifting the freeze can happen anytime during the day and the transaction will be settling in the next settlement cycle which can be the same day if the (I)CSD's operates several settlements cycles per day.
    /// Encoded/decoded by serializers as "BlockedTrades".
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_blqZkdp-Ed-ak6NoX_4Aeg_-1113423506")]
    [Description(@"Balance representing the projected total of all cash legs for trades settling via CSD that have been matched but blocked in order to not settle. These blocked trades are included in the calculation for settlement (eg, to avoid overdrafts).|Usage rule: Blocking can be done by account owner or its counterparties. Usually this is done to chain transactions or to prioritise other trades. Blocked trades have an indicator that prevents the transactions from settling. Once matched, they can settle whenever the freeze is lifted. In this case they will move to FSET. Lifting the freeze can happen anytime during the day and the transaction will be settling in the next settlement cycle which can be the same day if the (I)CSD's operates several settlements cycles per day.")]
    BlockedTrades,
    
    /// <summary>
    /// Balance representing the projected total of all cash legs for trades settling via CSD that have been matched but blocked in order to not settle. These blocked transactions are not included in the calculation for settlement.
    /// Encoded/decoded by serializers as "OtherBlockedTrades".
    /// </summary>
    [EnumMember(Value = "OTHB")]
    [IsoId("_blqZktp-Ed-ak6NoX_4Aeg_-1113423505")]
    [Description(@"Balance representing the projected total of all cash legs for trades settling via CSD that have been matched but blocked in order to not settle. These blocked transactions are not included in the calculation for settlement.")]
    OtherBlockedTrades,
    
    /// <summary>
    /// Balance representing the projected total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, etc.
    /// Encoded/decoded by serializers as "Custody".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_blqZk9p-Ed-ak6NoX_4Aeg_-1113423476")]
    [Description(@"Balance representing the projected total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, etc.")]
    Custody,
    
    /// <summary>
    /// Balance representing the total of all balance types representing transactions to settle, blocked items and custody transactions.
    /// Encoded/decoded by serializers as "CashForecast".
    /// </summary>
    [EnumMember(Value = "FORC")]
    [IsoId("_blqZlNp-Ed-ak6NoX_4Aeg_-1113423475")]
    [Description(@"Balance representing the total of all balance types representing transactions to settle, blocked items and custody transactions.")]
    CashForecast,
    
    /// <summary>
    /// Balance representing the projected total amount of all payment obligations to the participant (bank), based on their role as main paying agent.
    /// Encoded/decoded by serializers as "DividendsCollection".
    /// </summary>
    [EnumMember(Value = "COLC")]
    [IsoId("_blqZldp-Ed-ak6NoX_4Aeg_-1113423474")]
    [Description(@"Balance representing the projected total amount of all payment obligations to the participant (bank), based on their role as main paying agent.")]
    DividendsCollection,
    
    /// <summary>
    /// Balance representing the net amount to be funded resulting from all transactions which have an impact on the funding requirement.
    /// Encoded/decoded by serializers as "NetFunding".
    /// </summary>
    [EnumMember(Value = "FUND")]
    [IsoId("_blqZltp-Ed-ak6NoX_4Aeg_-1113423446")]
    [Description(@"Balance representing the net amount to be funded resulting from all transactions which have an impact on the funding requirement.")]
    NetFunding,
    
    /// <summary>
    /// Balance representing the fictive forecast of automated direct debits or payment based on standing arrangements between the CSD and the user.||Usage: Pay-Ins and Pay-Outs can be different based on individual payment instructions or available funds.
    /// Encoded/decoded by serializers as "PayInPayOut".
    /// </summary>
    [EnumMember(Value = "PIPO")]
    [IsoId("_blqZl9p-Ed-ak6NoX_4Aeg_-1113423445")]
    [Description(@"Balance representing the fictive forecast of automated direct debits or payment based on standing arrangements between the CSD and the user.||Usage: Pay-Ins and Pay-Outs can be different based on individual payment instructions or available funds.")]
    PayInPayOut,
    
    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges.
    /// Encoded/decoded by serializers as "ExchangeForecast".
    /// </summary>
    [EnumMember(Value = "XCHG")]
    [IsoId("_blqZmNp-Ed-ak6NoX_4Aeg_-1113423415")]
    [Description(@"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges.")]
    ExchangeForecast,
    
    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges that operate a central counterparty functionality.
    /// Encoded/decoded by serializers as "CentralCounterparty".
    /// </summary>
    [EnumMember(Value = "CCPS")]
    [IsoId("_blqZmdp-Ed-ak6NoX_4Aeg_-1113423414")]
    [Description(@"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges that operate a central counterparty functionality.")]
    CentralCounterparty,
    
    /// <summary>
    /// Balance representing the total of the payments that were put on hold because the limits have been exceeded.
    /// Encoded/decoded by serializers as "TotalOnHold".
    /// </summary>
    [EnumMember(Value = "TOHB")]
    [IsoId("_bl0KkNp-Ed-ak6NoX_4Aeg_-1113423413")]
    [Description(@"Balance representing the total of the payments that were put on hold because the limits have been exceeded.")]
    TotalOnHold,
    
    /// <summary>
    /// Balance representing the total incoming payments that were put on hold because the credit limit has been exceeded.
    /// Encoded/decoded by serializers as "CreditOnHold".
    /// </summary>
    [EnumMember(Value = "COHB")]
    [IsoId("_bl0Kkdp-Ed-ak6NoX_4Aeg_-1113423384")]
    [Description(@"Balance representing the total incoming payments that were put on hold because the credit limit has been exceeded.")]
    CreditOnHold,
    
    /// <summary>
    /// Balance representing the total outgoing payments that were put on hold because the debit limit has been exceeded.
    /// Encoded/decoded by serializers as "DebitOnHold".
    /// </summary>
    [EnumMember(Value = "DOHB")]
    [IsoId("_bl0Kktp-Ed-ak6NoX_4Aeg_-1113423383")]
    [Description(@"Balance representing the total outgoing payments that were put on hold because the debit limit has been exceeded.")]
    DebitOnHold,
    
    /// <summary>
    /// Balance representing the total of the payments that have been processed and are waiting for settlement during the day.
    /// Encoded/decoded by serializers as "TotalProcessed".
    /// </summary>
    [EnumMember(Value = "TPBL")]
    [IsoId("_bl0Kk9p-Ed-ak6NoX_4Aeg_-1113423382")]
    [Description(@"Balance representing the total of the payments that have been processed and are waiting for settlement during the day.")]
    TotalProcessed,
    
    /// <summary>
    /// Balance representing the total incoming payments that have been processed and are waiting for settlement.
    /// Encoded/decoded by serializers as "CreditProcessed".
    /// </summary>
    [EnumMember(Value = "CPBL")]
    [IsoId("_bl0KlNp-Ed-ak6NoX_4Aeg_-1113423354")]
    [Description(@"Balance representing the total incoming payments that have been processed and are waiting for settlement.")]
    CreditProcessed,
    
    /// <summary>
    /// Balance representing the total outgoing payments that have been processed and are waiting for settlement.
    /// Encoded/decoded by serializers as "DebitProcessed".
    /// </summary>
    [EnumMember(Value = "DPBL")]
    [IsoId("_bl0Kldp-Ed-ak6NoX_4Aeg_-1113423353")]
    [Description(@"Balance representing the total outgoing payments that have been processed and are waiting for settlement.")]
    DebitProcessed,
    
    /// <summary>
    /// Balance representing the total of the payments with a processing date in the future.
    /// Encoded/decoded by serializers as "TotalFuture".
    /// </summary>
    [EnumMember(Value = "FUTB")]
    [IsoId("_bl0Kltp-Ed-ak6NoX_4Aeg_-1113423352")]
    [Description(@"Balance representing the total of the payments with a processing date in the future.")]
    TotalFuture,
    
    /// <summary>
    /// Balance representing the total of the payments that have been rejected.
    /// Encoded/decoded by serializers as "TotalRejected".
    /// </summary>
    [EnumMember(Value = "REJB")]
    [IsoId("_bl0Kl9p-Ed-ak6NoX_4Aeg_-1113423323")]
    [Description(@"Balance representing the total of the payments that have been rejected.")]
    TotalRejected,
    
    /// <summary>
    /// Balance representing the forecast of the cash-equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral.
    /// Encoded/decoded by serializers as "FirmCollateralisation".
    /// </summary>
    [EnumMember(Value = "FCOL")]
    [IsoId("_bl0KmNp-Ed-ak6NoX_4Aeg_-1026611124")]
    [Description(@"Balance representing the forecast of the cash-equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral.")]
    FirmCollateralisation,
    
    /// <summary>
    /// Balance representing the cash equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral and have been used as collateral.
    /// Encoded/decoded by serializers as "UsedAmountsFirmCollateralisation".
    /// </summary>
    [EnumMember(Value = "FCOU")]
    [IsoId("_bl0Kmdp-Ed-ak6NoX_4Aeg_-1026611062")]
    [Description(@"Balance representing the cash equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral and have been used as collateral.")]
    UsedAmountsFirmCollateralisation,
    
    /// <summary>
    /// Balance representing the forecast of the cash-equivalent resulting from evaluation of the net incoming balance of securities qualified to serve as collateral for which settlement instructions are held at.
    /// Encoded/decoded by serializers as "SelfCollateralisation".
    /// </summary>
    [EnumMember(Value = "SCOL")]
    [IsoId("_bl0Kmtp-Ed-ak6NoX_4Aeg_-1025690998")]
    [Description(@"Balance representing the forecast of the cash-equivalent resulting from evaluation of the net incoming balance of securities qualified to serve as collateral for which settlement instructions are held at.")]
    SelfCollateralisation,
    
    /// <summary>
    /// Balance representing the cash-equivalent resulting from evaluation of incoming securities, qualified to serve as collateral and actually used as collateral, which have been settled during the settlement process.
    /// Encoded/decoded by serializers as "UsedAmountsSelfCollateralisation".
    /// </summary>
    [EnumMember(Value = "SCOU")]
    [IsoId("_bl97kNp-Ed-ak6NoX_4Aeg_-1025690937")]
    [Description(@"Balance representing the cash-equivalent resulting from evaluation of incoming securities, qualified to serve as collateral and actually used as collateral, which have been settled during the settlement process.")]
    UsedAmountsSelfCollateralisation,
    
    /// <summary>
    /// Balance representing the actual total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, redemptions, etc.
    /// Encoded/decoded by serializers as "CustodyActual".
    /// </summary>
    [EnumMember(Value = "CUSA")]
    [IsoId("_bl97kdp-Ed-ak6NoX_4Aeg_-1025690845")]
    [Description(@"Balance representing the actual total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, redemptions, etc.")]
    CustodyActual,
    
    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions in exchanges, going through CCP functions.
    /// Encoded/decoded by serializers as "CCPGuaranteedForecasting".
    /// </summary>
    [EnumMember(Value = "XCHC")]
    [IsoId("_bl97ktp-Ed-ak6NoX_4Aeg_-1025690815")]
    [Description(@"Balance representing the forecast of the total of all cash legs of transactions in exchanges, going through CCP functions.")]
    CCPGuaranteedForecasting,
    
    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges not going through CCP functions.
    /// Encoded/decoded by serializers as "NonCCPGuaranteedForecasting".
    /// </summary>
    [EnumMember(Value = "XCHN")]
    [IsoId("_bl97k9p-Ed-ak6NoX_4Aeg_-1025690753")]
    [Description(@"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges not going through CCP functions.")]
    NonCCPGuaranteedForecasting,
    
    /// <summary>
    /// Balance representing the cash equivalent of all settled securities transactions.
    /// Encoded/decoded by serializers as "DefinitiveSettledSecurities".
    /// </summary>
    [EnumMember(Value = "DSET")]
    [IsoId("_bl97lNp-Ed-ak6NoX_4Aeg_-1025690506")]
    [Description(@"Balance representing the cash equivalent of all settled securities transactions.")]
    DefinitiveSettledSecurities,
    
    /// <summary>
    /// Balance representing the cash equivalent of transactions with a lack of holdings.
    /// Encoded/decoded by serializers as "LackOfHoldingsTransactions".
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_bl97ldp-Ed-ak6NoX_4Aeg_-1025690445")]
    [Description(@"Balance representing the cash equivalent of transactions with a lack of holdings.")]
    LackOfHoldingsTransactions,
    
    /// <summary>
    /// Balance representing the cash equivalent of all non-settled securities transactions.
    /// Encoded/decoded by serializers as "NonSettledSecurities".
    /// </summary>
    [EnumMember(Value = "NSET")]
    [IsoId("_bl97ltp-Ed-ak6NoX_4Aeg_-1025690414")]
    [Description(@"Balance representing the cash equivalent of all non-settled securities transactions.")]
    NonSettledSecurities,
    
    /// <summary>
    /// Balance representing the Forecast of the total of all cash-legs of transactions 'over the counter' (OTC), going through CCP functions.
    /// Encoded/decoded by serializers as "CCPGuaranteedOTCTransactions".
    /// </summary>
    [EnumMember(Value = "OTCC")]
    [IsoId("_bl97l9p-Ed-ak6NoX_4Aeg_-1025690361")]
    [Description(@"Balance representing the Forecast of the total of all cash-legs of transactions 'over the counter' (OTC), going through CCP functions.")]
    CCPGuaranteedOTCTransactions,
    
    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded 'over the counter' (OTC).
    /// Encoded/decoded by serializers as "ForecastOTCTransactions".
    /// </summary>
    [EnumMember(Value = "OTCG")]
    [IsoId("_bl97mNp-Ed-ak6NoX_4Aeg_-1025690051")]
    [Description(@"Balance representing the forecast of the total of all cash legs of transactions traded 'over the counter' (OTC).")]
    ForecastOTCTransactions,
    
    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded 'over the counter' (OTC) not going through CCP functions.
    /// Encoded/decoded by serializers as "NonCCPGuaranteedOTCTransactions".
    /// </summary>
    [EnumMember(Value = "OTCN")]
    [IsoId("_bl97mdp-Ed-ak6NoX_4Aeg_-1025690021")]
    [Description(@"Balance representing the forecast of the total of all cash legs of transactions traded 'over the counter' (OTC) not going through CCP functions.")]
    NonCCPGuaranteedOTCTransactions,
    
    /// <summary>
    /// Balance represents the settlement account processor direct debit amount.
    /// Encoded/decoded by serializers as "SAPDirectDebitAmount".
    /// </summary>
    [EnumMember(Value = "SAPD")]
    [IsoId("_bmHFgNp-Ed-ak6NoX_4Aeg_-1025689960")]
    [Description(@"Balance represents the settlement account processor direct debit amount.")]
    SAPDirectDebitAmount,
    
    /// <summary>
    /// Balance represents the settlement account processor direct credit amount.
    /// Encoded/decoded by serializers as "SAPDirectCreditAmount".
    /// </summary>
    [EnumMember(Value = "SAPC")]
    [IsoId("_bmHFgdp-Ed-ak6NoX_4Aeg_-1025689898")]
    [Description(@"Balance represents the settlement account processor direct credit amount.")]
    SAPDirectCreditAmount,
    
    /// <summary>
    /// Balance represents the total of the central moneymarkets unit processor repo debits.
    /// Encoded/decoded by serializers as "CMUPRepoDebit".
    /// </summary>
    [EnumMember(Value = "REPD")]
    [IsoId("_bmHFgtp-Ed-ak6NoX_4Aeg_-1025689837")]
    [Description(@"Balance represents the total of the central moneymarkets unit processor repo debits.")]
    CMUPRepoDebit,
    
    /// <summary>
    /// Balance represents the total of the central moneymarkets unit processor repo credits.
    /// Encoded/decoded by serializers as "CMUPRepoCredit".
    /// </summary>
    [EnumMember(Value = "REPC")]
    [IsoId("_bmHFg9p-Ed-ak6NoX_4Aeg_-1025689806")]
    [Description(@"Balance represents the total of the central moneymarkets unit processor repo credits.")]
    CMUPRepoCredit,
    
    /// <summary>
    /// Balance represents the total of the bulk settlement and central moneymarkets unit processor debit.
    /// Encoded/decoded by serializers as "BulkSettlementCMUPDebit".
    /// </summary>
    [EnumMember(Value = "BSCD")]
    [IsoId("_bmHFhNp-Ed-ak6NoX_4Aeg_-1025689528")]
    [Description(@"Balance represents the total of the bulk settlement and central moneymarkets unit processor debit.")]
    BulkSettlementCMUPDebit,
    
    /// <summary>
    /// Balance represents the total of the bulk settlement and central moneymarkets unit processor credit.
    /// Encoded/decoded by serializers as "BulkSettlementCMUPCredit".
    /// </summary>
    [EnumMember(Value = "BSCC")]
    [IsoId("_bmHFhdp-Ed-ak6NoX_4Aeg_-1025689467")]
    [Description(@"Balance represents the total of the bulk settlement and central moneymarkets unit processor credit.")]
    BulkSettlementCMUPCredit,
    
    /// <summary>
    /// Balance represents the settlement account processor queue amount.
    /// Encoded/decoded by serializers as "SAPQueueAmount".
    /// </summary>
    [EnumMember(Value = "SAPP")]
    [IsoId("_bmHFhtp-Ed-ak6NoX_4Aeg_-1025689413")]
    [Description(@"Balance represents the settlement account processor queue amount.")]
    SAPQueueAmount,
    
    /// <summary>
    /// Balance represents the intraday repo limit.
    /// Encoded/decoded by serializers as "IntradayRepoLimit".
    /// </summary>
    [EnumMember(Value = "IRLT")]
    [IsoId("_bmHFh9p-Ed-ak6NoX_4Aeg_-1025689103")]
    [Description(@"Balance represents the intraday repo limit.")]
    IntradayRepoLimit,
    
    /// <summary>
    /// Balance represents the intraday repo drawings.
    /// Encoded/decoded by serializers as "IntradayRepoDrawings".
    /// </summary>
    [EnumMember(Value = "IRDR")]
    [IsoId("_bmHFiNp-Ed-ak6NoX_4Aeg_-1025689042")]
    [Description(@"Balance represents the intraday repo drawings.")]
    IntradayRepoDrawings,
    
    /// <summary>
    /// Balance represents the discount window repo drawings.
    /// Encoded/decoded by serializers as "DiscountWindowRepoDrawings".
    /// </summary>
    [EnumMember(Value = "DWRD")]
    [IsoId("_bmHFidp-Ed-ak6NoX_4Aeg_-1025688981")]
    [Description(@"Balance represents the discount window repo drawings.")]
    DiscountWindowRepoDrawings,
    
    /// <summary>
    /// Balance represents the available discounted market value for discount window repo.
    /// Encoded/decoded by serializers as "AvailableDMVForDiscountWindowRepo".
    /// </summary>
    [EnumMember(Value = "ADWR")]
    [IsoId("_bmQ2gNp-Ed-ak6NoX_4Aeg_-1025688920")]
    [Description(@"Balance represents the available discounted market value for discount window repo.")]
    AvailableDMVForDiscountWindowRepo,
    
    /// <summary>
    /// Balance represents the available discounted market value for intraday repo.
    /// Encoded/decoded by serializers as "AvailableDMVForIntradayRepo".
    /// </summary>
    [EnumMember(Value = "AIDR")]
    [IsoId("_bmQ2gdp-Ed-ak6NoX_4Aeg_-1025688858")]
    [Description(@"Balance represents the available discounted market value for intraday repo.")]
    AvailableDMVForIntradayRepo,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BalanceType11CodeMetadataExtensions
{
    private static readonly BalanceType11CodeDropdownSource _dropdownSource = new BalanceType11CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBalanceType11CodeDropdownRow GetMetadata(this BalanceType11Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


