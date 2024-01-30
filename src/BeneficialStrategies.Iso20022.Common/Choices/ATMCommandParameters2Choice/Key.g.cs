﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Key.  ISO2002 ID# _rAZ80ItIEeSxlKlAGYErFg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ATMCommandParameters2Choice;

/// <summary>
/// Parameters to be used by the various cryptographic key commands.
/// </summary>
public partial record Key : IATMCommandParameters2Choice
{
    #nullable enable
    /// <summary>
    /// Category of the cryptographic key.
    /// </summary>
    public CryptographicKeyType4Code? KeyCategory { get; init; } 
    /// <summary>
    /// Random value from the host provided during a previous exchange.
    /// </summary>
    public IsoMax140Binary? HostChallenge { get; init; } 
    /// <summary>
    /// Ordered certificate chain of the asymmetric key encryption key, starting with the host certificate.
    /// </summary>
    public IsoMax5000Binary? Certificate { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Cryptographic key involved in the security command.
    /// </summary>
    public KEKIdentifier4? KeyProperties { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
