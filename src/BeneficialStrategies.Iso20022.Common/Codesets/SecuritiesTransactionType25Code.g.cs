﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesTransactionType25Code.  ISO2002 ID# _xKn5AdYOEeiHVOfMzoKxnA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies underlying information regarding the type of settlement transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xKn5AdYOEeiHVOfMzoKxnA")]
[Description(@"Specifies underlying information regarding the type of settlement transaction.")]
[DerivedFrom(typeof(SecuritiesTransactionTypeV4Code))]
public enum SecuritiesTransactionType25Code
{
    /// <summary>
    /// Relates to a buy sell back transaction.
    /// Encoded/decoded by serializers as &quot;BSBK&quot;.
    /// </summary>
    [EnumMember(Value = "BSBK")]
    [IsoId("_xejhodYOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a buy sell back transaction.")]
    BuySellBack = SecuritiesTransactionTypeV4Code.BuySellBack, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a buy-in by the market following a delivery transaction failure.
    /// Encoded/decoded by serializers as &quot;BYIY&quot;.
    /// </summary>
    [EnumMember(Value = "BYIY")]
    [IsoId("_xejho9YOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a buy-in by the market following a delivery transaction failure.")]
    BuyIn = SecuritiesTransactionTypeV4Code.BuyIn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.
    /// Encoded/decoded by serializers as &quot;CNCB&quot;.
    /// </summary>
    [EnumMember(Value = "CNCB")]
    [IsoId("_xejhpdYOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.")]
    CentralBankCollateralOperation = SecuritiesTransactionTypeV4Code.CentralBankCollateralOperation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral taker or its agent.
    /// Encoded/decoded by serializers as &quot;COLI&quot;.
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_xejhp9YOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a collateral transaction, from the point of view of the collateral taker or its agent.")]
    CollateralIn = SecuritiesTransactionTypeV4Code.CollateralIn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral giver or its agent.
    /// Encoded/decoded by serializers as &quot;COLO&quot;.
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_xejhqdYOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a collateral transaction, from the point of view of the collateral giver or its agent.")]
    CollateralOut = SecuritiesTransactionTypeV4Code.CollateralOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a depository receipt conversion.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_xejhq9YOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a depository receipt conversion.")]
    DepositoryReceiptConversion = SecuritiesTransactionTypeV4Code.DepositoryReceiptConversion, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a factor update.
    /// Encoded/decoded by serializers as &quot;FCTA&quot;.
    /// </summary>
    [EnumMember(Value = "FCTA")]
    [IsoId("_xejhrdYOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a factor update.")]
    FactorUpdate = SecuritiesTransactionTypeV4Code.FactorUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a movement of shares into or out of a pooled account.
    /// Encoded/decoded by serializers as &quot;INSP&quot;.
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("_xejhr9YOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a movement of shares into or out of a pooled account.")]
    MoveOfStock = SecuritiesTransactionTypeV4Code.MoveOfStock, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the issuance of a security such as an equity or a depositary receipt.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_xejhsdYOEeiHVOfMzoKxnA")]
    [Description(@"Relates to the issuance of a security such as an equity or a depositary receipt.")]
    Issuance = SecuritiesTransactionTypeV4Code.Issuance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceeds of corporate event realigned).
    /// Encoded/decoded by serializers as &quot;MKDW&quot;.
    /// </summary>
    [EnumMember(Value = "MKDW")]
    [IsoId("_xejhs9YOEeiHVOfMzoKxnA")]
    [Description(@"Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceeds of corporate event realigned).")]
    MarkDown = SecuritiesTransactionTypeV4Code.MarkDown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceeds of corporate event realigned).
    /// Encoded/decoded by serializers as &quot;MKUP&quot;.
    /// </summary>
    [EnumMember(Value = "MKUP")]
    [IsoId("_xejhtdYOEeiHVOfMzoKxnA")]
    [Description(@"Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceeds of corporate event realigned).")]
    MarkUp = SecuritiesTransactionTypeV4Code.MarkUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the netting of settlement instructions.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_xejht9YOEeiHVOfMzoKxnA")]
    [Description(@"Relates to the netting of settlement instructions.")]
    Netting = SecuritiesTransactionTypeV4Code.Netting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the issue of medium and short term paper (CP, CD, MTN, notes) under a program and without syndication arrangement.
    /// Encoded/decoded by serializers as &quot;NSYN&quot;.
    /// </summary>
    [EnumMember(Value = "NSYN")]
    [IsoId("_xejhudYOEeiHVOfMzoKxnA")]
    [Description(@"Relates to the issue of medium and short term paper (CP, CD, MTN, notes) under a program and without syndication arrangement.")]
    NonSyndicated = SecuritiesTransactionTypeV4Code.NonSyndicated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to an account transfer involving more than one instructing party (message sender) and/or account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNE&quot;.
    /// </summary>
    [EnumMember(Value = "OWNE")]
    [IsoId("_xejhu9YOEeiHVOfMzoKxnA")]
    [Description(@"Relates to an account transfer involving more than one instructing party (message sender) and/or account servicer (messages receiver).")]
    ExternalAccountTransfer = SecuritiesTransactionTypeV4Code.ExternalAccountTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to an account transfer involving one instructing party (message sender) at one account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNI&quot;.
    /// </summary>
    [EnumMember(Value = "OWNI")]
    [IsoId("_xejhvdYOEeiHVOfMzoKxnA")]
    [Description(@"Relates to an account transfer involving one instructing party (message sender) at one account servicer (messages receiver).")]
    InternalAccountTransfer = SecuritiesTransactionTypeV4Code.InternalAccountTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.
    /// Encoded/decoded by serializers as &quot;PAIR&quot;.
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("_xejhv9YOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.")]
    PairOff = SecuritiesTransactionTypeV4Code.PairOff, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the placement/new issue of a financial instrument.
    /// Encoded/decoded by serializers as &quot;PLAC&quot;.
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("_xejhwdYOEeiHVOfMzoKxnA")]
    [Description(@"Relates to the placement/new issue of a financial instrument.")]
    Placement = SecuritiesTransactionTypeV4Code.Placement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.
    /// Encoded/decoded by serializers as &quot;PORT&quot;.
    /// </summary>
    [EnumMember(Value = "PORT")]
    [IsoId("_xejhw9YOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.")]
    PortfolioMove = SecuritiesTransactionTypeV4Code.PortfolioMove, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a realignment of positions.
    /// Encoded/decoded by serializers as &quot;REAL&quot;.
    /// </summary>
    [EnumMember(Value = "REAL")]
    [IsoId("_xejhxdYOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a realignment of positions.")]
    Realignment = SecuritiesTransactionTypeV4Code.Realignment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the withdrawal of specified amounts from specified subaccounts.
    /// Encoded/decoded by serializers as &quot;REDI&quot;.
    /// </summary>
    [EnumMember(Value = "REDI")]
    [IsoId("_xejhx9YOEeiHVOfMzoKxnA")]
    [Description(@"Relates to the withdrawal of specified amounts from specified subaccounts.")]
    Withdrawal = SecuritiesTransactionTypeV4Code.Withdrawal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a redemption of funds (funds industry only).
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_xejhydYOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a redemption of funds (funds industry only).")]
    Redemption = SecuritiesTransactionTypeV4Code.Redemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a release (into/from local) of depository receipt operation.
    /// Encoded/decoded by serializers as &quot;RELE&quot;.
    /// </summary>
    [EnumMember(Value = "RELE")]
    [IsoId("_xejhy9YOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a release (into/from local) of depository receipt operation.")]
    DepositoryReceiptReleaseCancellation = SecuritiesTransactionTypeV4Code.DepositoryReceiptReleaseCancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;REPU&quot;.
    /// </summary>
    [EnumMember(Value = "REPU")]
    [IsoId("_xejhzdYOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a repurchase agreement transaction.")]
    Repo = SecuritiesTransactionTypeV4Code.Repo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the return of financial instruments resulting from a rejected delivery without a matching operation.
    /// Encoded/decoded by serializers as &quot;RODE&quot;.
    /// </summary>
    [EnumMember(Value = "RODE")]
    [IsoId("_xejhz9YOEeiHVOfMzoKxnA")]
    [Description(@"Relates to the return of financial instruments resulting from a rejected delivery without a matching operation.")]
    ReturnDeliveryWithoutMatching = SecuritiesTransactionTypeV4Code.ReturnDeliveryWithoutMatching, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;RVPO&quot;.
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_xejh0dYOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a reverse repurchase agreement transaction.")]
    ReverseRepurchaseAgreement = SecuritiesTransactionTypeV4Code.ReverseRepurchaseAgreement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a sell buy back transaction.
    /// Encoded/decoded by serializers as &quot;SBBK&quot;.
    /// </summary>
    [EnumMember(Value = "SBBK")]
    [IsoId("_xejh09YOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a sell buy back transaction.")]
    SellBuyBack = SecuritiesTransactionTypeV4Code.SellBuyBack, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Internal reallocation of a borrowed holding from one safekeeping account to another.
    /// Encoded/decoded by serializers as &quot;SBRE&quot;.
    /// </summary>
    [EnumMember(Value = "SBRE")]
    [IsoId("_xejh1dYOEeiHVOfMzoKxnA")]
    [Description(@"Internal reallocation of a borrowed holding from one safekeeping account to another.")]
    BorrowingReallocation = SecuritiesTransactionTypeV4Code.BorrowingReallocation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a securities borrowing operation.
    /// Encoded/decoded by serializers as &quot;SECB&quot;.
    /// </summary>
    [EnumMember(Value = "SECB")]
    [IsoId("_xejh19YOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a securities borrowing operation.")]
    SecuritiesBorrowing = SecuritiesTransactionTypeV4Code.SecuritiesBorrowing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a securities lending operation.
    /// Encoded/decoded by serializers as &quot;SECL&quot;.
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_xejh2dYOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a securities lending operation.")]
    SecuritiesLending = SecuritiesTransactionTypeV4Code.SecuritiesLending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Internal reallocation of a holding on loan from one safekeeping account to another.
    /// Encoded/decoded by serializers as &quot;SLRE&quot;.
    /// </summary>
    [EnumMember(Value = "SLRE")]
    [IsoId("_xejh29YOEeiHVOfMzoKxnA")]
    [Description(@"Internal reallocation of a holding on loan from one safekeeping account to another.")]
    LendingReallocation = SecuritiesTransactionTypeV4Code.LendingReallocation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a subscription to funds (funds industry only).
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_xejh3dYOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a subscription to funds (funds industry only).")]
    Subscription = SecuritiesTransactionTypeV4Code.Subscription, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.
    /// Encoded/decoded by serializers as &quot;SYND&quot;.
    /// </summary>
    [EnumMember(Value = "SYND")]
    [IsoId("_xejh39YOEeiHVOfMzoKxnA")]
    [Description(@"Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.")]
    SyndicateUnderwriters = SecuritiesTransactionTypeV4Code.SyndicateUnderwriters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a To Be Announced (TBA) closing trade.
    /// Encoded/decoded by serializers as &quot;TBAC&quot;.
    /// </summary>
    [EnumMember(Value = "TBAC")]
    [IsoId("_xejh4dYOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a To Be Announced (TBA) closing trade.")]
    TBAClosing = SecuritiesTransactionTypeV4Code.TBAClosing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the settlement of a trade.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_xejh49YOEeiHVOfMzoKxnA")]
    [Description(@"Relates to the settlement of a trade.")]
    Trade = SecuritiesTransactionTypeV4Code.Trade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a triparty repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRPO&quot;.
    /// </summary>
    [EnumMember(Value = "TRPO")]
    [IsoId("_xejh5dYOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a triparty repurchase agreement.")]
    TripartyRepo = SecuritiesTransactionTypeV4Code.TripartyRepo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a triparty reverse repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRVO&quot;.
    /// </summary>
    [EnumMember(Value = "TRVO")]
    [IsoId("_xejh59YOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a triparty reverse repurchase agreement.")]
    TripartyReverseRepo = SecuritiesTransactionTypeV4Code.TripartyReverseRepo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.
    /// Encoded/decoded by serializers as &quot;TURN&quot;.
    /// </summary>
    [EnumMember(Value = "TURN")]
    [IsoId("_xejh6dYOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.")]
    Turnaround = SecuritiesTransactionTypeV4Code.Turnaround, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a market claim.
    /// Encoded/decoded by serializers as &quot;CLAI&quot;.
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_xejh69YOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a market claim.")]
    MarketClaim = SecuritiesTransactionTypeV4Code.MarketClaim, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a corporate action.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_xejh7dYOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a corporate action.")]
    CorporateAction = SecuritiesTransactionTypeV4Code.CorporateAction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to an auto-collateralisation movement.
    /// Encoded/decoded by serializers as &quot;AUTO&quot;.
    /// </summary>
    [EnumMember(Value = "AUTO")]
    [IsoId("_xejh79YOEeiHVOfMzoKxnA")]
    [Description(@"Relates to an auto-collateralisation movement.")]
    AutoCollateralisation = SecuritiesTransactionTypeV4Code.AutoCollateralisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a change of an investment from one sub-fund to another sub-fund (redemption-leg).
    /// Encoded/decoded by serializers as &quot;SWIF&quot;.
    /// </summary>
    [EnumMember(Value = "SWIF")]
    [IsoId("_xejh8dYOEeiHVOfMzoKxnA")]
    [Description(@"Transaction is a change of an investment from one sub-fund to another sub-fund (redemption-leg).")]
    SwitchFrom = SecuritiesTransactionTypeV4Code.SwitchFrom, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a change of an investment from one sub-fund to another sub-fund (subscription-leg).
    /// Encoded/decoded by serializers as &quot;SWIT&quot;.
    /// </summary>
    [EnumMember(Value = "SWIT")]
    [IsoId("_xejh89YOEeiHVOfMzoKxnA")]
    [Description(@"Transaction is a change of an investment from one sub-fund to another sub-fund (subscription-leg).")]
    SwitchTo = SecuritiesTransactionTypeV4Code.SwitchTo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to an ETF creation or redemption.
    /// Encoded/decoded by serializers as &quot;ETFT&quot;.
    /// </summary>
    [EnumMember(Value = "ETFT")]
    [IsoId("_xejh9dYOEeiHVOfMzoKxnA")]
    [Description(@"Relates to an ETF creation or redemption.")]
    ExchangeTradedFunds = SecuritiesTransactionTypeV4Code.ExchangeTradedFunds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a rebalanced transaction.
    /// Encoded/decoded by serializers as &quot;REBL&quot;.
    /// </summary>
    [EnumMember(Value = "REBL")]
    [IsoId("_Av_rYdYPEeiHVOfMzoKxnA")]
    [Description(@"Relates to a rebalanced transaction.")]
    Rebalancing = SecuritiesTransactionTypeV4Code.Rebalancing, // same ordinal as derivation source for type conversions
    
}
