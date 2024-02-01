﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnmatchedReason5.  ISO2002 ID# _A4s_EtokEeC60axPepSq7g_-893449260.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The status of an instruction, advice or request.
/// </summary>
public partial record UnmatchedReason5
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction has an unmatched status.
    /// </summary>
    public required UnmatchedReason7Choice_ Code { get; init; } 
    /// <summary>
    /// Provides additional information about the reason in narrative form.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
