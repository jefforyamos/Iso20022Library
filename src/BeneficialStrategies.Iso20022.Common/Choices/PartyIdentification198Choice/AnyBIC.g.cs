﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AnyBIC.  ISO2002 ID# _z8lF8ztpEemIf7eyjCwinw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification198Choice;

/// <summary>
/// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
/// </summary>
public partial record AnyBIC : PartyIdentification198Choice_
{
    public required IsoAnyBICDec2014Identifier Value { get; init; }
}
