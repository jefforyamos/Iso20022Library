﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _tv-sYUzLEeafiMTDrtSnyw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ConfirmationType1Choice;

/// <summary>
/// Confirmation type expressed as a code.
/// </summary>
public partial record Code : ConfirmationType1Choice_
{
    public required AccountManagementType2Code Value { get; init; }
}
