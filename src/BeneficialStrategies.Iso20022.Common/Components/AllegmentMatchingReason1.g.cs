﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AllegmentMatchingReason1.  ISO2002 ID# _A4j1I9okEeC60axPepSq7g_-1544737926.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The status of an instruction, advice or request.
/// </summary>
public partial record AllegmentMatchingReason1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction has been alleged.
    /// </summary>
    public required IAllegmentReason1Choice Code { get; init; } 
    /// <summary>
    /// Provides additional information about the reason in narrative form.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
