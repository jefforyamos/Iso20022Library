﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _HrWewZBjEeakHoV5BVecAQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradingPartyCapacity4Choice;

/// <summary>
/// Trading capacity expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ITradingPartyCapacity4Choice
{
    public required TradingCapacity4Code Value { get; init; }
}
