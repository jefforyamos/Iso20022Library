﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CreditDefaultSwapIndexDerivative.  ISO2002 ID# _xfbL135eEea2k7EBUopqxw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CreditDefaultSwapsDerivative3Choice;

/// <summary>
/// A credit default swap derivative on an index.
/// </summary>
public partial record CreditDefaultSwapIndexDerivative : ICreditDefaultSwapsDerivative3Choice
{
    #nullable enable
    /// <summary>
    /// Derivative on a credit default swap with the ISIN code of the underlying index.
    /// </summary>
    public IsoISINOct2015Identifier? UnderlyingIndexIdentification { get; init; } 
    /// <summary>
    /// To be populated for derivatives on a CDS index with the standardized name of the index.
    /// </summary>
    public required IsoMax25Text IndexName { get; init; } 
    /// <summary>
    /// Describes the Index specific details the derivative is being made on.
    /// </summary>
    public required CreditDefaultSwapIndex2 Index { get; init; } 
    #nullable disable
}
