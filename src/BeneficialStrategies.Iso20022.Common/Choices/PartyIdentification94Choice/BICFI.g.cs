﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BICFI.  ISO2002 ID# _wnZu-EHREeW-Sp6UI3iOQA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification94Choice;

/// <summary>
/// Code allocated to a financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
/// </summary>
public partial record BICFI : PartyIdentification94Choice_
{
    public required IsoBICFIIdentifier Value { get; init; }
}
