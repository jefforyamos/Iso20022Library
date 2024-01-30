﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SystemPartyIdentification10.  ISO2002 ID# _90Gi0b10Eeiut6mmSKzDFQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identification to unambiguously identify the party within the system.
/// </summary>
public partial record SystemPartyIdentification10
{
    #nullable enable
    
    /// <summary>
    /// Starting date from which the identification is valid.
    /// </summary>
    public IsoISODate? ValidFrom { get; init; } 
    /// <summary>
    /// Unique and unambiguous way to identify a system party.
    /// </summary>
    public PartyIdentification136? Identification { get; init; } 
    
    #nullable disable
}
