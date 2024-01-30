﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MandateCancellation3.  ISO2002 ID# _pxt2sSmfEeKdFJmzhTDOvQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate to be cancelled.
/// </summary>
public partial record MandateCancellation3
{
    #nullable enable
    
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; } 
    /// <summary>
    /// Provides detailed information on the cancellation reason.
    /// </summary>
    public required PaymentCancellationReason1 CancellationReason { get; init; } 
    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    public required IOriginalMandate2Choice OriginalMandate { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
