﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IntraPositionMovementPostingReportIdentification.  ISO2002 ID# _5pbMbzqnEeWyoP0PbocV1Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References43Choice;

/// <summary>
/// Identification of the intra-position movement posting report to be cancelled.
/// </summary>
public partial record IntraPositionMovementPostingReportIdentification : IReferences43Choice
{
    public required IsoMax35Text Value { get; init; }
}
