﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Create.  ISO2002 ID# _v7YEYdOtEeilDKNlC_3bSg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BenchmarkReport1Choice;

/// <summary>
/// Creation of a benchmark.
/// </summary>
public partial record Create : IBenchmarkReport1Choice
{
    #nullable enable
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// </summary>
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the benchmark.
    /// </summary>
    public required SecurityIdentification19 Identification { get; init; } 
    /// <summary>
    /// Any other additional information about the benchmark.
    /// </summary>
    public required BenchmarkDetail1 Other { get; init; } 
    /// <summary>
    /// Set of identifiers of the party who is administrating the benchmark.
    /// </summary>
    public required PartyIdentification136 Administrator { get; init; } 
    /// <summary>
    /// Set of identifiers of the party who is the supervised entity endorsing the benchmark.
    /// </summary>
    public PartyIdentification136? EndorsingParty { get; init; } 
    /// <summary>
    /// Status of the decision taken by a relevant institution concerning the benchmark.
    /// </summary>
    public StatusDetail1? Status { get; init; } 
    /// <summary>
    /// Period of time when the associated record is technically valid.
    /// </summary>
    public IPeriod4Choice? TechnicalValidityPeriod { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
