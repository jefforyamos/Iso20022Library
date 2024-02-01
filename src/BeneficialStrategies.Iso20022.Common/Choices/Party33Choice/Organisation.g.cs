﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Organisation.  ISO2002 ID# _52fY8UzQEea8fovz_9xSTQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party33Choice;

/// <summary>
/// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
/// </summary>
public partial record Organisation : Party33Choice_
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
    public PartyIdentification72Choice_? Identification { get; init; } 
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
    /// Information related to an address to be inserted, updated or deleted.
    /// </summary>
    public ModificationScope34? ModifiedPostalAddress { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Type of organisation.
    /// </summary>
    public OrganisationType1Choice_? TypeOfOrganisation { get; init; } 
    /// <summary>
    /// Place of listing for shares in the organisation.
    /// </summary>
    public IsoMICIdentifier? PlaceOfListing { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
