﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for KeyIdentifier.  ISO2002 ID# _c8uDQFc0EeOi-M6GtW0vCQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Recipient3Choice;

/// <summary>
/// Identification of a cryptographic symetric key, previously exchanged between the initiator and the recipient.
/// </summary>
public partial record KeyIdentifier : IRecipient3Choice
{
    #nullable enable
    /// <summary>
    /// Identification of the cryptographic key.
    /// </summary>
    public required IsoMax140Text KeyIdentification { get; init; } 
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    public required IsoExact10Text KeyVersion { get; init; } 
    /// <summary>
    /// Identification used for derivation of a unique key from a master key provided for the data protection.
    /// </summary>
    public IsoMin5Max16Binary? DerivationIdentification { get; init; } 
    #nullable disable
}
