﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification112.  ISO2002 ID# _1EXqocNQEeWGDrnsYu2p6g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify a person or an organisation.
/// </summary>
public partial record PartyIdentification112
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    public Party10Choice_? Identification { get; init; } 
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public IsoMax35Text? Name { get; init; } 
    /// <summary>
    /// Information that locates and identifies a specific address.
    /// </summary>
    public PostalAddress6? PostalAddress { get; init; } 
    /// <summary>
    /// Country in which a person resides (the place of a person's home). In the case of a company, it is the country from which the affairs of that company are directed.
    /// </summary>
    public CountryCode? CountryOfResidence { get; init; } 
    /// <summary>
    /// Contact defined for this party.
    /// </summary>
    public Contacts3[] ContactDetails { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
