﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _NwxZGZp3EeWLs7cvLxlyAg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity40Choice;

/// <summary>
/// Standard code to specify quantity of a financial instrument.
/// </summary>
public partial record Code : Quantity40Choice_
{
    public required Quantity1Code Value { get; init; }
}
