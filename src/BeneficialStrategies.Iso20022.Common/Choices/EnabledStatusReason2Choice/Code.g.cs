﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _ScfY8Ey-EeafiMTDrtSnyw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EnabledStatusReason2Choice;

/// <summary>
/// Reason for the enabled account status expressed as a code.
/// </summary>
public partial record Code : EnabledStatusReason2Choice_
{
    public required EnabledStatusReason1Code Value { get; init; }
}
