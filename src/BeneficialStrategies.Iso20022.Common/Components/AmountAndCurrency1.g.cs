﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndCurrency1.  ISO2002 ID# _nuIgAIolEeSaAcF2oE2GNQ.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount to be authorised by the issuer.
/// </summary>
public partial record AmountAndCurrency1
{
    #nullable enable
    
    /// <summary>
    /// Amount value.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Currency of the amount.
    /// </summary>
    public ActiveCurrencyCode? Currency { get; init; } 
    
    #nullable disable
}
