﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Organisation21.  ISO2002 ID# _xXY_ESX-EeWJkOUkQWu90g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
/// </summary>
public partial record Organisation21
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public required IsoMax140Text Name { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for the organisation.
    /// </summary>
    public PartyIdentification72Choice_? Identification { get; init; } 
    /// <summary>
    /// Purpose of the organisation, for example, charity.
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
    /// Postal address of a party.
    /// </summary>
    public required PostalAddress1 CorporateInvestorAddress { get; init; } 
    
    #nullable disable
}
