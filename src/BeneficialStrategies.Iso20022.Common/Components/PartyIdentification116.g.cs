﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification116.  ISO2002 ID# _ynQ8AEkIEeaOe8w0NJ11wQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identification, as assigned by an organisation, to unambiguously identify a party.
/// </summary>
[DataContract]
[XmlType]
public partial record PartyIdentification116
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [DataMember]
    public required OrganisationIdentification28 PartyIdentification { get; init; } 
    /// <summary>
    /// Identifier and name of an organisation that is allocated by an institution.
    /// </summary>
    [DataMember]
    public LegalOrganisation1? LegalOrganisation { get; init; } 
    /// <summary>
    /// TaxParty.
    /// </summary>
    [DataMember]
    public TaxParty1? TaxParty { get; init; } 
    
    #nullable disable
}
