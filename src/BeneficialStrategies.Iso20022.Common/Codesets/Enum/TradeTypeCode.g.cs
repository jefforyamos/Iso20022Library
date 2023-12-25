﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradeTypeCode.  ISO2002 ID# _YqNVE9p-Ed-ak6NoX_4Aeg_1275192520.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of executed order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YqNVE9p-Ed-ak6NoX_4Aeg_1275192520")]
[Description(@"Specifies the type of executed order.")]
public enum TradeTypeCode
{
    /// <summary>
    /// A basket trade, i.e. a unit of 15 or more financial instruments used in program trading.
    /// </summary>
    [EnumMember(Value = "BSKT")]
    [IsoId("_YqNVFNp-Ed-ak6NoX_4Aeg_1180327952")]
    [Description(@"A basket trade, i.e. a unit of 15 or more financial instruments used in program trading.")]
    BSKT,
    
    /// <summary>
    /// A trade of a predetermined set of financial instruments.
    /// </summary>
    [EnumMember(Value = "INDX")]
    [IsoId("_YqNVFdp-Ed-ak6NoX_4Aeg_1200645094")]
    [Description(@"A trade of a predetermined set of financial instruments.")]
    INDX,
    
    /// <summary>
    /// A trade of a predetermined set of financial instruments.
    /// </summary>
    [EnumMember(Value = "LIST")]
    [IsoId("_YqNVFtp-Ed-ak6NoX_4Aeg_1221883891")]
    [Description(@"A trade of a predetermined set of financial instruments.")]
    LIST,
    
    /// <summary>
    /// A pre-allocated trade.
    /// </summary>
    [EnumMember(Value = "PRAL")]
    [IsoId("_YqNVF9p-Ed-ak6NoX_4Aeg_1236661357")]
    [Description(@"A pre-allocated trade.")]
    PRAL,
    
    /// <summary>
    /// A program trade, i.e. a computer-driven trade of buying and selling of baskets of 15 or more financial instruments by index arbitrage specialists or institutional traders.
    /// </summary>
    [EnumMember(Value = "PROG")]
    [IsoId("_YqNVGNp-Ed-ak6NoX_4Aeg_1250513614")]
    [Description(@"A program trade, i.e. a computer-driven trade of buying and selling of baskets of 15 or more financial instruments by index arbitrage specialists or institutional traders.")]
    PROG,
    
    /// <summary>
    /// An executed order.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_YqNVGdp-Ed-ak6NoX_4Aeg_1268984128")]
    [Description(@"An executed order.")]
    TRAD,
    
    /// <summary>
    /// A trade from a broker to another broker.
    /// </summary>
    [EnumMember(Value = "BRBR")]
    [IsoId("_YqXGENp-Ed-ak6NoX_4Aeg_-57032311")]
    [Description(@"A trade from a broker to another broker.")]
    BRBR,
    
    /// <summary>
    /// A trade from an investment fund to another investment fund.
    /// </summary>
    [EnumMember(Value = "FDFD")]
    [IsoId("_YqXGEdp-Ed-ak6NoX_4Aeg_227581")]
    [Description(@"A trade from an investment fund to another investment fund.")]
    FDFD,
    
    /// <summary>
    /// Trade involving risk.
    /// </summary>
    [EnumMember(Value = "RISK")]
    [IsoId("_YqXGEtp-Ed-ak6NoX_4Aeg_1363842325")]
    [Description(@"Trade involving risk.")]
    RISK,
    
    /// <summary>
    /// Trade whose price is guaranteed as the weighted average of the trade prices on a specific day.
    /// </summary>
    [EnumMember(Value = "VWAP")]
    [IsoId("_YqXGE9p-Ed-ak6NoX_4Aeg_1363842326")]
    [Description(@"Trade whose price is guaranteed as the weighted average of the trade prices on a specific day.")]
    VWAP,
    
    /// <summary>
    /// Trade in which an agent intermediates between a buyer and a seller.
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("_YqXGFNp-Ed-ak6NoX_4Aeg_1363842334")]
    [Description(@"Trade in which an agent intermediates between a buyer and a seller.")]
    AGEN,
    
    /// <summary>
    /// Trade which is guaranteed to be finalized.
    /// </summary>
    [EnumMember(Value = "GUAR")]
    [IsoId("_YqXGFdp-Ed-ak6NoX_4Aeg_1363842335")]
    [Description(@"Trade which is guaranteed to be finalized.")]
    GUAR,
    
    /// <summary>
    /// On order book/market trade.
    /// </summary>
    [EnumMember(Value = "OOBK")]
    [IsoId("_YqXGFtp-Ed-ak6NoX_4Aeg_-390833182")]
    [Description(@"On order book/market trade.")]
    OOBK,
    
    /// <summary>
    /// Trades coming from the application of a coorporate event.
    /// </summary>
    [EnumMember(Value = "LKTR")]
    [IsoId("_YqXGF9p-Ed-ak6NoX_4Aeg_-220495244")]
    [Description(@"Trades coming from the application of a coorporate event.")]
    LKTR,
    
    /// <summary>
    /// Trade generated by a give-up.
    /// </summary>
    [EnumMember(Value = "GUTR")]
    [IsoId("_YqXGGNp-Ed-ak6NoX_4Aeg_415878249")]
    [Description(@"Trade generated by a give-up.")]
    GUTR,
    
    /// <summary>
    /// Trade that is generated following a corporate action.
    /// </summary>
    [EnumMember(Value = "COTR")]
    [IsoId("_YqXGGdp-Ed-ak6NoX_4Aeg_-2057393937")]
    [Description(@"Trade that is generated following a corporate action.")]
    COTR,
    
    /// <summary>
    /// Trade that is input manually in case of issue on the original trade that either was not processed or not received.
    /// </summary>
    [EnumMember(Value = "BKTR")]
    [IsoId("_YqgQANp-Ed-ak6NoX_4Aeg_-1994813658")]
    [Description(@"Trade that is input manually in case of issue on the original trade that either was not processed or not received.")]
    BKTR,
    
    /// <summary>
    /// Trade that is over the counter.
    /// </summary>
    [EnumMember(Value = "OFBK")]
    [IsoId("_YqgQAdp-Ed-ak6NoX_4Aeg_-707208703")]
    [Description(@"Trade that is over the counter.")]
    OFBK,
    
    /// <summary>
    /// Transaction relates to employee trade reporting.
    /// </summary>
    [EnumMember(Value = "EMTR")]
    [IsoId("__5EuENojEeC60axPepSq7g_-1320847336")]
    [Description(@"Transaction relates to employee trade reporting.")]
    EMTR,
    
    /// <summary>
    /// Transaction is an Initial Public Offer (IPO) order.
    /// </summary>
    [EnumMember(Value = "IPOO")]
    [IsoId("__5EuEdojEeC60axPepSq7g_-1097946825")]
    [Description(@"Transaction is an Initial Public Offer (IPO) order.")]
    IPOO,
    
    /// <summary>
    /// Indicates that the trade is a Offering issue trade.
    /// </summary>
    [EnumMember(Value = "OFIT")]
    [IsoId("__5EuEtojEeC60axPepSq7g_-1779724746")]
    [Description(@"Indicates that the trade is a Offering issue trade.")]
    OFIT,
    
    /// <summary>
    /// Relates to the issuance of a security such as an equity or a depositary receipt.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("__5EuE9ojEeC60axPepSq7g_-178168873")]
    [Description(@"Relates to the issuance of a security such as an equity or a depositary receipt.")]
    ISSU,
    
    /// <summary>
    /// The trade is a Bond repricing.
    /// </summary>
    [EnumMember(Value = "BORE")]
    [IsoId("__5OfENojEeC60axPepSq7g_1746600155")]
    [Description(@"The trade is a Bond repricing.")]
    BORE,
    
    /// <summary>
    /// The trade is a Bond substitution.
    /// </summary>
    [EnumMember(Value = "BOSU")]
    [IsoId("__5OfEdojEeC60axPepSq7g_2018650338")]
    [Description(@"The trade is a Bond substitution.")]
    BOSU,
    
    /// <summary>
    /// The trade is a Bond end.
    /// </summary>
    [EnumMember(Value = "BOEN")]
    [IsoId("__5OfEtojEeC60axPepSq7g_343765467")]
    [Description(@"The trade is a Bond end.")]
    BOEN,
    
    /// <summary>
    /// The trade is a Bond start.
    /// </summary>
    [EnumMember(Value = "BOST")]
    [IsoId("__5OfE9ojEeC60axPepSq7g_-1022334635")]
    [Description(@"The trade is a Bond start.")]
    BOST,
    
    /// <summary>
    /// Indicates that the trade is a Lending and borrowing.
    /// </summary>
    [EnumMember(Value = "LABO")]
    [IsoId("__5OfFNojEeC60axPepSq7g_-272127876")]
    [Description(@"Indicates that the trade is a Lending and borrowing.")]
    LABO,
    
    /// <summary>
    /// Indicates that the trade is a Futures contract trade.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("__5OfFdojEeC60axPepSq7g_1805283326")]
    [Description(@"Indicates that the trade is a Futures contract trade.")]
    FUTR,
    
    /// <summary>
    /// Indicates that the trade is a Option contract trade.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("__5OfFtojEeC60axPepSq7g_-429155997")]
    [Description(@"Indicates that the trade is a Option contract trade.")]
    OPTN,
    
    /// <summary>
    /// Indicates that the trade is a Futures option contract trade.
    /// </summary>
    [EnumMember(Value = "FUOP")]
    [IsoId("__5XpANojEeC60axPepSq7g_1586587105")]
    [Description(@"Indicates that the trade is a Futures option contract trade.")]
    FUOP,
    
    /// <summary>
    /// The security will be bought back in the future.
    /// </summary>
    [EnumMember(Value = "FBBT")]
    [IsoId("__5XpAdojEeC60axPepSq7g_-432324318")]
    [Description(@"The security will be bought back in the future.")]
    FBBT,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradeTypeCodeMetadataExtensions
{
    private static readonly TradeTypeCodeDropdownSource _dropdownSource = new TradeTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradeTypeCodeDropdownRow GetMetadata(this TradeTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


