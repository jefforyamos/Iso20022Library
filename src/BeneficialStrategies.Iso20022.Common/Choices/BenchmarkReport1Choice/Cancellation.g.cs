﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Cancellation.  ISO2002 ID# _P2VfdDrWEeedCZZ8dIPp6g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.BenchmarkReport1Choice;

/// <summary>
/// Cancellation of a benchmark previously updated.
/// </summary>
public partial record Cancellation : IBenchmarkReport1Choice
{
    #nullable enable
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// </summary>
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    /// <summary>
    /// Identification of the benchmark to be cancelled.
    /// </summary>
    public required SecurityIdentification19 Identification { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
