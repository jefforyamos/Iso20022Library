﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _PUFSA5EkEeakHoV5BVecAQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reversible2Choice;

/// <summary>
/// Closing of the securities lending contract is identified using a code.
/// </summary>
public partial record Code : Reversible2Choice_
{
    public required Reversible1Code Value { get; init; }
}
