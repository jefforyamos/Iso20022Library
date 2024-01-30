﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DiscountAmountAndType1.  ISO2002 ID# _tlhp8VkyEeGeoaLUQk__nA_1198616303.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the amount with a specific type.
/// </summary>
public partial record DiscountAmountAndType1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of the amount.
    /// </summary>
    public IDiscountAmountType1Choice? Type { get; init; } 
    /// <summary>
    /// Amount of money, which has been typed.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    #nullable disable
}
