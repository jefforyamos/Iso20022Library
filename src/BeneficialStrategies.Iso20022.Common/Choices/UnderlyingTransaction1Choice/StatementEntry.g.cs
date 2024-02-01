﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for StatementEntry.  ISO2002 ID# _P9NIsNp-Ed-ak6NoX_4Aeg_-1542940351.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingTransaction1Choice;

/// <summary>
/// Reference details on the underlying statement cash entry.
/// </summary>
public partial record StatementEntry : UnderlyingTransaction1Choice_
{
    #nullable enable
    /// <summary>
    /// Set of elements used to provide information on the original message.
    /// </summary>
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the original statement.
    /// </summary>
    public IsoMax35Text? OriginalStatementIdentification { get; init; } 
    /// <summary>
    /// Original unique identification, as assigned by the account servicer, to unambiguously identify the original entry.
    /// </summary>
    public IsoMax35Text? OriginalEntryIdentification { get; init; } 
    #nullable disable
}
