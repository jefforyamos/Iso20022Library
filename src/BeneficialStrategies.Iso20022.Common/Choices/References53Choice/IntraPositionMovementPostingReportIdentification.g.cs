﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IntraPositionMovementPostingReportIdentification.  ISO2002 ID# _6EvMO5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References53Choice;

/// <summary>
/// Identification of the intra-position movement posting report to be cancelled.
/// </summary>
public partial record IntraPositionMovementPostingReportIdentification : References53Choice_
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}
