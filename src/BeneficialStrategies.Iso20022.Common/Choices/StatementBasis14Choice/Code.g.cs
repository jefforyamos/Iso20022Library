﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _dOSH0MRyEeij-rSPpvD-Tw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.StatementBasis14Choice;

/// <summary>
/// Statement basis expressed as code.
/// </summary>
public partial record Code : IStatementBasis14Choice
{
    public required StatementBasis3Code Value { get; init; }
}
