﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for LinkedOfficialCorporateActionEventIdentification.  ISO2002 ID# _4h3LozncEeWLJsP1cO-amg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventReference3Choice;

/// <summary>
/// Official and unique reference assigned by the official central body/ entity within each market at the beginning of a corporate action event.
/// </summary>
public partial record LinkedOfficialCorporateActionEventIdentification : CorporateActionEventReference3Choice_
{
    public required IsoMax35Text Value { get; init; }
}
