﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _MfWS0UzDEeafiMTDrtSnyw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ProformaStatusReason2Choice;

/// <summary>
/// Reason for the enabled account status expressed as a code.
/// </summary>
public partial record Code : IProformaStatusReason2Choice
{
    public required ProformaStatusReason1Code Value { get; init; }
}
