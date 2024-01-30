﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherClearingCodeIdentification.  ISO2002 ID# _TDPFhdp-Ed-ak6NoX_4Aeg_-1854348245.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice;

/// <summary>
/// Identification Code for a clearing system, that has not yet been identified in the list of clearing systems.
/// </summary>
public partial record OtherClearingCodeIdentification : IClearingSystemMemberIdentification2Choice
{
    public required IsoMax35Text Value { get; init; }
}
