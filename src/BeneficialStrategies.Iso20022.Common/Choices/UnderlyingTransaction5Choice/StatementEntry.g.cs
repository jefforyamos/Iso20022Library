﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for StatementEntry.  ISO2002 ID# _ISFv5W49EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingTransaction5Choice;

/// <summary>
/// Reference details on the underlying statement cash entry.
/// </summary>
public partial record StatementEntry : IUnderlyingTransaction5Choice
{
    #nullable enable
    /// <summary>
    /// Set of elements used to provide information on the original message.
    /// </summary>
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the original statement.
    /// </summary>
    public IsoMax35Text? OriginalStatementIdentification { get; init; } 
    /// <summary>
    /// Original unique identification, as assigned by the account servicer, to unambiguously identify the original entry.
    /// </summary>
    public IsoMax35Text? OriginalEntryIdentification { get; init; } 
    /// <summary>
    /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
    /// </summary>
    public IsoUUIDv4Identifier? OriginalUETR { get; init; } 
    #nullable disable
}
