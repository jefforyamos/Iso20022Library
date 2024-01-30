﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IsabelSignatureRecord2.  ISO2002 ID# _l1lLp8_aEeWjSMe6YTKHlQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the individual record of the file signature.
/// </summary>
public partial record IsabelSignatureRecord2
{
    #nullable enable
    
    /// <summary>
    /// Type of the signature.
    /// </summary>
    public required SignatureOriginType1Code SignatureType { get; init; } 
    /// <summary>
    /// Serial number of the certificate.
    /// </summary>
    public required IsoMax20AlphaNumericText SerialNumber { get; init; } 
    /// <summary>
    /// Electronic document which uses a digital signature to bind together a public key with an identity.
    /// </summary>
    public required IsoMax4kBinary Certificate { get; init; } 
    /// <summary>
    /// Mathematical scheme for demonstrating the authenticity of a digital message or document.
    /// </summary>
    public required IsoMax1kBinary Signature { get; init; } 
    /// <summary>
    /// Effective method for calculating the signature using a finite sequence of instructions.
    /// </summary>
    public required IsoMax105Text Algorithm { get; init; } 
    /// <summary>
    /// Unique identification of the signer that issued the signature.
    /// </summary>
    public required IsoMax13AlphaNumericText SignerIdentification { get; init; } 
    /// <summary>
    /// Block of signature related data in case the LRCI protocol is used during the signature process of a set of payment files.
    /// </summary>
    public IsabelLRCIExtension1? LRCIExtension { get; init; } 
    
    #nullable disable
}
