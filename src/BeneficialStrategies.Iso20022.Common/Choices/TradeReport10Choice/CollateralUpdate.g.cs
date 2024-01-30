﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CollateralUpdate.  ISO2002 ID# _38nfW__qEemm3skPVSMJQg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport10Choice;

/// <summary>
/// Details of the loan used for financing the transaction.
/// </summary>
public partial record CollateralUpdate : ITradeReport10Choice
{
    #nullable enable
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    public required CounterpartyData76 CounterpartyData { get; init; } 
    /// <summary>
    /// Data specifically related to transaction.
    /// </summary>
    public required ITransactionLoanData9Choice LoanData { get; init; } 
    /// <summary>
    /// Information on collateral used in the transaction.
    /// </summary>
    public required ITransactionCollateralData14Choice CollateralData { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
