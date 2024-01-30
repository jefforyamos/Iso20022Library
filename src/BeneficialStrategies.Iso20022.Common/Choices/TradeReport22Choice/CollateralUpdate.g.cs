﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CollateralUpdate.  ISO2002 ID# _zvSse8g3EeuGrNSsxk3B0A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport22Choice;

/// <summary>
/// Details of the loan used for financing the transaction.
/// </summary>
public partial record CollateralUpdate : ITradeReport22Choice
{
    #nullable enable
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
    /// <summary>
    /// Counterparty and related information.
    /// </summary>
    public required CounterpartyData88 CounterpartySpecificData { get; init; } 
    /// <summary>
    /// Data specifically related to transaction.
    /// </summary>
    public ITransactionLoanData26Choice? LoanData { get; init; } 
    /// <summary>
    /// Provides the details of the collateral used in the transaction.
    /// </summary>
    public required ITransactionCollateralData18Choice CollateralData { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
