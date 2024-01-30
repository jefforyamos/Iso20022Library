﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Linkages38.  ISO2002 ID# _vqhsYztBEeWRTLSN0i0tng.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a linked transaction.
/// </summary>
public partial record Linkages38
{
    #nullable enable
    
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    public IProcessingPosition7Choice? ProcessingPosition { get; init; } 
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    public IDocumentNumber5Choice? MessageNumber { get; init; } 
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    public required IReferences47Choice Reference { get; init; } 
    /// <summary>
    /// Quantity of financial instruments of the linked transaction to be paired-off or turned.
    /// </summary>
    public IPairedOrTurnedQuantity3Choice? LinkedQuantity { get; init; } 
    
    #nullable disable
}
