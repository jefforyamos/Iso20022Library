﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _yOuqYyY4EeW_ZNn8gbfY7Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InRepairStatus4Choice;

/// <summary>
/// Reason for the in-repair status.
/// </summary>
public partial record Reason : IInRepairStatus4Choice
{
    public required IsoMax350Text Value { get; init; }
}
