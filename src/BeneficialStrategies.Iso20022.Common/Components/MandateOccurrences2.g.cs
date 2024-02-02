﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MandateOccurrences2.  ISO2002 ID# _tyV98FkyEeGeoaLUQk__nA_-12295162.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details related to the duration of the mandate and the occurrence of the underlying transactions.
/// </summary>
[DataContract]
[XmlType]
public partial record MandateOccurrences2
{
    #nullable enable
    
    /// <summary>
    /// Identifies the underlying transaction sequence as either recurring or one-off.
    /// </summary>
    [DataMember]
    public required SequenceType2Code SequenceType { get; init; } 
    /// <summary>
    /// Regularity with which instructions are to be created and processed.
    /// </summary>
    [DataMember]
    public Frequency6Code? Frequency { get; init; } 
    /// <summary>
    /// Length of time for which the mandate remains valid.
    /// </summary>
    [DataMember]
    public DatePeriodDetails1? Duration { get; init; } 
    /// <summary>
    /// Date of the first collection of a direct debit as per the mandate.
    /// </summary>
    [DataMember]
    public IsoISODate? FirstCollectionDate { get; init; } 
    /// <summary>
    /// Date of the final collection of a direct debit as per the mandate.
    /// </summary>
    [DataMember]
    public IsoISODate? FinalCollectionDate { get; init; } 
    
    #nullable disable
}
