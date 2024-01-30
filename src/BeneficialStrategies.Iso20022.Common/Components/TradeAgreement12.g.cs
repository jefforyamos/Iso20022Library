﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeAgreement12.  ISO2002 ID# _WFoGkVN5EeOEi5J12GuNGQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and identification of a trade together with references to previous events in its life.
/// </summary>
public partial record TradeAgreement12
{
    #nullable enable
    
    /// <summary>
    /// Date on which the trading parties agreed on the trade.
    /// </summary>
    public required IsoISODate TradeDate { get; init; } 
    /// <summary>
    /// Identification of the present message assigned by the party issuing the message. This identification must be unique amongst all messages of same type sent by the same party.
    /// </summary>
    public required IsoMax35Text MessageIdentification { get; init; } 
    /// <summary>
    /// Represents the original reference of the instruction for which the status is given, as assigned by the participant that submitted the foreign exchange trade.
    /// </summary>
    public required IsoMax35Text OriginatorReference { get; init; } 
    /// <summary>
    /// Reference common to both parties of the trade.
    /// </summary>
    public IsoMax35Text? CommonReference { get; init; } 
    /// <summary>
    /// Specifies the reason for the cancellation or the amendment.
    /// </summary>
    public IsoMax35Text? AmendOrCancelReason { get; init; } 
    /// <summary>
    /// Reference to the identification of a previous event in the life of a trade which is amended or cancelled.
    /// </summary>
    public IsoMax35Text? RelatedReference { get; init; } 
    /// <summary>
    /// Specifies the product for which the status of the confirmation is reported.
    /// </summary>
    public IsoMax35Text? ProductType { get; init; } 
    /// <summary>
    /// Specifies the type of underlying transaction, for example cancellation (CANC).
    /// </summary>
    public IsoMax4Text? OperationType { get; init; } 
    /// <summary>
    /// Specifies the business role between the submitter and the trade party, for example, agent (AGNT).
    /// </summary>
    public IsoMax4Text? OperationScope { get; init; } 
    /// <summary>
    /// To indicate the requested CLS settlement session that the related trade is part of.
    /// </summary>
    public IsoExact4AlphaNumericText? SettlementSessionIdentifier { get; init; } 
    /// <summary>
    /// To indicate if the trade is split.
    /// </summary>
    public required IsoYesNoIndicator SplitTradeIndicator { get; init; } 
    /// <summary>
    /// Specifies if the FX transaction is PVP settlement. Payment versus payment (PvP) settlement arrangement allows for two currencies in a foreign exchange (FX) contract to exchange simultaneously on a central settlement platform to eliminate the settlement risk. To apply PvP, the two parties in the FX contract need to have a pre-agreement with the central settlement platform, for example, USD/MYR FX deals require both parties to have an agreement to settle via HK Interbank Clearing Ltd settlement platform.
    /// </summary>
    public IsoYesNoIndicator? PaymentVersusPaymentIndicator { get; init; } 
    
    #nullable disable
}
