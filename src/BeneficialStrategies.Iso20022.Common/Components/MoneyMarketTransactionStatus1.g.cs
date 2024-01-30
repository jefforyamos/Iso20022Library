﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MoneyMarketTransactionStatus1.  ISO2002 ID# _6oYUY9jFEeSD0e0ybx5L5Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of each individual secured market transaction.
/// </summary>
public partial record MoneyMarketTransactionStatus1
{
    #nullable enable
    
    /// <summary>
    /// Unique transaction identifier will be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction during its lifetime.
    /// </summary>
    public IsoMax105Text? UniqueTransactionIdentifier { get; init; } 
    /// <summary>
    /// Internal unique transaction identifier used by the reporting agent for each transaction.
    /// </summary>
    public required IsoMax105Text ProprietaryTransactionIdentification { get; init; } 
    /// <summary>
    /// Defines status of the reported transaction.
    /// </summary>
    public required StatisticalReportingStatus2Code Status { get; init; } 
    /// <summary>
    /// Provides the details of the rule which could not be validated.
    /// </summary>
    public GenericValidationRuleIdentification1? ValidationRule { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
