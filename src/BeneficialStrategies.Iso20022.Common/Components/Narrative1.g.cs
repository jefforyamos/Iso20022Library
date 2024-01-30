﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Narrative1.  ISO2002 ID# _94mSknltEeG7BsjMvd1mEw_1059061696.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Narrative information for an undertaking.
/// </summary>
public partial record Narrative1
{
    #nullable enable
    
    /// <summary>
    /// Type of term or condition.
    /// </summary>
    public INarrativeType1Choice? Type { get; init; } 
    /// <summary>
    /// Narrative text.
    /// </summary>
    // public IReadOnlyCollection<IsoMax20000Text> Text { get; init; }
    
    #nullable disable
}
