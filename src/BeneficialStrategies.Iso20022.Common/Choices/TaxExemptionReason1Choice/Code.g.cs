﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _0qVdABc-EeK5g-3oYI0_9Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxExemptionReason1Choice;

/// <summary>
/// Tax exemption reason expressed as a code.
/// </summary>
public partial record Code : TaxExemptionReason1Choice_
{
    public required TaxExemptReason1Code Value { get; init; }
}
