﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _hlx-c73REeO2FLWuu_JIqg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReportItemRejectionReason1Choice;

/// <summary>
/// Status reason expressed as a code.
/// </summary>
public partial record Code : ReportItemRejectionReason1Choice_
{
    public required HoldingRejectionReason41Code Value { get; init; }
}
