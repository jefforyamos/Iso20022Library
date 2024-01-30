﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MandateOccurrences3.  ISO2002 ID# _vVpaUSLzEeSizvrwx7oJNQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details related to the duration of the mandate and the occurrence of the underlying transactions.
/// </summary>
public partial record MandateOccurrences3
{
    #nullable enable
    
    /// <summary>
    /// Identifies the underlying transaction sequence as either recurring or one-off.
    /// </summary>
    public required SequenceType2Code SequenceType { get; init; } 
    /// <summary>
    /// Regularity with which instructions are to be created and processed.
    /// </summary>
    public IFrequency21Choice? Frequency { get; init; } 
    /// <summary>
    /// Length of time for which the mandate remains valid.
    /// </summary>
    public DatePeriodDetails1? Duration { get; init; } 
    /// <summary>
    /// Date of the first collection of a direct debit as per the mandate.
    /// </summary>
    public IsoISODate? FirstCollectionDate { get; init; } 
    /// <summary>
    /// Date of the final collection of a direct debit as per the mandate.
    /// </summary>
    public IsoISODate? FinalCollectionDate { get; init; } 
    
    #nullable disable
}
