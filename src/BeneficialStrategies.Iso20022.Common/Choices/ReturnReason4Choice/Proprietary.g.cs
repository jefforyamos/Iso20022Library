﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _V5oD09p-Ed-ak6NoX_4Aeg_434826094.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReturnReason4Choice;

/// <summary>
/// Reason for the return not catered for by the available codes.
/// </summary>
public partial record Proprietary : IReturnReason4Choice
{
    public required IsoRestrictedRR01SL01CodeText Value { get; init; }
}
