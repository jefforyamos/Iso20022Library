﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoPrice.  ISO2002 ID# _8RdkgOI-EeWWKb0jFHxViQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice4Choice;

/// <summary>
/// Captures where no price is yet known.
/// </summary>
public partial record NoPrice : ISecuritiesTransactionPrice4Choice
{
    #nullable enable
    /// <summary>
    /// Price is currently not available, but pending.
    /// </summary>
    public required PriceStatus1Code Pending { get; init; } 
    /// <summary>
    /// Currency that will be used but for which no price is yet known.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    #nullable disable
}
