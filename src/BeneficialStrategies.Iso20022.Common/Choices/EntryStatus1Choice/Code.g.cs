﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _H_H9sIaoEeeUws0ZryHQ2w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EntryStatus1Choice;

/// <summary>
/// Entry status, in a coded form.
/// </summary>
public partial record Code : IEntryStatus1Choice
{
    public required ExternalEntryStatus1Code Value { get; init; }
}
