﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ISIN.  ISO2002 ID# _xzhRMSyGEe2xAdY9t5fB3g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstrumentIdentification6Choice;

/// <summary>
/// International Securities Identification Number (ISIN). A numbering system designed by the United Nation's International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
/// </summary>
public partial record ISIN : IInstrumentIdentification6Choice
{
    public required IsoISINOct2015Identifier Value { get; init; }
}
