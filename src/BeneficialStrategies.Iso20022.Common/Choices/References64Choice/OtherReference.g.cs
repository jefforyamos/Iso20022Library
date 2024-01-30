﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherReference.  ISO2002 ID# _5wfiQ2pYEeipaMTLlhaKMQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.References64Choice;

/// <summary>
/// Reference to a linked proprietary message or reference of a system that was previously received.
/// </summary>
public partial record OtherReference : IReferences64Choice
{
    #nullable enable
    /// <summary>
    /// Reference issued by a party to identify an instruction, transaction or a message.
    /// </summary>
    public required IsoMax35Text Reference { get; init; } 
    /// <summary>
    /// Issuer of the reference.
    /// </summary>
    public PartyIdentification139? ReferenceIssuer { get; init; } 
    /// <summary>
    /// Name of the message.
    /// </summary>
    public IsoMax35Text? MessageName { get; init; } 
    #nullable disable
}
