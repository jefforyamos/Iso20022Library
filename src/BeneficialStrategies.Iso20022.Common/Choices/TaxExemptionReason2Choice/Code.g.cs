﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _PE3O0SDAEeWPMvNwVtiMsA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TaxExemptionReason2Choice;

/// <summary>
/// Tax exemption reason expressed as a code.
/// </summary>
public partial record Code : ITaxExemptionReason2Choice
{
    public required TaxExemptReason3Code Value { get; init; }
}
