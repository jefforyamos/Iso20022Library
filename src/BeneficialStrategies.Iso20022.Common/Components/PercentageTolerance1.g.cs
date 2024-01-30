﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PercentageTolerance1.  ISO2002 ID# _SsvRF9p-Ed-ak6NoX_4Aeg_964334524.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Variance allowed on a quantity or on a price.
/// </summary>
public partial record PercentageTolerance1
{
    #nullable enable
    
    /// <summary>
    /// Variance in percentage allowed over the agreed dimension. For example, plus 10 percent.
    /// </summary>
    public required IsoPercentageRate PlusPercent { get; init; } 
    /// <summary>
    /// Variance in percentage allowed below the agreed dimension. For example, minus 10 percent.
    /// </summary>
    public required IsoPercentageRate MinusPercent { get; init; } 
    
    #nullable disable
}
