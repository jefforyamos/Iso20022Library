﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeAgreement10.  ISO2002 ID# _wiD-kVN4EeOEi5J12GuNGQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and identification of a trade.
/// </summary>
[DataContract]
[XmlType]
public partial record TradeAgreement10
{
    #nullable enable
    
    /// <summary>
    /// Date on which the trading parties agreed on the trade.
    /// </summary>
    [DataMember]
    public required IsoISODate TradeDate { get; init; } 
    /// <summary>
    /// Reference of the present instruction assigned by the party issuing the message. This reference must be unique amongst all messages of same type sent by the same party.
    /// </summary>
    [DataMember]
    public required IsoMax35Text OriginatorReference { get; init; } 
    /// <summary>
    /// Reference common to both parties of the trade.
    /// </summary>
    [DataMember]
    public IsoMax35Text? CommonReference { get; init; } 
    /// <summary>
    /// Specifies the type of underlying transaction, for example cancellation (CANC).
    /// </summary>
    [DataMember]
    public IsoMax4Text? OperationType { get; init; } 
    /// <summary>
    /// Specifies the business role between the submitter and the trade party, for example Agent (AGNT).
    /// </summary>
    [DataMember]
    public IsoMax4Text? OperationScope { get; init; } 
    /// <summary>
    /// To indicate the requested CLS settlement session that the related trade is part of.
    /// </summary>
    [DataMember]
    public IsoExact4AlphaNumericText? SettlementSessionIdentifier { get; init; } 
    /// <summary>
    /// Specifies if the FX transaction is PVP settlement. Payment versus payment (PvP) settlement arrangement allows for two currencies in a foreign exchange (FX) contract to exchange simultaneously on a central settlement platform to eliminate the settlement risk. To apply PvP, the two parties in the FX contract need to have a pre-agreement with the central settlement platform, for example, USD/MYR FX deals require both parties to have an agreement to settle via HK Interbank Clearing Ltd settlement platform.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? PaymentVersusPaymentIndicator { get; init; } 
    
    #nullable disable
}
