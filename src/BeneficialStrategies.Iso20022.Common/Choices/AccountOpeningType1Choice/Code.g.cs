﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _3Et5EUzJEeafiMTDrtSnyw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountOpeningType1Choice;

/// <summary>
/// Type of account opening instruction expressed as a code.
/// </summary>
public partial record Code : IAccountOpeningType1Choice
{
    public required AccountOpeningType1Code Value { get; init; }
}
