﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReceiptAcknowledgementReport1.  ISO2002 ID# _jHt69O5NEeCisYr99QEiWA_-1586267634.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the original request. Identifies the message being acknowledged and its status.
/// </summary>
public partial record ReceiptAcknowledgementReport1
{
    #nullable enable
    
    /// <summary>
    /// Reference of the request.
    /// </summary>
    public required AdditionalReferences RelatedReference { get; init; } 
    /// <summary>
    /// Gives the status of the request.
    /// </summary>
    public required RequestHandling1 RequestHandling { get; init; } 
    /// <summary>
    /// Identification of the original message for which the acknowledgement is sent.
    /// </summary>
    public MessageIdentification6? OriginalMessageIdentification { get; init; } 
    
    #nullable disable
}
