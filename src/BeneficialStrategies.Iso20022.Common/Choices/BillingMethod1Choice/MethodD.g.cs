﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MethodD.  ISO2002 ID# _6P9DtJqlEeGSON8vddiWzQ_1766081075.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BillingMethod1Choice;

/// <summary>
/// Tax values are based on tax calculation method D.
/// </summary>
public partial record MethodD : IBillingMethod1Choice
{
    #nullable enable
    /// <summary>
    /// Equivalent amount to the service tax host amount but allows the sender to optionally express the value in the pricing currency.
    /// </summary>
    public required AmountAndDirection34 ServiceTaxPriceAmount { get; init; } 
    /// <summary>
    /// Provides for the specific tax identification within the same tax region. 
    /// Usage: This element allows for a maximum of three regional taxes on the same service.
    /// </summary>
    // public IReadOnlyCollection<BillingServicesTax2> TaxIdentification { get; init; }
    #nullable disable
}
