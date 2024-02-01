﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeTransactionCorrection9.  ISO2002 ID# _0mDKIQAAEeqefbt-QjTNnA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates that the report is correcting the erroneous data fields of a previously submitted position.
/// </summary>
public partial record TradeTransactionCorrection9
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
    public TransactionLoanData20Choice_? LoanData { get; init; } 
    /// <summary>
    /// Information on collateral used in the transaction.
    /// </summary>
    public TransactionCollateralData14Choice_? CollateralData { get; init; } 
    /// <summary>
    /// Information concerning the reported transaction level type.
    /// </summary>
    public required ModificationLevel1Code LevelType { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1[] SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
