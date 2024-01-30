﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Modification.  ISO2002 ID# _JfG635w3EeazcsnODTksnQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UpdateType26Choice;

/// <summary>
/// Modification of information in the securities transaction.
/// </summary>
public partial record Modification : IUpdateType26Choice
{
    #nullable enable
    /// <summary>
    /// Provides settlement type and identification information.
    /// </summary>
    public SettlementTypeAndAdditionalParameters18? SettlementTypeAndAdditionalParameters { get; init; } 
    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    public Linkages48? Linkages { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Details of the trade.
    /// </summary>
    public SecuritiesTradeDetails66? TradeDetails { get; init; } 
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public SecurityIdentification20? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Attributes defining a financial instrument.
    /// </summary>
    public FinancialInstrumentAttributes78? FinancialInstrumentAttributes { get; init; } 
    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    public QuantityAndAccount60? QuantityAndAccountDetails { get; init; } 
    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    public SettlementDetails138? SettlementParameters { get; init; } 
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    public StandingSettlementInstruction12? StandingSettlementInstructionDetails { get; init; } 
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    public SettlementParties44? DeliveringSettlementParties { get; init; } 
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    public SettlementParties44? ReceivingSettlementParties { get; init; } 
    /// <summary>
    /// Cash parties involved in the transaction if different for the securities settlement parties.
    /// </summary>
    public CashParties30? CashParties { get; init; } 
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    public AmountAndDirection85? SettlementAmount { get; init; } 
    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    public OtherAmounts35? OtherAmounts { get; init; } 
    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    public OtherParties29? OtherBusinessParties { get; init; } 
    /// <summary>
    /// Provides information required for the registration or physical settlement.
    /// </summary>
    public RegistrationParameters5? AdditionalPhysicalOrRegistrationDetails { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
