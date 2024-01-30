﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AuthenticatedData3.  ISO2002 ID# _47gRwTF2EeO118ZQJgaQSQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Message authentication code (MAC), computed on the data to protect with an encryption key.
/// </summary>
public partial record AuthenticatedData3
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    public IsoNumber? Version { get; init; } 
    /// <summary>
    /// Information related to the transport key.
    /// </summary>
    public IRecipient3Choice? Recipient { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Algorithm to compute message authentication code (MAC).
    /// </summary>
    public required AlgorithmIdentification10 MACAlgorithm { get; init; } 
    /// <summary>
    /// Data to authenticate.
    /// </summary>
    public required EncapsulatedContent2 EncapsulatedContent { get; init; } 
    /// <summary>
    /// Encrypted data which authenticates the data.
    /// </summary>
    public required IsoMax35Binary MAC { get; init; } 
    
    #nullable disable
}
