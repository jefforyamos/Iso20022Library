﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Organisation39.  ISO2002 ID# _mDHs1ZQ_EemqYPWMBuVawg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
/// </summary>
public partial record Organisation39
{
    #nullable enable
    
    /// <summary>
    /// Name by which the organisation is known and which is usually used to identify that organisation.
    /// </summary>
    public IsoMax350Text? Name { get; init; } 
    /// <summary>
    /// Name of the organisation in short form.
    /// </summary>
    public IsoMax35Text? ShortName { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for the organisation.
    /// </summary>
    public IPartyIdentification177Choice? Identification { get; init; } 
    /// <summary>
    /// Identification of the organisation with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 "Financial Services - Legal Entity Identifier (LEI)".
    /// </summary>
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; } 
    /// <summary>
    /// Purpose of the organisation, for example, charity.
    /// </summary>
    public IsoMax35Text? Purpose { get; init; } 
    /// <summary>
    /// Country in which the organisation is registered.
    /// </summary>
    public CountryCode? RegistrationCountry { get; init; } 
    /// <summary>
    /// Date and time at which a given organisation was officially registered.
    /// </summary>
    public IsoISODate? RegistrationDate { get; init; } 
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    // public IReadOnlyCollection<PostalAddress21> PostalAddress { get; init; }
    /// <summary>
    /// Type of organisation.
    /// </summary>
    public IOrganisationType1Choice? TypeOfOrganisation { get; init; } 
    /// <summary>
    /// Place of listing for shares in the organisation.
    /// </summary>
    public IsoMICIdentifier? PlaceOfListing { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
