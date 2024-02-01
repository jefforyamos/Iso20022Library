﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BICFI.  ISO2002 ID# _6VaZYeaQEd-q8fx_Zl_34A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification38Choice;

/// <summary>
/// Code allocated to a financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
/// </summary>
public partial record BICFI : PartyIdentification38Choice_
{
    public required IsoBICFIIdentifier Value { get; init; }
}
