﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeAgreement4.  ISO2002 ID# _TJzAgtp-Ed-ak6NoX_4Aeg_-331393042.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and identification of a trade together with references to previous events in its life.
/// </summary>
public partial record TradeAgreement4
{
    #nullable enable
    
    /// <summary>
    /// Date on which the trading parties agree to amend or cancel the trade.
    /// </summary>
    public required IsoISODate TradeDate { get; init; } 
    /// <summary>
    /// Identification of the notification.This identification must be unique amongst all notifications of same type confirmed by the same party.
    /// </summary>
    public required IsoMax35Text NotificationIdentification { get; init; } 
    /// <summary>
    /// Reference common to both parties of the trade.
    /// </summary>
    public IsoMax35Text? CommonReference { get; init; } 
    /// <summary>
    /// Describes the reason for the cancellation or the amendment.
    /// </summary>
    public IsoMax35Text? AmendOrCancelReason { get; init; } 
    /// <summary>
    /// Refers to the identification of a previous event in the life of a trade which is amended or cancelled.
    /// </summary>
    public required IsoMax35Text RelatedReference { get; init; } 
    /// <summary>
    /// Specifies the type of underlying transaction, for example, option.
    /// </summary>
    public IsoMax4Text? OperationType { get; init; } 
    /// <summary>
    /// Specifies the business role between the submitter and the trade party, for example Agent (AGNT).
    /// </summary>
    public IsoMax4Text? OperationScope { get; init; } 
    
    #nullable disable
}
