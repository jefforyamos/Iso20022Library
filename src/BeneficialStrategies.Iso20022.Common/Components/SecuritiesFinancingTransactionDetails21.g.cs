﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesFinancingTransactionDetails21.  ISO2002 ID# _Evc18SW7EeOslcz0TJwprQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the closing of the securities financing transaction.
/// </summary>
public partial record SecuritiesFinancingTransactionDetails21
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the underlying securities financing trade as assigned by the instructing party. The identification is common to all collateral pieces (one or many).
    /// </summary>
    public IsoMax35Text? SecuritiesFinancingTradeIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the second leg of the transaction as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    public IsoMax35Text? ClosingLegIdentification { get; init; } 
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    public IsoMax35Text? PoolIdentification { get; init; } 
    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    public IsoMax35Text? CorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the triparty agent's point of view.
    /// </summary>
    public IsoMax35Text? TripartyAgentCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client's point of view.
    /// </summary>
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public IPartyIdentification36Choice? AccountOwner { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public required SecuritiesAccount13 SafekeepingAccount { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public ISafekeepingPlaceFormat3Choice? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Context, or geographic environment, in which trading parties may meet in order to negotiate and execute trades among themselves.
    /// </summary>
    public MarketIdentification78? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    public required IQuantity6Choice SettlementQuantity { get; init; } 
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities at the opening of a securities financing transaction.
    /// </summary>
    public AmountAndDirection8? OpeningSettlementAmount { get; init; } 
    /// <summary>
    /// Total amount of money to be settled to terminate the transaction.
    /// </summary>
    public AmountAndDirection4? TerminationTransactionAmount { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    public required ISettlementDate2Choice OpeningSettlementDate { get; init; } 
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    public ITerminationDate2Choice? TerminationDate { get; init; } 
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    public ITradeDate1Choice? TradeDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    public IDateAndDateTimeChoice? ExpectedSettlementDate { get; init; } 
    /// <summary>
    /// For against payment transactions, the value date/time at which the account servicer expects the settlement amount to be credited or debited.
    /// </summary>
    public IDateAndDateTimeChoice? ExpectedValueDate { get; init; } 
    /// <summary>
    /// Date and time after the settlement date specified in the trade, used for pool trades resulting from the original To Be Assigned (TBA) securities.
    /// </summary>
    public IDateAndDateTimeChoice? LateDeliveryDate { get; init; } 
    /// <summary>
    /// Date/Time at which rate change has taken place.
    /// </summary>
    public IDateAndDateTimeChoice? RateChangeDate { get; init; } 
    /// <summary>
    /// Specifies the type of securities financing transaction, that is, repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing.
    /// </summary>
    public required SecuritiesFinancingTransactionType1Code SecuritiesFinancingTransactionType { get; init; } 
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
    public SettlementDetails73? SettlementParameters { get; init; } 
    /// <summary>
    /// Specifies whether the rate is fixed or variable.
    /// </summary>
    public IRateType5Choice? RateType { get; init; } 
    /// <summary>
    /// Index or support rate used together with the spread to calculate the|repurchase rate.
    /// </summary>
    public RateName1? VariableRateSupport { get; init; } 
    /// <summary>
    /// Rate to be used to recalculate the repurchase amount.
    /// </summary>
    public Rate2? RepurchaseRate { get; init; } 
    /// <summary>
    /// Percentage mark-up on a loan consideration used to reflect the lender's risk.
    /// </summary>
    public Rate2? StockLoanMargin { get; init; } 
    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    public Rate2? SecuritiesHaircut { get; init; } 
    /// <summary>
    /// Interest rate to be paid on the transaction amount, as agreed between the counterparties.
    /// </summary>
    public IRateOrName1Choice? PricingRate { get; init; } 
    /// <summary>
    /// Repurchase spread expressed as a rate; margin over or under an index that determines the repurchase rate.
    /// </summary>
    public Rate2? Spread { get; init; } 
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    public SettlementParties11? DeliveringSettlementParties { get; init; } 
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    public SettlementParties11? ReceivingSettlementParties { get; init; } 
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    public IPartyIdentification37Choice? Investor { get; init; } 
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    public IsoMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; } 
    
    #nullable disable
}
