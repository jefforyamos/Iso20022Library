﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OriginalMandateIdentification.  ISO2002 ID# _HtlUo249EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate6Choice;

/// <summary>
/// Unique identification, as assigned by the responsible party (such as the creditor) or agent (such as the debtor agent), to unambiguously identify the original mandate.
/// </summary>
public partial record OriginalMandateIdentification : IOriginalMandate6Choice
{
    public required IsoMax35Text Value { get; init; }
}
