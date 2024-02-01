﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IndividualPerson16.  ISO2002 ID# _QBX3Adp-Ed-ak6NoX_4Aeg_-685335209.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an 'artificial person').
/// </summary>
public partial record IndividualPerson16
{
    #nullable enable
    
    /// <summary>
    /// Name received at birth, eg, maiden name.
    /// </summary>
    public required IsoMax35Text BirthName { get; init; } 
    /// <summary>
    /// First name of a person.
    /// </summary>
    public IsoMax35Text? GivenName { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of a person, eg, passport.
    /// </summary>
    public PersonIdentification6? Identification { get; init; } 
    /// <summary>
    /// Postal address of a party.
    /// </summary>
    public LongPostalAddress2Choice_? Address { get; init; } 
    /// <summary>
    /// Organisation represented by a person, or for which a person works.
    /// </summary>
    public PartyIdentification9Choice_? EmployingParty { get; init; } 
    
    #nullable disable
}
