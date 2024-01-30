﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesSettlementTransactionDetails4.  ISO2002 ID# _0dHS-QlIEeGATtfOBToyew_-422096510.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the update(s) for the settlement transaction.
/// </summary>
public partial record SecuritiesSettlementTransactionDetails4
{
    #nullable enable
    
    /// <summary>
    /// Provides settlement type and identification information.
    /// </summary>
    public SettlementTypeAndAdditionalParameters6? SettlementTypeAndAdditionalParameters { get; init; } 
    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    public Linkages21? Linkages { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Details of the trade.
    /// </summary>
    public SecuritiesTradeDetails25? TradeDetails { get; init; } 
    /// <summary>
    /// Attributes defining a financial instrument.
    /// </summary>
    public FinancialInstrumentAttributes35? FinancialInstrumentAttributes { get; init; } 
    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    public QuantityAndAccount29? QuantityAndAccountDetails { get; init; } 
    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    public SettlementDetails50? SettlementParameters { get; init; } 
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    public StandingSettlementInstruction4? StandingSettlementInstructionDetails { get; init; } 
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    public SettlementParties26? DeliveringSettlementParties { get; init; } 
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    public SettlementParties26? ReceivingSettlementParties { get; init; } 
    /// <summary>
    /// Cash parties involved in the transaction if different for the securities settlement parties.
    /// </summary>
    public CashParties8? CashParties { get; init; } 
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    public AmountAndDirection32? SettlementAmount { get; init; } 
    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    public OtherAmounts14? OtherAmounts { get; init; } 
    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    public OtherParties19? OtherBusinessParties { get; init; } 
    /// <summary>
    /// Provides information required for the registration or physical settlement.
    /// </summary>
    public RegistrationParameters1? AdditionalPhysicalOrRegistrationDetails { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
