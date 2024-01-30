﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Contacts3.  ISO2002 ID# _TGcRXwEcEeCQm6a_G2yO_w_1262678434.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Address for electronic mail (e-mail).
/// </summary>
public partial record Contacts3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// </summary>
    public NamePrefix1Code? NamePrefix { get; init; } 
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public IsoMax140Text? Name { get; init; } 
    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    public IsoPhoneNumber? PhoneNumber { get; init; } 
    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
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
    /// Contact details in another form.
    /// </summary>
    public IsoMax35Text? Other { get; init; } 
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
    
    #nullable disable
}
