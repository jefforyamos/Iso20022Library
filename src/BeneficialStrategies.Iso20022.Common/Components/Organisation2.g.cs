﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Organisation2.  ISO2002 ID# _QNckJtp-Ed-ak6NoX_4Aeg_-1898805277.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Organised structure that is set up for a particular purpose, eg, a business, government body, department, charity, or financial institution.
/// </summary>
public partial record Organisation2
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public required IsoMax140Text Name { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun & Bradstreet Identification.
    /// </summary>
    public PartyIdentification4Choice_? Identification { get; init; } 
    /// <summary>
    /// Purpose of the organisation, eg, charity.
    /// </summary>
    public IsoMax35Text? Purpose { get; init; } 
    /// <summary>
    /// Country of taxation of an organisation.
    /// </summary>
    public CountryCode? TaxationCountry { get; init; } 
    /// <summary>
    /// Country in which the organisation is registered.
    /// </summary>
    public CountryCode? RegistrationCountry { get; init; } 
    /// <summary>
    /// Date and time at which a given organisation was officially registered.
    /// </summary>
    public IsoISODate? RegistrationDate { get; init; } 
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    public IsoMax35Text? TaxIdentificationNumber { get; init; } 
    /// <summary>
    /// Number assigned by a national registration authority to an entity.
    /// </summary>
    public IsoMax35Text? NationalRegistrationNumber { get; init; } 
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    public PostalAddress3[] PostalAddress { get; init; } = [];
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
    
    #nullable disable
}
