﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesTransactionType10Code.  ISO2002 ID# _0Oaigf8qEeCQ-IWv9MUPeQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies underlying information regarding the type of transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0Oaigf8qEeCQ-IWv9MUPeQ")]
[Description(@"Specifies underlying information regarding the type of transaction.")]
[DerivedFrom(typeof(SecuritiesTransactionTypeV2Code))]
public enum SecuritiesTransactionType10Code
{
    /// <summary>
    /// Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.
    /// Encoded/decoded by serializers as "CentralBankCollateralOperation".
    /// </summary>
    [EnumMember(Value = "CNCB")]
    [IsoId("_0Ojsdf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.")]
    CentralBankCollateralOperation,
    
    /// <summary>
    /// Relates to a buy sell back transaction.
    /// Encoded/decoded by serializers as "BuySellBack".
    /// </summary>
    [EnumMember(Value = "BSBK")]
    [IsoId("_0Ojsef8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a buy sell back transaction.")]
    BuySellBack,
    
    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral taker or its agent.
    /// Encoded/decoded by serializers as "CollateralIn".
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_0Ojsff8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a collateral transaction, from the point of view of the collateral taker or its agent.")]
    CollateralIn,
    
    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral giver or its agent.
    /// Encoded/decoded by serializers as "CollateralOut".
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_0Ojsgf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a collateral transaction, from the point of view of the collateral giver or its agent.")]
    CollateralOut,
    
    /// <summary>
    /// Relates to the netting of settlement instructions.
    /// Encoded/decoded by serializers as "Netting".
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_0Ojshf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to the netting of settlement instructions.")]
    Netting,
    
    /// <summary>
    /// Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver).
    /// Encoded/decoded by serializers as "ExternalAccountTransfer".
    /// </summary>
    [EnumMember(Value = "OWNE")]
    [IsoId("_0Ojsif8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver).")]
    ExternalAccountTransfer,
    
    /// <summary>
    /// Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver).
    /// Encoded/decoded by serializers as "InternalAccountTransfer".
    /// </summary>
    [EnumMember(Value = "OWNI")]
    [IsoId("_0Ojsjf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver).")]
    InternalAccountTransfer,
    
    /// <summary>
    /// Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.
    /// Encoded/decoded by serializers as "PairOff".
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("_0Ojskf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.")]
    PairOff,
    
    /// <summary>
    /// Relates to the placement/new issue of a financial instrument.
    /// Encoded/decoded by serializers as "Placement".
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("_0Ojslf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to the placement/new issue of a financial instrument.")]
    Placement,
    
    /// <summary>
    /// Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.
    /// Encoded/decoded by serializers as "PortfolioMove".
    /// </summary>
    [EnumMember(Value = "PORT")]
    [IsoId("_0Ojsmf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.")]
    PortfolioMove,
    
    /// <summary>
    /// Relates to a realignment of positions.
    /// Encoded/decoded by serializers as "Realignment".
    /// </summary>
    [EnumMember(Value = "REAL")]
    [IsoId("_0Ojsnf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a realignment of positions.")]
    Realignment,
    
    /// <summary>
    /// Relates to a redemption of funds (funds industry only).
    /// Encoded/decoded by serializers as "Redemption".
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_0Ojsof8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a redemption of funds (funds industry only).")]
    Redemption,
    
    /// <summary>
    /// Relates to a repurchase agreement transaction.
    /// Encoded/decoded by serializers as "Repo".
    /// </summary>
    [EnumMember(Value = "REPU")]
    [IsoId("_0Ojspf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a repurchase agreement transaction.")]
    Repo,
    
    /// <summary>
    /// Relates to a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as "ReverseRepo".
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_0Ojsqf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a reverse repurchase agreement transaction.")]
    ReverseRepo,
    
    /// <summary>
    /// Relates to a securities borrowing operation.
    /// Encoded/decoded by serializers as "SecuritiesBorrowing".
    /// </summary>
    [EnumMember(Value = "SECB")]
    [IsoId("_0Ojsrf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a securities borrowing operation.")]
    SecuritiesBorrowing,
    
    /// <summary>
    /// Relates to a securities lending operation.
    /// Encoded/decoded by serializers as "SecuritiesLending".
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_0Ojssf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a securities lending operation.")]
    SecuritiesLending,
    
    /// <summary>
    /// Relates to a subscription to funds (funds industry only).
    /// Encoded/decoded by serializers as "Subscription".
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_0Ojstf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a subscription to funds (funds industry only).")]
    Subscription,
    
    /// <summary>
    /// Relates to the settlement of a trade.
    /// Encoded/decoded by serializers as "Trade".
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_0Ojsuf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to the settlement of a trade.")]
    Trade,
    
    /// <summary>
    /// Relates to a triparty repurchase agreement.
    /// Encoded/decoded by serializers as "TripartyRepo".
    /// </summary>
    [EnumMember(Value = "TRPO")]
    [IsoId("_0Ojsvf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a triparty repurchase agreement.")]
    TripartyRepo,
    
    /// <summary>
    /// Relates to a triparty reverse repurchase agreement.
    /// Encoded/decoded by serializers as "TripartyReverseRepo".
    /// </summary>
    [EnumMember(Value = "TRVO")]
    [IsoId("_0Ojswf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a triparty reverse repurchase agreement.")]
    TripartyReverseRepo,
    
    /// <summary>
    /// Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.
    /// Encoded/decoded by serializers as "Turnaround".
    /// </summary>
    [EnumMember(Value = "TURN")]
    [IsoId("_0Ojsxf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.")]
    Turnaround,
    
    /// <summary>
    /// Relates to an auto-collateralisation movement.
    /// Encoded/decoded by serializers as "AutoCollateralisation".
    /// </summary>
    [EnumMember(Value = "AUTO")]
    [IsoId("_0Ojsyf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to an auto-collateralisation movement.")]
    AutoCollateralisation,
    
    /// <summary>
    /// Relates to a market claim.
    /// Encoded/decoded by serializers as "MarketClaim".
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_0Ojszf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a market claim.")]
    MarketClaim,
    
    /// <summary>
    /// Relates to a corporate action.
    /// Encoded/decoded by serializers as "CorporateAction".
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_0Ojs0f8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a corporate action.")]
    CorporateAction,
    
    /// <summary>
    /// Relates to an ETF creation or redemption.
    /// Encoded/decoded by serializers as "ExchangeTradedFunds".
    /// </summary>
    [EnumMember(Value = "ETFT")]
    [IsoId("_1QIeNv8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to an ETF creation or redemption.")]
    ExchangeTradedFunds,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesTransactionType10CodeMetadataExtensions
{
    private static readonly SecuritiesTransactionType10CodeDropdownSource _dropdownSource = new SecuritiesTransactionType10CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesTransactionType10CodeDropdownRow GetMetadata(this SecuritiesTransactionType10Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


