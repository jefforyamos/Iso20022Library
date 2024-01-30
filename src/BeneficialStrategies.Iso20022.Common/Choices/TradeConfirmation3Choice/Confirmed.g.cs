﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Confirmed.  ISO2002 ID# _PQNwEVo3Ee23K4GXSpBSeg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeConfirmation3Choice;

/// <summary>
/// Indicates the type of contract confirmation.
/// </summary>
public partial record Confirmed : ITradeConfirmation3Choice
{
    #nullable enable
    /// <summary>
    /// Specifies whether the contract was confirmed electronically or non-electronically.
    /// </summary>
    public TradeConfirmationType1Code? Type { get; init; } 
    /// <summary>
    /// Date and time of the trade confirmation, indicating time zone in which the confirmation has taken place.
    /// </summary>
    public IsoISODateTime? TimeStamp { get; init; } 
    #nullable disable
}
