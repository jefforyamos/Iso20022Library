﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradingModeTypeCode.  ISO2002 ID# _-aXGMESeEeS6cOLECtYLrA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of the trading mode.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-aXGMESeEeS6cOLECtYLrA")]
[Description(@"Identifies the type of the trading mode.")]
public enum TradingModeTypeCode
{
    /// <summary>
    /// Members could click When market makers quote continuously,or enter RFQ trading process, and make a deal with market makers finally.
    /// Encoded/decoded by serializers as "QUDR".
    /// </summary>
    [EnumMember(Value = "QUDR")]
    [IsoId("_INJ18ESfEeS6cOLECtYLrA")]
    [Description(@"Members could click When market makers quote continuously,or enter RFQ trading process, and make a deal with market makers finally.")]
    QuotationDriven,
    
    /// <summary>
    /// Using matchmaking mechanism to match orders which are submitted by members.
    /// Encoded/decoded by serializers as "ORDR".
    /// </summary>
    [EnumMember(Value = "ORDR")]
    [IsoId("_inb8YESfEeS6cOLECtYLrA")]
    [Description(@"Using matchmaking mechanism to match orders which are submitted by members.")]
    OrderDriven,
    
    /// <summary>
    /// Members send advertisements, and then other members could enter negotiation trade process. In the negotiation trade process, the member completes product elements and submits, and the counterpart just confirms the deal to make a negotiation trade.
    /// Encoded/decoded by serializers as "NETR".
    /// </summary>
    [EnumMember(Value = "NETR")]
    [IsoId("_jBgOsEVOEeSGWeX3z5zSZQ")]
    [Description(@"Members send advertisements, and then other members could enter negotiation trade process. In the negotiation trade process, the member completes product elements and submits, and the counterpart just confirms the deal to make a negotiation trade.")]
    NegotiationTrade,
    
    /// <summary>
    /// When issuer issues the deposits, market members subscribe the deposits.
    /// Encoded/decoded by serializers as "AUCT".
    /// </summary>
    [EnumMember(Value = "AUCT")]
    [IsoId("_oba5sEVOEeSGWeX3z5zSZQ")]
    [Description(@"When issuer issues the deposits, market members subscribe the deposits.")]
    Auction,
    
    /// <summary>
    /// Counterparties neogiate trading details to execute trades.
    /// Encoded/decoded by serializers as "BILA".
    /// </summary>
    [EnumMember(Value = "BILA")]
    [IsoId("_d3BmQKUnEeSgR8TUIX6rXQ")]
    [Description(@"Counterparties neogiate trading details to execute trades.")]
    Bilateral,
    
    /// <summary>
    /// Trades are executed anonymously to each counterparty, based on rule "pritority of price and time" to match trade.
    /// Encoded/decoded by serializers as "ANON".
    /// </summary>
    [EnumMember(Value = "ANON")]
    [IsoId("_gOE9MKUnEeSgR8TUIX6rXQ")]
    [Description(@"Trades are executed anonymously to each counterparty, based on rule ""pritority of price and time"" to match trade.")]
    Anonymous,
    
    /// <summary>
    /// Trades are executed through matching system.
    /// Encoded/decoded by serializers as "MARC".
    /// </summary>
    [EnumMember(Value = "MARC")]
    [IsoId("_h4q2wKUnEeSgR8TUIX6rXQ")]
    [Description(@"Trades are executed through matching system.")]
    Matching,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradingModeTypeCodeMetadataExtensions
{
    private static readonly TradingModeTypeCodeDropdownSource _dropdownSource = new TradingModeTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradingModeTypeCodeDropdownRow GetMetadata(this TradingModeTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


