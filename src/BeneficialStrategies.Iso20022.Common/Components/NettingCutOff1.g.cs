﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NettingCutOff1.  ISO2002 ID# _3VEsgJVHEeaYkf5FCqYMeA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details for one to many netting cut off update requests to be actioned by a central system.
/// </summary>
public partial record NettingCutOff1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the netting party or group.
    /// </summary>
    public required NettingIdentification1Choice_ NettingIdentification { get; init; } 
    /// <summary>
    /// Specifies the information regarding the updated netting cut off.
    /// </summary>
    public CutOff1[] NewCutOff { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
