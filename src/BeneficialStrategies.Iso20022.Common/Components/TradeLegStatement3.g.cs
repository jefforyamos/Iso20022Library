﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeLegStatement3.  ISO2002 ID# _dEWFES6XEeSQQqw1BT_aMg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the trade leg statement details.
/// </summary>
public partial record TradeLegStatement3
{
    #nullable enable
    
    /// <summary>
    /// Identifies the clearing member account at the Central counterparty through which the trade must be cleared (sometimes called position account).
    /// </summary>
    public SecuritiesAccount18? ClearingAccount { get; init; } 
    /// <summary>
    /// Clearing organisation that will clear the trade.
    /// Note: This field allows Clearing Member Firm to segregate flows coming from clearing counterparty's clearing system. Indeed, Clearing Member Firms receive messages from the same system (same sender) and this field allows them to know if the message is related to equities or derivatives.
    /// </summary>
    public PartyIdentification35Choice_? ClearingSegment { get; init; } 
    /// <summary>
    /// Provides the identification for the non-clearing member.
    /// </summary>
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; } 
    /// <summary>
    /// Provides the lists of all trades during the period in consideration for the statement.
    /// </summary>
    public TradeLeg9[] TradeLegsDetails { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
