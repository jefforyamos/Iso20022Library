﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransferCancellationStatus2.  ISO2002 ID# _RQWyqNp-Ed-ak6NoX_4Aeg_610595446.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transfer cancellation status is accepted or sent to next party.
/// </summary>
public partial record TransferCancellationStatus2
{
    #nullable enable
    
    /// <summary>
    /// Status of the transfer cancellation is accepted or sent to next party.
    /// </summary>
    public required CancellationStatus2Code Status { get; init; } 
    /// <summary>
    /// Reason for the status.
    /// </summary>
    public IsoMax350Text? Reason { get; init; } 
    
    #nullable disable
}
