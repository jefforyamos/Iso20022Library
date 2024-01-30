﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IndividualPerson33.  ISO2002 ID# _49vcsU_pEeaB8-OWTiMVrQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an 'artificial person').
/// </summary>
public partial record IndividualPerson33
{
    #nullable enable
    
    /// <summary>
    /// Term used to address the person.
    /// </summary>
    public INamePrefix1Choice? NamePrefix { get; init; } 
    /// <summary>
    /// First name of the person.
    /// </summary>
    public IsoMax35Text? GivenName { get; init; } 
    /// <summary>
    /// Second name of the person.
    /// </summary>
    public IsoMax35Text? MiddleName { get; init; } 
    /// <summary>
    /// Name by which the party is known and which is usually used to identify that person.
    /// </summary>
    public required IsoMax350Text Name { get; init; } 
    /// <summary>
    /// Additional information about the person that follows a person's name, for example, qualification such as Doctor of Philosophy (PhD).
    /// </summary>
    public IsoMax35Text? NameSuffix { get; init; } 
    /// <summary>
    /// Gender of the person.
    /// </summary>
    public Gender1Code? Gender { get; init; } 
    /// <summary>
    /// Date on which the person was born.
    /// </summary>
    public IsoISODate? BirthDate { get; init; } 
    /// <summary>
    /// Country where the person was born.
    /// </summary>
    public CountryCode? CountryOfBirth { get; init; } 
    /// <summary>
    /// Province where the person was born.
    /// </summary>
    public IsoMax35Text? ProvinceOfBirth { get; init; } 
    /// <summary>
    /// City where the person was born.
    /// </summary>
    public IsoMax35Text? CityOfBirth { get; init; } 
    /// <summary>
    /// Name of the occupation or job of the person.
    /// </summary>
    public IsoMax35Text? Profession { get; init; } 
    /// <summary>
    /// Information related to an address to be inserted, updated or deleted.
    /// </summary>
    public ModificationScope34? ModifiedPostalAddress { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Citizenship information to be inserted or deleted.
    /// </summary>
    // public IReadOnlyCollection<ModificationScope39> ModifiedCitizenship { get; init; }
    /// <summary>
    /// Organisation represented by a person, or for which a person works.
    /// </summary>
    public IsoMax140Text? EmployingCompany { get; init; } 
    /// <summary>
    /// Title of the function.
    /// </summary>
    public IsoMax35Text? BusinessFunction { get; init; } 
    /// <summary>
    /// Specifies if due diligence checks on the political exposure of the investor or account servicer have been carried out and whether these checks are national or foreign. (A politically exposed person is someone who has been entrusted with a prominent public function, or an individual who is closely related to such a person.).
    /// </summary>
    public IPoliticalExposureType1Choice? PoliticallyExposedPersonType { get; init; } 
    /// <summary>
    /// Date of death.
    /// </summary>
    public IsoISODate? DeathDate { get; init; } 
    /// <summary>
    /// Civil status of the individual person.
    /// </summary>
    public ICivilStatus1Choice? CivilStatus { get; init; } 
    /// <summary>
    /// Highest level of education reached by the individual person.
    /// </summary>
    public IsoMax35Text? EducationLevel { get; init; } 
    /// <summary>
    /// Information related to the person.
    /// </summary>
    public PersonalInformation1? FamilyInformation { get; init; } 
    
    #nullable disable
}
