﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeParty4.  ISO2002 ID# _N3SQQeWlEeevU7McUP3D1w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies an entity involved in a trade activity.
/// </summary>
public partial record TradeParty4
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    public required PartyIdentification129 PartyIdentification { get; init; } 
    /// <summary>
    /// Legally constituted organization specified for this trade party.
    /// </summary>
    public LegalOrganisation1? LegalOrganisation { get; init; } 
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    public TaxParty3? TaxParty { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
