﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _RCpGwNp-Ed-ak6NoX_4Aeg_1852257292.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationRejectionStatus1Choice;

/// <summary>
/// Reason advising the rejection of the instruction cancellation request in the form of a code.
/// </summary>
public partial record Code : CancellationRejectionStatus1Choice_
{
    public required RejectionReason2Code Value { get; init; }
}
