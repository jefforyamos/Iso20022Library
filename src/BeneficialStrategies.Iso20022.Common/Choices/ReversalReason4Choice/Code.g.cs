﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _TRGiYNp-Ed-ak6NoX_4Aeg_-340627868.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReversalReason4Choice;

/// <summary>
/// Reason for the reversal, as published in an external reason code list.
/// </summary>
public partial record Code : ReversalReason4Choice_
{
    public required ExternalReversalReason1Code Value { get; init; }
}
