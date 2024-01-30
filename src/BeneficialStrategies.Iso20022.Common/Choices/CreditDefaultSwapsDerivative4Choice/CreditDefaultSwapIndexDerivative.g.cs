﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CreditDefaultSwapIndexDerivative.  ISO2002 ID# _xSzjVye0Eei12pGEsJIAeQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CreditDefaultSwapsDerivative4Choice;

/// <summary>
/// A credit default swap derivative on an index.
/// </summary>
public partial record CreditDefaultSwapIndexDerivative : ICreditDefaultSwapsDerivative4Choice
{
    #nullable enable
    /// <summary>
    /// Derivative on a credit default swap with the ISIN code of the underlying swap.
    /// </summary>
    public IsoISINOct2015Identifier? UnderlyingCreditDefaultSwapIdentification { get; init; } 
    /// <summary>
    /// Describes the Credit Default Swap Index specific details the derivative is being made on.
    /// </summary>
    public required CreditDefaultSwapIndex3 UnderlyingCreditDefaultSwapIndex { get; init; } 
    #nullable disable
}
