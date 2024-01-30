﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BillingServicesAmount1.  ISO2002 ID# _6QP-pJqlEeGSON8vddiWzQ_1984361507.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Taxable service charge amount conversions to host currency.
/// </summary>
public partial record BillingServicesAmount1
{
    #nullable enable
    
    /// <summary>
    /// Sum of all the individual taxes on the service expressed in the host currency.
    /// </summary>
    public required AmountAndDirection34 HostAmount { get; init; } 
    /// <summary>
    /// Amount of the tax obligation expressed in the tax region's pricing currency.|Usage: This is the same amount as carried in the host amount but allows the sender to optionally express the value in the pricing currency.
    /// </summary>
    public AmountAndDirection34? PricingAmount { get; init; } 
    
    #nullable disable
}
