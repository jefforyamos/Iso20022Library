﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for State.  ISO2002 ID# _x-2JI8K-EeuCIrYISEfoUg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TradeStateReport5Choice;

/// <summary>
/// Information related to trade state reporting.
/// </summary>
public partial record State : ITradeStateReport5Choice
{
    #nullable enable
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    public required CounterpartyData88 CounterpartySpecificData { get; init; } 
    /// <summary>
    /// Details of the loan used for financing the transaction.
    /// </summary>
    public ITransactionLoanData31Choice? LoanData { get; init; } 
    /// <summary>
    /// Set of information on collateral used in the transaction.
    /// </summary>
    public ITransactionCollateralData18Choice? CollateralData { get; init; } 
    /// <summary>
    /// List of possible values for TRs reconciliation purposes.
    /// </summary>
    public ReconciliationFlag2? ReconciliationFlag { get; init; } 
    /// <summary>
    /// Contract modification details expressed as an action type and a reporting level type.
    /// </summary>
    public required ContractModification3 ContractModification { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
