﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MonetaryValue.  ISO2002 ID# _rdXYAUDWEeWOL-OsSq2h6w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice3Choice;

/// <summary>
/// Indicates that price is expressed as a monetary value.
/// </summary>
public partial record MonetaryValue : ISecuritiesTransactionPrice3Choice
{
    #nullable enable
    /// <summary>
    /// Amount of money that results in an increase (positively signed) or decrease (negatively signed), with specification of the currency.
    /// </summary>
    public required IsoImpliedCurrencyAnd20Amount Amount { get; init; } 
    /// <summary>
    /// Indicates that the amount value is positive or negative.
    /// Usage: When absent, the amount is positive.
    /// </summary>
    public IsoPlusOrMinusIndicator? Sign { get; init; } 
    #nullable disable
}
