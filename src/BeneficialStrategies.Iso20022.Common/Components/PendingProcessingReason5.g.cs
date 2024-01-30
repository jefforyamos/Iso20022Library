﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PendingProcessingReason5.  ISO2002 ID# _0jExAwlIEeGATtfOBToyew_2075567682.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The status of an instruction, advice or request.
/// </summary>
public partial record PendingProcessingReason5
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction has a pending processing status.
    /// </summary>
    public required IPendingProcessingReason5Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
