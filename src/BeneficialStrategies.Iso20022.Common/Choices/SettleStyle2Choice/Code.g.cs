﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _ra2T0eLaEeWFtOV72FbX9w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettleStyle2Choice;

/// <summary>
/// Settle style expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ISettleStyle2Choice
{
    public required SettleStyle1Code Value { get; init; }
}
