﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IndividualPerson11.  ISO2002 ID# _QCRO5tp-Ed-ak6NoX_4Aeg_440061392.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an 'artificial person').
/// </summary>
public partial record IndividualPerson11
{
    #nullable enable
    
    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// </summary>
    public NamePrefix1Code? NamePrefix { get; init; } 
    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// </summary>
    public IsoExtended350Code? ExtendedNamePrefix { get; init; } 
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
    /// Additional information about a person that follows a person's name, eg, qualification such as Doctor of Philosophy (PhD).
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
    /// Country of taxation of an individual person or an organisation.
    /// </summary>
    public CountryCode? TaxationCountry { get; init; } 
    /// <summary>
    /// Country and residential status of an individual, for example, non-pernament resident.
    /// </summary>
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; init; } 
    /// <summary>
    /// Title of the function.
    /// </summary>
    public IsoMax35Text? BusinessFunction { get; init; } 
    /// <summary>
    /// Organisation represented by a person, or for which a person works.
    /// </summary>
    public IsoMax140Text? EmployingCompany { get; init; } 
    /// <summary>
    /// Address information to be either inserted, updated or deleted.
    /// </summary>
    // public IReadOnlyCollection<ModificationScope1> ModifiedPostalAddress { get; init; }
    /// <summary>
    /// Citizenship information to be inserted or deleted.
    /// </summary>
    // public IReadOnlyCollection<ModificationScope3> ModifiedCitizenship { get; init; }
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
    /// <summary>
    /// Identification information to be either inserted or deleted.
    /// </summary>
    // public IReadOnlyCollection<ModificationScope2> ModifiedOtherIdentification { get; init; }
    
    #nullable disable
}
