﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Confirmation.  ISO2002 ID# _tx5SAlkyEeGeoaLUQk__nA_-1832258084.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatus3Choice;

/// <summary>
/// Specifies the status of the investigation, in a coded form.
/// </summary>
public partial record Confirmation : InvestigationStatus3Choice_
{
    public required InvestigationExecutionConfirmation3Code Value { get; init; }
}
