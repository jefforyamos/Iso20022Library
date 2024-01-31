﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PostalAddress24.  ISO2002 ID# _9XYD524-EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a specific address, as defined by postal services.
/// </summary>
public partial record PostalAddress24
{
    #nullable enable
    
    /// <summary>
    /// Identifies the nature of the postal address.
    /// </summary>
    public IAddressType3Choice? AddressType { get; init; } 
    /// <summary>
    /// Identification of a division of a large organisation or building.
    /// </summary>
    public IsoMax70Text? Department { get; init; } 
    /// <summary>
    /// Identification of a sub-division of a large organisation or building.
    /// </summary>
    public IsoMax70Text? SubDepartment { get; init; } 
    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    public IsoMax70Text? StreetName { get; init; } 
    /// <summary>
    /// Number that identifies the position of a building on a street.
    /// </summary>
    public IsoMax16Text? BuildingNumber { get; init; } 
    /// <summary>
    /// Name of the building or house.
    /// </summary>
    public IsoMax35Text? BuildingName { get; init; } 
    /// <summary>
    /// Floor or storey within a building.
    /// </summary>
    public IsoMax70Text? Floor { get; init; } 
    /// <summary>
    /// Numbered box in a post office, assigned to a person or organisation, where letters are kept until called for.
    /// </summary>
    public IsoMax16Text? PostBox { get; init; } 
    /// <summary>
    /// Building room number.
    /// </summary>
    public IsoMax70Text? Room { get; init; } 
    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    public IsoMax16Text? PostCode { get; init; } 
    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    public IsoMax35Text? TownName { get; init; } 
    /// <summary>
    /// Specific location name within the town.
    /// </summary>
    public IsoMax35Text? TownLocationName { get; init; } 
    /// <summary>
    /// Identifies a subdivision within a country sub-division.
    /// </summary>
    public IsoMax35Text? DistrictName { get; init; } 
    /// <summary>
    /// Identifies a subdivision of a country such as state, region, county.
    /// </summary>
    public IsoMax35Text? CountrySubDivision { get; init; } 
    /// <summary>
    /// Nation with its own government.
    /// </summary>
    public CountryCode? Country { get; init; } 
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services, presented in free format text.
    /// </summary>
    public IReadOnlyCollection<IsoMax70Text> AddressLine { get; init; } = [];
    
    #nullable disable
}
