﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardTransaction13.  ISO2002 ID# _UCtJgXvHEeSCJdwgzb6SFw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Key exchange transaction.
/// </summary>
public partial record CardTransaction13
{
    #nullable enable
    
    /// <summary>
    /// Type of key exchange.
    /// </summary>
    public required CardServiceType3Code KeyExchangeType { get; init; } 
    /// <summary>
    /// Date and time of the transaction.
    /// </summary>
    public required IsoISODateTime InitiatorDateTime { get; init; } 
    /// <summary>
    /// Key that must be created and sent in the response, or that must be verified.
    /// </summary>
    public KEKIdentifier3? RequestedKey { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Created key to be stored.
    /// </summary>
    public CryptographicKey6? Key { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Response to the key exchange request.
    /// </summary>
    public ResponseType2? TransactionResponse { get; init; } 
    
    #nullable disable
}
