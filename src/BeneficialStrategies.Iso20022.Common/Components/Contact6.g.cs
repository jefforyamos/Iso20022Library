﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Contact6.  ISO2002 ID# _nFpsXfPXEeihCvvpsmGI2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of a contact person.
/// </summary>
public partial record Contact6
{
    #nullable enable
    
    /// <summary>
    /// Home phone number of contact.
    /// </summary>
    public IsoPhoneNumber? HomePhoneNumber { get; init; } 
    /// <summary>
    /// Business phone number of contact.
    /// </summary>
    public IsoPhoneNumber? BusinessPhoneNumber { get; init; } 
    /// <summary>
    /// Mobile phone number of contact.
    /// </summary>
    public IsoPhoneNumber? MobilePhoneNumber { get; init; } 
    /// <summary>
    /// Other phone number of contact.
    /// </summary>
    public IsoPhoneNumber? OtherPhoneNumber { get; init; } 
    /// <summary>
    /// Personal email address of contact.
    /// </summary>
    public IsoMax256Text? PersonalEmailAddress { get; init; } 
    /// <summary>
    /// Business email address of contact.
    /// </summary>
    public IsoMax256Text? BusinessEmailAddress { get; init; } 
    /// <summary>
    /// Other email address of contact.
    /// </summary>
    public IsoMax256Text? OtherEmailAddress { get; init; } 
    /// <summary>
    /// Home fax number, as defined by telecom services.
    /// </summary>
    public IsoPhoneNumber? HomeFaxNumber { get; init; } 
    /// <summary>
    /// Business fax number, as defined by telecom services.
    /// </summary>
    public IsoPhoneNumber? BusinessFaxNumber { get; init; } 
    /// <summary>
    /// Universal Resource Locator (URL) address.
    /// </summary>
    public IsoMax256Text? URLAddress { get; init; } 
    /// <summary>
    /// Language of the contact.
    /// </summary>
    public LanguageCode? Language { get; init; } 
    
    #nullable disable
}
