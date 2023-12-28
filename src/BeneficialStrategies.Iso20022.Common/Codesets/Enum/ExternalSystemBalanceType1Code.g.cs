﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalSystemBalanceType1Code.  ISO2002 ID# _qP4YgXhYEeidzqjNEfehPg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the system balance type, as published in an external system balance type code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qP4YgXhYEeidzqjNEfehPg")]
[Description(@"Specifies the system balance type, as published in an external system balance type code set. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalSystemBalanceTypeCode))]
public enum ExternalSystemBalanceType1Code
{
    /// <summary>
    /// Average balance to be held in the settlement account at the end of each day in order to fulfil the reserve due.|The approximation will be always made rounding up.
    /// Encoded/decoded by serializers as "Adjustment".
    /// </summary>
    [EnumMember(Value = "ADJT")]
    [IsoId("_ueCp7vRYEeuLhpyIdtJzwg")]
    [Description(@"Average balance to be held in the settlement account at the end of each day in order to fulfil the reserve due.|The approximation will be always made rounding up.")]
    Adjustment,
    
    /// <summary>
    /// Balance represents the available discounted market value for discount window repo.
    /// Encoded/decoded by serializers as "AvailableDMVForDiscountWindowRepo".
    /// </summary>
    [EnumMember(Value = "ADWR")]
    [IsoId("_ueLz0vRYEeuLhpyIdtJzwg")]
    [Description(@"Balance represents the available discounted market value for discount window repo.")]
    AvailableDMVForDiscountWindowRepo,
    
    /// <summary>
    /// Balance represents the available discounted market value for intraday repo.
    /// Encoded/decoded by serializers as "AvailableDMVForIntradayRepo".
    /// </summary>
    [EnumMember(Value = "AIDR")]
    [IsoId("_ueLz1fRYEeuLhpyIdtJzwg")]
    [Description(@"Balance represents the available discounted market value for intraday repo.")]
    AvailableDMVForIntradayRepo,
    
    /// <summary>
    /// Balance of money or securities that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "Available".
    /// </summary>
    [EnumMember(Value = "AVLB")]
    [IsoId("_ueVk0vRYEeuLhpyIdtJzwg")]
    [Description(@"Balance of money or securities that is at the disposal of the account owner on the date specified.")]
    Available,
    
    /// <summary>
    /// Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, such as the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes. In some countries, a blocked balance is known as a 'reserve' balance.
    /// Encoded/decoded by serializers as "Blocked".
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_ueVk1fRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, such as the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes. In some countries, a blocked balance is known as a 'reserve' balance.")]
    Blocked,
    
    /// <summary>
    /// Balance representing the projected total of all cash legs for trades settling via a central securities depository that have been matched but blocked in order to not settle. These blocked trades are included in the calculation for settlement (for example to avoid overdrafts).|Usage rule: Blocking can be done by account owner or its counterparties. Usually this is done to chain transactions or to prioritise other trades. Blocked trades have an indicator that prevents the transactions from settling. Once matched, they can settle whenever the freeze is lifted. In this case they will move to FSET. Lifting the freeze can happen anytime during the day and the transaction will be settling in the next settlement cycle which can be the same day if the (international) central securities depository's operates several settlements cycles per day.
    /// Encoded/decoded by serializers as "BlockedTrades".
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_ueVk2PRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the projected total of all cash legs for trades settling via a central securities depository that have been matched but blocked in order to not settle. These blocked trades are included in the calculation for settlement (for example to avoid overdrafts).|Usage rule: Blocking can be done by account owner or its counterparties. Usually this is done to chain transactions or to prioritise other trades. Blocked trades have an indicator that prevents the transactions from settling. Once matched, they can settle whenever the freeze is lifted. In this case they will move to FSET. Lifting the freeze can happen anytime during the day and the transaction will be settling in the next settlement cycle which can be the same day if the (international) central securities depository's operates several settlements cycles per day.")]
    BlockedTrades,
    
    /// <summary>
    /// Balance that is registered in the books of the account servicer.
    /// Encoded/decoded by serializers as "Book".
    /// </summary>
    [EnumMember(Value = "BOOK")]
    [IsoId("_ueVk2_RYEeuLhpyIdtJzwg")]
    [Description(@"Balance that is registered in the books of the account servicer.")]
    Book,
    
    /// <summary>
    /// Balance represents the total of the bulk settlement and central moneymarkets unit processor credit.
    /// Encoded/decoded by serializers as "BulkSettlementCMUPCredit".
    /// </summary>
    [EnumMember(Value = "BSCC")]
    [IsoId("_uefV0vRYEeuLhpyIdtJzwg")]
    [Description(@"Balance represents the total of the bulk settlement and central moneymarkets unit processor credit.")]
    BulkSettlementCMUPCredit,
    
    /// <summary>
    /// Balance represents the total of the bulk settlement and central moneymarkets unit processor debit.
    /// Encoded/decoded by serializers as "BulkSettlementCMUPDebit".
    /// </summary>
    [EnumMember(Value = "BSCD")]
    [IsoId("_uefV1fRYEeuLhpyIdtJzwg")]
    [Description(@"Balance represents the total of the bulk settlement and central moneymarkets unit processor debit.")]
    BulkSettlementCMUPDebit,
    
    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges that operate a central counterparty functionality.
    /// Encoded/decoded by serializers as "CentralCounterparty".
    /// </summary>
    [EnumMember(Value = "CCPS")]
    [IsoId("_uefV2PRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges that operate a central counterparty functionality.")]
    CentralCounterparty,
    
    /// <summary>
    /// Balance of the account at the end of the account servicer's business day. It is the sum of the opening balance at the beginning of the day and all entries booked to the account during the account servicer's business day.
    /// Encoded/decoded by serializers as "Closing".
    /// </summary>
    [EnumMember(Value = "CLSG")]
    [IsoId("_uefV2_RYEeuLhpyIdtJzwg")]
    [Description(@"Balance of the account at the end of the account servicer's business day. It is the sum of the opening balance at the beginning of the day and all entries booked to the account during the account servicer's business day.")]
    Closing,
    
    /// <summary>
    /// Balance representing the total incoming payments that were put on hold because the credit limit has been exceeded.
    /// Encoded/decoded by serializers as "CreditOnHold".
    /// </summary>
    [EnumMember(Value = "COHB")]
    [IsoId("_ueofwvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the total incoming payments that were put on hold because the credit limit has been exceeded.")]
    CreditOnHold,
    
    /// <summary>
    /// Balance representing the projected total amount of all payment obligations to the participant (bank), based on their role as main paying agent.
    /// Encoded/decoded by serializers as "DividendsCollection".
    /// </summary>
    [EnumMember(Value = "COLC")]
    [IsoId("_ueofxfRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the projected total amount of all payment obligations to the participant (bank), based on their role as main paying agent.")]
    DividendsCollection,
    
    /// <summary>
    /// Balance representing the total incoming payments that have been processed and are waiting for settlement.
    /// Encoded/decoded by serializers as "CreditProcessed".
    /// </summary>
    [EnumMember(Value = "CPBL")]
    [IsoId("_ueofyPRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the total incoming payments that have been processed and are waiting for settlement.")]
    CreditProcessed,
    
    /// <summary>
    /// Balance representing the sum of all credit entries booked to an account.
    /// Encoded/decoded by serializers as "Credit".
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_ueofy_RYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the sum of all credit entries booked to an account.")]
    Credit,
    
    /// <summary>
    /// Balance of the account at a precise moment in time.
    /// Encoded/decoded by serializers as "Current".
    /// </summary>
    [EnumMember(Value = "CRRT")]
    [IsoId("_ueofzvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance of the account at a precise moment in time.")]
    Current,
    
    /// <summary>
    /// Balance representing the actual total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, redemptions, etc.
    /// Encoded/decoded by serializers as "CustodyActual".
    /// </summary>
    [EnumMember(Value = "CUSA")]
    [IsoId("_ueyQwvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the actual total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, redemptions, etc.")]
    CustodyActual,
    
    /// <summary>
    /// Balance representing the projected total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, etc.
    /// Encoded/decoded by serializers as "Custody".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_ue8BwfRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the projected total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, etc.")]
    Custody,
    
    /// <summary>
    /// Balance representing the sum of all debit entries booked to an account.
    /// Encoded/decoded by serializers as "Debit".
    /// </summary>
    [EnumMember(Value = "DBIT")]
    [IsoId("_ue8BxPRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the sum of all debit entries booked to an account.")]
    Debit,
    
    /// <summary>
    /// Balance representing the intra day overdraft granted by the central bank to financial institutions participating in a RTGS system. This balance may vary over time and shall be offset at the end of the day.
    /// Encoded/decoded by serializers as "DaylightOverdraft".
    /// </summary>
    [EnumMember(Value = "DLOD")]
    [IsoId("_ue8Bx_RYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the intra day overdraft granted by the central bank to financial institutions participating in a RTGS system. This balance may vary over time and shall be offset at the end of the day.")]
    DaylightOverdraft,
    
    /// <summary>
    /// Balance representing the total outgoing payments that were put on hold because the debit limit has been exceeded.
    /// Encoded/decoded by serializers as "DebitOnHold".
    /// </summary>
    [EnumMember(Value = "DOHB")]
    [IsoId("_ufFLsvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the total outgoing payments that were put on hold because the debit limit has been exceeded.")]
    DebitOnHold,
    
    /// <summary>
    /// Balance representing the total outgoing payments that have been processed and are waiting for settlement.
    /// Encoded/decoded by serializers as "DebitProcessed".
    /// </summary>
    [EnumMember(Value = "DPBL")]
    [IsoId("_ufFLtfRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the total outgoing payments that have been processed and are waiting for settlement.")]
    DebitProcessed,
    
    /// <summary>
    /// Balance representing the cash equivalent of all settled securities transactions.
    /// Encoded/decoded by serializers as "DefinitiveSettledSecurities".
    /// </summary>
    [EnumMember(Value = "DSET")]
    [IsoId("_ufFLuPRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the cash equivalent of all settled securities transactions.")]
    DefinitiveSettledSecurities,
    
    /// <summary>
    /// Balance represents the discount window repo drawings.
    /// Encoded/decoded by serializers as "DiscountWindowRepoDrawings".
    /// </summary>
    [EnumMember(Value = "DWRD")]
    [IsoId("_ufFLu_RYEeuLhpyIdtJzwg")]
    [Description(@"Balance represents the discount window repo drawings.")]
    DiscountWindowRepoDrawings,
    
    /// <summary>
    /// Balance representing the potential loan a Central Bank would make in cash if the collateral is pledged, such as securities available and eligible as collateral with the central bank.
    /// Encoded/decoded by serializers as "EligibleAssets".
    /// </summary>
    [EnumMember(Value = "EAST")]
    [IsoId("_ufO8svRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the potential loan a Central Bank would make in cash if the collateral is pledged, such as securities available and eligible as collateral with the central bank.")]
    EligibleAssets,
    
    /// <summary>
    /// The code defines the threshold to the value excess reserve exemption balance between the exempt and non-exempt tiers of excess reserve. 
    /// Encoded/decoded by serializers as "ExcessReserveExemptionThresholdExemptTier".
    /// </summary>
    [EnumMember(Value = "EXRE")]
    [IsoId("_ufO8tfRYEeuLhpyIdtJzwg")]
    [Description(@"The code defines the threshold to the value excess reserve exemption balance between the exempt and non-exempt tiers of excess reserve. ")]
    ExcessReserveExemptionThresholdExemptTier,
    
    /// <summary>
    /// The code defines the balance beyond excess reserve exemption threshold within the periodic average balance for minimum reserve. Thus, this part of the excess reserve is still to be remunerated.
    /// Encoded/decoded by serializers as "ExcessReserveRemunerationBalanceNonExemptTier".
    /// </summary>
    [EnumMember(Value = "EXRR")]
    [IsoId("_ufO8uPRYEeuLhpyIdtJzwg")]
    [Description(@"The code defines the balance beyond excess reserve exemption threshold within the periodic average balance for minimum reserve. Thus, this part of the excess reserve is still to be remunerated.")]
    ExcessReserveRemunerationBalanceNonExemptTier,
    
    /// <summary>
    /// Balance representing the forecast of the cash-equivalent resulting from evaluation of existing holdings at central securities depositary that are qualified to serve as collateral.
    /// Encoded/decoded by serializers as "FirmCollateralisation".
    /// </summary>
    [EnumMember(Value = "FCOL")]
    [IsoId("_ufO8u_RYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the forecast of the cash-equivalent resulting from evaluation of existing holdings at central securities depositary that are qualified to serve as collateral.")]
    FirmCollateralisation,
    
    /// <summary>
    /// Balance representing the cash equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral and have been used as collateral.
    /// Encoded/decoded by serializers as "UsedAmountsFirmCollateralisation".
    /// </summary>
    [EnumMember(Value = "FCOU")]
    [IsoId("_ufYGovRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the cash equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral and have been used as collateral.")]
    UsedAmountsFirmCollateralisation,
    
    /// <summary>
    /// Balance representing the total of all balance types representing transactions to settle, blocked items and custody transactions.
    /// Encoded/decoded by serializers as "CashForecast".
    /// </summary>
    [EnumMember(Value = "FORC")]
    [IsoId("_ufYGpfRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the total of all balance types representing transactions to settle, blocked items and custody transactions.")]
    CashForecast,
    
    /// <summary>
    /// Balance representing the forecast of total of all cash legs for trades that are ready to settle via a central securities depository. Amounts shown are still subject to processing of the securities settlement.
    /// Encoded/decoded by serializers as "ForecastSettlement".
    /// </summary>
    [EnumMember(Value = "FSET")]
    [IsoId("_ufYGqPRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the forecast of total of all cash legs for trades that are ready to settle via a central securities depository. Amounts shown are still subject to processing of the securities settlement.")]
    ForecastSettlement,
    
    /// <summary>
    /// Balance representing the net amount to be funded resulting from all transactions which have an impact on the funding requirement.
    /// Encoded/decoded by serializers as "NetFunding".
    /// </summary>
    [EnumMember(Value = "FUND")]
    [IsoId("_ufYGq_RYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the net amount to be funded resulting from all transactions which have an impact on the funding requirement.")]
    NetFunding,
    
    /// <summary>
    /// Balance representing the total of the payments with a processing date in the future.
    /// Encoded/decoded by serializers as "TotalFuture".
    /// </summary>
    [EnumMember(Value = "FUTB")]
    [IsoId("_ufYGrvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the total of the payments with a processing date in the future.")]
    TotalFuture,
    
    /// <summary>
    /// Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as "Interim".
    /// </summary>
    [EnumMember(Value = "INTM")]
    [IsoId("_ufh3ovRYEeuLhpyIdtJzwg")]
    [Description(@"Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.")]
    Interim,
    
    /// <summary>
    /// Balance represents the intraday repo drawings.
    /// Encoded/decoded by serializers as "IntradayRepoDrawings".
    /// </summary>
    [EnumMember(Value = "IRDR")]
    [IsoId("_ufh3pfRYEeuLhpyIdtJzwg")]
    [Description(@"Balance represents the intraday repo drawings.")]
    IntradayRepoDrawings,
    
    /// <summary>
    /// Balance represents the intraday repo limit.
    /// Encoded/decoded by serializers as "IntradayRepoLimit".
    /// </summary>
    [EnumMember(Value = "IRLT")]
    [IsoId("_ufh3qPRYEeuLhpyIdtJzwg")]
    [Description(@"Balance represents the intraday repo limit.")]
    IntradayRepoLimit,
    
    /// <summary>
    /// Balance representing the cash equivalent of transactions with a lack of holdings.
    /// Encoded/decoded by serializers as "LackOfHoldingsTransactions".
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_ufh3q_RYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the cash equivalent of transactions with a lack of holdings.")]
    LackOfHoldingsTransactions,
    
    /// <summary>
    /// Balance of a specific limit value, such as a bilateral balance is calculated in relation to a given bilateral limit.
    /// Encoded/decoded by serializers as "LimitRelated".
    /// </summary>
    [EnumMember(Value = "LRLD")]
    [IsoId("_ufrBkvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance of a specific limit value, such as a bilateral balance is calculated in relation to a given bilateral limit.")]
    LimitRelated,
    
    /// <summary>
    /// Balance composed of the sum of all liquidity transfers made to or from an account.
    /// Encoded/decoded by serializers as "LiquidityTransfer".
    /// </summary>
    [EnumMember(Value = "LTSF")]
    [IsoId("_ufrBlfRYEeuLhpyIdtJzwg")]
    [Description(@"Balance composed of the sum of all liquidity transfers made to or from an account.")]
    LiquidityTransfer,
    
    /// <summary>
    /// Balance of the identified account plus the balance of all of its subaccounts.
    /// Encoded/decoded by serializers as "Master".
    /// </summary>
    [EnumMember(Value = "MSTR")]
    [IsoId("_ufrBmPRYEeuLhpyIdtJzwg")]
    [Description(@"Balance of the identified account plus the balance of all of its subaccounts.")]
    Master,
    
    /// <summary>
    /// Balance representing the amount that a financial institution has set aside for a specific reason and which is therefore not available.
    /// Encoded/decoded by serializers as "Noted".
    /// </summary>
    [EnumMember(Value = "NOTE")]
    [IsoId("_ufrBm_RYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the amount that a financial institution has set aside for a specific reason and which is therefore not available.")]
    Noted,
    
    /// <summary>
    /// Balance representing the cash equivalent of all non-settled securities transactions.
    /// Encoded/decoded by serializers as "NonSettledSecurities".
    /// </summary>
    [EnumMember(Value = "NSET")]
    [IsoId("_uf0ykvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the cash equivalent of all non-settled securities transactions.")]
    NonSettledSecurities,
    
    /// <summary>
    /// Book balance of the account at the beginning of the account servicer's business day. It always equals the closing book balance from the previous business day. |Note: the available balance at the beginning of the account servicer's business day may be different from the closing book balance from the previous business day.
    /// Encoded/decoded by serializers as "Opening".
    /// </summary>
    [EnumMember(Value = "OPNG")]
    [IsoId("_uf0ylfRYEeuLhpyIdtJzwg")]
    [Description(@"Book balance of the account at the beginning of the account servicer's business day. It always equals the closing book balance from the previous business day. |Note: the available balance at the beginning of the account servicer's business day may be different from the closing book balance from the previous business day.")]
    Opening,
    
    /// <summary>
    /// Balance representing the Forecast of the total of all cash-legs of transactions 'over the counter' (OTC), going through central counter party (CCP) functions.
    /// Encoded/decoded by serializers as "CCPGuaranteedOTCTransactions".
    /// </summary>
    [EnumMember(Value = "OTCC")]
    [IsoId("_uf-jkvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the Forecast of the total of all cash-legs of transactions 'over the counter' (OTC), going through central counter party (CCP) functions.")]
    CCPGuaranteedOTCTransactions,
    
    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded 'over the counter' (OTC).
    /// Encoded/decoded by serializers as "ForecastOTCTransactions".
    /// </summary>
    [EnumMember(Value = "OTCG")]
    [IsoId("_uf-jlfRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the forecast of the total of all cash legs of transactions traded 'over the counter' (OTC).")]
    ForecastOTCTransactions,
    
    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded 'over the counter' (OTC) not going through central counter party (CCP) functions.
    /// Encoded/decoded by serializers as "NonCCPGuaranteedOTCTransactions".
    /// </summary>
    [EnumMember(Value = "OTCN")]
    [IsoId("_uf-jmPRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the forecast of the total of all cash legs of transactions traded 'over the counter' (OTC) not going through central counter party (CCP) functions.")]
    NonCCPGuaranteedOTCTransactions,
    
    /// <summary>
    /// Balance representing the projected total of all cash legs for trades settling via a central securities depository that have been matched but blocked in order to not settle. These blocked transactions are not included in the calculation for settlement.
    /// Encoded/decoded by serializers as "OtherBlockedTrades".
    /// </summary>
    [EnumMember(Value = "OTHB")]
    [IsoId("_ugIUkvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the projected total of all cash legs for trades settling via a central securities depository that have been matched but blocked in order to not settle. These blocked transactions are not included in the calculation for settlement.")]
    OtherBlockedTrades,
    
    /// <summary>
    /// Balance of securities pending delivery, such as the orders to sell securities have been executed but settlement of the open transactions has not been confirmed.
    /// Encoded/decoded by serializers as "Pending".
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_ugIUlfRYEeuLhpyIdtJzwg")]
    [Description(@"Balance of securities pending delivery, such as the orders to sell securities have been executed but settlement of the open transactions has not been confirmed.")]
    Pending,
    
    /// <summary>
    /// Balance representing the fictive forecast of automated direct debits or payment based on standing arrangements between a central securities depository and the user.||||Usage: Pay-Ins and Pay-Outs can be different based on individual payment instructions or available funds.
    /// Encoded/decoded by serializers as "PayInPayOut".
    /// </summary>
    [EnumMember(Value = "PIPO")]
    [IsoId("_ugIUmPRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the fictive forecast of automated direct debits or payment based on standing arrangements between a central securities depository and the user.||||Usage: Pay-Ins and Pay-Outs can be different based on individual payment instructions or available funds.")]
    PayInPayOut,
    
    /// <summary>
    /// Average of the daily balances on the account used to fulfil the reserve requirements calculated from the beginning of the maintenance period.
    /// Encoded/decoded by serializers as "ProgressiveAverage".
    /// </summary>
    [EnumMember(Value = "PRAV")]
    [IsoId("_ugIUm_RYEeuLhpyIdtJzwg")]
    [Description(@"Average of the daily balances on the account used to fulfil the reserve requirements calculated from the beginning of the maintenance period.")]
    ProgressiveAverage,
    
    /// <summary>
    /// Balance representing the sum of entries as a result of payments processing. Entries relating to fees, interest, or other movements not a result of payments sent or received by the account owner are not included.
    /// Encoded/decoded by serializers as "Payment".
    /// </summary>
    [EnumMember(Value = "PYMT")]
    [IsoId("_ugIUnvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the sum of entries as a result of payments processing. Entries relating to fees, interest, or other movements not a result of payments sent or received by the account owner are not included.")]
    Payment,
    
    /// <summary>
    /// Balance representing the total of the payments that have been rejected.
    /// Encoded/decoded by serializers as "TotalRejected".
    /// </summary>
    [EnumMember(Value = "REJB")]
    [IsoId("_ugRegvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the total of the payments that have been rejected.")]
    TotalRejected,
    
    /// <summary>
    /// Balance represents the total of the central moneymarkets unit processor repo credits.
    /// Encoded/decoded by serializers as "CMUPRepoCredit".
    /// </summary>
    [EnumMember(Value = "REPC")]
    [IsoId("_ugRehfRYEeuLhpyIdtJzwg")]
    [Description(@"Balance represents the total of the central moneymarkets unit processor repo credits.")]
    CMUPRepoCredit,
    
    /// <summary>
    /// Balance represents the total of the central moneymarkets unit processor repo debits.
    /// Encoded/decoded by serializers as "CMUPRepoDebit".
    /// </summary>
    [EnumMember(Value = "REPD")]
    [IsoId("_ugReiPRYEeuLhpyIdtJzwg")]
    [Description(@"Balance represents the total of the central moneymarkets unit processor repo debits.")]
    CMUPRepoDebit,
    
    /// <summary>
    /// Balance of cash that may only be used under certain conditions.||Balance type is used to block securities/cash in the client account for example, when related to specific corporate actions, the holding is under the direct control of the system paying agent, who is the only one who can transfer securities out of this balance type.|Also known as the "escrow balance" or "sequestered balance".
    /// Encoded/decoded by serializers as "Restricted".
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_ugRei_RYEeuLhpyIdtJzwg")]
    [Description(@"Balance of cash that may only be used under certain conditions.||Balance type is used to block securities/cash in the client account for example, when related to specific corporate actions, the holding is under the direct control of the system paying agent, who is the only one who can transfer securities out of this balance type.|Also known as the ""escrow balance"" or ""sequestered balance"".")]
    Restricted,
    
    /// <summary>
    /// Balance represents the settlement account processor direct credit amount.
    /// Encoded/decoded by serializers as "SAPDirectCreditAmount".
    /// </summary>
    [EnumMember(Value = "SAPC")]
    [IsoId("_ugbPgvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance represents the settlement account processor direct credit amount.")]
    SAPDirectCreditAmount,
    
    /// <summary>
    /// Balance represents the settlement account processor direct debit amount.
    /// Encoded/decoded by serializers as "SAPDirectDebitAmount".
    /// </summary>
    [EnumMember(Value = "SAPD")]
    [IsoId("_ugbPhfRYEeuLhpyIdtJzwg")]
    [Description(@"Balance represents the settlement account processor direct debit amount.")]
    SAPDirectDebitAmount,
    
    /// <summary>
    /// Balance represents the settlement account processor queue amount.
    /// Encoded/decoded by serializers as "SAPQueueAmount".
    /// </summary>
    [EnumMember(Value = "SAPP")]
    [IsoId("_uglAgvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance represents the settlement account processor queue amount.")]
    SAPQueueAmount,
    
    /// <summary>
    /// Balance representing the forecast of the cash-equivalent resulting from evaluation of the net incoming balance of securities qualified to serve as collateral for which settlement instructions are held at.
    /// Encoded/decoded by serializers as "SelfCollateralisation".
    /// </summary>
    [EnumMember(Value = "SCOL")]
    [IsoId("_uglAhfRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the forecast of the cash-equivalent resulting from evaluation of the net incoming balance of securities qualified to serve as collateral for which settlement instructions are held at.")]
    SelfCollateralisation,
    
    /// <summary>
    /// Balance representing the cash-equivalent resulting from evaluation of incoming securities, qualified to serve as collateral and actually used as collateral, which have been settled during the settlement process.
    /// Encoded/decoded by serializers as "UsedAmountsSelfCollateralisation".
    /// </summary>
    [EnumMember(Value = "SCOU")]
    [IsoId("_uglAiPRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the cash-equivalent resulting from evaluation of incoming securities, qualified to serve as collateral and actually used as collateral, which have been settled during the settlement process.")]
    UsedAmountsSelfCollateralisation,
    
    /// <summary>
    /// Balance of the account identified (as opposed to Master Balance).
    /// Encoded/decoded by serializers as "Self".
    /// </summary>
    [EnumMember(Value = "SELF")]
    [IsoId("_uguKcvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance of the account identified (as opposed to Master Balance).")]
    Self,
    
    /// <summary>
    /// Balance representing the amount that will be destined for investment. Difference between available balance and threshold for investment limit.
    /// Encoded/decoded by serializers as "Threshold".
    /// </summary>
    [EnumMember(Value = "THRE")]
    [IsoId("_uguKdfRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the amount that will be destined for investment. Difference between available balance and threshold for investment limit.")]
    Threshold,
    
    /// <summary>
    /// Balance representing the total of the payments that were put on hold because the limits have been exceeded.
    /// Encoded/decoded by serializers as "TotalOnHold".
    /// </summary>
    [EnumMember(Value = "TOHB")]
    [IsoId("_uguKePRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the total of the payments that were put on hold because the limits have been exceeded.")]
    TotalOnHold,
    
    /// <summary>
    /// Balance representing the total of the payments that have been processed and are waiting for settlement during the day.
    /// Encoded/decoded by serializers as "TotalProcessed".
    /// </summary>
    [EnumMember(Value = "TPBL")]
    [IsoId("_uguKe_RYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the total of the payments that have been processed and are waiting for settlement during the day.")]
    TotalProcessed,
    
    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions in exchanges, going through CCP functions.
    /// Encoded/decoded by serializers as "CCPGuaranteedForecasting".
    /// </summary>
    [EnumMember(Value = "XCHC")]
    [IsoId("_ug37cvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the forecast of the total of all cash legs of transactions in exchanges, going through CCP functions.")]
    CCPGuaranteedForecasting,
    
    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges.
    /// Encoded/decoded by serializers as "ExchangeForecast".
    /// </summary>
    [EnumMember(Value = "XCHG")]
    [IsoId("_ug37dfRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges.")]
    ExchangeForecast,
    
    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges not going through central counter party (CCP) functions.
    /// Encoded/decoded by serializers as "NonCCPGuaranteedForecasting".
    /// </summary>
    [EnumMember(Value = "XCHN")]
    [IsoId("_ug37ePRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges not going through central counter party (CCP) functions.")]
    NonCCPGuaranteedForecasting,
    
    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day credit balance if everything books to the account and no other credit entry is posted.
    /// Encoded/decoded by serializers as "ExpectedCredit".
    /// </summary>
    [EnumMember(Value = "XCRD")]
    [IsoId("_ug37e_RYEeuLhpyIdtJzwg")]
    [Description(@"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day credit balance if everything books to the account and no other credit entry is posted.")]
    ExpectedCredit,
    
    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day debit balance if everything books to the account and no other debit entry is posted.
    /// Encoded/decoded by serializers as "ExpectedDebit".
    /// </summary>
    [EnumMember(Value = "XDBT")]
    [IsoId("_ug37fvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day debit balance if everything books to the account and no other debit entry is posted.")]
    ExpectedDebit,
    
    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.
    /// Encoded/decoded by serializers as "Expected".
    /// </summary>
    [EnumMember(Value = "XPCD")]
    [IsoId("_uhBFYvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.")]
    Expected,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalSystemBalanceType1CodeMetadataExtensions
{
    private static readonly ExternalSystemBalanceType1CodeDropdownSource _dropdownSource = new ExternalSystemBalanceType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalSystemBalanceType1CodeDropdownRow GetMetadata(this ExternalSystemBalanceType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


