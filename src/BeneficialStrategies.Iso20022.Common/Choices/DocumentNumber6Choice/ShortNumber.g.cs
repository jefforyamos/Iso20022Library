﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ShortNumber.  ISO2002 ID# _celQ1ZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DocumentNumber6Choice;

/// <summary>
/// Message type number of the document referenced.
/// </summary>
public partial record ShortNumber : DocumentNumber6Choice_
{
    public required IsoExact3NumericText Value { get; init; }
}
