﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Error.  ISO2002 ID# _zvSsdcg3EeuGrNSsxk3B0A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport22Choice;

/// <summary>
/// Indicates whether transaction was reported by mistake and needs to be removed.
/// </summary>
public partial record Error : ITradeReport22Choice
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
    public required LoanData86 LoanData { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
