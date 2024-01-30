﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RelatedReference.  ISO2002 ID# _duUiYSYtEeW_ZNn8gbfY7Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.References49Choice;

/// <summary>
/// Reference to a linked message that was previously received.
/// </summary>
public partial record RelatedReference : IReferences49Choice
{
    #nullable enable
    /// <summary>
    /// Message identification of a message. This reference was assigned by the party issuing the message.
    /// </summary>
    public required IsoMax35Text Reference { get; init; } 
    /// <summary>
    /// Issuer of the reference.
    /// </summary>
    public IPartyIdentification90Choice? ReferenceIssuer { get; init; } 
    /// <summary>
    /// Name of the message.
    /// </summary>
    public IsoMax35Text? MessageName { get; init; } 
    #nullable disable
}
