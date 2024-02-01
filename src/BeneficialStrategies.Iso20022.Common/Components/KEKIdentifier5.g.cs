﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for KEKIdentifier5.  ISO2002 ID# _gwCa4Y3_EeWRwov1g9WL_A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a key encryption key (KEK), using previously distributed symmetric key.
/// </summary>
public partial record KEKIdentifier5
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
    public IsoMin5Max16Binary? DerivationIdentification { get; init; } 
    /// <summary>
    /// Type of algorithm used by the cryptographic key.
    /// </summary>
    public CryptographicKeyType3Code? Type { get; init; } 
    /// <summary>
    /// Allowed usage of the key.
    /// </summary>
    public KeyUsage1Code[] Function { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
