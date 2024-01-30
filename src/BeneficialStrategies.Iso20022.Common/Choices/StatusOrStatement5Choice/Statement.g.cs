﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Statement.  ISO2002 ID# _BTOMjf7yEeCvPoRGOxRobQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement5Choice;

/// <summary>
/// Identify the statement/report that was requested.
/// </summary>
public partial record Statement : IStatusOrStatement5Choice
{
    #nullable enable
    /// <summary>
    /// Number used to identify a message or document.
    /// </summary>
    public required IDocumentNumber1Choice Number { get; init; } 
    #nullable disable
}
