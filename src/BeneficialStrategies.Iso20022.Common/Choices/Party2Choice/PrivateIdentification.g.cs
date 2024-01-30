﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PrivateIdentification.  ISO2002 ID# _RCDQ4tp-Ed-ak6NoX_4Aeg_-1657924072.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Party2Choice;

/// <summary>
/// Unique and unambiguous identification of a person, eg, passport.
/// </summary>
public partial record PrivateIdentification : IParty2Choice
{
    #nullable enable
    /// <summary>
    /// Number assigned by a license authority to a driver's license.
    /// </summary>
    public required IsoMax35Text DriversLicenseNumber { get; init; } 
    /// <summary>
    /// Number assigned by an agent to identify its customer.
    /// </summary>
    public required IsoMax35Text CustomerNumber { get; init; } 
    /// <summary>
    /// Number assigned by a social security agency.
    /// </summary>
    public required IsoMax35Text SocialSecurityNumber { get; init; } 
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// </summary>
    public required IsoMax35Text AlienRegistrationNumber { get; init; } 
    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// </summary>
    public required IsoMax35Text PassportNumber { get; init; } 
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    public required IsoMax35Text TaxIdentificationNumber { get; init; } 
    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// </summary>
    public required IsoMax35Text IdentityCardNumber { get; init; } 
    /// <summary>
    /// Number assigned to an employer by a registration authority.
    /// </summary>
    public required IsoMax35Text EmployerIdentificationNumber { get; init; } 
    /// <summary>
    /// Date and place of birth of a person.
    /// </summary>
    public required DateAndPlaceOfBirth DateAndPlaceOfBirth { get; init; } 
    /// <summary>
    /// Identifier issued to a person for which no specific identifier has been defined.
    /// </summary>
    public required GenericIdentification4 OtherIdentification { get; init; } 
    /// <summary>
    /// Entity that assigns the identifier.
    /// </summary>
    public IsoMax35Text? Issuer { get; init; } 
    #nullable disable
}
