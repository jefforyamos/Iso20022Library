﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Confirmation.  ISO2002 ID# _T-P8Rdp-Ed-ak6NoX_4Aeg_523812421.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatus2Choice;

/// <summary>
/// Specifies the status of the investigation, in a coded form.
/// </summary>
public partial record Confirmation : InvestigationStatus2Choice_
{
    public required InvestigationExecutionConfirmation3Code Value { get; init; }
}
