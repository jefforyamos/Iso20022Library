﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _jkjDILXIEeiTob_PrFFUxA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EventSequenceTypeFormat1Choice;

/// <summary>
/// Type of an event sequence, in a coded format.
/// </summary>
public partial record Code : EventSequenceTypeFormat1Choice_
{
    public required EventSequenceType1Code Value { get; init; }
}
