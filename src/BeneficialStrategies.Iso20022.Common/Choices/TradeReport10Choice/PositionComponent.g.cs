﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PositionComponent.  ISO2002 ID# _38nfWf_qEemm3skPVSMJQg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport10Choice;

/// <summary>
/// Indicates contract that is to be reported as a new trade and also included in a separate position report on the same day.
/// </summary>
public partial record PositionComponent : TradeReport10Choice_
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
    /// Details of the loan used for financing the transaction.
    /// </summary>
    public TransactionLoanData21Choice_? LoanData { get; init; } 
    /// <summary>
    /// Information on collateral used in the transaction.
    /// </summary>
    public CollateralData27? CollateralData { get; init; } 
    /// <summary>
    /// Information concerning the reported transaction level type.
    /// </summary>
    public required ModificationLevel1Code LevelType { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
