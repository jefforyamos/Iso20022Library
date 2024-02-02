﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeParty5.  ISO2002 ID# _EjORi249EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies an entity involved in a trade activity.
/// </summary>
[DataContract]
[XmlType]
public partial record TradeParty5
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [DataMember]
    public required PartyIdentification135 PartyIdentification { get; init; } 
    /// <summary>
    /// Legally constituted organization specified for this trade party.
    /// </summary>
    [DataMember]
    public LegalOrganisation2? LegalOrganisation { get; init; } 
    /// <summary>
    /// Further tax details of an entity involved in an activity which is subject to taxation.
    /// </summary>
    [DataMember]
    public ValueList<TaxParty4> TaxParty { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
