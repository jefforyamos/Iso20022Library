﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _Pdd4sdp-Ed-ak6NoX_4Aeg_-912371522.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CashAccountIdentification5Choice;

/// <summary>
/// Unique identifier for an account. It is assigned by the account servicer using a proprietary identification scheme.
/// </summary>
public partial record Proprietary : ICashAccountIdentification5Choice
{
    public required IsoMax34Text Value { get; init; }
}
