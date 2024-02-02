﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionDetails84.  ISO2002 ID# _6zZCs5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the details of the transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record TransactionDetails84
{
    #nullable enable
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [DataMember]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [DataMember]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    /// <summary>
    /// Specifies how the transaction is to be settled, eg, against payment.
    /// </summary>
    [DataMember]
    public required DeliveryReceiptType2Code Payment { get; init; } 
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [DataMember]
    public required Quantity10Choice_ SettlementQuantity { get; init; } 
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [DataMember]
    public AmountAndDirection67? SettlementAmount { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [DataMember]
    public required SettlementDate15Choice_ SettlementDate { get; init; } 
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [DataMember]
    public TradeDate6Choice_? TradeDate { get; init; } 
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [DataMember]
    public SettlementParties49? DeliveringSettlementParties { get; init; } 
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [DataMember]
    public SettlementParties49? ReceivingSettlementParties { get; init; } 
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [DataMember]
    public PartyIdentification110? Investor { get; init; } 
    
    #nullable disable
}
