﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherReference.  ISO2002 ID# _5R1ss6DjEeahP9OZs6K4wg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.LinkedMessage4Choice;

/// <summary>
/// Reference to a linked message sent in a proprietary way or reference of a system.
/// </summary>
public partial record OtherReference : ILinkedMessage4Choice
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
