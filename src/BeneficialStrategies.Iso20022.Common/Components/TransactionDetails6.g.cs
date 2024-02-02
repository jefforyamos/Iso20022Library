﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionDetails6.  ISO2002 ID# _UelpO9p-Ed-ak6NoX_4Aeg_917435878.
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
public partial record TransactionDetails6
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of activity to which this instruction relates.
    /// </summary>
    [DataMember]
    public required TransactionActivity1Choice_ TransactionActivity { get; init; } 
    /// <summary>
    /// Choice of type for the transaction reported.
    /// </summary>
    [DataMember]
    public SettlementOrCorporateActionEvent1Choice_? SettlementTransactionOrCorporateActionEventType { get; init; } 
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
    /// Parameters applied to the settlement of a security transfer.
    /// </summary>
    [DataMember]
    public SettlementDetails2? SettlementParameters { get; init; } 
    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    [DataMember]
    public MarketIdentification4? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [DataMember]
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Infrastructure which may be a component of a clearing house and wich facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    [DataMember]
    public IsoAnyBICIdentifier? PlaceOfClearing { get; init; } 
    /// <summary>
    /// Quantity of financial instrument (to be) posted to the safekeeping account.
    /// </summary>
    [DataMember]
    public required Quantity6Choice_ PostingQuantity { get; init; } 
    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    [DataMember]
    public IsoMax3Number? NumberOfDaysAccrued { get; init; } 
    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    [DataMember]
    public AmountAndDirection3? PostingAmount { get; init; } 
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [DataMember]
    public AmountAndDirection4? AccruedInterestAmount { get; init; } 
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [DataMember]
    public TradeDate1Choice_? TradeDate { get; init; } 
    /// <summary>
    /// Date and time at which a transaction is completed and cleared, ie, payment is effected and securities are delivered.
    /// </summary>
    [DataMember]
    public required DateAndDateTimeChoice_ EffectiveSettlementDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [DataMember]
    public SettlementDate1Choice_? SettlementDate { get; init; } 
    /// <summary>
    /// Date and time assets become available to the account owner (in a credit entry), or cease to be available to the account owner (in a debit entry).
    /// </summary>
    [DataMember]
    public DateAndDateTimeChoice_? ValueDate { get; init; } 
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [DataMember]
    public SettlementParties2? DeliveringSettlementParties { get; init; } 
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [DataMember]
    public SettlementParties2? ReceivingSettlementParties { get; init; } 
    /// <summary>
    /// Specifies whether it is the reversal of a previously reported movement.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? ReversalIndicator { get; init; } 
    /// <summary>
    /// Provides additional details on the transaction which can not be included within the structured fields of the message.
    /// </summary>
    [DataMember]
    public IsoMax350Text? TransactionAdditionalDetails { get; init; } 
    
    #nullable disable
}
