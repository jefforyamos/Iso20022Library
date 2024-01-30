﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ContactDetails.  ISO2002 ID# _J8b4wYwAEei289CGNqs21g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification2Choice;

/// <summary>
/// Specifies the options on how to contact the party.
/// </summary>
public partial record ContactDetails : ISystemPartyModification2Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// </summary>
    public NamePrefix2Code? NamePrefix { get; init; } 
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public IsoMax140Text? Name { get; init; } 
    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    public IsoPhoneNumber? PhoneNumber { get; init; } 
    /// <summary>
    /// Collection of information that identifies a mobile phone number, as defined by telecom services.
    /// </summary>
    public IsoPhoneNumber? MobileNumber { get; init; } 
    /// <summary>
    /// Collection of information that identifies a FAX number, as defined by telecom services.
    /// </summary>
    public IsoPhoneNumber? FaxNumber { get; init; } 
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    public IsoMax2048Text? EmailAddress { get; init; } 
    /// <summary>
    /// Purpose for which an email address may be used.
    /// </summary>
    public IsoMax35Text? EmailPurpose { get; init; } 
    /// <summary>
    /// Title of the function.
    /// </summary>
    public IsoMax35Text? JobTitle { get; init; } 
    /// <summary>
    /// Role of a person in an organisation.
    /// </summary>
    public IsoMax35Text? Responsibility { get; init; } 
    /// <summary>
    /// Identification of a division of a large organisation or building.
    /// </summary>
    public IsoMax70Text? Department { get; init; } 
    /// <summary>
    /// Contact details in another form.
    /// </summary>
    public OtherContact1? Other { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Preferred method used to reach the technical contact.
    /// </summary>
    public PreferredContactMethod1Code? PreferredMethod { get; init; } 
    /// <summary>
    /// Starting validity date for the contact.
    /// </summary>
    public IsoISODate? ValidFrom { get; init; } 
    /// <summary>
    /// Ending validity date for the contact.
    /// </summary>
    public IsoISODate? ValidTo { get; init; } 
    #nullable disable
}
