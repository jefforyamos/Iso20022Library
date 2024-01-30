﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InternalisationData2.  ISO2002 ID# _RCmFcO3uEeaWjpoyrnG6Rw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the aggregated data of internalised settlement instructions.
/// </summary>
public partial record InternalisationData2
{
    #nullable enable
    
    /// <summary>
    /// Aggregated volume and value of internalised settlement instructions settled during the period covered by the report, for financial Instruments, types of transactions, types of clients and cash transfers.
    /// </summary>
    public required InternalisationDataVolume1 Settled { get; init; } 
    /// <summary>
    /// Aggregated volume and value of internalised settlement instructions failed during the period covered by the report, for financial Instruments, types of transactions, types of clients and cash transfers.
    /// </summary>
    public required InternalisationDataVolume1 Failed { get; init; } 
    /// <summary>
    /// Aggregated total volume and value of internalised settlement instructions performed (settled and failed) during the period covered by the report, for financial Instruments, types of transactions, types of clients and cash transfers.
    /// </summary>
    public required InternalisationDataVolume1 Total { get; init; } 
    
    #nullable disable
}
