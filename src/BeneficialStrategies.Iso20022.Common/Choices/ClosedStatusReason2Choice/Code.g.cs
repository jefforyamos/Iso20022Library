﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _lSNvgUzDEeafiMTDrtSnyw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClosedStatusReason2Choice;

/// <summary>
/// Reason for the closed account status expressed as a code.
/// </summary>
public partial record Code : ClosedStatusReason2Choice_
{
    public required ClosedStatusReason1Code Value { get; init; }
}
