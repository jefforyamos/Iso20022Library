﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountToAmountRatio1.  ISO2002 ID# _UHySwNp-Ed-ak6NoX_4Aeg_579173663.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Ratio expressed as a quotient of amounts.
/// </summary>
public partial record AmountToAmountRatio1
{
    #nullable enable
    
    /// <summary>
    /// Numerator of the quotient of amounts.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount1 { get; init; } 
    /// <summary>
    /// Denominator of the quotient of amounts.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount2 { get; init; } 
    
    #nullable disable
}
