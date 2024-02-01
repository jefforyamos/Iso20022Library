﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionDetails144.  ISO2002 ID# _waX6QyAeEeuyDZ-ukt4YRg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the transaction.
/// </summary>
public partial record TransactionDetails144
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of activity to which this instruction relates.
    /// </summary>
    public required TransactionActivity4Choice_ TransactionActivity { get; init; } 
    /// <summary>
    /// Choice of type for the transaction reported.
    /// </summary>
    public SettlementOrCorporateActionEvent32Choice_? SettlementTransactionOrCorporateActionEventType { get; init; } 
    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    public required DeliveryReceiptType2Code Payment { get; init; } 
    /// <summary>
    /// Parameters applied to the settlement of a security transfer.
    /// </summary>
    public SettlementDetails197? SettlementParameters { get; init; } 
    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    public PlaceOfTradeIdentification2? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafeKeepingPlace4? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Infrastructure which may be a component of a clearing house and which facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    public PlaceOfClearingIdentification2? PlaceOfClearing { get; init; } 
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Quantity of financial instrument (to be) posted to the safekeeping account.
    /// </summary>
    public required Quantity10Choice_ PostingQuantity { get; init; } 
    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    public AmountAndDirection67? PostingAmount { get; init; } 
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    public TradeDate9Choice_? TradeDate { get; init; } 
    /// <summary>
    /// Date/time at which the sender expects settlement.
    /// </summary>
    public DateAndDateTime2Choice_? ExpectedSettlementDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    public required SettlementDate32Choice_ SettlementDate { get; init; } 
    /// <summary>
    /// Date and time after the settlement date specified in the trade, used for pool trades resulting from the original To Be Assigned (TBA) securities.
    /// </summary>
    public DateAndDateTime2Choice_? LateDeliveryDate { get; init; } 
    /// <summary>
    /// For against payment transactions, the value date/time at which the account servicer expects the settlement amount to be credited or debited.
    /// </summary>
    public DateAndDateTime2Choice_? ExpectedValueDate { get; init; } 
    /// <summary>
    /// Time stamp on when the transaction is acknowledged.
    /// </summary>
    public IsoISODateTime? AcknowledgedStatusTimeStamp { get; init; } 
    /// <summary>
    /// Time stamp on when the transaction is matched.
    /// </summary>
    public IsoISODateTime? MatchedStatusTimeStamp { get; init; } 
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    public SettlementParties90? DeliveringSettlementParties { get; init; } 
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    public SettlementParties90? ReceivingSettlementParties { get; init; } 
    /// <summary>
    /// Provides additional details on the transaction which cannot be included within the structured fields of the message.
    /// </summary>
    public IsoRestrictedFINXMax350Text? TransactionAdditionalDetails { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1[] SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
