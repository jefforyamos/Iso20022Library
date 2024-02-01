﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SellerBankContactPerson.  ISO2002 ID# _pb7W8DAZEeOKib24wnHaFg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BankContactPerson1Choice;

/// <summary>
/// Person to be contacted in the seller's bank.
/// </summary>
public partial record SellerBankContactPerson : BankContactPerson1Choice_
{
    #nullable enable
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public required IsoMax35Text Name { get; init; } 
    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// </summary>
    public NamePrefix1Code? NamePrefix { get; init; } 
    /// <summary>
    /// First name of a person.
    /// </summary>
    public IsoMax35Text? GivenName { get; init; } 
    /// <summary>
    /// Role of the party in the activity.
    /// </summary>
    public IsoMax35Text? Role { get; init; } 
    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    public IsoPhoneNumber? PhoneNumber { get; init; } 
    /// <summary>
    /// Collection of information that identifies a FAX number, as defined by telecom services.
    /// </summary>
    public IsoPhoneNumber? FaxNumber { get; init; } 
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    public IsoMax256Text? EmailAddress { get; init; } 
    #nullable disable
}
