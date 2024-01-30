﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ChargeOrCommissionDiscount1.  ISO2002 ID# _zuNFIFiOEeaMNZxYNthMeA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about discounts or waivers to charges and commissions.
/// </summary>
public partial record ChargeOrCommissionDiscount1
{
    #nullable enable
    
    /// <summary>
    /// Difference between the standard fee (charge/commission) amount and the applied fee (charge/commission) amount.
    /// EXAMPLE:
    /// Standard charge is EUR 100
    /// Discount is EUR 30
    /// Applied charge is EUR 70.
    /// </summary>
    public IsoActiveCurrencyAndAmount? Amount { get; init; } 
    /// <summary>
    /// Difference between the standard fee (charge/commission) rate and the applied rate of the fee (charge/commission).
    /// EXAMPLE:
    /// Standard rate is 5%
    /// Discount rate is 3%
    /// Applied rate is 2%.
    /// </summary>
    public IsoPercentageRate? Rate { get; init; } 
    /// <summary>
    /// Form of the discount or rebate, for example, cash.
    /// </summary>
    public IWaivingInstruction2Choice? Basis { get; init; } 
    
    #nullable disable
}
