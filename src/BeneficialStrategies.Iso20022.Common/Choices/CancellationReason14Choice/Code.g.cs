﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _t3j1IVkyEeGeoaLUQk__nA_2050646614.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CancellationReason14Choice;

/// <summary>
/// Reason for the cancellation request, in a coded form.
/// </summary>
public partial record Code : ICancellationReason14Choice
{
    public required CancellationReason5Code Value { get; init; }
}
