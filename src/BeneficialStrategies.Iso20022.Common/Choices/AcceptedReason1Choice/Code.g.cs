﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _QyjcWNp-Ed-ak6NoX_4Aeg_831638604.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AcceptedReason1Choice;

/// <summary>
/// Standard code to specify additional information about the processed instruction.
/// </summary>
public partial record Code : IAcceptedReason1Choice
{
    public required AcknowledgementReason4Code Value { get; init; }
}
