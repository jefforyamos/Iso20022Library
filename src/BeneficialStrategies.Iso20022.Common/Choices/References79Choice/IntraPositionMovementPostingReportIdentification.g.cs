﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IntraPositionMovementPostingReportIdentification.  ISO2002 ID# _Wkm3jUfGEey6Is2iMqV8fg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References79Choice;

/// <summary>
/// Identification of the intra-position movement posting report to be cancelled.
/// </summary>
public partial record IntraPositionMovementPostingReportIdentification : References79Choice_
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}
