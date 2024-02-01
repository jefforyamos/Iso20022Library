﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MethodB.  ISO2002 ID# _6P9Ds5qlEeGSON8vddiWzQ_1047988105.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BillingMethod1Choice;

/// <summary>
/// Tax values are based on tax calculation method B.
/// </summary>
public partial record MethodB : BillingMethod1Choice_
{
    #nullable enable
    /// <summary>
    /// Amount of the original charge expressed in the host currency.
    /// </summary>
    public required AmountAndDirection34 ServiceChargeHostAmount { get; init; } 
    /// <summary>
    /// Provides for the regional taxes on the service. Up to three regional taxes may be defined for the same service.
    /// </summary>
    public required BillingServicesAmount1 ServiceTax { get; init; } 
    /// <summary>
    /// Provides for the specific tax identification within the same tax region. 
    /// Usage: This element allows for a maximum of three regional taxes on the same service.
    /// </summary>
    public IReadOnlyCollection<BillingServicesTax1> TaxIdentification { get; init; } = [];
    #nullable disable
}
