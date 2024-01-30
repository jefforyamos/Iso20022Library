﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionDetails121.  ISO2002 ID# _AYE-K_fZEeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the transaction.
/// </summary>
public partial record TransactionDetails121
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    public IsoRestrictedFINXMax52Text? TradeIdentification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    public IsoRestrictedFINXMax16Text? PoolIdentification { get; init; } 
    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    public IsoRestrictedFINXMax16Text? CorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Unique identification identifying the triparty collateral management transaction from the triparty-agent's/service-provider's point of view.
    /// </summary>
    public IsoRestrictedFINXMax16Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client's point of view.
    /// </summary>
    public IsoRestrictedFINXMax16Text? ClientTripartyCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification assigned to the instruction by the client.
    /// </summary>
    public IsoRestrictedFINXMax16Text? ClientCollateralInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification assigned to the instruction by the triparty-agent/service-provider.
    /// </summary>
    public IsoRestrictedFINXMax16Text? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification156? AccountOwner { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public required SecuritiesAccount30 SafekeepingAccount { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafeKeepingPlace4? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    public PlaceOfTradeIdentification2? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Infrastructure which may be a component of a clearing house and which facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    public PlaceOfClearingIdentification2? PlaceOfClearing { get; init; } 
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    public required IQuantity10Choice SettlementQuantity { get; init; } 
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    public AmountAndDirection67? SettlementAmount { get; init; } 
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
    public required ISettlementDate32Choice SettlementDate { get; init; } 
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    public ITradeDate9Choice? TradeDate { get; init; } 
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
    public required SettlementDetails181 SettlementParameters { get; init; } 
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    public SettlementParties90? ReceivingSettlementParties { get; init; } 
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    public SettlementParties90? DeliveringSettlementParties { get; init; } 
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    public PartyIdentification170? Investor { get; init; } 
    /// <summary>
    /// Foreign financial institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    public PartyIdentification157? QualifiedForeignIntermediary { get; init; } 
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    public IsoRestrictedFINXMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; } 
    
    #nullable disable
}
