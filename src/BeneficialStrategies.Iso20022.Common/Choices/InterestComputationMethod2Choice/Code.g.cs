﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _4-vxgNopEeCWg-hsBVGrDA_-492084439.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestComputationMethod2Choice;

/// <summary>
/// Code is used to determine the interest computation method.
/// </summary>
public partial record Code : InterestComputationMethod2Choice_
{
    public required InterestComputationMethod1Code Value { get; init; }
}
