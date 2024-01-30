﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BIC.  ISO2002 ID# _AUMj1NokEeC60axPepSq7g_-257660170.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification68Choice;

/// <summary>
/// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
/// </summary>
public partial record BIC : IPartyIdentification68Choice
{
    public required IsoAnyBICIdentifier Value { get; init; }
}
