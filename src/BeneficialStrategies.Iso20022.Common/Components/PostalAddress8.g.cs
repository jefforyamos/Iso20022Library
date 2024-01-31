﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PostalAddress8.  ISO2002 ID# _ASQqINokEeC60axPepSq7g_1366752354.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a specific address, as defined by postal services.
/// </summary>
public partial record PostalAddress8
{
    #nullable enable
    
    /// <summary>
    /// Identifies the nature of the postal address.
    /// </summary>
    public AddressType2Code? AddressType { get; init; } 
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services, that is presented in free format text.
    /// </summary>
    public IReadOnlyCollection<IsoMax70Text> AddressLine { get; init; } = [];
    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    public IsoMax70Text? StreetName { get; init; } 
    /// <summary>
    /// Number that identifies the position of a building on a street.
    /// </summary>
    public IsoMax16Text? BuildingNumber { get; init; } 
    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    public IsoMax16Text? PostCode { get; init; } 
    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    public IsoMax35Text? TownName { get; init; } 
    /// <summary>
    /// Identifies a subdivision of a country for example, state, region, county.
    /// </summary>
    public IsoMax35Text? CountrySubDivision { get; init; } 
    /// <summary>
    /// Nation with its own government, occupying a particular territory.
    /// </summary>
    public required CountryCode Country { get; init; } 
    
    #nullable disable
}
