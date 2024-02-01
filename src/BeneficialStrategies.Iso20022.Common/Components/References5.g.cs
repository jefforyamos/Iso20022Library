﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for References5.  ISO2002 ID# _QoQ359p-Ed-ak6NoX_4Aeg_823875605.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements for the identification of the message and related references.
/// </summary>
public partial record References5
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of acknowledged request.
    /// </summary>
    public required UseCases1Code RequestType { get; init; } 
    /// <summary>
    /// Identifies a message by a unique identifier and the date and time when the message was created by the sender.
    /// </summary>
    public required MessageIdentification1 MessageIdentification { get; init; } 
    /// <summary>
    /// Identifies a process by a unique identifier and the date and time when the first message belonging to the process was created by the sender. The process identification remains the same in all messages belonging to the same process, from the initial request message to the final account report closing the process.
    /// </summary>
    public required MessageIdentification1 ProcessIdentification { get; init; } 
    /// <summary>
    /// Reference to the message that is acknowledged.
    /// </summary>
    public MessageIdentification1[] AcknowledgedMessageIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Status of the request.
    /// </summary>
    public IsoMax35Text? Status { get; init; } 
    /// <summary>
    /// File name of a document logically related to the request.
    /// </summary>
    public IsoMax70Text[] AttachedDocumentName { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
