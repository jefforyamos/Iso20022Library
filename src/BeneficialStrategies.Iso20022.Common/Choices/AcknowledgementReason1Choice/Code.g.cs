﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _UXuzSNp-Ed-ak6NoX_4Aeg_-355998518.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AcknowledgementReason1Choice;

/// <summary>
/// Specifies additional information about the processed instruction.
/// </summary>
public partial record Code : IAcknowledgementReason1Choice
{
    public required AcknowledgementReason3Code Value { get; init; }
}
