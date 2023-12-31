﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradingModeType1Code.  ISO2002 ID# _-JagcIBEEeSUJZYcWGKkkw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of the trading mode.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-JagcIBEEeSUJZYcWGKkkw")]
[Description(@"Identifies the type of the trading mode.")]
[DerivedFrom(typeof(TradingModeTypeCode))]
public enum TradingModeType1Code
{
    /// <summary>
    /// Members could click When market makers quote continuously,or enter RFQ trading process, and make a deal with market makers finally.
    /// Encoded/decoded by serializers as "QuotationDriven".
    /// </summary>
    [EnumMember(Value = "QUDR")]
    [IsoId("_i_oaQYBFEeSUJZYcWGKkkw")]
    [Description(@"Members could click When market makers quote continuously,or enter RFQ trading process, and make a deal with market makers finally.")]
    QuotationDriven,
    
    /// <summary>
    /// Using matchmaking mechanism to match orders which are submitted by members.
    /// Encoded/decoded by serializers as "OrderDriven".
    /// </summary>
    [EnumMember(Value = "ORDR")]
    [IsoId("_jFLBkYBFEeSUJZYcWGKkkw")]
    [Description(@"Using matchmaking mechanism to match orders which are submitted by members.")]
    OrderDriven,
    
    /// <summary>
    /// Members send advertisements, and then other members could enter negotiation trade process. In the negotiation trade process, the member completes product elements and submits, and the counterpart just confirms the deal to make a negotiation trade.
    /// Encoded/decoded by serializers as "NegotiationTrade".
    /// </summary>
    [EnumMember(Value = "NETR")]
    [IsoId("_jKBFUYBFEeSUJZYcWGKkkw")]
    [Description(@"Members send advertisements, and then other members could enter negotiation trade process. In the negotiation trade process, the member completes product elements and submits, and the counterpart just confirms the deal to make a negotiation trade.")]
    NegotiationTrade,
    
    /// <summary>
    /// When issuer issues the deposits, market members subscribe the deposits.
    /// Encoded/decoded by serializers as "Auction".
    /// </summary>
    [EnumMember(Value = "AUCT")]
    [IsoId("_jO6MYYBFEeSUJZYcWGKkkw")]
    [Description(@"When issuer issues the deposits, market members subscribe the deposits.")]
    Auction,
    
    /// <summary>
    /// Trades are executed through matching system.
    /// Encoded/decoded by serializers as "Matching".
    /// </summary>
    [EnumMember(Value = "MARC")]
    [IsoId("_HLbbQaUrEeSgR8TUIX6rXQ")]
    [Description(@"Trades are executed through matching system.")]
    Matching,
    
    /// <summary>
    /// Counterparties neogiate trading details to execute trades.
    /// Encoded/decoded by serializers as "Bilateral".
    /// </summary>
    [EnumMember(Value = "BILA")]
    [IsoId("_HTB4EaUrEeSgR8TUIX6rXQ")]
    [Description(@"Counterparties neogiate trading details to execute trades.")]
    Bilateral,
    
    /// <summary>
    /// Trades are executed anonymously to each counterparty, based on rule "pritority of price and time" to match trade.
    /// Encoded/decoded by serializers as "Anonymous".
    /// </summary>
    [EnumMember(Value = "ANON")]
    [IsoId("_HZXwoaUrEeSgR8TUIX6rXQ")]
    [Description(@"Trades are executed anonymously to each counterparty, based on rule ""pritority of price and time"" to match trade.")]
    Anonymous,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradingModeType1CodeMetadataExtensions
{
    private static readonly TradingModeType1CodeDropdownSource _dropdownSource = new TradingModeType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradingModeType1CodeDropdownRow GetMetadata(this TradingModeType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


