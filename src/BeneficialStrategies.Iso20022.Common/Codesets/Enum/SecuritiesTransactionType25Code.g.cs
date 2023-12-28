﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesTransactionType25Code.  ISO2002 ID# _xKn5AdYOEeiHVOfMzoKxnA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// ??
    /// Encoded/decoded by serializers as "BuySellBack".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhodYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    BuySellBack,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BuyIn".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejho9YOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    BuyIn,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CentralBankCollateralOperation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhpdYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    CentralBankCollateralOperation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CollateralIn".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhp9YOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    CollateralIn,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CollateralOut".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhqdYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    CollateralOut,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DepositoryReceiptConversion".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhq9YOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    DepositoryReceiptConversion,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FactorUpdate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhrdYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    FactorUpdate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MoveOfStock".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhr9YOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    MoveOfStock,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Issuance".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhsdYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    Issuance,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarkDown".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhs9YOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    MarkDown,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarkUp".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhtdYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    MarkUp,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Netting".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejht9YOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    Netting,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonSyndicated".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhudYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    NonSyndicated,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExternalAccountTransfer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhu9YOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    ExternalAccountTransfer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InternalAccountTransfer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhvdYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    InternalAccountTransfer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PairOff".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhv9YOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    PairOff,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Placement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhwdYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    Placement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PortfolioMove".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhw9YOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    PortfolioMove,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Realignment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhxdYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    Realignment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Withdrawal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhx9YOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    Withdrawal,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Redemption".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhydYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    Redemption,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DepositoryReceiptReleaseCancellation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhy9YOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    DepositoryReceiptReleaseCancellation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Repo".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhzdYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    Repo,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReturnDeliveryWithoutMatching".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejhz9YOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    ReturnDeliveryWithoutMatching,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReverseRepurchaseAgreement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejh0dYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    ReverseRepurchaseAgreement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SellBuyBack".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejh09YOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    SellBuyBack,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BorrowingReallocation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejh1dYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    BorrowingReallocation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecuritiesBorrowing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejh19YOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    SecuritiesBorrowing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecuritiesLending".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejh2dYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    SecuritiesLending,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LendingReallocation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejh29YOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    LendingReallocation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Subscription".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejh3dYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    Subscription,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SyndicateUnderwriters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejh39YOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    SyndicateUnderwriters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TBAClosing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejh4dYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    TBAClosing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Trade".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejh49YOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    Trade,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TripartyRepo".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejh5dYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    TripartyRepo,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TripartyReverseRepo".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejh59YOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    TripartyReverseRepo,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Turnaround".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejh6dYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    Turnaround,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketClaim".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejh69YOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    MarketClaim,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CorporateAction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejh7dYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    CorporateAction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AutoCollateralisation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejh79YOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    AutoCollateralisation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SwitchFrom".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejh8dYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    SwitchFrom,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SwitchTo".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejh89YOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    SwitchTo,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExchangeTradedFunds".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xejh9dYOEeiHVOfMzoKxnA")]
    [Description(@"??")]
    ExchangeTradedFunds,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Rebalancing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Av_rYdYPEeiHVOfMzoKxnA")]
    [Description(@"??")]
    Rebalancing,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesTransactionType25CodeMetadataExtensions
{
    private static readonly SecuritiesTransactionType25CodeDropdownSource _dropdownSource = new SecuritiesTransactionType25CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesTransactionType25CodeDropdownRow GetMetadata(this SecuritiesTransactionType25Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

