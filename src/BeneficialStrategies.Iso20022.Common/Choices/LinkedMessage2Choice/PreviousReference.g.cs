﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PreviousReference.  ISO2002 ID# _u0o9AQguEeSy_NqeitQG4Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.LinkedMessage2Choice;

/// <summary>
/// Reference to a linked message that was previously sent.
/// </summary>
public partial record PreviousReference : ILinkedMessage2Choice
{
    #nullable enable
    /// <summary>
    /// Business reference of a message assigned by the party issuing the message. This reference must be unique amongst all messages of the same name sent by the same party.
    /// </summary>
    public required IsoMax35Text Reference { get; init; } 
    /// <summary>
    /// Issuer of the reference.
    /// </summary>
    public IPartyIdentification2Choice? ReferenceIssuer { get; init; } 
    /// <summary>
    /// Name of a message.
    /// </summary>
    public IsoMax35Text? MessageName { get; init; } 
    #nullable disable
}
