﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _TP6Pk9p-Ed-ak6NoX_4Aeg_-1676325975.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReturnReason5Choice;

/// <summary>
/// Reason for the return, in a proprietary form.
/// </summary>
public partial record Proprietary : IReturnReason5Choice
{
    public required IsoMax35Text Value { get; init; }
}
