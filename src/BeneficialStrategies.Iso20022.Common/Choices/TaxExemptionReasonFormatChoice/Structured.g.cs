﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Structured.  ISO2002 ID# _UzJj9Np-Ed-ak6NoX_4Aeg_-1748201268.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxExemptionReasonFormatChoice;

/// <summary>
/// Structured format.
/// </summary>
public partial record Structured : TaxExemptionReasonFormatChoice_
{
    public required TaxExemptReason1Code Value { get; init; }
}
