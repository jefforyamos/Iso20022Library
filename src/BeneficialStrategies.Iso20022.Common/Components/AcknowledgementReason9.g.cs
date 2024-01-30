﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcknowledgementReason9.  ISO2002 ID# _hQwiETnvEeWfSKvvZlhRKg.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies additional information about the processed instruction.
/// </summary>
public partial record AcknowledgementReason9
{
    #nullable enable
    
    /// <summary>
    /// Reason provided for the status.
    /// </summary>
    public required IAcknowledgementReason12Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
