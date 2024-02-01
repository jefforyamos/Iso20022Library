﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Other.  ISO2002 ID# _6geZA5icEe2f7NHvXATP5g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentAttributes5Choice;

/// <summary>
/// Description of the financial instrument, such as a a derivative, when the instrument is not admitted to trading on a trading venue.
/// </summary>
public partial record Other : FinancialInstrumentAttributes5Choice_
{
    #nullable enable
    /// <summary>
    /// Attributes and characteristics of the financial instrument.
    /// </summary>
    public required SecurityInstrumentDescription23 FinancialInstrumentGeneralAttributes { get; init; } 
    /// <summary>
    /// Attributes specific to debt instruments.
    /// </summary>
    public DebtInstrument4? DebtInstrumentAttributes { get; init; } 
    /// <summary>
    /// Attributes specific to derivative instruments.
    /// </summary>
    public required DerivativeInstrument6 DerivativeInstrumentAttributes { get; init; } 
    #nullable disable
}
