﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MandateCancellation1.  ISO2002 ID# _RBmk8tp-Ed-ak6NoX_4Aeg_-1323180575.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate to be cancelled.
/// </summary>
public partial record MandateCancellation1
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide information on the original messsage.
    /// </summary>
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; } 
    /// <summary>
    /// Set of elements used to provide detailed information on the cancellation reason.
    /// </summary>
    public required CancellationReasonInformation2 CancellationReason { get; init; } 
    /// <summary>
    /// Set of elements used to provide the original mandate data.
    /// </summary>
    public required IOriginalMandate1Choice OriginalMandate { get; init; } 
    
    #nullable disable
}
