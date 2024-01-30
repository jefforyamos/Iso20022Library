﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransferCancellationStatus.  ISO2002 ID# _U0fAuNp-Ed-ak6NoX_4Aeg_441136069.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancellation status.
/// </summary>
public partial record TransferCancellationStatus
{
    #nullable enable
    
    /// <summary>
    /// Status of the transfer cancellation instruction.
    /// </summary>
    public required CancellationStatus1Code Status { get; init; } 
    /// <summary>
    /// Additional information about the status in textual form.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
