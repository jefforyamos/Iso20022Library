﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnmatchedReason23.  ISO2002 ID# _goeg_Qd4Ee2fOITqoTnSLQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The status of an instruction, advice or request.
/// </summary>
public partial record UnmatchedReason23
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction has an unmatched status.
    /// </summary>
    public required UnmatchedReason32Choice_ Code { get; init; } 
    /// <summary>
    /// Provides additional information about the reason in narrative form.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
