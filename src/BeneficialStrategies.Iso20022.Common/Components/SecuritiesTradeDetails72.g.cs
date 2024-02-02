﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesTradeDetails72.  ISO2002 ID# _bXLIwa2-EeeBVbuVcoH9Nw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the securities trade.
/// </summary>
[DataContract]
[XmlType]
public partial record SecuritiesTradeDetails72
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as known by the notification receiver.
    /// </summary>
    [DataMember]
    public IsoMax35Text? NotificationSenderTransactionIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction as known by the notification receiver.
    /// </summary>
    [DataMember]
    public IsoMax35Text? NotificationReceiverTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [DataMember]
    public IsoMax35Text? CommonIdentification { get; init; } 
    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [DataMember]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [DataMember]
    public required DeliveryReceiptType2Code Payment { get; init; } 
    /// <summary>
    /// Status of the transfer.
    /// </summary>
    [DataMember]
    public PortfolioTransferStatus1Choice_? Status { get; init; } 
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [DataMember]
    public TradeDate8Choice_? TradeDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [DataMember]
    public required SettlementDate17Choice_ SettlementDate { get; init; } 
    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    [DataMember]
    public IsoMax3Number? NumberOfDaysAccrued { get; init; } 
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [DataMember]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [DataMember]
    public FinancialInstrumentAttributes91? FinancialInstrumentAttributes { get; init; } 
    /// <summary>
    /// Specifies that a trade is to be reported to a third party.
    /// </summary>
    [DataMember]
    public ValueList<Reporting7Choice_> Reporting { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Details about the financial instrument quantity involved in the transfer.
    /// </summary>
    [DataMember]
    public required Quantity14 QuantityDetails { get; init; } 
    /// <summary>
    /// Parameters applied to the settlement of a security transfer.
    /// </summary>
    [DataMember]
    public SettlementDetails100? SettlementParameters { get; init; } 
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [DataMember]
    public SettlementParties62? DeliveringSettlementParties { get; init; } 
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [DataMember]
    public SettlementParties62? ReceivingSettlementParties { get; init; } 
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [DataMember]
    public AmountAndDirection52? SettlementAmount { get; init; } 
    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [DataMember]
    public OtherAmounts29? OtherAmounts { get; init; } 
    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [DataMember]
    public OtherParties26? OtherBusinessParties { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [DataMember]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
