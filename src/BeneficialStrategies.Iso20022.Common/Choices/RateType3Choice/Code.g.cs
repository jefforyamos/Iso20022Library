﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _RBJ5CNp-Ed-ak6NoX_4Aeg_811184280.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateType3Choice;

/// <summary>
/// Rate is defined using a code.
/// </summary>
public partial record Code : RateType3Choice_
{
    public required RateType1Code Value { get; init; }
}
