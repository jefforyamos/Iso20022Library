﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TrackerPartyIdentification1.  ISO2002 ID# _XaC4YfWfEemtd4wHZYvFUQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the identification of a person or an organisation.
/// </summary>
public partial record TrackerPartyIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of a party.
    /// </summary>
    public required TrackerParty1 Identification { get; init; } 
    
    #nullable disable
}
