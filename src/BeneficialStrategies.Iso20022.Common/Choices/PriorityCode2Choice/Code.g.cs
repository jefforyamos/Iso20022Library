﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _74UMs6MgEeCJ6YNENx4h-w_1723672223.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriorityCode2Choice;

/// <summary>
/// Priority code, in a coded form.
/// </summary>
public partial record Code : PriorityCode2Choice_
{
    public required Priority1Code Value { get; init; }
}
