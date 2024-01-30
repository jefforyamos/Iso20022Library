﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Adjustment7.  ISO2002 ID# _n3oMMRrcEeOVR9VN6fAMUg.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Modification on the value of goods and / or services. For example: rebate, discount, surcharge.
/// </summary>
public partial record Adjustment7
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of adjustment.
    /// </summary>
    public required IAdjustmentType1Choice Type { get; init; } 
    /// <summary>
    /// Specifies the monetary amount or rate of the adjustment.
    /// </summary>
    public required IAmountOrPercentage2Choice AmountOrPercentage { get; init; } 
    /// <summary>
    /// Specifies whether the adjustment must be subtracted or added to the total amount.
    /// </summary>
    public required AdjustmentDirection1Code Direction { get; init; } 
    
    #nullable disable
}
