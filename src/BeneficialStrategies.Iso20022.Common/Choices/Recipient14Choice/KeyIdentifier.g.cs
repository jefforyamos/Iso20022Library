﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for KeyIdentifier.  ISO2002 ID# _4SHA5XDEEe2MCaKO5AtGsA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Recipient14Choice;

/// <summary>
/// Identification of a protection key without a session key, shared and previously exchanged between the initiator and the recipient.
/// </summary>
public partial record KeyIdentifier : Recipient14Choice_
{
    #nullable enable
    /// <summary>
    /// Identification of the cryptographic key.
    /// </summary>
    public required IsoMax140Text KeyIdentification { get; init; } 
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    public required IsoMax140Text KeyVersion { get; init; } 
    /// <summary>
    /// Number of usages of the cryptographic key.
    /// </summary>
    public IsoNumber? SequenceNumber { get; init; } 
    /// <summary>
    /// Identification used for derivation of a unique key from a master key provided for the data protection.
    /// </summary>
    public IsoMax500Binary? DerivationIdentification { get; init; } 
    #nullable disable
}
