﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Linkages19.  ISO2002 ID# _XGUCef7uEeCvPoRGOxRobQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a linked transaction.
/// </summary>
public partial record Linkages19
{
    #nullable enable
    
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    public IProcessingPosition1Choice? ProcessingPosition { get; init; } 
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    public IDocumentNumber1Choice? MessageNumber { get; init; } 
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    public required IReferences25Choice Reference { get; init; } 
    /// <summary>
    /// Party that generates the reference.
    /// </summary>
    public IPartyIdentification36Choice? ReferenceOwner { get; init; } 
    
    #nullable disable
}
