﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _l6enkCCzEeWJd9HF2tO7BA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AccountDesignation1Choice;

/// <summary>
/// Account designation expressed as a code.
/// </summary>
public partial record Code : IAccountDesignation1Choice
{
    public required Rank1Code Value { get; init; }
}
