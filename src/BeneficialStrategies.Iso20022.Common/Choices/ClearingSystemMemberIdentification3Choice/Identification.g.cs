﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Identification.  ISO2002 ID# _TMehGtp-Ed-ak6NoX_4Aeg_-1564562062.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification3Choice;

/// <summary>
/// Identification for a clearing system member, identified in the list of clearing system member identifications published externally.
/// </summary>
public partial record Identification : IClearingSystemMemberIdentification3Choice
{
    public required ExternalClearingSystemMemberCode Value { get; init; }
}
