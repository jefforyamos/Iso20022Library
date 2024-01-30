﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Clearing4.  ISO2002 ID# _tv6MUWpUEeSgo9vJrfSF_Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the clearing details.
/// </summary>
public partial record Clearing4
{
    #nullable enable
    
    /// <summary>
    /// Indicates to the clearing member whether the trade is eligible for settlement netting or not.
    /// </summary>
    public required NettingEligible1Code SettlementNettingEligibleCode { get; init; } 
    /// <summary>
    /// Clearing organisation that will clear the trade.
    /// Note: This field allows clearing member firm to segregate flows coming from clearing counterparty's clearing system. Indeed, clearing member firms receive messages from the same system (same sender) and this field allows them to know if the message is related to equities or derivatives.
    /// </summary>
    public IPartyIdentification35Choice? ClearingSegment { get; init; } 
    /// <summary>
    /// Indicates if the position is guaranteed or non-guaranteed by the central counterparty, that is whether the CCP has done the novation and then guarantees the trade, or not.
    /// </summary>
    public IsoYesNoIndicator? GuaranteedTrade { get; init; } 
    /// <summary>
    /// In case of trades that are not guaranteed by the central counterparty (this is when the central counterparty has not done the novation), provides details such as the trade counterparty member identification or the trade counterparty clearing member identification.
    /// </summary>
    public NonGuaranteedTrade3? NonGuaranteedTrade { get; init; } 
    
    #nullable disable
}
