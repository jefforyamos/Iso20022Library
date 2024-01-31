﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PostalAddress21.  ISO2002 ID# _E4FW4SFyEeW9XJWqfgXIIA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a specific address, as defined by postal services.
/// </summary>
public partial record PostalAddress21
{
    #nullable enable
    
    /// <summary>
    /// Type of address.
    /// </summary>
    public IAddressType2Choice? AddressType { get; init; } 
    /// <summary>
    /// Indicates whether mail should be sent to the address.
    /// </summary>
    public IsoYesNoIndicator? MailingIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the address is the official address of the party.
    /// </summary>
    public IsoYesNoIndicator? RegistrationAddressIndicator { get; init; } 
    /// <summary>
    /// When the individual resides at another person’s address, the name of the other person.
    /// </summary>
    public IsoMax70Text? CareOf { get; init; } 
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services, that is presented in free format text.
    /// </summary>
    public IReadOnlyCollection<IsoMax70Text> AddressLine { get; init; } = [];
    /// <summary>
    /// Name of the street or thoroughfare.
    /// </summary>
    public IsoMax70Text? StreetName { get; init; } 
    /// <summary>
    /// Number that identifies the position of the building on a street.
    /// </summary>
    public IsoMax16Text? BuildingNumber { get; init; } 
    /// <summary>
    /// Name of the building or house.
    /// </summary>
    public IsoMax35Text? BuildingName { get; init; } 
    /// <summary>
    /// Post box number of the addressee within the residential or company building.
    /// </summary>
    public IsoMax10Text? PostBox { get; init; } 
    /// <summary>
    /// Side or wing of the building, for example, ‘wing A’.
    /// </summary>
    public IsoMax35Text? SideInBuilding { get; init; } 
    /// <summary>
    /// Floor or storey within the building.
    /// </summary>
    public IsoMax70Text? Floor { get; init; } 
    /// <summary>
    /// Identification of the suite or apartment.
    /// </summary>
    public IsoMax10Text? SuiteIdentification { get; init; } 
    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    public IsoMax16Text? PostCode { get; init; } 
    /// <summary>
    /// Name of a district, that is, a part of the town or region.
    /// </summary>
    public IsoMax35Text? DistrictName { get; init; } 
    /// <summary>
    /// Name of the village.
    /// </summary>
    public IsoMax70Text? Village { get; init; } 
    /// <summary>
    /// Name of the town or city.
    /// </summary>
    public IsoMax35Text? TownName { get; init; } 
    /// <summary>
    /// Name of the state, county or country sub-division.
    /// </summary>
    public IsoMax70Text? State { get; init; } 
    /// <summary>
    /// Country of the address.
    /// </summary>
    public required CountryCode Country { get; init; } 
    
    #nullable disable
}
