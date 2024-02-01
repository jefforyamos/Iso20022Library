﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Linkages7.  ISO2002 ID# _WoYoQdzkEd-tnM7aRm4nqg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a linked transaction.
/// </summary>
public partial record Linkages7
{
    #nullable enable
    
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    public ProcessingPosition1Choice_? ProcessingPosition { get; init; } 
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    public DocumentNumber1Choice_? MessageNumber { get; init; } 
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    public required References14Choice_ Reference { get; init; } 
    /// <summary>
    /// Quantity of financial instruments of the linked transaction to be paired-off or turned.
    /// </summary>
    public PairedOrTurnedQuantity1Choice_? LinkedQuantity { get; init; } 
    /// <summary>
    /// Party that generates the reference.
    /// </summary>
    public PartyIdentification36Choice_? ReferenceOwner { get; init; } 
    
    #nullable disable
}
