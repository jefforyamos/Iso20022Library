﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradeTransactionCondition3Code.  ISO2002 ID# _YobMYNp-Ed-ak6NoX_4Aeg_1891584902.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the conditions under which the order/trade is to be/was executed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YobMYNp-Ed-ak6NoX_4Aeg_1891584902")]
[Description(@"Specifies the conditions under which the order/trade is to be/was executed.")]
[DerivedFrom(typeof(TradeTransactionConditionCode))]
public enum TradeTransactionCondition3Code
{
    /// <summary>
    /// Indicates whether the trade is executed cum bonus.
    /// Encoded/decoded by serializers as "CumBonus".
    /// </summary>
    [EnumMember(Value = "CBNS")]
    [IsoId("_YobMYdp-Ed-ak6NoX_4Aeg_1891584904")]
    [Description(@"Indicates whether the trade is executed cum bonus.")]
    CumBonus,
    
    /// <summary>
    /// Indicates whether the trade is executed ex bonus.
    /// Encoded/decoded by serializers as "ExBonus".
    /// </summary>
    [EnumMember(Value = "XBNS")]
    [IsoId("_YobMYtp-Ed-ak6NoX_4Aeg_1891584919")]
    [Description(@"Indicates whether the trade is executed ex bonus.")]
    ExBonus,
    
    /// <summary>
    /// Indicates whether the trade is executed cum coupon.
    /// Encoded/decoded by serializers as "CumCoupon".
    /// </summary>
    [EnumMember(Value = "CCPN")]
    [IsoId("_YobMY9p-Ed-ak6NoX_4Aeg_1891584920")]
    [Description(@"Indicates whether the trade is executed cum coupon.")]
    CumCoupon,
    
    /// <summary>
    /// Indicates whether the trade is executed ex coupon.
    /// Encoded/decoded by serializers as "ExCoupon".
    /// </summary>
    [EnumMember(Value = "XCPN")]
    [IsoId("_YobMZNp-Ed-ak6NoX_4Aeg_1891584937")]
    [Description(@"Indicates whether the trade is executed ex coupon.")]
    ExCoupon,
    
    /// <summary>
    /// Indicates whether the trade is executed cum dividend.
    /// Encoded/decoded by serializers as "CumDividend".
    /// </summary>
    [EnumMember(Value = "CDIV")]
    [IsoId("_YobMZdp-Ed-ak6NoX_4Aeg_1891584938")]
    [Description(@"Indicates whether the trade is executed cum dividend.")]
    CumDividend,
    
    /// <summary>
    /// Indicates whether the trade is executed ex dividend.
    /// Encoded/decoded by serializers as "ExDividend".
    /// </summary>
    [EnumMember(Value = "XDIV")]
    [IsoId("_YobMZtp-Ed-ak6NoX_4Aeg_1898972621")]
    [Description(@"Indicates whether the trade is executed ex dividend.")]
    ExDividend,
    
    /// <summary>
    /// Indicates whether the trade is executed cum rights.
    /// Encoded/decoded by serializers as "CumRights".
    /// </summary>
    [EnumMember(Value = "CRTS")]
    [IsoId("_YobMZ9p-Ed-ak6NoX_4Aeg_1898972622")]
    [Description(@"Indicates whether the trade is executed cum rights.")]
    CumRights,
    
    /// <summary>
    /// Indicates whether the trade is executed ex rights.
    /// Encoded/decoded by serializers as "ExRights".
    /// </summary>
    [EnumMember(Value = "XRTS")]
    [IsoId("_YobMaNp-Ed-ak6NoX_4Aeg_1898972639")]
    [Description(@"Indicates whether the trade is executed ex rights.")]
    ExRights,
    
    /// <summary>
    /// Indicates whether the trade is executed cum warrant.
    /// Encoded/decoded by serializers as "CumWarrant".
    /// </summary>
    [EnumMember(Value = "CWAR")]
    [IsoId("_YokWUNp-Ed-ak6NoX_4Aeg_1898972640")]
    [Description(@"Indicates whether the trade is executed cum warrant.")]
    CumWarrant,
    
    /// <summary>
    /// Indicates whether the trade is executed ex warrant.
    /// Encoded/decoded by serializers as "ExWarrant".
    /// </summary>
    [EnumMember(Value = "XWAR")]
    [IsoId("_YokWUdp-Ed-ak6NoX_4Aeg_1898972656")]
    [Description(@"Indicates whether the trade is executed ex warrant.")]
    ExWarrant,
    
    /// <summary>
    /// Indicates whether the trade is executed with a special cum 
    /// dividend, that is, buying after the ex date and getting the dividend.
    /// Encoded/decoded by serializers as "SpecialCumDividend".
    /// </summary>
    [EnumMember(Value = "SPCU")]
    [IsoId("_YokWUtp-Ed-ak6NoX_4Aeg_1898972657")]
    [Description(@"Indicates whether the trade is executed with a special cum  dividend, that is, buying after the ex date and getting the dividend.")]
    SpecialCumDividend,
    
    /// <summary>
    /// Indicates whether the trade is executed with a special ex 
    /// dividend, that is, selling before the ex date without the coupon.
    /// Encoded/decoded by serializers as "SpecialExDividend".
    /// </summary>
    [EnumMember(Value = "SPEX")]
    [IsoId("_YokWU9p-Ed-ak6NoX_4Aeg_1898972666")]
    [Description(@"Indicates whether the trade is executed with a special ex  dividend, that is, selling before the ex date without the coupon.")]
    SpecialExDividend,
    
    /// <summary>
    /// Indicates that the trade is executed cum-dividend or cum-coupon and a due bill is required. |A due bill is a contractual agreement to pay the dividend along with the delivery of |the financial instrument.
    /// Encoded/decoded by serializers as "BrokerDueBill".
    /// </summary>
    [EnumMember(Value = "DUEB")]
    [IsoId("_YokWVNp-Ed-ak6NoX_4Aeg_1898972674")]
    [Description(@"Indicates that the trade is executed cum-dividend or cum-coupon and a due bill is required. |A due bill is a contractual agreement to pay the dividend along with the delivery of |the financial instrument.")]
    BrokerDueBill,
    
    /// <summary>
    /// Indicates whether the trade is sold short. When the seller does not have the |financial instrument, the delivery is effected by borrowing the financial instrument by or |for the account of the seller.
    /// Encoded/decoded by serializers as "SoldShort".
    /// </summary>
    [EnumMember(Value = "SSTI")]
    [IsoId("_YokWVdp-Ed-ak6NoX_4Aeg_1898972675")]
    [Description(@"Indicates whether the trade is sold short. When the seller does not have the |financial instrument, the delivery is effected by borrowing the financial instrument by or |for the account of the seller.")]
    SoldShort,
    
    /// <summary>
    /// Indicates that the trade is executed dirty, ie government tax must be paid on the accrued interest on the bond.
    /// Encoded/decoded by serializers as "Dirty".
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_YokWVtp-Ed-ak6NoX_4Aeg_1898972699")]
    [Description(@"Indicates that the trade is executed dirty, ie government tax must be paid on the accrued interest on the bond.")]
    Dirty,
    
    /// <summary>
    /// Indicates that the trade is executed clean, ie government tax must not be paid on the accrued interest on the bond.
    /// Encoded/decoded by serializers as "Clean".
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_YokWV9p-Ed-ak6NoX_4Aeg_1898972700")]
    [Description(@"Indicates that the trade is executed clean, ie government tax must not be paid on the accrued interest on the bond.")]
    Clean,
    
    /// <summary>
    /// Indicates whether the trade is a block trade or not, ie, whether allocation instruction will follow or not.
    /// Encoded/decoded by serializers as "Block".
    /// </summary>
    [EnumMember(Value = "BLKO")]
    [IsoId("_YokWWNp-Ed-ak6NoX_4Aeg_1898972716")]
    [Description(@"Indicates whether the trade is a block trade or not, ie, whether allocation instruction will follow or not.")]
    Block,
    
    /// <summary>
    /// Indicates whether the delivery of the financial instrument on settlement date |is guaranteed.
    /// Encoded/decoded by serializers as "GuaranteedDelivery".
    /// </summary>
    [EnumMember(Value = "GTDL")]
    [IsoId("_YokWWdp-Ed-ak6NoX_4Aeg_1898972717")]
    [Description(@"Indicates whether the delivery of the financial instrument on settlement date |is guaranteed.")]
    GuaranteedDelivery,
    
    /// <summary>
    /// Indicates whether fractional parts are allowed.
    /// Encoded/decoded by serializers as "Fractions".
    /// </summary>
    [EnumMember(Value = "FRAC")]
    [IsoId("_YouHUNp-Ed-ak6NoX_4Aeg_1898972734")]
    [Description(@"Indicates whether fractional parts are allowed.")]
    Fractions,
    
    /// <summary>
    /// Indicates that cross trades are allowed whereby buy and sell orders are offset without recording the trade on the exchange.
    /// Encoded/decoded by serializers as "CrossTrade".
    /// </summary>
    [EnumMember(Value = "CRST")]
    [IsoId("_YouHUdp-Ed-ak6NoX_4Aeg_1898972735")]
    [Description(@"Indicates that cross trades are allowed whereby buy and sell orders are offset without recording the trade on the exchange.")]
    CrossTrade,
    
    /// <summary>
    /// Indicates that cross trades, whereby buy and sell orders are offset without recording the trade on the exchange, are not allowed.
    /// Encoded/decoded by serializers as "NoCrossTrade".
    /// </summary>
    [EnumMember(Value = "NCRS")]
    [IsoId("_YouHUtp-Ed-ak6NoX_4Aeg_1898972976")]
    [Description(@"Indicates that cross trades, whereby buy and sell orders are offset without recording the trade on the exchange, are not allowed.")]
    NoCrossTrade,
    
    /// <summary>
    /// Indicates that the order is to be executed by a trading party other than the trading party to which the |order is sent. In this case, the instructing party has traded with another broker which will |subsequently send an advice of execution to the executing party who received the order |and which is acting as clearing broker.
    /// Encoded/decoded by serializers as "DirectOrder".
    /// </summary>
    [EnumMember(Value = "DORD")]
    [IsoId("_YouHU9p-Ed-ak6NoX_4Aeg_1898972977")]
    [Description(@"Indicates that the order is to be executed by a trading party other than the trading party to which the |order is sent. In this case, the instructing party has traded with another broker which will |subsequently send an advice of execution to the executing party who received the order |and which is acting as clearing broker.")]
    DirectOrder,
    
    /// <summary>
    /// Indicates that the order must be executed with a specific trading party.
    /// Encoded/decoded by serializers as "DirectedOrder".
    /// </summary>
    [EnumMember(Value = "DIOR")]
    [IsoId("_YouHVNp-Ed-ak6NoX_4Aeg_1898972978")]
    [Description(@"Indicates that the order must be executed with a specific trading party.")]
    DirectedOrder,
    
    /// <summary>
    /// Warehouse Trade.
    /// Encoded/decoded by serializers as "WarehouseTrade".
    /// </summary>
    [EnumMember(Value = "WARE")]
    [IsoId("_YouHVdp-Ed-ak6NoX_4Aeg_1898972993")]
    [Description(@"Warehouse Trade.")]
    WarehouseTrade,
    
    /// <summary>
    /// A limit order to buy or a stop order to sell or a stop limit order which is not to be increased in shares on the ex-dividend date as a result of a stock dividend or distribution.
    /// Encoded/decoded by serializers as "NotIncrease".
    /// </summary>
    [EnumMember(Value = "DNIN")]
    [IsoId("_YouHVtp-Ed-ak6NoX_4Aeg_1898973011")]
    [Description(@"A limit order to buy or a stop order to sell or a stop limit order which is not to be increased in shares on the ex-dividend date as a result of a stock dividend or distribution.")]
    NotIncrease,
    
    /// <summary>
    /// A limit order to buy or a stop order to sell, or a stop-limit order to sell which is not to be reduced in price by the amount of an ordinary cash dividend. Only applies to ordinary stock dividends; it should be reduced for other distributions. e.g. when a stock goes 'ex' stock dividend or rights.
    /// Encoded/decoded by serializers as "NotReduce".
    /// </summary>
    [EnumMember(Value = "DNRE")]
    [IsoId("_YouHV9p-Ed-ak6NoX_4Aeg_1898973028")]
    [Description(@"A limit order to buy or a stop order to sell, or a stop-limit order to sell which is not to be reduced in price by the amount of an ordinary cash dividend. Only applies to ordinary stock dividends; it should be reduced for other distributions. e.g. when a stock goes 'ex' stock dividend or rights.")]
    NotReduce,
    
    /// <summary>
    /// Indicates that the order is based on a forward price.
    /// Encoded/decoded by serializers as "ForwardPriceTrade".
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_YouHWNp-Ed-ak6NoX_4Aeg_1898973029")]
    [Description(@"Indicates that the order is based on a forward price.")]
    ForwardPriceTrade,
    
    /// <summary>
    /// Indicates that the order is based on a historic price.
    /// Encoded/decoded by serializers as "HistoricPriceTrade".
    /// </summary>
    [EnumMember(Value = "HIST")]
    [IsoId("_YouHWdp-Ed-ak6NoX_4Aeg_1898973046")]
    [Description(@"Indicates that the order is based on a historic price.")]
    HistoricPriceTrade,
    
    /// <summary>
    /// Result of option when set. (UK specific).
    /// Encoded/decoded by serializers as "ResultOption".
    /// </summary>
    [EnumMember(Value = "BCRO")]
    [IsoId("_Yo3RQNp-Ed-ak6NoX_4Aeg_1898973047")]
    [Description(@"Result of option when set. (UK specific).")]
    ResultOption,
    
    /// <summary>
    /// Result of repo when set (UK specific).
    /// Encoded/decoded by serializers as "ResultRepo".
    /// </summary>
    [EnumMember(Value = "BCRP")]
    [IsoId("_Yo3RQdp-Ed-ak6NoX_4Aeg_1898973071")]
    [Description(@"Result of repo when set (UK specific).")]
    ResultRepo,
    
    /// <summary>
    /// Place of delivery, in country of incorporation when unset (UK specific).
    /// Encoded/decoded by serializers as "DeliverCountryIncorporation".
    /// </summary>
    [EnumMember(Value = "BCPD")]
    [IsoId("_Yo3RQtp-Ed-ak6NoX_4Aeg_1898973072")]
    [Description(@"Place of delivery, in country of incorporation when unset (UK specific).")]
    DeliverCountryIncorporation,
    
    /// <summary>
    /// Form of delivery, not for foreign registration when unset (UK specific).
    /// Encoded/decoded by serializers as "DeliveryForm".
    /// </summary>
    [EnumMember(Value = "BCFD")]
    [IsoId("_Yo3RQ9p-Ed-ak6NoX_4Aeg_1898973088")]
    [Description(@"Form of delivery, not for foreign registration when unset (UK specific).")]
    DeliveryForm,
    
    /// <summary>
    /// Board lots, not set for odd lots (UK specific).
    /// Encoded/decoded by serializers as "BoardLot".
    /// </summary>
    [EnumMember(Value = "BCBL")]
    [IsoId("_Yo3RRNp-Ed-ak6NoX_4Aeg_1898973089")]
    [Description(@"Board lots, not set for odd lots (UK specific).")]
    BoardLot,
    
    /// <summary>
    /// Bad names, not set for good names (UK specific).
    /// Encoded/decoded by serializers as "BadName".
    /// </summary>
    [EnumMember(Value = "BCBN")]
    [IsoId("_Yo3RRdp-Ed-ak6NoX_4Aeg_1898973106")]
    [Description(@"Bad names, not set for good names (UK specific).")]
    BadName,
    
    /// <summary>
    /// Trade was executed at market price.
    /// Encoded/decoded by serializers as "MarketPrice".
    /// </summary>
    [EnumMember(Value = "MAPR")]
    [IsoId("_Yo3RRtp-Ed-ak6NoX_4Aeg_-2079226165")]
    [Description(@"Trade was executed at market price.")]
    MarketPrice,
    
    /// <summary>
    /// Trade for which the price is not the one quoted but an improved one, that is, the negotiated price.
    /// Encoded/decoded by serializers as "NegotiatedTrade".
    /// </summary>
    [EnumMember(Value = "NEGO")]
    [IsoId("_Yo3RR9p-Ed-ak6NoX_4Aeg_-2003495363")]
    [Description(@"Trade for which the price is not the one quoted but an improved one, that is, the negotiated price.")]
    NegotiatedTrade,
    
    /// <summary>
    /// Trade was executed outside of normal market conditions, for example, in the case of an iceberg order.
    /// Encoded/decoded by serializers as "NonMarketPrice".
    /// </summary>
    [EnumMember(Value = "NMPR")]
    [IsoId("_Yo3RSNp-Ed-ak6NoX_4Aeg_1216951482")]
    [Description(@"Trade was executed outside of normal market conditions, for example, in the case of an iceberg order.")]
    NonMarketPrice,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradeTransactionCondition3CodeMetadataExtensions
{
    private static readonly TradeTransactionCondition3CodeDropdownSource _dropdownSource = new TradeTransactionCondition3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradeTransactionCondition3CodeDropdownRow GetMetadata(this TradeTransactionCondition3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


