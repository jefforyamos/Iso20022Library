﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ClassificationFinancialInstrument.  ISO2002 ID# _chVpxZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClassificationType33Choice;

/// <summary>
/// ISO 10962 Classification of Financial Instrument (CFI).
/// </summary>
public partial record ClassificationFinancialInstrument : ClassificationType33Choice_
{
    public required IsoCFIOct2015Identifier Value { get; init; }
}
