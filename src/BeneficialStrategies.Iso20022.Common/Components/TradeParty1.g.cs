﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeParty1.  ISO2002 ID# _SkxHpQEcEeCQm6a_G2yO_w_-1189818940.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies an entity involved in a trade activity.
/// </summary>
public partial record TradeParty1
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    public required PartyIdentification45 PartyIdentification { get; init; } 
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
