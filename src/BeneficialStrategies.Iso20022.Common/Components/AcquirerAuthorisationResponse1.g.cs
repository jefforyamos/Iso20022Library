﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcquirerAuthorisationResponse1.  ISO2002 ID# __-xbkHuOEeSVeNXcmBQ4hQ.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of an authorisation.
/// </summary>
public partial record AcquirerAuthorisationResponse1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardTransactionEnvironment2 Environment { get; init; } 
    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    public CardTransactionContext3? Context { get; init; } 
    /// <summary>
    /// Card transaction for which the authorisation has been requested.
    /// </summary>
    public CardTransaction4? Transaction { get; init; } 
    
    #nullable disable
}
