﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Transaction.  ISO2002 ID# _qm-xU52WEeW_58xcYxhewg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ForeignExchangeSwap2Choice;

/// <summary>
/// Provides the details of the foreign exchange transaction as reported by the reporting agent.
/// </summary>
public partial record Transaction : IForeignExchangeSwap2Choice
{
    #nullable enable
    /// <summary>
    /// Defines the status of the reported transaction, that is details on whether the transaction is a new transaction, an amendment of a previously reported transaction, a cancellation of a previously reported transaction or a correction to a previously reported and rejected transaction.
    /// </summary>
    public required TransactionOperationType1Code ReportedTransactionStatus { get; init; } 
    /// <summary>
    /// Unique and unambiguous legal entity identification of the branch of the reporting agent in which the transaction has been booked.
    /// Usage: This field must only be provided if the transaction has been conducted and booked by a branch of the reporting agent and only if this branch has its own LEI that the reporting agent can clearly identify. 
    /// Where the transaction has been booked by the head office or the reporting agent cannot be identified by a unique branch-specific LEI, the reporting agent must provide the LEI of the head office.
    /// </summary>
    public IsoLEIIdentifier? BranchIdentification { get; init; } 
    /// <summary>
    /// Unique transaction identifier will be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction during its lifetime.
    /// </summary>
    public IsoMax105Text? UniqueTransactionIdentifier { get; init; } 
    /// <summary>
    /// Internal unique transaction identifier used by the reporting agent for each transaction.
    /// </summary>
    public required IsoMax105Text ProprietaryTransactionIdentification { get; init; } 
    /// <summary>
    /// Internal unique proprietary transaction identifier as assigned by the counterparty of the reporting agent for each transaction.
    /// </summary>
    public IsoMax105Text? CounterpartyProprietaryTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the counterparty of the reporting agent for the reported transaction.
    /// </summary>
    public required ICounterpartyIdentification2Choice CounterpartyIdentification { get; init; } 
    /// <summary>
    /// Date and time on which the parties entered into the reported transaction.
    /// Usage: when time is available, it must be reported.
    /// It is to be reported with only the date when the time of the transaction is not available. 
    /// The reported time is the execution time when available or otherwise the time at which the transaction entered the trading system of the reporting agent.
    /// </summary>
    public required IDateAndDateTimeChoice TradeDate { get; init; } 
    /// <summary>
    /// Date on which one party sells to the other a specified amount of a specified currency against payment of an agreed amount of a specified different currency based on an agreed foreign exchange rate known as foreign exchange spot rate.
    /// </summary>
    public required IsoISODate SpotValueDate { get; init; } 
    /// <summary>
    /// Date on which the foreign exchange swap transaction expires and the currency sold on the value date is repurchased.
    /// </summary>
    public required IsoISODate MaturityDate { get; init; } 
    /// <summary>
    /// Defines whether the amount of money reported under the transaction nominal amount is bought or sold on the spot value date.
    /// </summary>
    public required SecuritiesTransactionType15Code TransactionType { get; init; } 
    /// <summary>
    /// Specifies the nominal amount of the foreign exchange swap, that is the amount bought/sold on the spot value date and reported as an absolute value.
    /// </summary>
    public required IsoActiveCurrencyAndAmount TransactionNominalAmount { get; init; } 
    /// <summary>
    /// Provides the details of the foreign exchange transaction.
    /// </summary>
    public required ForeignExchange1 ForeignExchange { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
