﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CryptographicKey4.  ISO2002 ID# _555bkTZ3EeOP_KvUKe29ng.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic Key to exchange.
/// </summary>
public partial record CryptographicKey4
{
    #nullable enable
    
    /// <summary>
    /// Name of the cryptographic key.
    /// </summary>
    public required IsoMax140Text Identification { get; init; } 
    /// <summary>
    /// Additional identification of the key.
    /// Usage
    /// For derived unique key per transaction (DUKPT) keys, the key serial number (KSN) with the 21 bits of the transaction counter set to zero.
    /// </summary>
    public IsoMax35Binary? AdditionalIdentification { get; init; } 
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    public required IsoExact10Text Version { get; init; } 
    /// <summary>
    /// Type of algorithm used by the cryptographic key.
    /// </summary>
    public CryptographicKeyType2Code? Type { get; init; } 
    /// <summary>
    /// Allowed usage of the key.
    /// </summary>
    public KeyUsage1Code? Function { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Date and time on which the key must be activated.
    /// </summary>
    public IsoISODateTime? ActivationDate { get; init; } 
    /// <summary>
    /// Date and time on which the key must be deactivated.
    /// </summary>
    public IsoISODateTime? DeactivationDate { get; init; } 
    /// <summary>
    /// Encrypted cryptographic key.
    /// </summary>
    public required ContentInformationType7 KeyValue { get; init; } 
    
    #nullable disable
}
