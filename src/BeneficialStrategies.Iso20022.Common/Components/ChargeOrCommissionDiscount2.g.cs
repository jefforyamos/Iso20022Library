﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ChargeOrCommissionDiscount2.  ISO2002 ID# _CXqF4YjMEeeqaMoyJI1HbA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Discounts or waivers to charges and commissions.
/// </summary>
public partial record ChargeOrCommissionDiscount2
{
    #nullable enable
    
    /// <summary>
    /// Amount of discount or waiver.
    /// </summary>
    public IsoActiveCurrencyAndAmount? Amount { get; init; } 
    /// <summary>
    /// Rate of discount or waiver.
    /// </summary>
    public IsoPercentageRate? Rate { get; init; } 
    /// <summary>
    /// Form of the discount or rebate.
    /// </summary>
    public IWaivingInstruction2Choice? Basis { get; init; } 
    
    #nullable disable
}
