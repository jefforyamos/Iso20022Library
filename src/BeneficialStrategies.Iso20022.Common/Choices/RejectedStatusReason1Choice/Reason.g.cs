﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _Rhov59p-Ed-ak6NoX_4Aeg_-75492719.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RejectedStatusReason1Choice;

/// <summary>
/// Reason for the rejected status.
/// </summary>
public partial record Reason : IRejectedStatusReason1Choice
{
    public required RejectedStatusReason10Code Value { get; init; }
}
