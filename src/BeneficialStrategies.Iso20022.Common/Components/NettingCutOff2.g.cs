﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NettingCutOff2.  ISO2002 ID# _B-239QN1Ee2-vqzwMUAewg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details for one to many netting cut off update requests to be actioned by a central system.
/// </summary>
public partial record NettingCutOff2
{
    #nullable enable
    
    /// <summary>
    /// Identifies the netting party or group.
    /// </summary>
    public required NettingIdentification2Choice_ NettingIdentification { get; init; } 
    /// <summary>
    /// Specifies the information regarding the updated netting cut off.
    /// </summary>
    public CutOff1[] NewCutOff { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
