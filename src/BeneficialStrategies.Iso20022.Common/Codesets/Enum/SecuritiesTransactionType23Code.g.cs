﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesTransactionType23Code.  ISO2002 ID# _7umhANEfEeiO-eodGv5iKQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies underlying information regarding the type of settlement transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7umhANEfEeiO-eodGv5iKQ")]
[Description(@"Specifies underlying information regarding the type of settlement transaction.")]
[DerivedFrom(typeof(SecuritiesTransactionTypeV4Code))]
public enum SecuritiesTransactionType23Code
{
    /// <summary>
    /// Relates to a buy sell back transaction.
    /// Encoded/decoded by serializers as "BSBK".
    /// </summary>
    [EnumMember(Value = "BSBK")]
    [IsoId("_M0NXEdEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to a buy sell back transaction.")]
    BuySellBack = SecuritiesTransactionTypeV4Code.BuySellBack, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral taker or its agent.
    /// Encoded/decoded by serializers as "COLI".
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_NMxoEdEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to a collateral transaction, from the point of view of the collateral taker or its agent.")]
    CollateralIn = SecuritiesTransactionTypeV4Code.CollateralIn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral giver or its agent.
    /// Encoded/decoded by serializers as "COLO".
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_NTHgodEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to a collateral transaction, from the point of view of the collateral giver or its agent.")]
    CollateralOut = SecuritiesTransactionTypeV4Code.CollateralOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceeds of corporate event realigned).
    /// Encoded/decoded by serializers as "MKDW".
    /// </summary>
    [EnumMember(Value = "MKDW")]
    [IsoId("_QcqrgdEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceeds of corporate event realigned).")]
    MarkDown = SecuritiesTransactionTypeV4Code.MarkDown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceeds of corporate event realigned).
    /// Encoded/decoded by serializers as "MKUP".
    /// </summary>
    [EnumMember(Value = "MKUP")]
    [IsoId("_Qs9KQdEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceeds of corporate event realigned).")]
    MarkUp = SecuritiesTransactionTypeV4Code.MarkUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the netting of settlement instructions.
    /// Encoded/decoded by serializers as "NETT".
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_Q_7wodEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to the netting of settlement instructions.")]
    Netting = SecuritiesTransactionTypeV4Code.Netting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the issue of medium and short term paper (CP, CD, MTN, notes) under a program and without syndication arrangement.
    /// Encoded/decoded by serializers as "NSYN".
    /// </summary>
    [EnumMember(Value = "NSYN")]
    [IsoId("_RKgB4dEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to the issue of medium and short term paper (CP, CD, MTN, notes) under a program and without syndication arrangement.")]
    NonSyndicated = SecuritiesTransactionTypeV4Code.NonSyndicated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.
    /// Encoded/decoded by serializers as "PAIR".
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("_RcFhIdEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.")]
    PairOff = SecuritiesTransactionTypeV4Code.PairOff, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the placement/new issue of a financial instrument.
    /// Encoded/decoded by serializers as "PLAC".
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("_RlOPAdEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to the placement/new issue of a financial instrument.")]
    Placement = SecuritiesTransactionTypeV4Code.Placement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.
    /// Encoded/decoded by serializers as "PORT".
    /// </summary>
    [EnumMember(Value = "PORT")]
    [IsoId("_Rs_q8dEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.")]
    PortfolioMove = SecuritiesTransactionTypeV4Code.PortfolioMove, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a realignment of positions.
    /// Encoded/decoded by serializers as "REAL".
    /// </summary>
    [EnumMember(Value = "REAL")]
    [IsoId("_SKIS4dEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to a realignment of positions.")]
    Realignment = SecuritiesTransactionTypeV4Code.Realignment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a redemption of funds (funds industry only).
    /// Encoded/decoded by serializers as "REDM".
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_SSqj0dEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to a redemption of funds (funds industry only).")]
    Redemption = SecuritiesTransactionTypeV4Code.Redemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a repurchase agreement transaction.
    /// Encoded/decoded by serializers as "REPU".
    /// </summary>
    [EnumMember(Value = "REPU")]
    [IsoId("_Si6mUdEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to a repurchase agreement transaction.")]
    Repo = SecuritiesTransactionTypeV4Code.Repo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the return of financial instruments resulting from a rejected delivery without a matching operation.
    /// Encoded/decoded by serializers as "RODE".
    /// </summary>
    [EnumMember(Value = "RODE")]
    [IsoId("_S3o5IdEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to the return of financial instruments resulting from a rejected delivery without a matching operation.")]
    ReturnDeliveryWithoutMatching = SecuritiesTransactionTypeV4Code.ReturnDeliveryWithoutMatching, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as "RVPO".
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_S-S6wdEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to a reverse repurchase agreement transaction.")]
    ReverseRepurchaseAgreement = SecuritiesTransactionTypeV4Code.ReverseRepurchaseAgreement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a securities borrowing operation.
    /// Encoded/decoded by serializers as "SECB".
    /// </summary>
    [EnumMember(Value = "SECB")]
    [IsoId("_TNRK4dEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to a securities borrowing operation.")]
    SecuritiesBorrowing = SecuritiesTransactionTypeV4Code.SecuritiesBorrowing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a securities lending operation.
    /// Encoded/decoded by serializers as "SECL".
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_TUP8odEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to a securities lending operation.")]
    SecuritiesLending = SecuritiesTransactionTypeV4Code.SecuritiesLending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a subscription to funds (funds industry only).
    /// Encoded/decoded by serializers as "SUBS".
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_UE_dEdEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to a subscription to funds (funds industry only).")]
    Subscription = SecuritiesTransactionTypeV4Code.Subscription, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.
    /// Encoded/decoded by serializers as "SYND".
    /// </summary>
    [EnumMember(Value = "SYND")]
    [IsoId("_UXvZ8dEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.")]
    SyndicateUnderwriters = SecuritiesTransactionTypeV4Code.SyndicateUnderwriters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a To Be Announced (TBA) closing trade.
    /// Encoded/decoded by serializers as "TBAC".
    /// </summary>
    [EnumMember(Value = "TBAC")]
    [IsoId("_UeGgodEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to a To Be Announced (TBA) closing trade.")]
    TBAClosing = SecuritiesTransactionTypeV4Code.TBAClosing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the settlement of a trade.
    /// Encoded/decoded by serializers as "TRAD".
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_Us05IdEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to the settlement of a trade.")]
    Trade = SecuritiesTransactionTypeV4Code.Trade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a triparty repurchase agreement.
    /// Encoded/decoded by serializers as "TRPO".
    /// </summary>
    [EnumMember(Value = "TRPO")]
    [IsoId("_Uy7hIdEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to a triparty repurchase agreement.")]
    TripartyRepo = SecuritiesTransactionTypeV4Code.TripartyRepo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a triparty reverse repurchase agreement.
    /// Encoded/decoded by serializers as "TRVO".
    /// </summary>
    [EnumMember(Value = "TRVO")]
    [IsoId("_U5LTEdEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to a triparty reverse repurchase agreement.")]
    TripartyReverseRepo = SecuritiesTransactionTypeV4Code.TripartyReverseRepo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.
    /// Encoded/decoded by serializers as "TURN".
    /// </summary>
    [EnumMember(Value = "TURN")]
    [IsoId("_VDRqQdEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.")]
    Turnaround = SecuritiesTransactionTypeV4Code.Turnaround, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a buy-in by the market following a delivery transaction failure.
    /// Encoded/decoded by serializers as "BYIY".
    /// </summary>
    [EnumMember(Value = "BYIY")]
    [IsoId("_fsV6sdEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to a buy-in by the market following a delivery transaction failure.")]
    BuyIn = SecuritiesTransactionTypeV4Code.BuyIn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.
    /// Encoded/decoded by serializers as "CNCB".
    /// </summary>
    [EnumMember(Value = "CNCB")]
    [IsoId("_jOsAEdEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.")]
    CentralBankCollateralOperation = SecuritiesTransactionTypeV4Code.CentralBankCollateralOperation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to an account transfer involving more than one instructing party (message sender) and/or account servicer (messages receiver).
    /// Encoded/decoded by serializers as "OWNE".
    /// </summary>
    [EnumMember(Value = "OWNE")]
    [IsoId("_2_R1sdEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to an account transfer involving more than one instructing party (message sender) and/or account servicer (messages receiver).")]
    ExternalAccountTransfer = SecuritiesTransactionTypeV4Code.ExternalAccountTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a factor update.
    /// Encoded/decoded by serializers as "FCTA".
    /// </summary>
    [EnumMember(Value = "FCTA")]
    [IsoId("_4k5IodEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to a factor update.")]
    FactorUpdate = SecuritiesTransactionTypeV4Code.FactorUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to an account transfer involving one instructing party (message sender) at one account servicer (messages receiver).
    /// Encoded/decoded by serializers as "OWNI".
    /// </summary>
    [EnumMember(Value = "OWNI")]
    [IsoId("_7OV3IdEgEeiO-eodGv5iKQ")]
    [Description(@"Relates to an account transfer involving one instructing party (message sender) at one account servicer (messages receiver).")]
    InternalAccountTransfer = SecuritiesTransactionTypeV4Code.InternalAccountTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a release (into/from local) of depository receipt operation.
    /// Encoded/decoded by serializers as "RELE".
    /// </summary>
    [EnumMember(Value = "RELE")]
    [IsoId("_qK8DsdEkEeiO-eodGv5iKQ")]
    [Description(@"Relates to a release (into/from local) of depository receipt operation.")]
    DepositoryReceiptReleaseCancellation = SecuritiesTransactionTypeV4Code.DepositoryReceiptReleaseCancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Internal reallocation of a borrowed holding from one safekeeping account to another.
    /// Encoded/decoded by serializers as "SBRE".
    /// </summary>
    [EnumMember(Value = "SBRE")]
    [IsoId("_yOlKAdEkEeiO-eodGv5iKQ")]
    [Description(@"Internal reallocation of a borrowed holding from one safekeeping account to another.")]
    BorrowingReallocation = SecuritiesTransactionTypeV4Code.BorrowingReallocation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a corporate action.
    /// Encoded/decoded by serializers as "CORP".
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_5Mc7EdEkEeiO-eodGv5iKQ")]
    [Description(@"Relates to a corporate action.")]
    CorporateAction = SecuritiesTransactionTypeV4Code.CorporateAction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a market claim.
    /// Encoded/decoded by serializers as "CLAI".
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_77absdEkEeiO-eodGv5iKQ")]
    [Description(@"Relates to a market claim.")]
    MarketClaim = SecuritiesTransactionTypeV4Code.MarketClaim, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to an auto-collateralisation movement.
    /// Encoded/decoded by serializers as "AUTO".
    /// </summary>
    [EnumMember(Value = "AUTO")]
    [IsoId("_9jGyQdEkEeiO-eodGv5iKQ")]
    [Description(@"Relates to an auto-collateralisation movement.")]
    AutoCollateralisation = SecuritiesTransactionTypeV4Code.AutoCollateralisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a change of an investment from one sub-fund to another sub-fund (redemption-leg).
    /// Encoded/decoded by serializers as "SWIF".
    /// </summary>
    [EnumMember(Value = "SWIF")]
    [IsoId("_DQfy4dElEeiO-eodGv5iKQ")]
    [Description(@"Transaction is a change of an investment from one sub-fund to another sub-fund (redemption-leg).")]
    SwitchFrom = SecuritiesTransactionTypeV4Code.SwitchFrom, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a change of an investment from one sub-fund to another sub-fund (subscription-leg).
    /// Encoded/decoded by serializers as "SWIT".
    /// </summary>
    [EnumMember(Value = "SWIT")]
    [IsoId("_DWvk0dElEeiO-eodGv5iKQ")]
    [Description(@"Transaction is a change of an investment from one sub-fund to another sub-fund (subscription-leg).")]
    SwitchTo = SecuritiesTransactionTypeV4Code.SwitchTo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a depository receipt conversion.
    /// Encoded/decoded by serializers as "CONV".
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_RromwdElEeiO-eodGv5iKQ")]
    [Description(@"Relates to a depository receipt conversion.")]
    DepositoryReceiptConversion = SecuritiesTransactionTypeV4Code.DepositoryReceiptConversion, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to an ETF creation or redemption.
    /// Encoded/decoded by serializers as "ETFT".
    /// </summary>
    [EnumMember(Value = "ETFT")]
    [IsoId("_czqEEdElEeiO-eodGv5iKQ")]
    [Description(@"Relates to an ETF creation or redemption.")]
    ExchangeTradedFunds = SecuritiesTransactionTypeV4Code.ExchangeTradedFunds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the issuance of a security such as an equity or a depositary receipt.
    /// Encoded/decoded by serializers as "ISSU".
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_iyTz0dElEeiO-eodGv5iKQ")]
    [Description(@"Relates to the issuance of a security such as an equity or a depositary receipt.")]
    Issuance = SecuritiesTransactionTypeV4Code.Issuance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Internal reallocation of a holding on loan from one safekeeping account to another.
    /// Encoded/decoded by serializers as "SLRE".
    /// </summary>
    [EnumMember(Value = "SLRE")]
    [IsoId("_kIvbQdElEeiO-eodGv5iKQ")]
    [Description(@"Internal reallocation of a holding on loan from one safekeeping account to another.")]
    LendingReallocation = SecuritiesTransactionTypeV4Code.LendingReallocation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a movement of shares into or out of a pooled account.
    /// Encoded/decoded by serializers as "INSP".
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("_mXt0QdElEeiO-eodGv5iKQ")]
    [Description(@"Relates to a movement of shares into or out of a pooled account.")]
    MoveOfStock = SecuritiesTransactionTypeV4Code.MoveOfStock, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a sell buy back transaction.
    /// Encoded/decoded by serializers as "SBBK".
    /// </summary>
    [EnumMember(Value = "SBBK")]
    [IsoId("_zWKnsdElEeiO-eodGv5iKQ")]
    [Description(@"Relates to a sell buy back transaction.")]
    SellBuyBack = SecuritiesTransactionTypeV4Code.SellBuyBack, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the withdrawal of specified amounts from specified subaccounts.
    /// Encoded/decoded by serializers as "REDI".
    /// </summary>
    [EnumMember(Value = "REDI")]
    [IsoId("_4zCgEdElEeiO-eodGv5iKQ")]
    [Description(@"Relates to the withdrawal of specified amounts from specified subaccounts.")]
    Withdrawal = SecuritiesTransactionTypeV4Code.Withdrawal, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesTransactionType23CodeMetadataExtensions
{
    private static readonly SecuritiesTransactionType23CodeDropdownSource _dropdownSource = new SecuritiesTransactionType23CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesTransactionType23CodeDropdownRow GetMetadata(this SecuritiesTransactionType23Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


