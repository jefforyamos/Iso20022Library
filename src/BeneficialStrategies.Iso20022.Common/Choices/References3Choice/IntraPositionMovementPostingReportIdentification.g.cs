﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IntraPositionMovementPostingReportIdentification.  ISO2002 ID# _USz3Adp-Ed-ak6NoX_4Aeg_-1482725092.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.References3Choice;

/// <summary>
/// Identification of the intra-position movement posting report to be cancelled.
/// </summary>
public partial record IntraPositionMovementPostingReportIdentification : IReferences3Choice
{
    public required IsoMax35Text Value { get; init; }
}
