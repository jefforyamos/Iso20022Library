﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReportTransactionResponse4.  ISO2002 ID# _QC3YoU0zEeybj420QgWBkA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Transaction Report Response message.
/// </summary>
public partial record ReportTransactionResponse4
{
    #nullable enable
    
    /// <summary>
    /// The total number of transactions matching the search criteria.
    /// </summary>
    public required IsoPositiveNumber ReportFullSize { get; init; } 
    /// <summary>
    /// Index of the first transaction reported in this message within the list of transactions matching the search criteria.
    /// </summary>
    public required IsoPositiveNumber BlockStart { get; init; } 
    /// <summary>
    /// Index of the last transaction reported in this message.
    /// </summary>
    public required IsoPositiveNumber BlockStop { get; init; } 
    /// <summary>
    /// List of Transaction Report containing one Transaction Report for each transaction matching the Search criteria. This list may be partial according to requested block.
    /// </summary>
    public PointOfInteractionTransactionReport4[] TransactionReport { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
