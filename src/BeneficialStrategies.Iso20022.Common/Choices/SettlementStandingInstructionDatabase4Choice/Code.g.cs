﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _O6Zr4TtGEeWRTLSN0i0tng.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SettlementStandingInstructionDatabase4Choice;

/// <summary>
/// Settlement standing instruction database expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ISettlementStandingInstructionDatabase4Choice
{
    public required SettlementStandingInstructionDatabase1Code Value { get; init; }
}
