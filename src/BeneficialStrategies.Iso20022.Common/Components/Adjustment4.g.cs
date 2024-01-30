﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Adjustment4.  ISO2002 ID# _SpKYqdp-Ed-ak6NoX_4Aeg_1141917187.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Modification on the value of goods and / or services. For example: rebate, discount, surcharge.
/// </summary>
public partial record Adjustment4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of adjustment applied to the amount of goods/services by means of a code.
    /// </summary>
    public required AdjustmentType2Code Type { get; init; } 
    /// <summary>
    /// Specifies a type of adjustment not present in the code list.
    /// </summary>
    public required IsoMax35Text OtherAdjustmentType { get; init; } 
    /// <summary>
    /// Specifies whether the adjustment must be subtracted or added to the total amount.
    /// </summary>
    public required AdjustmentDirection1Code Direction { get; init; } 
    /// <summary>
    /// Specifies the monetary amount of the adjustment.
    /// </summary>
    public required IsoCurrencyAndAmount Amount { get; init; } 
    
    #nullable disable
}
