﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Index.  ISO2002 ID# _HYrJVX5aEea2k7EBUopqxw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument48Choice;

/// <summary>
/// Index on which the financial instrument is based.
/// </summary>
public partial record Index : IFinancialInstrument48Choice
{
    #nullable enable
    /// <summary>
    /// Identification of the index on which the financial instrument is based.
    /// </summary>
    public IsoISINOct2015Identifier? ISIN { get; init; } 
    /// <summary>
    /// Name of the index on which the financial instrument is based.
    /// </summary>
    public required FloatingInterestRate8 Name { get; init; } 
    #nullable disable
}
