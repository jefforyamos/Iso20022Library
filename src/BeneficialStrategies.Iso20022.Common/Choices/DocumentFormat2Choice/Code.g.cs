﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _ElusseatEeqCKaUycnDWEg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DocumentFormat2Choice;

/// <summary>
/// Document format, in a coded form.
/// </summary>
public partial record Code : IDocumentFormat2Choice
{
    public required ExternalDocumentFormat1Code Value { get; init; }
}
