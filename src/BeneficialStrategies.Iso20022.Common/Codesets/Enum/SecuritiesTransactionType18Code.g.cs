﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesTransactionType18Code.  ISO2002 ID# _v5KIUYymEea-QrbCUXny2w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies underlying information regarding the type of transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_v5KIUYymEea-QrbCUXny2w")]
[Description(@"Specifies underlying information regarding the type of transaction.")]
[DerivedFrom(typeof(SecuritiesTransactionTypeV2Code))]
public enum SecuritiesTransactionType18Code
{
    /// <summary>
    /// Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.
    /// Encoded/decoded by serializers as "CentralBankCollateralOperation".
    /// </summary>
    [EnumMember(Value = "CNCB")]
    [IsoId("_wySIsYymEea-QrbCUXny2w")]
    [Description(@"Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.")]
    CentralBankCollateralOperation,
    
    /// <summary>
    /// Relates to a buy sell back transaction.
    /// Encoded/decoded by serializers as "BuySellBack".
    /// </summary>
    [EnumMember(Value = "BSBK")]
    [IsoId("_wySIs4ymEea-QrbCUXny2w")]
    [Description(@"Relates to a buy sell back transaction.")]
    BuySellBack,
    
    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral taker or its agent.
    /// Encoded/decoded by serializers as "CollateralIn".
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_wySItYymEea-QrbCUXny2w")]
    [Description(@"Relates to a collateral transaction, from the point of view of the collateral taker or its agent.")]
    CollateralIn,
    
    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral giver or its agent.
    /// Encoded/decoded by serializers as "CollateralOut".
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_wySIt4ymEea-QrbCUXny2w")]
    [Description(@"Relates to a collateral transaction, from the point of view of the collateral giver or its agent.")]
    CollateralOut,
    
    /// <summary>
    /// Relates to the netting of settlement instructions.
    /// Encoded/decoded by serializers as "Netting".
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_wySIuYymEea-QrbCUXny2w")]
    [Description(@"Relates to the netting of settlement instructions.")]
    Netting,
    
    /// <summary>
    /// Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver).
    /// Encoded/decoded by serializers as "ExternalAccountTransfer".
    /// </summary>
    [EnumMember(Value = "OWNE")]
    [IsoId("_wySIu4ymEea-QrbCUXny2w")]
    [Description(@"Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver).")]
    ExternalAccountTransfer,
    
    /// <summary>
    /// Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver).
    /// Encoded/decoded by serializers as "InternalAccountTransfer".
    /// </summary>
    [EnumMember(Value = "OWNI")]
    [IsoId("_wySIvYymEea-QrbCUXny2w")]
    [Description(@"Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver).")]
    InternalAccountTransfer,
    
    /// <summary>
    /// Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.
    /// Encoded/decoded by serializers as "PairOff".
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("_wySIv4ymEea-QrbCUXny2w")]
    [Description(@"Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.")]
    PairOff,
    
    /// <summary>
    /// Relates to the placement/new issue of a financial instrument.
    /// Encoded/decoded by serializers as "Placement".
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("_wySIwYymEea-QrbCUXny2w")]
    [Description(@"Relates to the placement/new issue of a financial instrument.")]
    Placement,
    
    /// <summary>
    /// Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.
    /// Encoded/decoded by serializers as "PortfolioMove".
    /// </summary>
    [EnumMember(Value = "PORT")]
    [IsoId("_wySIw4ymEea-QrbCUXny2w")]
    [Description(@"Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.")]
    PortfolioMove,
    
    /// <summary>
    /// Relates to a realignment of positions.
    /// Encoded/decoded by serializers as "Realignment".
    /// </summary>
    [EnumMember(Value = "REAL")]
    [IsoId("_wySIxYymEea-QrbCUXny2w")]
    [Description(@"Relates to a realignment of positions.")]
    Realignment,
    
    /// <summary>
    /// Relates to a redemption of funds (funds industry only).
    /// Encoded/decoded by serializers as "Redemption".
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_wySIx4ymEea-QrbCUXny2w")]
    [Description(@"Relates to a redemption of funds (funds industry only).")]
    Redemption,
    
    /// <summary>
    /// Relates to a repurchase agreement transaction.
    /// Encoded/decoded by serializers as "Repo".
    /// </summary>
    [EnumMember(Value = "REPU")]
    [IsoId("_wySIyYymEea-QrbCUXny2w")]
    [Description(@"Relates to a repurchase agreement transaction.")]
    Repo,
    
    /// <summary>
    /// Relates to a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as "ReverseRepo".
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_wySIy4ymEea-QrbCUXny2w")]
    [Description(@"Relates to a reverse repurchase agreement transaction.")]
    ReverseRepo,
    
    /// <summary>
    /// Relates to a securities borrowing operation.
    /// Encoded/decoded by serializers as "SecuritiesBorrowing".
    /// </summary>
    [EnumMember(Value = "SECB")]
    [IsoId("_wySIzYymEea-QrbCUXny2w")]
    [Description(@"Relates to a securities borrowing operation.")]
    SecuritiesBorrowing,
    
    /// <summary>
    /// Relates to a securities lending operation.
    /// Encoded/decoded by serializers as "SecuritiesLending".
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_wySIz4ymEea-QrbCUXny2w")]
    [Description(@"Relates to a securities lending operation.")]
    SecuritiesLending,
    
    /// <summary>
    /// Relates to a subscription to funds (funds industry only).
    /// Encoded/decoded by serializers as "Subscription".
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_wySI0YymEea-QrbCUXny2w")]
    [Description(@"Relates to a subscription to funds (funds industry only).")]
    Subscription,
    
    /// <summary>
    /// Relates to the settlement of a trade.
    /// Encoded/decoded by serializers as "Trade".
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_wySI04ymEea-QrbCUXny2w")]
    [Description(@"Relates to the settlement of a trade.")]
    Trade,
    
    /// <summary>
    /// Relates to a triparty repurchase agreement.
    /// Encoded/decoded by serializers as "TripartyRepo".
    /// </summary>
    [EnumMember(Value = "TRPO")]
    [IsoId("_wySI1YymEea-QrbCUXny2w")]
    [Description(@"Relates to a triparty repurchase agreement.")]
    TripartyRepo,
    
    /// <summary>
    /// Relates to a triparty reverse repurchase agreement.
    /// Encoded/decoded by serializers as "TripartyReverseRepo".
    /// </summary>
    [EnumMember(Value = "TRVO")]
    [IsoId("_wySI14ymEea-QrbCUXny2w")]
    [Description(@"Relates to a triparty reverse repurchase agreement.")]
    TripartyReverseRepo,
    
    /// <summary>
    /// Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.
    /// Encoded/decoded by serializers as "Turnaround".
    /// </summary>
    [EnumMember(Value = "TURN")]
    [IsoId("_wySI2YymEea-QrbCUXny2w")]
    [Description(@"Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.")]
    Turnaround,
    
    /// <summary>
    /// Relates to an auto-collateralisation movement.
    /// Encoded/decoded by serializers as "AutoCollateralisation".
    /// </summary>
    [EnumMember(Value = "AUTO")]
    [IsoId("_wySI24ymEea-QrbCUXny2w")]
    [Description(@"Relates to an auto-collateralisation movement.")]
    AutoCollateralisation,
    
    /// <summary>
    /// Relates to a market claim.
    /// Encoded/decoded by serializers as "MarketClaim".
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_wySI3YymEea-QrbCUXny2w")]
    [Description(@"Relates to a market claim.")]
    MarketClaim,
    
    /// <summary>
    /// Relates to a corporate action.
    /// Encoded/decoded by serializers as "CorporateAction".
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_wySI34ymEea-QrbCUXny2w")]
    [Description(@"Relates to a corporate action.")]
    CorporateAction,
    
    /// <summary>
    /// Relates to an ETF creation or redemption.
    /// Encoded/decoded by serializers as "ExchangeTradedFunds".
    /// </summary>
    [EnumMember(Value = "ETFT")]
    [IsoId("_wySI4YymEea-QrbCUXny2w")]
    [Description(@"Relates to an ETF creation or redemption.")]
    ExchangeTradedFunds,
    
    /// <summary>
    /// Transaction relates to a buy-in by the market following a delivery transaction failure.
    /// Encoded/decoded by serializers as "BuyIn".
    /// </summary>
    [EnumMember(Value = "BIYI")]
    [IsoId("_0n6WcYymEea-QrbCUXny2w")]
    [Description(@"Transaction relates to a buy-in by the market following a delivery transaction failure.")]
    BuyIn,
    
    /// <summary>
    /// Relates to a depository receipt conversion.
    /// Encoded/decoded by serializers as "DepositoryReceiptConversion".
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_8rjFEY68Eeaa5_S8lsRKCQ")]
    [Description(@"Relates to a depository receipt conversion.")]
    DepositoryReceiptConversion,
    
    /// <summary>
    /// Relates to the issuance of a security such as an equity or a depositary receipt.
    /// Encoded/decoded by serializers as "Issuance".
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_96inwY68Eeaa5_S8lsRKCQ")]
    [Description(@"Relates to the issuance of a security such as an equity or a depositary receipt.")]
    Issuance,
    
    /// <summary>
    /// Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corp. event realigned).
    /// Encoded/decoded by serializers as "MarkDown".
    /// </summary>
    [EnumMember(Value = "MKDW")]
    [IsoId("_-3_HcY68Eeaa5_S8lsRKCQ")]
    [Description(@"Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corp. event realigned).")]
    MarkDown,
    
    /// <summary>
    /// Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corporate event realigned).
    /// Encoded/decoded by serializers as "MarkUp".
    /// </summary>
    [EnumMember(Value = "MKUP")]
    [IsoId("__OKLwY68Eeaa5_S8lsRKCQ")]
    [Description(@"Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corporate event realigned).")]
    MarkUp,
    
    /// <summary>
    /// Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement.
    /// Encoded/decoded by serializers as "NonSyndicated".
    /// </summary>
    [EnumMember(Value = "NSYN")]
    [IsoId("__9Km0Y68Eeaa5_S8lsRKCQ")]
    [Description(@"Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement.")]
    NonSyndicated,
    
    /// <summary>
    /// Relates to the withdrawal of specified amounts from specified subaccounts.
    /// Encoded/decoded by serializers as "Withdrawal".
    /// </summary>
    [EnumMember(Value = "REDI")]
    [IsoId("_CnXjQY69Eeaa5_S8lsRKCQ")]
    [Description(@"Relates to the withdrawal of specified amounts from specified subaccounts.")]
    Withdrawal,
    
    /// <summary>
    /// Relates to a release (into/from local) of depository receipt operation.
    /// Encoded/decoded by serializers as "DepositoryReceiptReleaseCancellation".
    /// </summary>
    [EnumMember(Value = "RELE")]
    [IsoId("_D4cwoY69Eeaa5_S8lsRKCQ")]
    [Description(@"Relates to a release (into/from local) of depository receipt operation.")]
    DepositoryReceiptReleaseCancellation,
    
    /// <summary>
    /// Relates to a sell buy back transaction.
    /// Encoded/decoded by serializers as "SellBuyBack".
    /// </summary>
    [EnumMember(Value = "SBBK")]
    [IsoId("_FXW-oY69Eeaa5_S8lsRKCQ")]
    [Description(@"Relates to a sell buy back transaction.")]
    SellBuyBack,
    
    /// <summary>
    /// Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.
    /// Encoded/decoded by serializers as "SyndicateUnderwriters".
    /// </summary>
    [EnumMember(Value = "SYND")]
    [IsoId("_F66-sY69Eeaa5_S8lsRKCQ")]
    [Description(@"Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.")]
    SyndicateUnderwriters,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesTransactionType18CodeMetadataExtensions
{
    private static readonly SecuritiesTransactionType18CodeDropdownSource _dropdownSource = new SecuritiesTransactionType18CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesTransactionType18CodeDropdownRow GetMetadata(this SecuritiesTransactionType18Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


