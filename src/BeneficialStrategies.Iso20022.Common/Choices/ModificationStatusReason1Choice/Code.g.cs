﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _MG4Hg4lsEeePr-EGJjGYzQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ModificationStatusReason1Choice;

/// <summary>
/// Reason for the modification status, in a coded form.
/// </summary>
public partial record Code : IModificationStatusReason1Choice
{
    public required ExternalPaymentModificationRejection1Code Value { get; init; }
}
