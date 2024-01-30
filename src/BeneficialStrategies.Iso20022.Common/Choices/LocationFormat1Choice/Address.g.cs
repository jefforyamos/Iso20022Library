﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Address.  ISO2002 ID# _RXD3mNp-Ed-ak6NoX_4Aeg_-217471735.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.LocationFormat1Choice;

/// <summary>
/// Specifies physical address of the meeting.
/// </summary>
public partial record Address : ILocationFormat1Choice
{
    #nullable enable
    /// <summary>
    /// Identifies the nature of the postal address.
    /// </summary>
    public AddressType2Code? AddressType { get; init; } 
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services, that is presented in free format text.
    /// </summary>
    // public IReadOnlyCollection<IsoMax70Text> AddressLine { get; init; }
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
    /// Nation with its own government.
    /// </summary>
    public required CountryCode Country { get; init; } 
    #nullable disable
}
