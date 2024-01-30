﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionAndDocumentIdentification6.  ISO2002 ID# _p8kywTp7EemwKdP955WBJQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction and document identification details.
/// </summary>
public partial record TransactionAndDocumentIdentification6
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as known by the instructing party.
    /// </summary>
    public required IsoMax35Text TransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identifier of the document (message) assigned by the sender of the document.
    /// </summary>
    public IsoMax35Text? DocumentIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the transaction was created by the instructing party in its business application.
    /// </summary>
    public IDateAndDateTime2Choice? CreationDateTime { get; init; } 
    /// <summary>
    /// Specifies if this document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    public CopyDuplicate1Code? CopyDuplicate { get; init; } 
    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    public PartyIdentification136? MessageOriginator { get; init; } 
    /// <summary>
    /// Party that is the final destination of the message, if other than the receiver.
    /// </summary>
    public PartyIdentification136? MessageRecipient { get; init; } 
    
    #nullable disable
}
