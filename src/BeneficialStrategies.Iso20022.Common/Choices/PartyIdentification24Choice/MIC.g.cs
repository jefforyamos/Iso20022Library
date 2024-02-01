﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MIC.  ISO2002 ID# _QReIhtp-Ed-ak6NoX_4Aeg_246882827.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification24Choice;

/// <summary>
/// Market Identifier Code. Identification of a financial market, as stipulated in the norm ISO 10383 "Codes for exchanges and market identifications".
/// </summary>
public partial record MIC : PartyIdentification24Choice_
{
    public required IsoMICIdentifier Value { get; init; }
}
