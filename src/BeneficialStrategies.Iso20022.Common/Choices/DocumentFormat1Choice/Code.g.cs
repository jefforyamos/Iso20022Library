﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _932rtXltEeG7BsjMvd1mEw_1631851618.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DocumentFormat1Choice;

/// <summary>
/// Document format.
/// </summary>
public partial record Code : IDocumentFormat1Choice
{
    public required ExternalDocumentFormat1Code Value { get; init; }
}
