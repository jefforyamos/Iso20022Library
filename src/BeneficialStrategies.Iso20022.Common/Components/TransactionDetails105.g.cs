﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionDetails105.  ISO2002 ID# _rGYYMazwEeeBIMhGLpLUsQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the transaction.
/// </summary>
public partial record TransactionDetails105
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    public IsoMax35Text? TradeIdentification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    public IsoMax35Text? PoolIdentification { get; init; } 
    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    public IsoMax35Text? CorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Unique identification identifying the triparty collateral management transaction from the triparty-agent's/service-provider's point of view.
    /// </summary>
    public IsoMax35Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client's point of view.
    /// </summary>
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification assigned to the instruction by the client.
    /// </summary>
    public IsoMax35Text? ClientCollateralInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification assigned to the instruction by the triparty-agent/service-provider.
    /// </summary>
    public IsoMax35Text? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification98? AccountOwner { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public required SecuritiesAccount19 SafekeepingAccount { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafeKeepingPlace1? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    public PlaceOfTradeIdentification1? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Infrastructure which may be a component of a clearing house and which facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    public PlaceOfClearingIdentification1? PlaceOfClearing { get; init; } 
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    public required IQuantity6Choice SettlementQuantity { get; init; } 
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    public AmountAndDirection51? SettlementAmount { get; init; } 
    /// <summary>
    /// Date and time after the settlement date specified in the trade, used for pool trades resulting from the original To Be Assigned (TBA) securities.
    /// </summary>
    public IDateAndDateTime2Choice? LateDeliveryDate { get; init; } 
    /// <summary>
    /// Date/time at which the sender expects settlement.
    /// </summary>
    public IDateAndDateTime2Choice? ExpectedSettlementDate { get; init; } 
    /// <summary>
    /// For against payment transactions, the value date/time at which the Sender expects the settlement amount to be credited or debited.
    /// </summary>
    public IDateAndDateTime2Choice? ExpectedValueDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    public required ISettlementDate19Choice SettlementDate { get; init; } 
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    public ITradeDate8Choice? TradeDate { get; init; } 
    /// <summary>
    /// Time stamp on when the transaction is acknowledged.
    /// </summary>
    public IsoISODateTime? AcknowledgedStatusTimeStamp { get; init; } 
    /// <summary>
    /// Time stamp on when the transaction is matched.
    /// </summary>
    public IsoISODateTime? MatchedStatusTimeStamp { get; init; } 
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
    public required SettlementDetails143 SettlementParameters { get; init; } 
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    public SettlementParties40? ReceivingSettlementParties { get; init; } 
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    public SettlementParties40? DeliveringSettlementParties { get; init; } 
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    public PartyIdentification99? Investor { get; init; } 
    /// <summary>
    /// Foreign Financial Institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    public PartyIdentification100? QualifiedForeignIntermediary { get; init; } 
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    public IsoMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; } 
    
    #nullable disable
}
