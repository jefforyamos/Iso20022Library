﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _UXuzRdp-Ed-ak6NoX_4Aeg_2050241794.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AcknowledgementReason2Choice;

/// <summary>
/// Specifies additional information about the processed instruction.
/// </summary>
public partial record Code : IAcknowledgementReason2Choice
{
    public required AcknowledgementReason5Code Value { get; init; }
}
