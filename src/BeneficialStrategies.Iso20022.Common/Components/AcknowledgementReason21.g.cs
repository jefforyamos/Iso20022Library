﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcknowledgementReason21.  ISO2002 ID# _HwRDgZwZEeqtp-LOti013g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies additional information about a processed instruction.
/// </summary>
public partial record AcknowledgementReason21
{
    #nullable enable
    
    /// <summary>
    /// Reason provided for the status.
    /// </summary>
    public required AcknowledgementReason24Choice_ Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
