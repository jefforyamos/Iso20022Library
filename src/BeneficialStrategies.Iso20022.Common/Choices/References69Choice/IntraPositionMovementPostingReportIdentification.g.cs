﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IntraPositionMovementPostingReportIdentification.  ISO2002 ID# _z_ogPQzXEeuUZuaHWzkTew.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.References69Choice;

/// <summary>
/// Identification of the intra-position movement posting report to be cancelled.
/// </summary>
public partial record IntraPositionMovementPostingReportIdentification : IReferences69Choice
{
    public required IsoMax35Text Value { get; init; }
}
