﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnmatchedReason21.  ISO2002 ID# _fginYOCXEei2UYJ62ws-Fw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason of the unmatched status.
/// </summary>
public partial record UnmatchedReason21
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction has an unmatched status.
    /// </summary>
    public required IUnmatchedReason30Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
