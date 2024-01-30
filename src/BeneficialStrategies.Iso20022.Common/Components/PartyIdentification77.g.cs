﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification77.  ISO2002 ID# _j4YVsdLPEeSdq5yU2aaSNw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a person or an organisation.
/// </summary>
public partial record PartyIdentification77
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public IsoMax140Text? Name { get; init; } 
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    public PostalAddress19? PostalAddress { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of a party.
    /// </summary>
    public IParty11Choice? Identification { get; init; } 
    /// <summary>
    /// Country in which a person resides (the place of a person's home). In the case of a company, it is the country from which the affairs of that company are directed.
    /// </summary>
    public CountryCode? CountryOfResidence { get; init; } 
    /// <summary>
    /// Set of elements used to indicate how to contact the party.
    /// </summary>
    public ContactDetails2? ContactDetails { get; init; } 
    
    #nullable disable
}
