﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IndividualPerson.  ISO2002 ID# _Bkkfc2W8EeSHcOWXSsMhqw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party23Choice;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an 'artificial person').
/// </summary>
public partial record IndividualPerson : Party23Choice_
{
    #nullable enable
    /// <summary>
    /// Term used to address a person.
    /// </summary>
    public NamePrefix1Choice_? NamePrefix { get; init; } 
    /// <summary>
    /// First name of a person.
    /// </summary>
    public required IsoMax35Text GivenName { get; init; } 
    /// <summary>
    /// Second name of a person.
    /// </summary>
    public IsoMax35Text? MiddleName { get; init; } 
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public required IsoMax350Text Name { get; init; } 
    /// <summary>
    /// Additional information about a person that follows a person's name, for example, qualification such as Doctor of Philosophy (PhD).
    /// </summary>
    public IsoMax35Text? NameSuffix { get; init; } 
    /// <summary>
    /// Specifies the gender of the person.
    /// </summary>
    public GenderCode? Gender { get; init; } 
    /// <summary>
    /// Language in which a person communicates.
    /// </summary>
    public LanguageCode? Language { get; init; } 
    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    public required IsoISODate BirthDate { get; init; } 
    /// <summary>
    /// Country where a person was born.
    /// </summary>
    public CountryCode? CountryOfBirth { get; init; } 
    /// <summary>
    /// Province where a person was born.
    /// </summary>
    public IsoMax35Text? ProvinceOfBirth { get; init; } 
    /// <summary>
    /// City where a person was born.
    /// </summary>
    public IsoMax35Text? CityOfBirth { get; init; } 
    /// <summary>
    /// Name of the occupation or job of a person.
    /// </summary>
    public IsoMax35Text? Profession { get; init; } 
    /// <summary>
    /// Country of taxation of an individual person.
    /// </summary>
    public CountryCode? TaxationCountry { get; init; } 
    /// <summary>
    /// Country and residential status of an individual, for example, non-permanent resident.
    /// </summary>
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; init; } 
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    public IReadOnlyCollection<PostalAddress3> PostalAddress { get; init; } = [];
    /// <summary>
    /// Nationality and legal status (minor or major) or rights that an individual may possess.
    /// </summary>
    public IReadOnlyCollection<CitizenshipInformation> Citizenship { get; init; } = [];
    /// <summary>
    /// Organisation represented by a person, or for which a person works.
    /// </summary>
    public IsoMax140Text? EmployingCompany { get; init; } 
    /// <summary>
    /// Title of the function.
    /// </summary>
    public IsoMax35Text? BusinessFunction { get; init; } 
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
    /// <summary>
    /// Alternative identification, for example, national registration identification number, passport number, or an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
    /// </summary>
    public IReadOnlyCollection<GenericIdentification55> OtherIdentification { get; init; } = [];
    /// <summary>
    /// Additional regulatory information about the investor that is required in some markets to support anti-money laundering laws.
    /// </summary>
    public RegulatoryInformation1? AdditionalRegulatoryInformation { get; init; } 
    /// <summary>
    /// Specifies if due diligence checks on the political exposure of the investor have been carried out and whether these checks are national or foreign. (A politically exposed person is someone who has been entrusted with a prominent public function, or an individual who is closely related to such a person.).
    /// </summary>
    public PoliticalExposureType1Choice_? PoliticallyExposedPersonType { get; init; } 
    #nullable disable
}
