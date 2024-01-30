﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ClassificationFinancialInstrument.  ISO2002 ID# _Q4NYZtp-Ed-ak6NoX_4Aeg_833608701.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ClassificationType2Choice;

/// <summary>
/// ISO 10962 Classification of Financial Instrument (CFI).
/// </summary>
public partial record ClassificationFinancialInstrument : IClassificationType2Choice
{
    public required IsoCFIIdentifier Value { get; init; }
}
