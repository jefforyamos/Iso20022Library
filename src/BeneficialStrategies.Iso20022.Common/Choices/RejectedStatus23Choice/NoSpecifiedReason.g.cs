﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoSpecifiedReason.  ISO2002 ID# _HJOPMYlqEeavwKddCbm3hg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus23Choice;

/// <summary>
/// Reason not specified.
/// </summary>
public partial record NoSpecifiedReason : RejectedStatus23Choice_
{
    public required NoReasonCode Value { get; init; }
}
