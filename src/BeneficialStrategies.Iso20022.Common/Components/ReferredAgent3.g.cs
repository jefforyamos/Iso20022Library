﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReferredAgent3.  ISO2002 ID# _hyxAAZRBEemqYPWMBuVawg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the placement agent identification for a hedge fund if the investor was referred by one.
/// </summary>
public partial record ReferredAgent3
{
    #nullable enable
    
    /// <summary>
    /// Indicates if the investor was referred by a placement agent.
    /// </summary>
    public required Referred1Code Referred { get; init; } 
    /// <summary>
    /// Placement agent that referred the investor.
    /// </summary>
    public PartyIdentification125Choice_? ReferredPlacementAgent { get; init; } 
    
    #nullable disable
}
