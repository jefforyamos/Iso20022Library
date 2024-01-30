﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification41.  ISO2002 ID# _PXDustp-Ed-ak6NoX_4Aeg_1995698451.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify a person or an organisation.
/// </summary>
public partial record PartyIdentification41
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public IsoMax140Text? Name { get; init; } 
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    public PostalAddress6? PostalAddress { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of a party.
    /// </summary>
    public IParty8Choice? Identification { get; init; } 
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
