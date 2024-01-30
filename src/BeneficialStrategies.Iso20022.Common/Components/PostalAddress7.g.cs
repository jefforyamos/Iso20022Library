﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PostalAddress7.  ISO2002 ID# _WNJcz9p-Ed-ak6NoX_4Aeg_-1885159655.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a specific address, as defined by postal services.
/// </summary>
public partial record PostalAddress7
{
    #nullable enable
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services, that is presented in free format text.
    /// </summary>
    // public IReadOnlyCollection<IsoRestrictedFINMax35Text> AddressLine { get; init; }
    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    public IsoRestrictedFINMax8Text? PostCode { get; init; } 
    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    public IsoRestrictedFINMax23Text? TownName { get; init; } 
    /// <summary>
    /// Nation with its own government.
    /// </summary>
    public required CountryCode Country { get; init; } 
    
    #nullable disable
}
